using Coravel.Invocable;
using LojaVirtual.Models;
using LojaVirtual.Models.Constants;
using LojaVirtual.Repositories.Contracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.Gerenciador.Scheduler.Invocable
{
    public class PedidoDevolverEntregueJob: IInvocable
    {
        private IPedidoRepository _pedidoRepository;
        private IPedidoSituacoesRepository _pedidoSituacoesRepository;

        public PedidoDevolverEntregueJob(IPedidoRepository pedidoRepository, IPedidoSituacoesRepository pedidoSituacoesRepository)
        {
            _pedidoRepository = pedidoRepository;
            _pedidoSituacoesRepository = pedidoSituacoesRepository;
        }

        public Task Invoke()
        {
            var pedidos = _pedidoRepository.ObterTodosPedidosPorSituacao(PedidoSituacaoConstant.DEVOLVER);

            foreach (var pedido in pedidos)
            {
                var result = new Correios.NET.Services().GetPackageTracking(pedido.FreteCodRastreamento);

                if (result.IsDelivered)
                {
                    PedidoSituacao pedidoSituacao = new PedidoSituacao();
                    pedidoSituacao.PedidoId = pedido.Id;
                    pedidoSituacao.Situacao = PedidoSituacaoConstant.DEVOLVER_ENTREGUE;
                    pedidoSituacao.Data = result.DeliveryDate.Value;
                    pedidoSituacao.Dados = JsonConvert.SerializeObject(result);

                    //add historio de situacao do pedido
                    _pedidoSituacoesRepository.Cadastrar(pedidoSituacao);

                    //alteracao da situacao atual do pedido
                    pedido.Situacao = PedidoSituacaoConstant.DEVOLVER_ENTREGUE;
                    _pedidoRepository.Atualizar(pedido);
                }
            }
            return Task.CompletedTask;
        }
    }
}
