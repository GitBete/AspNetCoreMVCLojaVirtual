using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace LojaVirtual.Libraries.Texto
{
    public class Mascara
    {

        public static string Remover(string valor)
        {
            return valor.Replace("(", "").Replace(")","").Replace("-","").Replace(".","").Replace("R$", "").Replace(",", "");
        }

        public static int ConverterValorPagarMe(decimal valor)
        {
            string valorString = valor.ToString("C");
            valorString = Remover(valorString);

            int valorInt = int.Parse(valorString);
            return valorInt;
        }

        public static decimal ConverterPagarMeIntDecimal(int valor)
        {
            string valorPagarMe = valor.ToString();
            string valorDecimalString =  valorPagarMe.Substring(0, valorPagarMe.Length - 2) + "," + valorPagarMe.Substring( valorPagarMe.Length - 2);

            var valorDecimal = decimal.Parse(valorDecimalString);

            return valorDecimal;
        }

       public static int ExtrairCodigoPedido(string codigoPedido,out string transactionId)
        {
            string[] resultadoSeparacao = codigoPedido.Split("-");

            transactionId = resultadoSeparacao[1];

            return int.Parse(resultadoSeparacao[0]);
        }
    }
}
