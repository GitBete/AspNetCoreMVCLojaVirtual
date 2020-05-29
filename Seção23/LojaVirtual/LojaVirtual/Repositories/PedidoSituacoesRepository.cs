using LojaVirtual.Database;
using LojaVirtual.Models;
using LojaVirtual.Repositories.Contracts;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Repositories
{
    public class PedidoSituacoesRepository : IPedidoSituacoesRepository
    {
        private IConfiguration _configuration;
        private LojaVirtualContext _banco;

        public PedidoSituacoesRepository(IConfiguration configuration, LojaVirtualContext banco)
        {
            _configuration = configuration;
            _banco = banco;
        }

        public void Cadastrar(PedidoSituacao pedidoSituacao)
        {
            //Grava no Banco
            _banco.Add(pedidoSituacao);
            _banco.SaveChanges();
        }

        public void Atualizar(PedidoSituacao pedidoSituacao)
        {
            _banco.Update(pedidoSituacao);
            _banco.SaveChanges();
        }

        public void Excluir(int id)
        {
            PedidoSituacao pedidoSituacao = ObterPedidoSituacao(id);
            _banco.Remove(pedidoSituacao);
            _banco.SaveChanges();
        }

        public PedidoSituacao ObterPedidoSituacao(int id)
        {
            return _banco.PedidoSituacoes.Include(a => a.Pedido).Where(a => a.Id == id).FirstOrDefault();
        }

      

    }

}
