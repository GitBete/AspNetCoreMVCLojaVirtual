using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace LojaVirtual.Repositories
{
   public interface IClienteRepository
    {

        //Inclusao dos metodos que ira precisar
        Cliente Login(String Email,String Senha);
        
        //Crud
        void Cadastrar(Cliente cliente);
        void Atualizar(Cliente cliente);
        
        void Excluir(int Id);
        Cliente ObterCliente(int Id);
        IPagedList<Cliente> ObterTodosClientes(int? pagina,string pesquisa);
        
    }
}
