using AutoMapper;
using FichasAndDragons.DataTransfer.Base.Requests;
using FichasAndDragons.DataTransfer.Base.Responses;
using FichasAndDragons.Dominio.Base.Entidades;
using FichasAndDragons.Dominio.Base.Servicos.Comandos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.Aplicacao.Base.Profiles
{
    public class InformacoesProfile : Profile
    {
        public InformacoesProfile()
        {
            CreateMap<Informacao, InformacaoResponse>();
            CreateMap<InformacaoInserirRequest, InformacaoInstanciarComando>();
        }
    }
}
