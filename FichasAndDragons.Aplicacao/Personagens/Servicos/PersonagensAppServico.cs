using AutoMapper;
using FichasAndDragons.Aplicacao.Personagens.Servicos.Interfaces;
using FichasAndDragons.DataTransfer.Personagens.Requests;
using FichasAndDragons.DataTransfer.Personagens.Responses;
using FichasAndDragons.Dominio.Personagens.Entidades;
using FichasAndDragons.Dominio.Personagens.Servicos.Comandos;
using FichasAndDragons.Dominio.Personagens.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.Aplicacao.Personagens.Servicos
{
    public class PersonagensAppServico : IPersonagensAppServico
    {
        private readonly IPersonagensServico personagensServico;
        private readonly IMapper mapper;

        public PersonagensAppServico(IPersonagensServico personagensServico, IMapper mapper)
        {
            this.personagensServico = personagensServico;
            this.mapper = mapper;
        }
        public PersonagemResponse Adicionar(PersonagemInserirRequest request)
        {
            PersonagensInstanciarComando personagensInstanciarComando = mapper.Map<PersonagensInstanciarComando>(request);

            Personagem personagem = personagensServico.Instanciar(personagensInstanciarComando);

            personagem = personagensServico.Inserir(personagem);

            return mapper.Map<PersonagemResponse>(personagem);
        }
        public PersonagemResponse Recuperar(string id)
        {
            Personagem personagem = personagensServico.Validar(id);

            return mapper.Map<PersonagemResponse>(personagem);
        }

    }
}
