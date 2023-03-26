using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.DataTransfer.Base.Requests
{
    public class ItemInserirRequest
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public IEnumerable<DanoInserirRequest>? Danos { get; set; }
    }
}
