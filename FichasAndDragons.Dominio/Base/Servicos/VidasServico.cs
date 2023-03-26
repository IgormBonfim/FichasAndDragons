using FichasAndDragons.Dominio.Base.Entidades;
using FichasAndDragons.Dominio.Base.Servicos.Comandos;
using FichasAndDragons.Dominio.Base.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.Dominio.Base.Servicos
{
    public class VidasServico : IVidasServico
    {
        public Vida Instanciar(VidaInstanciarComando vidaInstanciarComando)
        {
            return new Vida(vidaInstanciarComando.PontosVidaMaximo, vidaInstanciarComando.PontosVida, vidaInstanciarComando.PontosVidaTemporario);
        }
    }
}
