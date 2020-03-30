using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models
{
    public class Produto
    {
        //PK
        public int Id { get; set; } 
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }

        //Frete - Correios
        public double Peso { get; set; }
        public int Largura { get; set; }
        public int Altura { get; set; }
        public int Comprimento { get; set; }

        /*
           * EntityFramework - ORM - Biblioteca unir banco de dados (ORM - mapeamento de objetos relacionais)
           * Fluente API - Attributes
        */

        //Categoria - Relacionamento Banco de Dados - Cardinalidade       
        public int CategoriaId { get; set; }

        //POO - Associacaoes entre objetos
        [ForeignKey("CategoriaId")]
        public virtual Categoria Categoria { get; set; }


        public virtual ICollection <Imagem> Imagens { get; set; }
    }
}
