using AutoMapper;
using FichasAndDragons.DataTransfer.Base.Requests;
using FichasAndDragons.DataTransfer.Base.Responses;
using FichasAndDragons.Dominio.Base.Entidades;
using FichasAndDragons.Dominio.Base.Entidades.Enumeradores;
using FichasAndDragons.Dominio.Base.Servicos.Comandos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.Aplicacao.Base.Profiles
{
    public class DadosProfile : Profile
    {
        public DadosProfile()
        {
            CreateMap<DadoInserirRequest, DadoInstanciarComando>();
            CreateMap<Dado, DadoResponse>()
                .ForMember(dest => dest.TipoDado, 
                    opt => opt.MapFrom(source => Enum.GetName(typeof(TipoDadoEnum), source.TipoDado)));
        }
    }
}
