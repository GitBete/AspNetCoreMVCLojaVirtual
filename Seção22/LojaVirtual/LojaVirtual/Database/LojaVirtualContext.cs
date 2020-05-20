
using LojaVirtual.Models;
using LojaVirtual.Models.ProdutoAgregador;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LojaVirtual.Database
{
    public class LojaVirtualContext: DbContext
    {
        // EF Core - ORM
        // SQL ->
        // ORM -> Biblioteca mapear Objetos

        public LojaVirtualContext(DbContextOptions<LojaVirtualContext> options):base(options)
        {
            //construtor
        }

        //Fazer a referencia a cada tabela do banco de dados
        //Classe criada em Models, precisa de tabela para essa classe
        //dai ele vai criar as tabelas necessarias
        public DbSet<Cliente>Clientes { get; set; }
        public DbSet<NewsletterEmail> NewsletterEmails { get; set; }
        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
       

        public DbSet<EnderecoEntrega> EnderecosEntrega { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoSituacao> PedidoSituacoes { get; set; }


        public DbSet<Produto> Produto { get; set; }
        public DbSet<Imagem> Imagem { get; set; }

    }
}
