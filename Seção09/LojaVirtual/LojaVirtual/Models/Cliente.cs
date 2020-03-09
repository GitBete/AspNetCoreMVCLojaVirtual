using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models
{
    public class Cliente
    {
        //pk
        public int Id { get; set; }
        public String Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public String Sexo { get; set; }
        public String CPF { get; set; }
        public String Telefone { get; set; }
        public String Email { get; set; }
        public String Senha { get; set; }


    }
}
