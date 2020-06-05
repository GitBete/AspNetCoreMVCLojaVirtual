
using LojaVirtual.Libraries.Login;
using LojaVirtual.Libraries.Texto;
using LojaVirtual.Models;
using LojaVirtual.Models.ProdutoAgregador;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Configuration;
using PagarMe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.Gerenciador.Pagamento.PagarMe
{
    public class GerenciarPagarMe
    {     
        private IConfiguration _configuration;
        private LoginCliente _loginCliente;

        public GerenciarPagarMe(IConfiguration configuration, LoginCliente loginCliente)
        {
            _configuration = configuration;
            _loginCliente = loginCliente;
        }

        
        //BOLETO BANCARIO
        public Transaction GerarBoleto(decimal valor,EnderecoEntrega enderecoEntrega, ValorPrazoFrete valorFrete, List<ProdutoItem> produtos)
        {
            Cliente cliente = _loginCliente.GetCliente();                       

            PagarMeService.DefaultApiKey = _configuration.GetValue<String>("Pagamento:PagarMe:ApiKey");
            PagarMeService.DefaultEncryptionKey = _configuration.GetValue<String>("Pagamento:PagarMe:EncryptionKey");
            //pega a data de expiraco do boleto pelo arquivo de configuracao
            int diasParaExpiracao = _configuration.GetValue<int>("Pagamento:PagarMe:BoletoDiasExpiracao");

            Transaction transaction = new Transaction();

            transaction.Amount = Mascara.ConverterValorPagarMe(valor);
            transaction.PaymentMethod = PaymentMethod.Boleto;
            transaction.BoletoExpirationDate = DateTime.Now.AddDays(diasParaExpiracao);                       
               
            //Dados do usuario logado
            transaction.Customer = new Customer
            {
                ExternalId = cliente.Id.ToString(),
                Name = cliente.Nome,
                Type = CustomerType.Individual,
                Country = "br",
                Email = cliente.Email,
                Documents = new[] {
                    new Document{
                        Type = DocumentType.Cpf,
                        Number = Mascara.Remover(cliente.CPF)
                    }                       
                },
                PhoneNumbers = new string[]
                {
                    "+55" + Mascara.Remover(cliente.Telefone)
                },                
                Birthday = cliente.Nascimento.ToString("yyyy-MM-dd")
            };

            var Today = DateTime.Now;
            int diasPreparoFrete = _configuration.GetValue<int>("Frete:DiasPreparoEnvio");

                    //decimal valorTotal = Convert.ToDecimal(valorFrete.Valor);

            //endereco de entrega
            transaction.Shipping = new Shipping
            {
                Name = enderecoEntrega.Nome,
                Fee = Mascara.ConverterValorPagarMe(Convert.ToDecimal(valorFrete.Valor)),
                //pode adicionar mais dias a essa data
                DeliveryDate = Today.AddDays(diasPreparoFrete).AddDays(valorFrete.Prazo).ToString("yyyy-MM-dd"),
                Expedited = false,
                Address = new Address()
                {
                    Country = "br",
                    State = enderecoEntrega.UF,
                    City = enderecoEntrega.Cidade,
                    Neighborhood = enderecoEntrega.Bairro,
                    Street = enderecoEntrega.Logradouro + " " + enderecoEntrega.Complemento,
                    StreetNumber = enderecoEntrega.LogradouroNumr,
                    Zipcode = Mascara.Remover(enderecoEntrega.CEP)
                }
            };

            Item[] itens = new Item[produtos.Count];

            for (var i = 0; i < produtos.Count; i++)
            {
                var item = produtos[i];

                var ItemA = new Item()
                {
                    Id = item.Id.ToString(),
                    Title = item.Nome,
                    Quantity = Mascara.ConverterValorPagarMe(item.QuantidadeProdutoCarrinho),
                    Tangible = true,
                    UnitPrice = Mascara.ConverterValorPagarMe(item.Valor)
                };

                //valorTotal += (item.Valor * item.QuantidadeProdutoCarrinho);
                itens[i] = ItemA;
            }

            //produto adquirido pelo cliente
            transaction.Item = itens;
            
            transaction.Save();

            //usado apenas para fazer automapper
            transaction.Customer.Gender = (cliente.Sexo == "M") ? Gender.Male : Gender.Female;

            //dados do boleto
            return transaction;

           
        }

        //CARTAO CREDITO
        public Transaction GerarPagCartaoCredito(CartaoCredito cartao, Parcelamento parcelamento, EnderecoEntrega enderecoEntrega, ValorPrazoFrete valorFrete, List<ProdutoItem> produtos)
        {
            Cliente cliente = _loginCliente.GetCliente();

            PagarMeService.DefaultApiKey = _configuration.GetValue<String>("Pagamento:PagarMe:ApiKey");
            PagarMeService.DefaultEncryptionKey = _configuration.GetValue<String>("Pagamento:PagarMe:EncryptionKey");

            Card card = new Card
            {
                Number = cartao.NumeroCartao,
                HolderName = cartao.NomeNoCartao,
                ExpirationDate = cartao.VencimentoMM + cartao.VencimentoYY,
                Cvv = cartao.CodigoSeguranca
            };

            card.Save();

            Transaction transaction = new Transaction();

            transaction.PaymentMethod = PaymentMethod.CreditCard;

            //parametro importante para que seu site seja informado para todas as mudancas de status 
            //ocorridas no Pagar.Me
            transaction.PostbackUrl = "http://seusite.com.br/pagamento/postback";

            //transaction.Amount = 2100;
            transaction.Card = new Card
            {
                //Id = "card_cj95mc28g0038cy6ewbwtwwx2"
                Id = card.Id
            };


            transaction.Customer = new Customer
            {
                ExternalId = cliente.Id.ToString(),
                Name = cliente.Nome,
                Type = CustomerType.Individual,
                Country = "br",
                Email = cliente.Email,
                Documents = new[]
              {
                new Document{
                  Type = DocumentType.Cpf,
                  Number = Mascara.Remover(cliente.CPF)
                //},
                //new Document{
                //  Type = DocumentType.Cnpj,
                //  Number = "83134932000154"
                }
              },
                PhoneNumbers = new string[]
            {
                "+55" + Mascara.Remover(cliente.Telefone)
              },               
                Birthday = cliente.Nascimento.ToString("yyyy-MM-dd")
            };

            //endereco da pessoa pagante           

            transaction.Billing = new Billing
            {
                Name = cliente.Nome,
                Address = new Address()
                {
                    Country = "br",
                    State = cliente.UF,
                    City = cliente.Cidade,
                    Neighborhood = cliente.Bairro,
                    Street = cliente.Logradouro + " " + cliente.Complemento,
                    StreetNumber = cliente.LogradouroNumr,
                    Zipcode = Mascara.Remover(cliente.CEP)
                }
            };

            var Today = DateTime.Now;
            int diasPreparoFrete = _configuration.GetValue<int>("Frete:DiasPreparoEnvio");

            //decimal valorTotal = Convert.ToDecimal(valorFrete.Valor);

            //endereco de entrega
            transaction.Shipping = new Shipping
            {
                Name = enderecoEntrega.Nome,
                Fee = Mascara.ConverterValorPagarMe(Convert.ToDecimal(valorFrete.Valor)),
                //pode adicionar mais dias a essa data
                DeliveryDate = Today.AddDays(diasPreparoFrete).AddDays(valorFrete.Prazo).ToString("yyyy-MM-dd"),
                Expedited = false,
                Address = new Address()
                {
                    Country = "br",
                    State = enderecoEntrega.UF,
                    City = enderecoEntrega.Cidade,
                    Neighborhood = enderecoEntrega.Bairro,
                    Street = enderecoEntrega.Logradouro + " " + enderecoEntrega.Complemento,
                    StreetNumber = enderecoEntrega.LogradouroNumr,
                    Zipcode = Mascara.Remover(enderecoEntrega.CEP)
                }
            };

            Item[] itens = new Item[produtos.Count];           

            for (var i = 0; i < produtos.Count; i++)
            {
                var item = produtos[i];

                var ItemA = new Item()
                {
                    Id = item.Id.ToString(),
                    Title = item.Nome,
                    Quantity = Mascara.ConverterValorPagarMe(item.QuantidadeProdutoCarrinho),
                    Tangible = true,
                    UnitPrice = Mascara.ConverterValorPagarMe(item.Valor)
                };
                               
                //valorTotal += (item.Valor * item.QuantidadeProdutoCarrinho);
                itens[i] = ItemA;
            }

            //produto adquirido pelo cliente
            transaction.Item = itens;
            transaction.Amount = Mascara.ConverterValorPagarMe (parcelamento.Valor);
            transaction.Installments = parcelamento.Numero;
                       
            transaction.Save();

            //usado apenas para fazer automapper
            transaction.Customer.Gender = (cliente.Sexo == "M") ? Gender.Male : Gender.Female;


            return transaction;
        }

        public List<Parcelamento> CalcularPagamentoParcelado(decimal valor)
        {
            List<Parcelamento> lista = new List<Parcelamento>();

            //em configuracoes
            int maxParcelas = _configuration.GetValue<int>("Pagamento:PagarMe:MaxParcelas");
            int parcelasPagasVendedor = _configuration.GetValue<int>("Pagamento:PagarMe:ParcelasPagasVendedor");
            decimal juros = _configuration.GetValue<int>("Pagamento:PagarMe:Juros");

            for (int i=1;i<=maxParcelas;i++)
            {
                Parcelamento parcelamento = new Parcelamento();
                parcelamento.Numero = i;
                if (i > parcelasPagasVendedor)
                {
                    //aplicar juros
                    
                    int quantidadeParcelasComJuros = i - parcelasPagasVendedor;
                    decimal valorComJuros = valor * juros / 100;

                    parcelamento.Valor = quantidadeParcelasComJuros * valorComJuros + valor;
                    parcelamento.ValorPorParcela = parcelamento.Valor / parcelamento.Numero;
                    parcelamento.Juros = true;
                }
                else
                {
                    
                    parcelamento.Valor = valor;
                    parcelamento.ValorPorParcela = parcelamento.Valor / parcelamento.Numero;
                    parcelamento.Juros = false;
                }

                lista.Add(parcelamento);

            }

            return lista;


        }


        public Transaction ObterTransacao(string transactionId)
        {
            PagarMeService.DefaultApiKey = _configuration.GetValue<String>("Pagamento:PagarMe:ApiKey");

            Transaction retornoTransacaoPagarMe = PagarMeService.GetDefaultService().Transactions.Find(transactionId);

            return retornoTransacaoPagarMe;
        }

    }
}
