using FichasAndDragons.Dominio.Base.Entidades;
using FichasAndDragons.Dominio.Base.Servicos.Comandos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.Dominio.Personagens.Servicos.Comandos
{
    public class PersonagensInstanciarComando
    {
        public string Nome { get; set; }
        public string Jogador { get; set; }
        public VidaInstanciarComando? Vida { get; set; }
        public ClasseInstanciarComando? Classe { get; set; }
        public InformacaoInstanciarComando? Informacoes { get; set; }
        public PersonalidadeInstanciarComando? Personalidade { get; set; }
        public StatusInstanciarComando? Status { get; set; }
        public IEnumerable<ProficienciaInstanciarComando> Proficiencias { get; set; } = new List<ProficienciaInstanciarComando>();
        public IEnumerable<CaracteristicaInstanciarComando> Caracteristicas { get; set; } = new List<CaracteristicaInstanciarComando>();
        public IEnumerable<ItemInstanciarComando> Equipamentos { get; set; } = new List<ItemInstanciarComando>();
        public IEnumerable<MagiaInstanciarComando> Magias { get; set; } = new List<MagiaInstanciarComando>();
        public bool Inspirado { get; set; }
    }
}
