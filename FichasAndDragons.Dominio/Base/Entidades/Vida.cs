namespace FichasAndDragons.Dominio.Base.Entidades
{
    public class Vida
    {
        public int PontosVidaMaximo { get; protected set; }
        public int PontosVida { get; protected set; }
        public int PontosVidaTemporario { get; protected set; }
        public int PontosVidaAtual { get; protected set; }

        public Vida() { }

        public Vida(int pontosVidaMaximo, int pontosVida, int pontosVidaTemporario)
        {
            SetPontosVidaMaximo(pontosVidaMaximo);
            SetPontosVida(pontosVida);
            SetPontosVidaTemporario(pontosVidaTemporario);
            SetPontosVidaAtual();
        }

        public void SetPontosVidaMaximo(int pontosVidaMaximo)
        {
            PontosVidaMaximo = pontosVidaMaximo;
        }

        public void SetPontosVida(int pontosVida)
        {
            PontosVida = pontosVida;
        }

        public void SetPontosVidaTemporario(int pontosVidaTemporario)
        {
            PontosVidaTemporario = pontosVidaTemporario;
        }

        private void SetPontosVidaAtual()
        {
            PontosVidaAtual = PontosVida + PontosVidaTemporario;
        }
    }
}
