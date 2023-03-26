using FichasAndDragons.Dominio.Personagens.Entidades;

namespace FichasAndDragons.Dominio.Base.Entidades
{
    public class Status
    {
        private const int VALOR_BASE = 10;
        public Atributo Forca { get; protected set; }
        public Atributo Destreza { get; protected set; }
        public Atributo Constituicao { get; protected set; }
        public Atributo Inteligencia { get; protected set; }
        public Atributo Sabedoria { get; protected set; }
        public Atributo Carisma { get; protected set; }
        public int BonusProficiencia { get; protected set; } = 0;
        public int PercepcaoPassiva { get; protected set; }
        public int Iniciativa { get; protected set; }

        public Status() { }

        public Status(int bonusProficiencia, Atributo forca, Atributo destreza, Atributo constituicao, Atributo inteligencia, Atributo sabedoria, Atributo carisma)
        {
            SetForca(forca);
            SetDestreza(destreza);
            SetConstituicao(constituicao);
            SetInteligencia(inteligencia);
            SetSabedoria(sabedoria); 
            SetCarisma(carisma);
            SetBonusProficiencia(bonusProficiencia);
            SetPercepcaoPassiva();
            SetIniciativa();
        }

        public void SetBonusProficiencia(int bonusProficiencia)
        {
            BonusProficiencia = bonusProficiencia;
        }

        public void SetForca(Atributo forca)
        {
            Forca = forca;
        }   
        
        public void SetDestreza(Atributo destreza)
        {
            Destreza = destreza;
        }

        public void SetConstituicao(Atributo constituicao)
        {
            Constituicao = constituicao;
        }

        public void SetInteligencia(Atributo inteligencia)
        {
            Inteligencia = inteligencia;
        }

        public void SetSabedoria(Atributo sabedoria)
        {
            Sabedoria = sabedoria;
        }

        public void SetCarisma(Atributo carisma)
        {
            Carisma = carisma;
        }

        private void SetPercepcaoPassiva()
        {
            PercepcaoPassiva = VALOR_BASE + Sabedoria.Modificador;

            if(Sabedoria.Proficiente)
                PercepcaoPassiva+= BonusProficiencia;
        }

        private void SetIniciativa()
        {
            Iniciativa = Destreza.Modificador;

            if (Destreza.Proficiente)
                Iniciativa += BonusProficiencia;
        }
    }
}
