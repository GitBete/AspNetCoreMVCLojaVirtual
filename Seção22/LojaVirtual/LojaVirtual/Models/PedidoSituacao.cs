using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models
{
    public class PedidoSituacao
    {
        //pk
        public int Id { get; set; }

        [ForeignKey("PedidoId")]
        public int? PedidoId { get; set; }


        public DateTime Data { get; set; }
        public string Situacao  { get; set; }
        public string Dados { get; set; } //Cod.Rastreamento ou qualquer informacao relevante

        
        public virtual Pedido Pedido { get; set; }
    }
}
