using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models
{
    public class Pedido
    {
        //pk
        public int Id { get; set; }

        [ForeignKey("Cliente")]
        public int? ClienteId { get; set; }
        public string TransactionId { get; set; } //Paar.Me - Identifica a transacao
     
        //Frete - ECT - Correios
        public string FreteEmpresa { get; set; }
        public string FreteCodRastreamento { get; set; }

        //Formas Pagamento - Boleto ou Cartão de Crédito
        public string FormaPagamento { get; set; }
        public decimal ValorTotal { get; set; }
        public string DadosTransaction { get; set; }  //Transaction JSON
        public string DadosProdutos { get; set; } //Produto item JSON

        public DateTime DataRegistro { get; set; }
        public string Situacao { get; set; }

        // URL - Levar URL com site da receita NF-e
        public string NFe { get; set; }

        //TODO - Pedido X Historico de situacao

        //TODO - relacionamento chave estrangeira com ClienteID       
        public virtual Cliente Cliente { get; set; }

        [ForeignKey("PedidoId")]
        public virtual  ICollection<PedidoSituacao> PedidoSituacoes { get; set; }

    }
}
