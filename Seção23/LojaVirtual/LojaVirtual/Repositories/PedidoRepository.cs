
using LojaVirtual.Database;
using LojaVirtual.Models;
using LojaVirtual.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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
    }
}
