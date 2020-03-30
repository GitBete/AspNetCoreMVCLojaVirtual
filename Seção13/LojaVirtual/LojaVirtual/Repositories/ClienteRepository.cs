using LojaVirtual.Database;
using LojaVirtual.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace LojaVirtual.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private IConfiguration _configuration;
        private LojaVirtualContext _banco;

        public ClienteRepository(LojaVirtualContext banco, IConfiguration configuration)
        {
            //Injecao de dependencias do Entyti framework
            _banco = banco;
            _configuration = configuration;
        }
               
        public void Cadastrar(Cliente cliente)
        {
            //Grava no Banco
            _banco.Add(cliente);
            _banco.SaveChanges();
        }

        public void Atualizar(Cliente cliente)
        {
            _banco.Update(cliente);
            _banco.SaveChanges();
        }
        
        public void Excluir(int Id)
        {
            Cliente cliente = ObterCliente(Id);
            _banco.Remove(cliente);
            _banco.SaveChanges();
        }

        public Cliente Login(string Email, string Senha)
        {
            Cliente cliente= _banco.Clientes.Where(m=>m.Email == Email && m.Senha ==Senha).FirstOrDefault();
            return cliente;
        }

        public Cliente ObterCliente(int Id)
        {
            return _banco.Clientes.Find(Id);
        }

        public IPagedList<Cliente> ObterTodosClientes(int? pagina,string pesquisa)
        {
           // return _banco.Clientes.ToList();

            //Acesso ao AppSettinga
            int RegistroPorPagina = _configuration.GetValue<int>("RegistroPorPagina");

            int NumeroPagina = pagina ?? 1;

            var bancoCliente = _banco.Clientes.AsQueryable();

            if (!string.IsNullOrEmpty(pesquisa))
            {
                //informou o parametro e vai pesquisar apenas o que indicou
                bancoCliente = bancoCliente.Where(a => a.Nome.Contains(pesquisa.Trim()) || a.Email.Contains(pesquisa.Trim()));
            }
            
            return bancoCliente.ToPagedList<Cliente>(NumeroPagina, RegistroPorPagina);

        }
    }
   
}
