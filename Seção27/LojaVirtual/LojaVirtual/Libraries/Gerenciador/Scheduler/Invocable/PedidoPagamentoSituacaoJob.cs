using AutoMapper;
using Coravel.Invocable;
using LojaVirtual.Libraries.Gerenciador.Pagamento.PagarMe;
using LojaVirtual.Libraries.Json.Resolver;
using LojaVirtual.Models;
using LojaVirtual.Models.Constants;
using LojaVirtual.Models.ProdutoAgregador;
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.JsonPatch.Internal;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using PagarMe;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.Gerenciador.Scheduler.Invocable
{
    public class PedidoPagamentoSituacaoJob : IInvocable
    {
        private GerenciarPagarMe _gerenciarPagarMe;
        private IPedidoRepository _pedidoRepository;
        private IMapper _mapper;
        private IPedidoSituacoesRepository _pedidoSituacoesRepository;
        private IConfiguration _configuration;
        private IProdutoRepository _produtoRepository;

        public PedidoPagamentoSituacaoJob(GerenciarPagarMe gerenciarPagarMe, IPedidoRepository pedidoRepository, IMapper mapper, IPedidoSituacoesRepository pedidoSituacoesRepository, IConfiguration configuration, IProdutoRepository produtoRepository)
        {
            _gerenciarPagarMe= gerenciarPagarMe;
            _pedidoRepository = pedidoRepository;
            _mapper = mapper;
            _pedidoSituacoesRepository = pedidoSituacoesRepository;
            _configuration = configuration;
            _produtoRepository = produtoRepository;
        }

        public Task Invoke()
        {
            //Debug.WriteLine("--PedidoPagamentoSituacaoJob - Executando --");

            //Rotina desenvolvida apenas para o Pagar.Me

            var pedidosRealizados = _pedidoRepository.ObterTodosPedidosPorSituacao(PedidoSituacaoConstant.PEDIDO_REALIZADO);

            foreach (var pedido in pedidosRealizados)
            {
                string situacao = null;
                var transaction = _gerenciarPagarMe.ObterTransacao(pedido.TransactionId);

                // Valores possíveis: processing, authorized, paid, refunded, waiting_payment, pending_refund, refused
                //Motivo pelo qual a transação foi recusada.
                //Valores possíveis: acquirer, antifraud, internal_error, no_acquirer, acquirer_timeout
               int toleranciaDias= _configuration.GetValue<int>("Pagamento:PagarMe:BoletoDiasExpiracao") +  _configuration.GetValue<int>("Pagamento:PagarMe:BoletoDiaToleranciaVencido");

                if (transaction.Status == TransactionStatus.WaitingPayment && transaction.PaymentMethod == PaymentMethod.Boleto && DateTime.Now == pedido.DataRegistro.AddDays(toleranciaDias))
                {
                    //Retornar para o estoque os produtos desse carrinho
                    situacao = PedidoSituacaoConstant.PAGAMENTO_NAO_REALIZADO;
                    DevolverProdutosEstoque(pedido);
                }

                if (transaction.Status == TransactionStatus.Refused )
                {
                    //Retornar para o estoque os produtos desse carrinho
                    situacao = PedidoSituacaoConstant.PAGAMENTO_REJEITADO;
                    DevolverProdutosEstoque(pedido);
                }

                if (transaction.Status == TransactionStatus.Authorized || transaction.Status == TransactionStatus.Paid)
                {
                    situacao = PedidoSituacaoConstant.PAGAMENTO_APROVADO;
                }

                if (transaction.Status == TransactionStatus.Refunded)
                {
                    situacao = PedidoSituacaoConstant.ESTORNO;
                    DevolverProdutosEstoque(pedido);
                }

                if (situacao != null)
                {
                    //rejeitado ou aprovado
                    TransacaoPagarMe transacaoPagarMe = _mapper.Map<Transaction, TransacaoPagarMe>(transaction);
                    transacaoPagarMe.Customer.Gender = (pedido.Cliente.Sexo == "M" ? Gender.Male : Gender.Female);

                    PedidoSituacao pedidoSituacao = new PedidoSituacao();
                    pedidoSituacao.PedidoId = pedido.Id;
                    pedidoSituacao.Situacao = situacao;
                    pedidoSituacao.Data = transaction.DateUpdated.Value;
                    pedidoSituacao.Dados = JsonConvert.SerializeObject(transacaoPagarMe);

                    //add historio de situacao do pedido
                    _pedidoSituacoesRepository.Cadastrar(pedidoSituacao);

                    //alteracao da situacao atual do pedido
                    pedido.Situacao = situacao;
                    _pedidoRepository.Atualizar(pedido);
                }
                              
            }

            return Task.CompletedTask;
        }

        private void DevolverProdutosEstoque(Pedido pedido)
        {
           List<ProdutoItem> produtos =  JsonConvert.DeserializeObject<List<ProdutoItem>>(pedido.DadosProdutos , new JsonSerializerSettings() { ContractResolver = new ProdutoItemResolver<List<ProdutoItem>>()});
       
           foreach (var produto in produtos)
           {
                Produto produtoDB = _produtoRepository.ObterProduto(produto.Id);
                produtoDB.Quantidade += produto.QuantidadeProdutoCarrinho;

                _produtoRepository.Atualizar(produto);
           }
        
        }
    }
}
