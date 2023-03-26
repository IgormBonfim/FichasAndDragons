using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.DataTransfer.Base.Requests
{
    public class DanoInserirRequest
    {
        public DadoInserirRequest Dado { get; set; }
        public string Tipo { get; set; }
    }
}
