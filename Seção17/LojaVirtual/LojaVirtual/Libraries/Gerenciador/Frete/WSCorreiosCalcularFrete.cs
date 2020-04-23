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

        public async Task CalcularValorPrazoFrente(string cepDestino, string tipoFrete,Pacote pacote)
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
                //Tudo OK

            }
            else
            {
                throw new Exception("Erro: " + resultado.Servicos[0].MsgErro);
            }

        }
    }
}