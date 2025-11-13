using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaDePersonagens.Data;
using SistemaDePersonagens.Models;

namespace SistemaDePersonagens.Controllers
{
    public class PersonagemController : Controller
    {
        private readonly AppDbContext _context;

        public PersonagemController(AppDbContext contextConstrutor)
        {
            _context = contextConstrutor;
        }

        //Listar
        public async Task<IActionResult> Index()
        {
            var lista = await _context.TabelaPersonagem.ToListAsync();
            return View(lista);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        // CRIAR
        public async Task<IActionResult> Criar(string nomeConstrutor, int nivelConstrutor, string tipoPersonagemConstrutor)
        {
            Personagem? novoPersonagem = null;
            if (tipoPersonagemConstrutor == "Guerreiro")
            {
                novoPersonagem = new Guerreiro(nomeConstrutor, nivelConstrutor);
            }
            else if (tipoPersonagemConstrutor == "Mago")
            {
                novoPersonagem = new Mago(nomeConstrutor, nivelConstrutor);
            }
            else
            {
                return BadRequest("Tipo de Curso Invalido!!");
            }

            _context.TabelaPersonagem.Add(novoPersonagem);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        //Excluir
        public async Task<IActionResult> Deletar(int id)
        {
            var personagem = await _context.TabelaPersonagem.FindAsync(id);

            if (personagem == null) return NotFound(); // Registro não encontrado

            _context.TabelaPersonagem.Remove(personagem);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}