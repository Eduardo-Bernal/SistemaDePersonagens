namespace SistemaDePersonagens.Models
{
    public class Mago : Personagem
    {
          //Metodo de Sobrecarda 
        public Mago() { }

        public Mago(String nomeConstrutor, int nivelConstrutor) : base(nomeConstrutor, nivelConstrutor)
        {

        }
        // Metodo de sobrescrita

        public override double CalcularPoder()
        {
            return Nivel * 8 + 20;
        }
    }
}