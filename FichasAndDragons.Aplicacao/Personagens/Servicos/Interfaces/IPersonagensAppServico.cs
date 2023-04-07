using FichasAndDragons.DataTransfer.Genericos.Responses;
using FichasAndDragons.DataTransfer.Personagens.Requests;
using FichasAndDragons.DataTransfer.Personagens.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.Aplicacao.Personagens.Servicos.Interfaces
{
    public interface IPersonagensAppServico
    {
        IEnumerable<PersonagemResponse> Listar(PersonagemListarRequest request);
        PersonagemResponse Recuperar(string id);
        PersonagemResponse Adicionar(PersonagemInserirRequest request);
        PersonagemResponse Editar(PersonagemInserirRequest request, string id);
        bool MudarInspiracao(string id);
    }
}
