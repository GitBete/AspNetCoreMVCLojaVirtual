﻿using LojaVirtual.Database;
using LojaVirtual.Models;
using LojaVirtual.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Repositories
{
    public class NewsletterRepository : INewsletterRepository
    {

        private LojaVirtualContext _banco;

        public NewsletterRepository(LojaVirtualContext banco)
        {
            //Injecao de dependencias do Entyti framework
            _banco = banco;
        }

        public void Cadastrar(NewsletterEmail newsletter)
        {
            _banco.NewsletterEmails.Add(newsletter);
            _banco.SaveChanges();
        }

        public IEnumerable<NewsletterEmail> ObterTodasNewsletters()
        {
            return _banco.NewsletterEmails.ToList();
        }
    }
}
