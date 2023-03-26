using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.DataTransfer.Base.Requests
{
    public class ClasseInserirRequest
    {
        public string Nome { get; set; }
        public int Nivel { get; set; }
        public int Experiencia { get; set; }
        public DadoInserirRequest DadoVida { get; set; }
    }
}
