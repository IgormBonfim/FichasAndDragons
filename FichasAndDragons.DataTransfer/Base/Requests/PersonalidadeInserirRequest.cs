using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.DataTransfer.Base.Requests
{
    public class PersonalidadeInserirRequest
    {
        public string TracoPersonalidade { get; set; }
        public string Ideais { get; set; }
        public string Vinculos { get; set; }
        public string Fraquezas { get; set; }
    }
}
