using FichasAndDragons.Dominio.Base.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.Dominio.Base.Servicos.Comandos
{
    public class MagiaInstanciarComando
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Circulo { get; set; }
        public string TempoConjuracao { get; set; }
        public string Alcance { get; set; }
        public string Componentes { get; set; }
        public string Duracao { get; set; }
        public IEnumerable<DanoInstanciarComando> Danos { get; set; }
    }
}
