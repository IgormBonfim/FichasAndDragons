using FichasAndDragons.Dominio.Base.Entidades.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.Dominio.Base.Entidades
{
    public class Dado
    {
        public TipoDadoEnum TipoDado { get; protected set; }
        public int QuantidadeDados { get; protected set; }

        public Dado() { }

        public Dado(TipoDadoEnum tipoDado, int quantidadeDados)
        {
            SetTipoDado(tipoDado);
            SetQuantidadeDados(quantidadeDados);
        }

        public void SetTipoDado(TipoDadoEnum tipoDado)
        {
            TipoDado = tipoDado;
        }

        public void SetQuantidadeDados(int quantidadeDados)
        {
            QuantidadeDados = quantidadeDados;
        }

    }
}
