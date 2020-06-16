using Coravel.Invocable;
using LojaVirtual.Models;
using LojaVirtual.Models.Constants;
using LojaVirtual.Repositories.Contracts;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.Gerenciador.Scheduler.Invocable
{
    public class PedidoFinalizadoJob : IInvocable
    {

        private IPedidoRepository _pedidoRepository;
        private IPedidoSituacoesRepository _pedidoSituacoesRepository;
        private IConfiguration _configuration;

        public PedidoFinalizadoJob(IPedidoRepository pedidoRepository, IPedidoSituacoesRepository pedidoSituacoesRepository, IConfiguration configuration)
        {
            _pedidoRepository = pedidoRepository;
            _pedidoSituacoesRepository = pedidoSituacoesRepository;
            _configuration = configuration;
        }

        public Task Invoke()
        {
            var pedidos = _pedidoRepository.ObterTodosPedidosPorSituacao(PedidoSituacaoConstant.ENTREGUE);

            foreach (var pedido in pedidos)
            {
                var pedidoSituacaoDB = pedido.PedidoSituacoes.FirstOrDefault(a => a.Situacao == PedidoSituacaoConstant.ENTREGUE);

                if (pedidoSituacaoDB != null)
                {

                    int tolerancia = _configuration.GetValue<int>("Finalizado:Days");
                    if (DateTime.Now >= pedidoSituacaoDB.Data.AddDays(tolerancia))
                    {
                        PedidoSituacao pedidoSituacao = new PedidoSituacao();
                        pedidoSituacao.PedidoId = pedido.Id;
                        pedidoSituacao.Situacao = PedidoSituacaoConstant.FINALIZADO;
                        pedidoSituacao.Data = DateTime.Now;
                        pedidoSituacao.Dados = "LojaVirtual";

                        //add historio de situacao do pedido
                        _pedidoSituacoesRepository.Cadastrar(pedidoSituacao);

                        //alteracao da situacao atual do pedido
                        pedido.Situacao = PedidoSituacaoConstant.FINALIZADO;
                        _pedidoRepository.Atualizar(pedido);
                    }
                }
            }
            return Task.CompletedTask;
        }
    }
}
