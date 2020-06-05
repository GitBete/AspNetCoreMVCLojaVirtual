using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models.ProdutoAgregador
{
    public class ProdutoItem:Produto
    {
        public int QuantidadeProdutoCarrinho { get; set; }
    }
}
