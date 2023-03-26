using FichasAndDragons.Dominio.Base.Servicos.Comandos;
using FichasAndDragons.Dominio.Base.Servicos.Interfaces;
using FichasAndDragons.Dominio.Personagens.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.Dominio.Base.Servicos
{
    public class AtributosServico : IAtributosServico
    {
        public Atributo Instanciar(AtributoInstanciarComando instanciarComando)
        {
            return new Atributo(instanciarComando.Valor, instanciarComando.Modificador, instanciarComando.Proficiente);
        }
    }
}