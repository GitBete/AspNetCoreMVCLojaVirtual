using AutoMapper;
using LojaVirtual.Models;
using LojaVirtual.Models.ProdutoAgregador;
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
                    origem => string.Format("Endereço Cliente ({0})", origem.Nome)
                ));
        }
    }
}
