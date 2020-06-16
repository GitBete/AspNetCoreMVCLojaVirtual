using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Libraries.Filtro;
using LojaVirtual.Libraries.Gerenciador.Pagamento.PagarMe;
using LojaVirtual.Libraries.Json.Resolver;
using LojaVirtual.Libraries.Login;
using LojaVirtual.Models;
using LojaVirtual.Models.Constants;
using LojaVirtual.Models.ProdutoAgregador;
using LojaVirtual.Models.ViewModels.Pedido;
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace LojaVirtual.Areas.Colaborador.Controllers
{
    [Area("Colaborador")]
    [ColaboradorAutorizacao]
    public class PedidoController : Controller
    {

        private IPedidoRepository _pedidoRepository;
        private IPedidoSituacoesRepository _pedidoSituacaoRepository;
        private GerenciarPagarMe _gerenciarPagarMe;

        //remover quando refatorar o devolver produto
        private IProdutoRepository _produtoRepository;

        public PedidoController(IPedidoRepository pedidoRepository, IPedidoSituacoesRepository pedidoSituacaoRepository, GerenciarPagarMe gerenciarPagarMe, IProdutoRepository produtoRepository)
        {
            _pedidoRepository = pedidoRepository;
            _pedidoSituacaoRepository = pedidoSituacaoRepository;
            _gerenciarPagarMe = gerenciarPagarMe;
            _produtoRepository = produtoRepository;
        }

        public IActionResult Index(int? pagina, string codigoPedido, string cpf)
        {
            var pedidos = _pedidoRepository.ObterTodosPedidos(pagina, codigoPedido, cpf);

            return View(pedidos);
        }

        public IActionResult Visualizar(int Id)
        {
           Pedido pedido = _pedidoRepository.ObterPedido(Id);

            var viewModel = new VisualizarViewModel() { Pedido = pedido };

            return View(viewModel);

        }

        public IActionResult NFE([FromForm]VisualizarViewModel viewModel ,int id)
        {
            ModelState.Remove("Pedido");
            ModelState.Remove("CodigoRastreamento");
            ModelState.Remove("CartaoCredito");
            ModelState.Remove("BoletoBancario");

            if (ModelState.IsValid)
            {
                string url = viewModel.NFE.NFE_URL;

                Pedido pedido = _pedidoRepository.ObterPedido(id);
                pedido.NFe = url;
                pedido.Situacao = PedidoSituacaoConstant.NF_EMITIDA;

                var pedidoSituacao = new PedidoSituacao();
                pedidoSituacao.Data = DateTime.Now;
                pedidoSituacao.Dados = url;
                pedidoSituacao.PedidoId = pedido.Id;
                pedidoSituacao.Situacao = PedidoSituacaoConstant.NF_EMITIDA;

                _pedidoSituacaoRepository.Cadastrar(pedidoSituacao);
                _pedidoRepository.Atualizar(pedido);
            }

            return RedirectToAction(nameof(Visualizar), new { id = id });
        }

        public IActionResult RegistrarRastreamento([FromForm] VisualizarViewModel viewModel, int id)
        {

            ModelState.Remove("Pedido");
            ModelState.Remove("NFE");
            ModelState.Remove("CartaoCredito");
            ModelState.Remove("BoletoBancario");

            if (ModelState.IsValid)
            {
                //string codRastreamento = HttpContext.Request.Form["cod_rastreamento"];
                string codRastreamento = viewModel.CodigoRastreamento.Codigo;

                Pedido pedido = _pedidoRepository.ObterPedido(id);
                pedido.FreteCodRastreamento = codRastreamento;

                pedido.Situacao = PedidoSituacaoConstant.EM_TRANSPORTE;

                var pedidoSituacao = new PedidoSituacao();
                pedidoSituacao.Data = DateTime.Now;
                pedidoSituacao.Dados = codRastreamento;
                pedidoSituacao.PedidoId = pedido.Id;
                pedidoSituacao.Situacao = PedidoSituacaoConstant.EM_TRANSPORTE;

                _pedidoSituacaoRepository.Cadastrar(pedidoSituacao);
                _pedidoRepository.Atualizar(pedido);

            }

            return RedirectToAction(nameof(Visualizar), new { id = id });
        }

        public IActionResult RegistrarCancelamentoPedidoCartaoCredito([FromForm] VisualizarViewModel viewModel, int id)
        {
            ModelState.Remove("Pedido");
            ModelState.Remove("NFE");
            ModelState.Remove("CodigoRastreamento");
            ModelState.Remove("BoletoBancario");

            if (ModelState.IsValid)
            {
                viewModel.CartaoCredito.FormaPagamento = MetodoPagamentoConstant.CartaoCredito;

                //Solicitar cancelamento pagar-me
                Pedido pedido = _pedidoRepository.ObterPedido(id);
                _gerenciarPagarMe.EstornoCartaoCredito(pedido.TransactionId);

                pedido.Situacao = PedidoSituacaoConstant.ESTORNO;

                //Salvar Pedido e Pedido Situacao
                var pedidoSituacao = new PedidoSituacao();
                pedidoSituacao.Data = DateTime.Now;
                pedidoSituacao.Dados = JsonConvert.SerializeObject(viewModel.CartaoCredito);
                pedidoSituacao.PedidoId = id;
                pedidoSituacao.Situacao = PedidoSituacaoConstant.ESTORNO;

                _pedidoSituacaoRepository.Cadastrar(pedidoSituacao);
                _pedidoRepository.Atualizar(pedido);

                //Devolver a mercadoria .. precisa refatorar o codigo
                DevolverProdutosEstoque(pedido);
            }

            return RedirectToAction(nameof(Visualizar), new { id = id });
        }


        public IActionResult RegistrarCancelamentoPedidoBoleto([FromForm] VisualizarViewModel viewModel, int id)
        {
            ModelState.Remove("Pedido");
            ModelState.Remove("NFE");
            ModelState.Remove("CodigoRastreamento");
            ModelState.Remove("CartaoCredito");

            if (ModelState.IsValid)
            {
                viewModel.BoletoBancario.FormaPagamento = MetodoPagamentoConstant.Boleto;

                //Solicitar cancelamento pagar-me
                Pedido pedido = _pedidoRepository.ObterPedido(id);
                _gerenciarPagarMe.EstornoBoletoBancario(pedido.TransactionId,viewModel.BoletoBancario);

                pedido.Situacao = PedidoSituacaoConstant.ESTORNO;

                //Salvar Pedido e Pedido Situacao
                var pedidoSituacao = new PedidoSituacao();
                pedidoSituacao.Data = DateTime.Now;
                pedidoSituacao.Dados = JsonConvert.SerializeObject(viewModel.BoletoBancario);
                pedidoSituacao.PedidoId = id;
                pedidoSituacao.Situacao = PedidoSituacaoConstant.ESTORNO;

                _pedidoSituacaoRepository.Cadastrar(pedidoSituacao);
                _pedidoRepository.Atualizar(pedido);

                //Devolver a mercadoria .. precisa refatorar o codigo
                DevolverProdutosEstoque(pedido);
            }

            return RedirectToAction(nameof(Visualizar), new { id = id });
        }


        private void DevolverProdutosEstoque(Pedido pedido)
        {
            List<ProdutoItem> produtos = JsonConvert.DeserializeObject<List<ProdutoItem>>(pedido.DadosProdutos, new JsonSerializerSettings() { ContractResolver = new ProdutoItemResolver<List<ProdutoItem>>() });

            foreach (var produto in produtos)
            {
                Produto produtoDB = _produtoRepository.ObterProduto(produto.Id);
                produtoDB.Quantidade += produto.QuantidadeProdutoCarrinho;

                _produtoRepository.Atualizar(produto);
            }

        }
    }
}