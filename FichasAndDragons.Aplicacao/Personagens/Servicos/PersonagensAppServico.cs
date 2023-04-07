using AutoMapper;
using FichasAndDragons.Aplicacao.Personagens.Servicos.Interfaces;
using FichasAndDragons.Comum.Genericos.Entidades;
using FichasAndDragons.Comum.Utils;
using FichasAndDragons.DataTransfer.Genericos.Responses;
using FichasAndDragons.DataTransfer.Personagens.Requests;
using FichasAndDragons.DataTransfer.Personagens.Responses;
using FichasAndDragons.Dominio.Personagens.Entidades;
using FichasAndDragons.Dominio.Personagens.Repositorios;
using FichasAndDragons.Dominio.Personagens.Servicos.Comandos;
using FichasAndDragons.Dominio.Personagens.Servicos.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.Aplicacao.Personagens.Servicos
{
    public class PersonagensAppServico : IPersonagensAppServico
    {
        private readonly IPersonagensServico personagensServico;
        private readonly IPersonagensRepositorio personagensRepositorio;
        private readonly IMapper mapper;

        public PersonagensAppServico(IPersonagensServico personagensServico, IPersonagensRepositorio personagensRepositorio, IMapper mapper)
        {
            this.personagensServico = personagensServico;
            this.personagensRepositorio = personagensRepositorio;
            this.mapper = mapper;
        }
        public IEnumerable<PersonagemResponse> Listar(PersonagemListarRequest request)
        {
            //Expression<Func<Personagem, bool>> filtro = x => true == true;

            //if (request.Nome.IsNotNull())
            //    filtro = p => p.Nome == request.Nome;

            //if (request.Jogador.IsNotNull())
            //    filtro = filtro.And(p => p.Jogador == request.Jogador);

            IEnumerable<Personagem> personagems = personagensRepositorio.Listar();

            return mapper.Map<IEnumerable<PersonagemResponse>>(personagems);
        }
        public PersonagemResponse Recuperar(string id)
        {
            Personagem personagem = personagensServico.Validar(id);

            return mapper.Map<PersonagemResponse>(personagem);
        }
        public PersonagemResponse Adicionar(PersonagemInserirRequest request)
        {
            PersonagensInstanciarComando personagensInstanciarComando = mapper.Map<PersonagensInstanciarComando>(request);

            Personagem personagem = personagensServico.Instanciar(personagensInstanciarComando);

            personagem = personagensServico.Inserir(personagem);

            return mapper.Map<PersonagemResponse>(personagem);
        }

        public PersonagemResponse Editar(PersonagemInserirRequest request, string id)
        {
            PersonagensInstanciarComando instanciarComando = mapper.Map<PersonagensInstanciarComando>(request);

            Personagem personagem = personagensServico.Instanciar(instanciarComando);

            personagem = personagensServico.Editar(personagem, id);

            return mapper.Map<PersonagemResponse>(personagem);
        }

        public bool MudarInspiracao(string id)
        {
            return personagensServico.MudarInspiracao(id);
        }
    }
}
