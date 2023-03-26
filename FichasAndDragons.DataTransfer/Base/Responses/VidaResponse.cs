using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.DataTransfer.Base.Responses
{
    public class VidaResponse
    {
        public int PontosVidaMaximo { get; set; }
        public int PontosVida { get; set; }
        public int PontosVidaTemporario { get; set; }
        public int PontosVidaAtual { get; set; }
    }
}
