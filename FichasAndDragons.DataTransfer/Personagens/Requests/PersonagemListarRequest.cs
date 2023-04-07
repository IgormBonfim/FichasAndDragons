using FichasAndDragons.DataTransfer.Genericos.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.DataTransfer.Personagens.Requests
{
    public class PersonagemListarRequest : PaginacaoRequest
    {
        public string? Id { get; set; }
        public string? Nome { get; set; }
        public string? Jogador { get; set; }
        public DateTime? DataInicioCriacao { get; set; }
        public DateTime? DataFimCriacao { get; set; }

        public PersonagemListarRequest() : base(campoOrdenacao: "Codigo", tipoOrdenacao: "ASC")
        {

        }
    }
}
