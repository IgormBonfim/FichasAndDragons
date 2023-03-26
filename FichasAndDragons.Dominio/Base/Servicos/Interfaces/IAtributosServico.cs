using FichasAndDragons.Dominio.Base.Servicos.Comandos;
using FichasAndDragons.Dominio.Personagens.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.Dominio.Base.Servicos.Interfaces
{
    public interface IAtributosServico
    {
        Atributo Instanciar(AtributoInstanciarComando instanciarComando);
    }
}
