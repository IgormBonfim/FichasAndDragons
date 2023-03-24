using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.DataTransfer.Genericos.Responses
{
    public class PaginacaoResponse<T> where T : class
    {
        public int Total { get; set; }
        public int Pagina { get; set; }
        public int Quantidade { get; set; }
        public IEnumerable<T> Registros { get; set; }
    }
}
