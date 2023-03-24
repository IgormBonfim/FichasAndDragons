using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.Dominio.Base.Entidades
{
    public class Proficiencia
    {
        public string Nome { get; protected set; }
        public string Descricao { get; protected set; }

        public Proficiencia() { }

        public Proficiencia(string nome, string descricao)
        {
            SetNome(nome);
            SetDescricao(descricao);
        }

        private void SetNome(string nome)
        {
            Nome = nome;
        }

        private void SetDescricao(string descricao)
        {
            Descricao  = descricao;
        }
    }
}
