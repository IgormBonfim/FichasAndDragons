using FichasAndDragons.Dominio.Base.Entidades;
using FichasAndDragons.Dominio.Base.Servicos.Interfaces;
using FichasAndDragons.Dominio.Personagens.Entidades;
using FichasAndDragons.Dominio.Personagens.Repositorios;
using FichasAndDragons.Dominio.Personagens.Servicos.Comandos;
using FichasAndDragons.Dominio.Personagens.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.Dominio.Personagens.Servicos
{
    public class PersonagensServico : IPersonagensServico
    {
        private readonly IPersonagensRepositorio personagensRepositorio;
        private readonly IVidasServico vidasServico;
        private readonly IClassesServico classesServico;
        private readonly IInformacoesServico informacoesServico;
        private readonly IPersonalidadesServico personalidadesServico;
        private readonly IStatusServico statusServico;
        private readonly IProficienciasServico proficienciasServico;
        private readonly ICaracteristicasServico caracteristicasServico;
        private readonly IItensServico itensServico;
        private readonly IMagiasServico magiasServico;

        public PersonagensServico(
            IPersonagensRepositorio personagensRepositorio,
            IVidasServico vidasServico, 
            IClassesServico classesServico, 
            IInformacoesServico informacoesServico, 
            IPersonalidadesServico personalidadesServico, 
            IStatusServico statusServico, 
            IProficienciasServico proficienciasServico,
            ICaracteristicasServico caracteristicasServico,
            IItensServico itensServico,
            IMagiasServico magiasServico)
        {
            this.personagensRepositorio = personagensRepositorio;
            this.vidasServico = vidasServico;
            this.classesServico = classesServico;
            this.informacoesServico = informacoesServico;
            this.personalidadesServico = personalidadesServico;
            this.statusServico = statusServico;
            this.proficienciasServico = proficienciasServico;
            this.caracteristicasServico = caracteristicasServico;
            this.itensServico = itensServico;
            this.magiasServico = magiasServico;
        }

        public Personagem Inserir(Personagem personagem)
        {
            return personagensRepositorio.Adicionar(personagem);
        }

        public Personagem Instanciar(PersonagensInstanciarComando instanciarComando)
        {
            Vida vida = vidasServico.Instanciar(instanciarComando.Vida);
            Classe classe = classesServico.Instanciar(instanciarComando.Classe);
            Informacao informacoes = informacoesServico.Instanciar(instanciarComando.Informacoes);
            Personalidade personalidade = personalidadesServico.Instanciar(instanciarComando.Personalidade);
            Status status = statusServico.Instanciar(instanciarComando.Status);
            IList<Proficiencia> proficiencias = new List<Proficiencia>();  
            IList<Caracteristica> caracteristicas = new List<Caracteristica>();
            IList<Item> equipamentos = new List<Item>();
            IList<Magia> magias = new List<Magia>();

            foreach (var proficienciaComando in instanciarComando.Proficiencias)
            {
                Proficiencia proficiencia = proficienciasServico.Instanciar(proficienciaComando);
                proficiencias.Add(proficiencia);
            }

            foreach (var caracteriscaComando in instanciarComando.Caracteristicas)
            {
                Caracteristica caracteristica = caracteristicasServico.Instanciar(caracteriscaComando);
                caracteristicas.Add(caracteristica);
            }

            foreach (var itemComando in instanciarComando.Equipamentos)
            {
                Item item = itensServico.Instanciar(itemComando);
                equipamentos.Add(item);
            }

            foreach (var magiaComando in instanciarComando.Magias)
            {
                Magia magia = magiasServico.Instanciar(magiaComando);
                magias.Add(magia);
            }

            return new Personagem(
                instanciarComando.Nome,
                instanciarComando.Jogador,
                vida,
                classe,
                informacoes,
                personalidade,
                status,
                proficiencias,
                caracteristicas,
                equipamentos,
                magias,
                instanciarComando.Inspirado
                );
        }
    }
}