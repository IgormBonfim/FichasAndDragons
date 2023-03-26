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
        PersonagemResponse Adicionar(PersonagemInserirRequest request);
    }
}
