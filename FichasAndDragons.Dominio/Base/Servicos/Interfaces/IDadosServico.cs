using FichasAndDragons.Dominio.Base.Entidades;
using FichasAndDragons.Dominio.Base.Entidades.Enumeradores;
using FichasAndDragons.Dominio.Base.Servicos.Comandos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.Dominio.Base.Servicos.Interfaces
{
    public interface IDadosServico
    {
        Dado Instanciar(DadoInstanciarComando dadoInstanciarComando);
    }
}
