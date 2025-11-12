using SistemaDePersonagens.Models;
using Microsoft.EntityFrameworkCore;

namespace SistemaDePersonagens.Data
{
    public class AppDbContext : DbContext
    {
        // Recebendo as opcoes de configuracao do banco
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        //Direciona a clase Curso para a TabelaPersonagem no Banco de dados
        public DbSet<Personagem> TabelaPersonagem { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personagem>()
            .HasDiscriminator<string>("Tipo")
            .HasValue<Guerreiro>("Guerreiro")
            .HasValue<Mago>("Mago");
        }
    }
}