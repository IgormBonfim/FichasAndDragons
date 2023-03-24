using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.Dominio.Base.Entidades
{
    public class Personalidade
    {
        public string TracoPersonalidade { get; protected set; }
        public string Ideais { get; protected set; }
        public string Vinculos { get; protected set; }
        public string Fraquezas { get; protected set; }

        public Personalidade() { }

        public Personalidade(string tracoPersonalidade, string ideais, string vinculos, string fraquezas)
        {
            SetTracoPersonalidade(tracoPersonalidade);
            SetIdeais(ideais);
            SetVinculos(vinculos);
            SetFraquezas(fraquezas);
        }

        public void SetTracoPersonalidade(string tracoPersonalidade)
        {
            TracoPersonalidade = tracoPersonalidade;
        }

        public void SetIdeais(string ideais)
        {
            Ideais = ideais;
        }

        public void SetVinculos(string vinculos)
        {
            Vinculos = vinculos;
        }

        public void SetFraquezas(string fraquezas)
        {
            Fraquezas = fraquezas;
        }
    }
}
