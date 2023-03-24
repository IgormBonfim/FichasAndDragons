using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.Dominio.Base.Entidades
{
    public class Informacoes
    {
        public int Idade { get; protected set; }
        public decimal Altura { get; protected set; }
        public decimal Peso { get; protected set; }
        public string CorOlhos { get; protected set; }
        public string CorPele { get; protected set; }
        public string CorCabelo { get; protected set; }
        public string Descricao { get; protected set; }
        public string Historia { get; protected set; }
        public string Antecedente { get; protected set; }
        public string Alinhamento { get; protected set; }

        public Informacoes() { }

        public Informacoes(int idade, decimal altura, decimal peso, string corOlhos, string corPele, string corCabelo, string descricao, string historia, string antecedente, string alinhamento)
        {
            SetIdade(idade);
            SetAltura(altura);
            SetPeso(peso);
            SetCorOlhos(corOlhos);
            SetCorPele(corPele);
            SetCorCabelo(corCabelo);
            SetDescricao(descricao);
            SetHistoria(historia);
            SetAntecedente(antecedente);
            SetAlinhamento(alinhamento);
        }

        public void SetIdade(int idade)
        {
            Idade = idade;
        }

        public void SetAltura(decimal altura)
        {
            Altura = altura; 
        }

        public void SetPeso(decimal peso)
        {
            Peso = peso;
        }

        public void SetCorOlhos(string corOlhos)
        {
            CorOlhos = corOlhos;
        }

        public void SetCorPele(string corPele)
        {
            CorPele = corPele;
        }

        public void SetCorCabelo(string corCabelo)
        {
            CorCabelo = corCabelo;
        }

        public void SetDescricao(string descricao)
        {
            Descricao = descricao;
        }

        public void SetHistoria(string historia)
        {
            Historia = historia;
        }

        public void SetAntecedente(string antecedente)
        {
            Antecedente = antecedente;
        }

        public void SetAlinhamento(string alinhamento)
        {
            Alinhamento = alinhamento;
        }
    }
}
