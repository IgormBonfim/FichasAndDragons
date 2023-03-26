using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.DataTransfer.Base.Requests
{
    public class MagiaInserirRequest
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Circulo { get; set; }
        public string TempoConjuracao { get; set; }
        public string Alcance { get; set; }
        public string Componentes { get; set; }
        public string Duracao { get; set; }
        public IEnumerable<DanoInserirRequest>? Danos { get; set; }
    }
}
