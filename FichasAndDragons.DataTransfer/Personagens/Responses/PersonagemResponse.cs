using FichasAndDragons.DataTransfer.Base.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.DataTransfer.Personagens.Responses
{
    public class PersonagemResponse
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Jogador { get; set; }
        public VidaResponse Vida { get; set; }
        public ClasseResponse Classe { get; set; }
        public InformacaoResponse Informacoes { get; set; }
        public PersonalidadeResponse Personalidade { get; set; }
        public StatusResponse Status { get; set; }
        public IEnumerable<ProficienciaResponse>? Proficiencias { get; set; }
        public IEnumerable<CaracteristicaResponse>? Caracteristicas { get; set; }
        public IEnumerable<ItemResponse>? Equipamentos { get; set; }
        public IEnumerable<MagiaResponse>? Magias { get; set; }
        public bool Inspirado { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataEdicao { get;}
    }
}
