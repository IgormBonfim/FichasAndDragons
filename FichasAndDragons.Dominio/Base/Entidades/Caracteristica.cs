using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.Dominio.Base.Entidades
{
    public class Caracteristica
    {
        public string Nome { get; protected set; }
        public string Descricao { get; protected set; }

        public Caracteristica() { }

        public Caracteristica(string nome, string descricao)
        {
            SetNome(nome);
            SetDescricao(descricao);
        }

        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public void SetDescricao(string descricao)
        {
            Descricao = descricao;
        }
    }
}
