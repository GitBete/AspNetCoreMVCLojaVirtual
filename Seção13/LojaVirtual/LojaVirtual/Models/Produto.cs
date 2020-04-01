using LojaVirtual.Libraries.Lang;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models
{
    public class Produto
    {
        //PK
        public int Id { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        public string Nome { get; set; }
        [Display(Name ="Descrição")]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        public string Descricao { get; set; }
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        [Display(Name = "Preço")]
        [Range(0.01, 1000000)]
        public decimal Valor { get; set; }
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        [Range(0,1000000, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E006")]
        public int Quantidade { get; set; }

        //Frete - Correios, ver regras do correio para as medidas do produto
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        [Range(0.001, 30, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E006")]
        public double Peso { get; set; }
      
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        [Range(11, 105, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E006")]
        public int Largura { get; set; }
       
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        [Range(2, 105, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E006")]
        public int Altura { get; set; }
      
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        [Range(16, 105, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E006")]
        public int Comprimento { get; set; }
     
        /*
           * EntityFramework - ORM - Biblioteca unir banco de dados (ORM - mapeamento de objetos relacionais)
           * Fluente API - Attributes
        */

        //Categoria - Relacionamento Banco de Dados - Cardinalidade  
        [Display(Name = "Categoria")]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        public int CategoriaId { get; set; }

        //POO - Associacaoes entre objetos
        [ForeignKey("CategoriaId")]
        public virtual Categoria Categoria { get; set; }

        public virtual ICollection <Imagem> Imagens { get; set; }
    }
}
