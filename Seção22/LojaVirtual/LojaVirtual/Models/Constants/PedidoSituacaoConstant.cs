using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models.Constants
{
    public class PedidoSituacaoConstant
    {
        public const string AGUARDANDO_PAGAMENTO = "01";
        public const string PAGAMENTO_APROVADO = "02";
        public const string PAGAMENTO_REJEITADO = "03";
        public const string NF_EMITIDA = "04";
        public const string EM_TRANSPORTE = "05";
        public const string ENTREGUE = "06";
        public const string FINALIZADO = "07"; //APOS 7 DIAS DA ENTREGA (DEPOIS NAO PODE SE ARREPENDER)
        public const string EM_CANCELAMENTO = "08"; //SOMENTE FUNCIONARIO FAZ CANCELAMENTO
        public const string EM_ANALISE = "09"; //2 DIAS UTEIS EM ANALISE
        public const string CANCELADO_ACEITO = "10";
        public const string CANCELADO_REJEITADO = "11";
        public const string ESTORNADO = "12"; //DEPOIS DO CANCELAMENTO ACEITO


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