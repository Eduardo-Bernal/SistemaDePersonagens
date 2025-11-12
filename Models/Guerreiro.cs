namespace SistemaDePersonagens.Models
{
    public class Guerreiro : Personagem
    {
          //Metodo de Sobrecarda 
        public Guerreiro() { }

        public Guerreiro(String nomeConstrutor, int nivelConstrutor) : base(nomeConstrutor, nivelConstrutor)
        {

        }
        // Metodo de sobrescrita

        public override double CalcularPoder()
        {
            return Nivel * 10;
        }
    }
}