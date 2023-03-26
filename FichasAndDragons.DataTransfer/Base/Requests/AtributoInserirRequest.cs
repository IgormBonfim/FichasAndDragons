using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.DataTransfer.Base.Requests
{
    public class AtributoInserirRequest
    {
        public int Valor { get; set; }
        public int Modificador { get; set; }
        public bool Proficiente { get; set; }
    }
}
