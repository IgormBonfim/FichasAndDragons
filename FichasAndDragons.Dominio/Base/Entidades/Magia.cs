using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.Dominio.Base.Entidades
{
    public class Magia
    {
        public string Nome { get; protected set; }
        public string Descricao { get; protected set; }
        public int Circulo { get; protected set; }
        public string TempoConjuracao { get; protected set; }
        public string Alcance { get; protected set; }
        public string Componentes { get; protected set; }
        public string Duracao { get; protected set; }

        public Magia() { }

        public Magia(string nome, string descricao, int circulo, string tempoConjuracao, string alcance, string componentes, string duracao)
        {
            SetNome(nome);
            SetDescricao(descricao);
            SetCirculo(circulo);
            SetTempoConjuracao(tempoConjuracao);
            SetAlcance(alcance);
            SetComponentes(componentes);
            SetDuracao(duracao);
        }

        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public void SetDescricao(string descricao)
        {
            Descricao = descricao;
        }

        public void SetCirculo(int circulo)
        {
            Circulo = circulo;
        }

        private void SetTempoConjuracao(string tempoConjuracao)
        {
            TempoConjuracao = tempoConjuracao;
        }

        public void SetAlcance(string alcance)
        {
            Alcance = alcance;
        }

        public void SetComponentes(string componentes)
        {
            Componentes = componentes;
        }

        public void SetDuracao(string duracao)
        {
            Duracao = duracao;
        }
    }
}
