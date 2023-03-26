using AutoMapper;
using FichasAndDragons.DataTransfer.Base.Requests;
using FichasAndDragons.DataTransfer.Base.Responses;
using FichasAndDragons.Dominio.Base.Servicos.Comandos;
using FichasAndDragons.Dominio.Personagens.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.Aplicacao.Base.Profiles
{
    public class AtributosProfile : Profile
    {
        public AtributosProfile()
        {
            CreateMap<Atributo, AtributoResponse>();
            CreateMap<AtributoInserirRequest, AtributoInstanciarComando>();
        }
    }
}
