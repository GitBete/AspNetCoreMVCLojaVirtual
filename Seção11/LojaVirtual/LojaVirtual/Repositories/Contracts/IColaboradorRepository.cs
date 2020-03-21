using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Repositories
{
    public interface IColaboradorRepository
    {
        Colaborador Login(string Email, string Senha);

        //Crud
        void Cadastrar(Colaborador colaborador);
        Colaborador ObterColaborador(int Id);

        IEnumerable<Colaborador> ObterTodosColaboradores();

        void Atualizar(Colaborador colaborador);
        void Excluir(int Id);
       
    }
}
