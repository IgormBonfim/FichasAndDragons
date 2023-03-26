using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.DataTransfer.Base.Requests
{
    public class VidaInserirRequest
    {
        public int PontosVidaMaximo { get; set; }
        public int PontosVida { get; set; }
        public int PontosVidaTemporario { get; set; }
    }
}
