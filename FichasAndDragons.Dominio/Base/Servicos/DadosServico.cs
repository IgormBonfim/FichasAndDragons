using FichasAndDragons.Dominio.Base.Entidades;
using FichasAndDragons.Dominio.Base.Entidades.Enumeradores;
using FichasAndDragons.Dominio.Base.Servicos.Comandos;
using FichasAndDragons.Dominio.Base.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.Dominio.Base.Servicos
{
    public class DadosServico : IDadosServico
    {
        public Dado Instanciar(DadoInstanciarComando dadoInstanciarComando)
        {
            return new Dado(dadoInstanciarComando.TipoDado, dadoInstanciarComando.QuantidadeDados);
        }
    }
}
