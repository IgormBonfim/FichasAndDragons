using FichasAndDragons.Comum.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.Dominio.Base.Entidades
{
    public class Item
    {
        public string Nome { get; protected set; }
        public string Descricao { get; protected set; }
        public IEnumerable<Dano>? Danos { get; protected set; }
        public Item() { }

        public Item(string nome, string descricao, IEnumerable<Dano>? danos)
        {
            SetNome(nome); 
            SetDescricao(descricao);
            SetDano(danos);
        }

        public void SetNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new BadRequestException("O Nome do item é obrigatório");
            Nome = nome;
        }

        public void SetDescricao(string descricao)
        {
            if (string.IsNullOrWhiteSpace(descricao))
                throw new BadRequestException("A Descrição do item é obrigatória");
            Descricao = descricao;
        }

        public void SetDano(IEnumerable<Dano>? danos)
        {
            Danos = danos;
        }
    }
}
