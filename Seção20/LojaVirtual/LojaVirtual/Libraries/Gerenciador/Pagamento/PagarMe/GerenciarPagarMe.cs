
using LojaVirtual.Libraries.Login;
using LojaVirtual.Libraries.Texto;
using LojaVirtual.Models;
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

        public object GerarBoleto(decimal valor)
        {
            try
            {
                PagarMeService.DefaultApiKey = _configuration.GetValue<String>("Pagamento:PagarMe:ApiKey");
                PagarMeService.DefaultEncryptionKey = _configuration.GetValue<String>("Pagamento:PagarMe:EncryptionKey");

                Transaction transaction = new Transaction();

                //Calcular o valor total
                transaction.Amount = Convert.ToInt32(valor);
                //transaction.Card = new Card
                //{
                //    Id = "card_cj95mc28g0038cy6ewbwtwwx2"
                //};
                transaction.PaymentMethod = PaymentMethod.Boleto;

                Cliente cliente = _loginCliente.GetCliente();

                //Dados do usuario logado
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
                          //Remover mascara
                          Number = Mascara.Remover(cliente.CPF)
                        },
                          //  new Document{
                          //    Type = DocumentType.Cnpj,
                          //    Number = "83134932000154"
                          //  }
                          },
                    PhoneNumbers = new string[]
                  {
                        //Remover mascara
                        "+55" + Mascara.Remover(cliente.Telefone)
                  },
                    Birthday = cliente.Nascimento.ToString("yyyy-MM-dd")
                };

                transaction.Save();

                //dados do boleto
                return new { BoletoURL = transaction.BoletoUrl, BarCode = transaction.BoletoBarcode, Expiracao = transaction.BoletoExpirationDate };

            } catch(Exception e)
                {
                return new { Erro = e.Message, CodErro =e.HResult };
            }
        }


        public void GerarPagCartaoCredito(CartaoCredito cartao)
        {
            Cliente cliente = _loginCliente.GetCliente();

            PagarMeService.DefaultApiKey = _configuration.GetValue<String>("Pagamento:PagarMe:ApiKey");
            PagarMeService.DefaultEncryptionKey = _configuration.GetValue<String>("Pagamento:PagarMe:EncryptionKey");

            Card card = new Card();
            card.Number = cartao.NumeroCartao ;
            card.HolderName = cartao.NomeNoCartao;
            card.ExpirationDate =cartao.VencimentoMM + cartao.VencimentoYY;
            card.Cvv = cartao.CodigoSeguranca;

            card.Save();

            Transaction transaction = new Transaction();

            transaction.Amount = 2100;
            transaction.Card = new Card
            {
                //Id = "card_cj95mc28g0038cy6ewbwtwwx2"
                Id = card.Number
            };
                        

            transaction.Customer = new Customer
            {
                ExternalId = card.Cvv,
                Name = card.HolderName,
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

            //endereco de entrega
            transaction.Shipping = new Shipping
            {
                Name = "Rick",
                Fee = 100,
                DeliveryDate = Today.AddDays(4).ToString("yyyy-MM-dd"),
                Expedited = false,
                Address = new Address()
                {
                    Country = "br",
                    State = "sp",
                    City = "Cotia",
                    Neighborhood = "Rio Cotia",
                    Street = "Rua Matrix",
                    StreetNumber = "213",
                    Zipcode = "04250000"
                }
            };

            //produto adquirido pelo cliente
            transaction.Item = new[]
            {
              new Item()
              {
                Id = "1",
                Title = "Little Car",
                Quantity = 1,
                Tangible = true,
                UnitPrice = 1000
              },
              new Item()
              {
                Id = "2",
                Title = "Baby Crib",
                Quantity = 1,
                Tangible = true,
                UnitPrice = 1000
              }
            };

            transaction.Save();
        }

    }
}
