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
        public async Task<IActionResult> Criar(string nomeConstrutor, int nivelConstrutor, string tipoPersonagemConstrutor)
        {
            Personagem? novoPersonagem = null;
            if (tipoPersonagemConstrutor == "Guerreiro")
            {
                
            }
        }
    }
}