using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.Dominio.Base.Entidades
{
    public class Dano
    {
        public Dado Dado { get; protected set; }
        public string Tipo { get; protected set; }

        public Dano() { }

        public Dano(Dado dado, string tipo)
        {
            SetDado(dado);
            SetTipo(tipo);
        }

        public void SetTipo(string tipo)
        {
            Tipo = tipo;
        }

        public void SetDado(Dado dado)
        {
            Dado = dado;
        }
    }
}
