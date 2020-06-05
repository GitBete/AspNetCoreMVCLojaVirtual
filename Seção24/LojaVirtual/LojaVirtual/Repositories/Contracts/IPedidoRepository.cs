using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace LojaVirtual.Repositories.Contracts
{
   public  interface IPedidoRepository
    {

        //Crud
        void Cadastrar(Pedido pedido);
        void Atualizar(Pedido pedido);                     
        Pedido ObterPedido(int id);
        IPagedList<Pedido> ObterTodosPedidosCliente(int? pagina, int clienteId);

        IPagedList<Pedido> ObterTodosPedidos(int? pagina, string codigoPedido, string cpf);

    }
}
