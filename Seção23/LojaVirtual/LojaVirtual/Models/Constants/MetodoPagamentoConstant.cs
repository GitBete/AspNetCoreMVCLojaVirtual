using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models.Constants
{
    public class MetodoPagamentoConstant
    {
        public const string CartaoCredito = "Cartão de Crédito";
        public const string Boleto = "Boleto Bancário";

        public static string GetName(string code)
        {

            foreach (var field in typeof(TipoFreteConstant).GetFields())
            {
                if ((string)field.GetValue(null) == code)
                {
                    return field.Name.ToString();
                }
            }

            return "";
        }

    }
}
