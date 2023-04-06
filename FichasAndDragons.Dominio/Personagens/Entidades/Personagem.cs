using FichasAndDragons.Comum.Exceptions;
using FichasAndDragons.Comum.Genericos.Entidades;
using FichasAndDragons.Dominio.Base.Entidades;

namespace FichasAndDragons.Dominio.Personagens.Entidades
{
    public class Personagem : Entidade
    {
        public string Nome { get; protected set; }
        public string Jogador { get; protected set; }
        public Vida? Vida { get; protected set; }
        public Classe? Classe { get; protected set; }
        public Informacao? Informacoes { get; protected set; }
        public Personalidade? Personalidade { get; protected set; }
        public Status? Status { get; protected set; }
        public IEnumerable<Proficiencia> Proficiencias { get; protected set; }
        public IEnumerable<Caracteristica> Caracteristicas { get; protected set; }
        public IEnumerable<Item> Equipamentos { get; protected set; }
        public IEnumerable<Magia> Magias { get; protected set; }
        public bool Inspirado { get; protected set; }
        public DateTime DataCriacao { get; protected set; }
        public DateTime? DataEdicao { get; protected set; }

        public Personagem() { }

        public Personagem(
            string nome, 
            string jogador, 
            Vida? vida, 
            Classe? classe, 
            Informacao? informacoes, 
            Personalidade? personalidade, 
            Status? status, 
            IEnumerable<Proficiencia> proficiencias, 
            IEnumerable<Caracteristica> caracteristicas, 
            IEnumerable<Item> equipamentos, 
            IEnumerable<Magia> magias,
            bool inspirado)
        {
            SetNome(nome);
            SetJogador(jogador);
            SetVida(vida);
            SetClasse(classe);
            SetInformacoes(informacoes);
            SetPersonalidade(personalidade);
            SetStatus(status);
            SetProficiencias(proficiencias);
            SetCaracteristicas(caracteristicas);
            SetEquipamentos(equipamentos);
            SetMagias(magias);
            SetInspirado(inspirado);
            SetDataCriacao();
        }

        public void SetNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome) || nome.Length < 2)
                throw new BadRequestException("O campo nome é obrigatório");
            Nome = nome;
        }

        public void SetJogador(string jogador)
        {
            if (string.IsNullOrWhiteSpace(jogador) || jogador.Length < 2)
                throw new BadRequestException("O campo jogador é obrigatório");
            Jogador = jogador;
        }

        public void SetVida(Vida? vida)
        {
            Vida = vida;
        }

        public void SetClasse(Classe? classe)
        {
            Classe = classe;
        }

        public void SetInformacoes(Informacao? informacoes)
        {
            Informacoes = informacoes;
        }

        public void SetPersonalidade(Personalidade? personalidade)
        {
            Personalidade = personalidade;
        }

        public void SetStatus(Status? status)
        {
            Status = status;
        }

        public void SetProficiencias(IEnumerable<Proficiencia> proficiencias)
        {
            Proficiencias = proficiencias;
        }

        public void SetCaracteristicas(IEnumerable<Caracteristica> caracteristicas)
        {
            Caracteristicas = caracteristicas;
        }

        public void SetEquipamentos(IEnumerable<Item> equipamentos)
        {
            Equipamentos = equipamentos;
        }

        public void SetMagias(IEnumerable<Magia> magias)
        {
            Magias = magias;
        }

        public void SetInspirado(bool inspirado)
        {
            Inspirado = inspirado;
        }

        private void SetDataCriacao()
        {
            DataCriacao = DateTime.Now;
        }       
        public void SetDataEdicao()
        {
            DataEdicao = DateTime.Now;
        }
    }
}
