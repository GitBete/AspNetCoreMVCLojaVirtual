using LojaVirtual.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using WSCorreios;

namespace LojaVirtual.Libraries.Gerenciador.Frete
{
    public class WSCorreiosCalcularFrete
    {
        private IConfiguration _configuration;
        private CalcPrecoPrazoWSSoap _servico;

        public WSCorreiosCalcularFrete(IConfiguration configuration, CalcPrecoPrazoWSSoap servico)
        {
            _configuration = configuration;
            _servico = servico;
        }

        public async Task<ValorPrazoFrete> CalcularFrete(String cepDestino,String tipoFrete, List<Pacote> pacotes)
        {
            List<ValorPrazoFrete> valorDosPacotesPorFrete = new List<ValorPrazoFrete>();

            foreach (var pacote in pacotes)
            {
                var resultado = await CalcularValorPrazoFrente(cepDestino, tipoFrete, pacote);

                if (resultado != null)
                {
                    valorDosPacotesPorFrete.Add(resultado);
                }
                
            }

            if (valorDosPacotesPorFrete.Count > 0)
            {
                //vai retornar uma lista com o valor de cada pacote
                ValorPrazoFrete ValorDosFretes = valorDosPacotesPorFrete
                     .GroupBy(a => a.TipoFrete)
                     .Select(list => new ValorPrazoFrete
                     {
                         TipoFrete = list.First().TipoFrete,
                         Prazo = list.Max(c => c.Prazo),
                         Valor = list.Sum(c => c.Valor)
                     }).ToList().First();

                return ValorDosFretes;
            }

            return null;
        }

        private async Task<ValorPrazoFrete> CalcularValorPrazoFrente(string cepDestino, string tipoFrete,Pacote pacote)
        {
            //app.setting ... deveria estar numa configuracao para cada cliente (forma flexivel)
            //Assim fica tendo que trocar no sistema para enviar para cada cliente - INVIAVEL
            var cepOrigem = _configuration.GetValue<string>("Frete:CepOrigem");
            var maoPropria = _configuration.GetValue<string>("Frete:MaoPropria");
            var avisoRecebimento = _configuration.GetValue<string>("Frete:AvisoRecebimento");

            var diametro = Math.Max(Math.Max(pacote.Comprimento, pacote.Largura), pacote.Altura);

            //reti=orna um arquivo JSON
            cResultado resultado = await _servico.CalcPrecoPrazoAsync("", "", tipoFrete, cepOrigem, cepDestino, pacote.Peso.ToString(),1,pacote.Comprimento,pacote.Altura,pacote.Largura, diametro,maoPropria,0, avisoRecebimento);
       
            if (resultado.Servicos[0].Erro =="0")
            {
                //Implementar um resultado desejado - o retorno do WebService devolve muitas informacoes
                return new ValorPrazoFrete()
                {
                    TipoFrete = tipoFrete,
                    Prazo = int.Parse(resultado.Servicos[0].PrazoEntrega),
                    Valor = double.Parse(resultado.Servicos[0].Valor.Replace(".", "").Replace(",", "."))
                };

            }
            else if(resultado.Servicos[0].Erro == "008")
            {
                //SEDEX10 - nao entrega na regiao solicitada
                return null;
            }
            else
            {
                throw new Exception("Erro: " + resultado.Servicos[0].MsgErro);
            }

        }
    }
}