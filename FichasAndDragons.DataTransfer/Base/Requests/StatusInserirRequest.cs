using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.DataTransfer.Base.Requests
{
    public class StatusInserirRequest
    {
        public AtributoInserirRequest Forca { get; set; }
        public AtributoInserirRequest Destreza { get; set; }
        public AtributoInserirRequest Constituicao { get; set; }
        public AtributoInserirRequest Inteligencia { get; set; }
        public AtributoInserirRequest Sabedoria { get; set; }
        public AtributoInserirRequest Carisma { get; set; }
        public int BonusProficiencia { get; set; }
    }
}
