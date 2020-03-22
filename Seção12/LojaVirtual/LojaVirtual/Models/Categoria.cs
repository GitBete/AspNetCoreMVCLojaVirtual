using LojaVirtual.Libraries.Lang;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models
{
    public class Categoria
    {
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(4, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E002")]
        //depois criar validacao para unico nome de categoria
        public string  Nome { get; set; }

        /*
         * Nome: Informática
         * Slug: telefone-sem-fio
         * Url normal: www.lojavirtual.com.br/categoria/5
         * url amigavel e com Slug: www.lojavirtual.com.br/categoria/informatica 
         * Slug:
         */
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(4, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E002")]
        public string Slug { get; set; }

        /*
         * Auto-relacionamento 
         * 1 - Informatica - Pai:null
         * 2 -- Mouse - Pai:1
         * 3 --- Mouse sem fio Pai:2
         * 4 ---- Mouse Gamer Pai:3
         */
        
         public int? CategoriaPaiId{ get; set; }

        /*
         * CRM - EntityFrameworkCore
         */
        [ForeignKey("CategoriaPaiId")]
        [Display(Name = "Categoria Pai")]

        public virtual Categoria CategoriaPai { get; set; }
    }
}
