using FichasAndDragons.Dominio.Base.Entidades;
using FichasAndDragons.Dominio.Base.Servicos.Comandos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.Dominio.Base.Servicos.Interfaces
{
    public interface IItensServico
    {
        Item Instanciar(ItemInstanciarComando itemInstanciarComando);
    }
}
