
using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace LojaVirtual.Repositories.Contracts
{
   public interface IProdutoRepository
    {               
        //Crud
        void Cadastrar(Produto produto);
        void Atualizar(Produto produto);
        void Excluir(int Id);

        //IEnumerable<Colaborador> ObterTodosColaboradores();        
        Produto ObterProduto(int Id);
        IPagedList<Produto> ObterTodosProdutos(int? pagina,string pesquisa);

    }
}
