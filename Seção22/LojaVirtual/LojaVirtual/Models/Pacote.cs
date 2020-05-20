using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models
{
    public class Pacote
    {

        //e não adicionar em DBContext ele pode ser utilizado sem incluir no banco de dados
        public int Largura { get; set; }
        public int Altura { get; set; }
        public int Comprimento { get; set; }
        public double Peso { get; set; }
    }
}
