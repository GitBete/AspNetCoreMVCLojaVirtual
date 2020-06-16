
using LojaVirtual.Database;
using LojaVirtual.Libraries.Texto;
using LojaVirtual.Models;
using LojaVirtual.Models.Constants;
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using X.PagedList;

namespace LojaVirtual.Repositories
{
    public class PedidoRepository:IPedidoRepository
    {

        private IConfiguration _configuration;
        private LojaVirtualContext _banco;

        public PedidoRepository(IConfiguration configuration, LojaVirtualContext banco)
        {
            _configuration = configuration;
            _banco = banco;
        }


        public void Cadastrar(Pedido pedido)
        {
            //Grava no Banco
            _banco.Add(pedido);
            _banco.SaveChanges();
        }

        public void Atualizar(Pedido pedido)
        {
            _banco.Update(pedido);
            _banco.SaveChanges();
        }


        public Pedido ObterPedido(int id)
        {
            Pedido pedido = _banco.Pedidos.Include(a => a.PedidoSituacoes).OrderByDescending(a=> a.DataRegistro).Where(a => a.Id == id).FirstOrDefault();
          
            return pedido;
        }


        public IPagedList<Pedido> ObterTodosPedidosCliente(int? pagina, int clienteId)
        {
            //Acesso ao AppSettinga
            int RegistroPorPagina = _configuration.GetValue<int>("RegistroPorPagina");

            int NumeroPagina = pagina ?? 1;

            //Acho que professor errou
            //return _banco.Pedidos.Include(a => a.PedidoSituacoes).ToPagedList<Pedido>(NumeroPagina,RegistroPorPagina);
            var pedidos = _banco.Pedidos.Include(u => u.PedidoSituacoes).OrderBy(a => a.DataRegistro).Where(a => a.ClienteId == clienteId).ToPagedList<Pedido>(NumeroPagina, RegistroPorPagina);
            
            return pedidos;
        }

        public IPagedList<Pedido> ObterTodosPedidos(int? pagina, string codigoPedido, string cpf)
        {
            //Acesso ao AppSettinga
            int RegistroPorPagina = _configuration.GetValue<int>("RegistroPorPagina");

            int NumeroPagina = pagina ?? 1;

            var query = _banco.Pedidos.Include(a => a.PedidoSituacoes).Include(a=> a.Cliente).AsQueryable();

            //filtro de pesquisa
            if (cpf != null)
            {
                query = query.Where(a => a.Cliente.CPF == cpf);
            }
            if (codigoPedido != null)
            {
                string transacaoId = string.Empty;
                int id = Mascara.ExtrairCodigoPedido(codigoPedido, out transacaoId);

                query = query.Where(a => a.Id == id && a.TransactionId == transacaoId);
            }

            return query.ToPagedList<Pedido>(NumeroPagina, RegistroPorPagina);
        }

        public List<Pedido> ObterTodosPedidosPorSituacao(string status)
        {
            return _banco.Pedidos.Include(a => a.PedidoSituacoes).Include(a => a.Cliente).Where(a => a.Situacao == status).ToList();
        }
    }
}
