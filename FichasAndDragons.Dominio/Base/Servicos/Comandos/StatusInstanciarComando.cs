using FichasAndDragons.Dominio.Personagens.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.Dominio.Base.Servicos.Comandos
{
    public class StatusInstanciarComando
    {
        public AtributoInstanciarComando Forca { get; set; }
        public AtributoInstanciarComando Destreza { get; set; }
        public AtributoInstanciarComando Constituicao { get; set; }
        public AtributoInstanciarComando Inteligencia { get; set; }
        public AtributoInstanciarComando Sabedoria { get; set; }
        public AtributoInstanciarComando Carisma { get; set; }
        public int BonusProficiencia { get; set; }
    }
}
