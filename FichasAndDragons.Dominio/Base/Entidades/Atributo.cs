namespace FichasAndDragons.Dominio.Personagens.Entidades
{
    public class Atributo
    {
        public int Valor { get; protected set; }
        public int Modificador { get; protected set; }
        public bool Proficiente { get; protected set; }

        public Atributo() { }

        public Atributo(int valor, int modificador, bool proficiente) 
        {
            SetValor(valor);
            SetModificador(modificador);
            SetProficiente(proficiente);
        }
        
        public void SetValor(int valor)
        {
            Valor = valor;
        }

        public void SetModificador(int modificador)
        {
            Modificador = modificador;
        }

        public void SetProficiente(bool proficiente)
        {
            Proficiente = proficiente;
        }
    }
}
