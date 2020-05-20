using AutoMapper;
using AutoMapper.Configuration.Conventions;
using LojaVirtual.Libraries.Json.Resolver;
using LojaVirtual.Libraries.Texto;
using LojaVirtual.Models;
using LojaVirtual.Models.Constants;
using LojaVirtual.Models.ProdutoAgregador;
using Newtonsoft.Json;
using PagarMe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.AutoMapper
{
    public class MappingProfile: Profile
    {
        //Define os objetos que voce pode converter
        //Profile deve fazer parte do nome no final
        //Definir a injecao de dependencia no Startup

        public MappingProfile()
        {
            //posibilidade de converter
            //Copiar -> dados do produdo para dentro de produto item
            CreateMap<Produto, ProdutoItem>();
            CreateMap<Cliente, EnderecoEntrega>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(origem => 0))
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(
                    origem => string.Format("Endereço Cliente ({0})", origem.Nome)))
                ;


            CreateMap<Transaction, TransacaoPagarMe>();

            CreateMap<Tuple<TransacaoPagarMe, List<ProdutoItem>>, Pedido>()
                 .ForMember(dest => dest.Id, opt => opt.MapFrom(origem => 0))
                 .ForMember(dest => dest.ClienteId, opt => opt.MapFrom(origem => int.Parse(origem.Item1.Customer.ExternalId)))
                 .ForMember(dest => dest.TransactionId, opt => opt.MapFrom(origem => origem.Item1.Id))
                 .ForMember(dest => dest.FreteEmpresa, opt => opt.MapFrom(origem => "ECT - Correios"))
                 .ForMember(dest => dest.FormaPagamento, opt => opt.MapFrom(origem => (origem.Item1.PaymentMethod == 0) ? MetodoPagamentoConstant.CartaoCredito : MetodoPagamentoConstant.Boleto))
                 .ForMember(dest => dest.DadosTransaction, opt => opt.MapFrom(origem => JsonConvert.SerializeObject(origem.Item1)))
                 .ForMember(dest => dest.DataRegistro, opt => opt.MapFrom(origem => DateTime.Now))
                 .ForMember(dest => dest.ValorTotal, opt => opt.MapFrom(origem => Mascara.ConverterPagarMeIntDecimal(origem.Item1.Amount)))
                 .ForMember(dest => dest.DadosProdutos, opt => opt.MapFrom(origem => JsonConvert.SerializeObject(origem.Item2, new JsonSerializerSettings() { ContractResolver = new ProdutoItemResolver<List<ProdutoItem>>() })))
                 ;


            CreateMap<Tuple<Pedido, TransactionProduto>, PedidoSituacao>()
                 .ForMember(dest => dest.PedidoId, opt => opt.MapFrom(origem => origem.Item1.Id))
                 .ForMember(dest => dest.Data, opt => opt.MapFrom(origem => DateTime.Now))
                 .ForMember(dest => dest.Dados, opt => opt.MapFrom(origem => JsonConvert.SerializeObject(origem.Item2, new JsonSerializerSettings() { ContractResolver = new ProdutoItemResolver<TransactionProduto>() })))
                 ;

            //CreateMap<TransacaoPagarMe, Pedido>()
            //    .ForMember(dest => dest.Id, opt => opt.MapFrom(origem => 0))
            //    .ForMember(dest => dest.ClienteId, opt => opt.MapFrom(origem => int.Parse(origem.Customer.ExternalId)))
            //    .ForMember(dest => dest.TransactionId, opt => opt.MapFrom(origem => origem.Id))
            //    .ForMember(dest => dest.FreteEmpresa, opt => opt.MapFrom(origem => "ECT - Correios"))
            //    .ForMember(dest => dest.FormaPagamento, opt => opt.MapFrom(origem => (origem.PaymentMethod == 0) ? MetodoPagamentoConstant.CartaoCredito : MetodoPagamentoConstant.Boleto))
            //    .ForMember(dest => dest.DadosTransaction, opt => opt.MapFrom(origem => JsonConvert.SerializeObject(origem)))
            //    .ForMember(dest => dest.DataRegistro, opt => opt.MapFrom(origem => DateTime.Now))
            //    .ForMember(dest => dest.ValorTotal, opt => opt.MapFrom(origem => Mascara.ConverterPagarMeIntDecimal(origem.Amount)))
            //    ;

            //CreateMap<List<ProdutoItem>, Pedido>()
            //.ForMember(dest => dest.DadosProdutos, opt => opt.MapFrom(origem => JsonConvert.SerializeObject(origem, new JsonSerializerSettings() { ContractResolver = new ProdutoItemResolver<List<ProdutoItem>>() })))
            //    ;

            //CreateMap<Pedido, PedidoSituacao>()
            //     .ForMember(dest => dest.Id, opt => opt.MapFrom(origem => 0))
            //     .ForMember(dest => dest.PedidoId, opt => opt.MapFrom(origem => origem.Id))
            //     .ForMember(dest => dest.Data, opt => opt.MapFrom(origem => DateTime.Now))
            //    ;

            //CreateMap<TransactionProduto, PedidoSituacao>()
            //    .ForMember(dest => dest.Dados, opt => opt.MapFrom(origem => JsonConvert.SerializeObject(origem, new JsonSerializerSettings() { ContractResolver = new ProdutoItemResolver<List<ProdutoItem>>() })))

            //   ;


        }

    }
    

}


