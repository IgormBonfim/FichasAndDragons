using FichasAndDragons.DataTransfer.Base.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.DataTransfer.Personagens.Requests
{
    public class PersonagemInserirRequest
    {
        public string Nome { get; set; }
        public string Jogador { get; set; }
        public VidaInserirRequest Vida { get; set; }
        public ClasseInserirRequest Classe { get; set; }
        public InformacaoInserirRequest Informacoes { get; set; }
        public PersonalidadeInserirRequest Personalidade { get; set; }
        public StatusInserirRequest Status { get; set; }
        public IEnumerable<ProficienciaInserirRequest> Proficiencias { get; set; } = new List<ProficienciaInserirRequest>();
        public IEnumerable<CaracteristicaInserirRequest> Caracteristicas { get; set; } = new List<CaracteristicaInserirRequest>();
        public IEnumerable<ItemInserirRequest> Equipamentos { get; set; } = new List<ItemInserirRequest>(); 
        public IEnumerable<MagiaInserirRequest> Magias { get; set; } = new List<MagiaInserirRequest>(); 
        public bool Inspirado { get; set; }
    }
}
