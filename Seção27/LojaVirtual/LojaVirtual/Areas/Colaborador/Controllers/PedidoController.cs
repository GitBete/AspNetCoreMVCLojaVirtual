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

        public IActionResult NFE([FromForm] VisualizarViewModel viewModel, int id)
        {
            ModelState.Remove("Pedido");
            ModelState.Remove("CodigoRastreamento");
            ModelState.Remove("CartaoCredito");
            ModelState.Remove("BoletoBancario");
            ModelState.Remove("DadosDevolucao");
            ModelState.Remove("DevolucaoMotivoRejeicao");


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
            else
            {
                ViewBag.MODAL_NFE = true;
            }

            viewModel.Pedido = _pedidoRepository.ObterPedido(id);
            return View(nameof(Visualizar), viewModel);
        }

        public IActionResult RegistrarRastreamento([FromForm] VisualizarViewModel viewModel, int id)
        {

            ModelState.Remove("Pedido");
            ModelState.Remove("NFE");
            ModelState.Remove("CartaoCredito");
            ModelState.Remove("BoletoBancario");
            ModelState.Remove("DadosDevolucao");
            ModelState.Remove("DevolucaoMotivoRejeicao");

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
            else
            {
                ViewBag.MODAL_RASTREAMENTO = true;
            }

            viewModel.Pedido = _pedidoRepository.ObterPedido(id);
            return View(nameof(Visualizar), viewModel);
        }

        public IActionResult RegistrarCancelamentoPedidoCartaoCredito([FromForm] VisualizarViewModel viewModel, int id)
        {
            ModelState.Remove("Pedido");
            ModelState.Remove("NFE");
            ModelState.Remove("CodigoRastreamento");
            ModelState.Remove("BoletoBancario");
            ModelState.Remove("DadosDevolucao");
            ModelState.Remove("DevolucaoMotivoRejeicao");

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
            else
            {
                ViewBag.MODAL_CARTAOCREDITO = true;
            }

            viewModel.Pedido = _pedidoRepository.ObterPedido(id);
            return View(nameof(Visualizar), viewModel);
        }


        public IActionResult RegistrarCancelamentoPedidoBoleto([FromForm] VisualizarViewModel viewModel, int id)
        {
            ModelState.Remove("Pedido");
            ModelState.Remove("NFE");
            ModelState.Remove("CodigoRastreamento");
            ModelState.Remove("CartaoCredito");
            ModelState.Remove("DadosDevolucao");
            ModelState.Remove("DevolucaoMotivoRejeicao");

            if (ModelState.IsValid)
            {
                viewModel.BoletoBancario.FormaPagamento = MetodoPagamentoConstant.Boleto;

                //Solicitar cancelamento pagar-me
                Pedido pedido = _pedidoRepository.ObterPedido(id);
                _gerenciarPagarMe.EstornoBoletoBancario(pedido.TransactionId, viewModel.BoletoBancario);

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
            else
            {
                ViewBag.MODAL_BOLETOBANCARIO = true;
            }

            viewModel.Pedido = _pedidoRepository.ObterPedido(id);
            return View(nameof(Visualizar), viewModel);
        }

        public IActionResult RegistrarDevoluvaoPedidoJaEntregue([FromForm] VisualizarViewModel viewModel, int id)
        {
            ModelState.Remove("Pedido");
            ModelState.Remove("NFE");
            ModelState.Remove("CodigoRastreamento");
            ModelState.Remove("CartaoCredito");
            ModelState.Remove("BoletoBancario");
            ModelState.Remove("DevolucaoMotivoRejeicao");

            if (ModelState.IsValid)
            {
                //Solicitar cancelamento pagar-me
                Pedido pedido = _pedidoRepository.ObterPedido(id);

                pedido.Situacao = PedidoSituacaoConstant.DEVOLVER;

                //Salvar Pedido e Pedido Situacao
                var pedidoSituacao = new PedidoSituacao();
                pedidoSituacao.Data = DateTime.Now;
                pedidoSituacao.Dados = JsonConvert.SerializeObject(viewModel.Devolucao);
                pedidoSituacao.PedidoId = id;
                pedidoSituacao.Situacao = PedidoSituacaoConstant.DEVOLVER;

                _pedidoSituacaoRepository.Cadastrar(pedidoSituacao);
                _pedidoRepository.Atualizar(pedido);

            }
            else
            {
                ViewBag.MODAL_DEVOLVER = true;
            }

            viewModel.Pedido = _pedidoRepository.ObterPedido(id);
            return View(nameof(Visualizar), viewModel);
        }

        public IActionResult RegistrarDevoluvaoPedidoRejeicao([FromForm] VisualizarViewModel viewModel, int id)
        {
            ModelState.Remove("Pedido");
            ModelState.Remove("NFE");
            ModelState.Remove("CodigoRastreamento");
            ModelState.Remove("CartaoCredito");
            ModelState.Remove("BoletoBancario");
            ModelState.Remove("DadosDevolucao");

            if (ModelState.IsValid)
            {
                //Solicitar cancelamento pagar-me
                Pedido pedido = _pedidoRepository.ObterPedido(id);

                pedido.Situacao = PedidoSituacaoConstant.DEVOLUCAO_REJEITADA;

                //Salvar Pedido e Pedido Situacao
                var pedidoSituacao = new PedidoSituacao();
                pedidoSituacao.Data = DateTime.Now;
                pedidoSituacao.Dados = viewModel.DevolucaoMotivoRejeicao;
                pedidoSituacao.PedidoId = id;
                pedidoSituacao.Situacao = PedidoSituacaoConstant.DEVOLUCAO_REJEITADA;

                _pedidoSituacaoRepository.Cadastrar(pedidoSituacao);
                _pedidoRepository.Atualizar(pedido);

            }
            else
            {
                ViewBag.MODAL_DEVOLVER_REJEITAR = true;
            }

            viewModel.Pedido = _pedidoRepository.ObterPedido(id);
            return View(nameof(Visualizar), viewModel);
        }

        public IActionResult RegistrarDevoluvaoPedidoAprovadoCartao( int id)
        {
            //Solicitar cancelamento pagar-me
            Pedido pedido = _pedidoRepository.ObterPedido(id);

            if (pedido.Situacao == PedidoSituacaoConstant.DEVOLUCAO_ACEITA)
            {
                pedido.Situacao = PedidoSituacaoConstant.DEVOLUCAO_ACEITA;

                //Salvar Pedido e Pedido Situacao
                var pedidoSituacao = new PedidoSituacao();
                pedidoSituacao.Data = DateTime.Now;
                pedidoSituacao.PedidoId = id;
                pedidoSituacao.Situacao = PedidoSituacaoConstant.DEVOLUCAO_ACEITA;

                _pedidoSituacaoRepository.Cadastrar(pedidoSituacao);
                _pedidoRepository.Atualizar(pedido);

                //Solicitar cancelamento pagar-me
                _gerenciarPagarMe.EstornoCartaoCredito(pedido.TransactionId);

                pedido.Situacao = PedidoSituacaoConstant.ESTORNO;

                pedidoSituacao = new PedidoSituacao();
                pedidoSituacao.Data = DateTime.Now;
                pedidoSituacao.PedidoId = id;
                pedidoSituacao.Situacao = PedidoSituacaoConstant.ESTORNO;

                _pedidoSituacaoRepository.Cadastrar(pedidoSituacao);
                _pedidoRepository.Atualizar(pedido);

                //Devolver a mercadoria .. precisa refatorar o codigo
                DevolverProdutosEstoque(pedido);
            }

            VisualizarViewModel viewModel = new VisualizarViewModel();
            viewModel.Pedido = pedido;
            return View(nameof(Visualizar), viewModel);

        }

      
        public IActionResult RegistrarDevoluvaoPedidoAprovadoBoleto([FromForm] VisualizarViewModel viewModel, int id)
        {
            ModelState.Remove("Pedido");
            ModelState.Remove("NFE");
            ModelState.Remove("CodigoRastreamento");
            ModelState.Remove("CartaoCredito");
            ModelState.Remove("DadosDevolucao");
            ModelState.Remove("DevolucaoMotivoRejeicao");

            ModelState.Remove("BoletoBancario.Motivo");

            if (ModelState.IsValid)
            {
                Pedido pedido = _pedidoRepository.ObterPedido(id);

                pedido.Situacao = PedidoSituacaoConstant.DEVOLUCAO_ACEITA;

                //Salvar Pedido e Pedido Situacao
                var pedidoSituacao = new PedidoSituacao();
                pedidoSituacao.Data = DateTime.Now;
                pedidoSituacao.PedidoId = id;
                pedidoSituacao.Situacao = PedidoSituacaoConstant.DEVOLUCAO_ACEITA;

                _pedidoSituacaoRepository.Cadastrar(pedidoSituacao);
                _pedidoRepository.Atualizar(pedido);

                viewModel.BoletoBancario.FormaPagamento = MetodoPagamentoConstant.Boleto;

                //Solicitar cancelamento pagar-me
                _gerenciarPagarMe.EstornoBoletoBancario(pedido.TransactionId, viewModel.BoletoBancario);

                pedido.Situacao = PedidoSituacaoConstant.ESTORNO;

                //Salvar Pedido e Pedido Situacao
                pedidoSituacao = new PedidoSituacao();
                pedidoSituacao.Data = DateTime.Now;
                pedidoSituacao.Dados = JsonConvert.SerializeObject(viewModel.BoletoBancario);
                pedidoSituacao.PedidoId = id;
                pedidoSituacao.Situacao = PedidoSituacaoConstant.ESTORNO;

                _pedidoSituacaoRepository.Cadastrar(pedidoSituacao);
                _pedidoRepository.Atualizar(pedido);

                //Devolver a mercadoria .. precisa refatorar o codigo
                DevolverProdutosEstoque(pedido);
            }
            else
            {
                ViewBag.MODAL_DEVOLVER_BOLETOBANCARIO = true;
            }

            viewModel.Pedido = _pedidoRepository.ObterPedido(id);
            return View(nameof(Visualizar), viewModel);
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