using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.DataTransfer.Base.Responses
{
    public class MagiaResponse
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Circulo { get; set; }
        public string TempoConjuracao { get; set; }
        public string Alcance { get; set; }
        public string Componentes { get; set; }
        public string Duracao { get; set; }
        public IEnumerable<DanoResponse>? Danos { get; set; }
    }
}
