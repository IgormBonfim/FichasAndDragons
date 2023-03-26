using AutoMapper;
using FichasAndDragons.DataTransfer.Personagens.Requests;
using FichasAndDragons.DataTransfer.Personagens.Responses;
using FichasAndDragons.Dominio.Personagens.Entidades;
using FichasAndDragons.Dominio.Personagens.Servicos.Comandos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.Aplicacao.Personagens.Profiles
{
    public class PersonagensProfile : Profile
    {
        public PersonagensProfile()
        {
            CreateMap<Personagem, PersonagemResponse>();
            CreateMap<PersonagemInserirRequest, PersonagensInstanciarComando>();
        }
    }
}
