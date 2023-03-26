using FichasAndDragons.Dominio.Base.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.Dominio.Base.Servicos.Comandos
{
    public class ClasseInstanciarComando
    {
        public string Nome { get; set; }
        public int Nivel { get; set; }
        public int Experiencia { get; set; }
        public DadoInstanciarComando DadoVida { get; set; }
    }
}
