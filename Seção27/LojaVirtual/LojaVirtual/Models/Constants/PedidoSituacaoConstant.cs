using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models.Constants
{
    public class PedidoSituacaoConstant
    {
        public const string PEDIDO_REALIZADO = "Pedido realizado";
        public const string PAGAMENTO_APROVADO = "Pagamento aprovado";
        public const string PAGAMENTO_REJEITADO = "Pagamento rejeitado";
        public const string PAGAMENTO_NAO_REALIZADO = "Pagamento nao realizado (vencido)";

        public const string NF_EMITIDA = "NF-e Emitida";
        public const string EM_TRANSPORTE = "EM Transporte";
        public const string ENTREGUE = "Entregue";
        public const string FINALIZADO = "Finalizado"; //APOS 7 DIAS DA ENTREGA (DEPOIS NAO PODE SE ARREPENDER)
        public const string ESTORNO = "Estorno"; //DEPOIS DO CANCELAMENTO ACEITO

        public const string DEVOLVER = "Devolver (Em Transporte)";
        public const string DEVOLVER_ENTREGUE = "Devolver (Entregue)";

        public const string DEVOLUCAO_ACEITA = "Devoluçao aceita";
        public const string DEVOLUCAO_REJEITADA = "Devolução rejeitada";
       
     

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