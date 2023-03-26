using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.DataTransfer.Base.Responses
{
    public class StatusResponse
    {
        public AtributoResponse Forca { get; set; }
        public AtributoResponse Destreza { get; set; }
        public AtributoResponse Constituicao { get; set; }
        public AtributoResponse Inteligencia { get; set; }
        public AtributoResponse Sabedoria { get; set; }
        public AtributoResponse Carisma { get; set; }
        public int BonusProficiencia { get; set; }
        public int PercepcaoPassiva { get; set; }
        public int Iniciativa { get; set; }
    }
}
