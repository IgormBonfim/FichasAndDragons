using FichasAndDragons.Dominio.Base.Entidades.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.Dominio.Base.Servicos.Comandos
{
    public class DadoInstanciarComando
    {
        public TipoDadoEnum TipoDado { get; set; }
        public int QuantidadeDados { get; set; }
    }
}
