using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.Dominio.Base.Servicos.Comandos
{
    public class InformacaoInstanciarComando
    {
        public int Idade { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public string CorOlhos { get; set; }
        public string CorPele { get; set; }
        public string CorCabelo { get; set; }
        public string Descricao { get; set; }
        public string Historia { get; set; }
        public string Antecedente { get; set; }
        public string Alinhamento { get; set; }
    }
}
