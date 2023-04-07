using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.DataTransfer.Genericos.Requests
{
    public class PaginacaoRequest
    {
        public int Pagina { get; set; }
        public int Quantidade { get; set; } 
        public string CampoOrdenacao { get; set; }
        public string TipoOrdenacao { get; set;}

        public PaginacaoRequest(string campoOrdenacao, string tipoOrdenacao)
        {
            CampoOrdenacao = campoOrdenacao;
            TipoOrdenacao = tipoOrdenacao;
        }
    }
}
