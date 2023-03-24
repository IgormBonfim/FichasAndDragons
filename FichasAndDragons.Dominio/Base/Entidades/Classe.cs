using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.Dominio.Base.Entidades
{
    public class Classe
    {
        public string Nome { get; protected set; }
        public int Nivel { get; protected set; }
        public int Experiencia { get; protected set; }
        public Dado DadoVida { get; protected set; }

        public Classe() { }

        public Classe(string nome, int nivel, int experiencia, Dado dadoVida)
        {
            SetNome(nome);
            SetNivel(nivel);
            SetExperiencia(experiencia);
            SetDadoVida(dadoVida);
        }

        private void SetNome(string nome)
        {
            Nome = nome;
        }

        private void SetNivel(int nivel)
        {
            Nivel = nivel;
        }

        private void SetExperiencia(int experiencia)
        {
            Experiencia = experiencia;
        }

        public void SetDadoVida(Dado dadoVida)
        {
            DadoVida = dadoVida;
        }
    }
}
