namespace SistemaDePersonagens.Models
{
    public abstract class Personagem
    {
         public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;

        public int Nivel { get; set; }
        
        public Personagem() { }
        public Personagem(String nomeConstrutor, int nivelConstrutor)
        {
            Nome = nomeConstrutor;
            Nivel = nivelConstrutor;
        }

        public abstract double CalcularPoder();
    }
}