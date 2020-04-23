
using LojaVirtual.Models;
using LojaVirtual.Models.ProdutoAgregador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.Gerenciador.Frete
{
    public class CalcularPacote
    {
        //Codigo nao muito eficiente para dimensoes diferentes de produto

        public List<Pacote> CalcularPacotesProdutos(List<ProdutoItem> produtos)
        {
            List<Pacote> pacotes = new List<Pacote>();

            Pacote pacote = new Pacote();
            foreach (var item in produtos)
            {
                for (int i = 0; i< item.QuantidadeProdutoCarrinho; i++)
                {
                    //Variaveis para montar pacote
                    var peso = pacote.Peso + item.Peso;
                    var altura = pacote.Altura + item.Altura;
                    //ja vai ser criticado no cadastro
                    var comprimento =  (pacote.Comprimento > item.Comprimento) ? pacote.Comprimento:item.Comprimento;
                    var largura =( pacote.Largura > item.Largura) ? pacote.Largura:item.Largura;

                    var dimensao = comprimento + largura + altura;


                    /* COVIT-19 ... 22/04/2020
                     * Regras do correio - Para criar novo pacote
                     * maior que 30kg e dimensao > 200cm
                     */
                    if (peso > 30 || dimensao > 200)
                    {
                        //guardar pacote anterior
                        pacotes.Add(pacote);
                        //cria novo pacote
                        pacote = new Pacote();
                        //Não vai zerar as variaveis ??????
                    }

                    //Montar Pacote
                    pacote.Peso = pacote.Peso + item.Peso;
                    pacote.Altura = pacote.Altura + item.Altura;
                    pacote.Comprimento = (pacote.Comprimento > item.Comprimento) ? pacote.Comprimento : item.Comprimento;
                    pacote.Largura = (pacote.Largura > item.Largura) ? pacote.Largura : item.Largura;


                }
            }

            pacotes.Add(pacote);
            return pacotes;
        }
    }
}
