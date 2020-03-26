using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace LojaVirtual.Repositories
{
    public interface IColaboradorRepository
    {
        Colaborador Login(string Email, string Senha);

        //Crud
        void Cadastrar(Colaborador colaborador);
        Colaborador ObterColaborador(int Id);
        void Atualizar(Colaborador colaborador);
        void Excluir(int Id);

        //IEnumerable<Colaborador> ObterTodosColaboradores();        

        IPagedList<Colaborador> ObterTodosColaboradores(int? pagina);

    }
}
