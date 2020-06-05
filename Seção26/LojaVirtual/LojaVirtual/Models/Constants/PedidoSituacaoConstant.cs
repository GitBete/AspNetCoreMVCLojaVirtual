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
        public const string EM_CANCELAMENTO = "Em Cancelamento"; //SOMENTE FUNCIONARIO FAZ CANCELAMENTO
        public const string EM_ANALISE = "Em análise"; //2 DIAS UTEIS EM ANALISE
        public const string CANCELADO_ACEITO = "Cancelamento aceito";
        public const string CANCELADO_REJEITADO = "Cancelamento rejeitado";
        public const string ESTORNO = "Estorno"; //DEPOIS DO CANCELAMENTO ACEITO
     

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