using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepositorioMusical.Data;
using RepositorioMusical.Models;
using System.Threading.Tasks;

namespace RepositorioMusical.Controllers
{
    public class ArtistasController : Controller
    {
        private readonly AppDbContext _context;

        public ArtistasController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var artistas = await _context.Artistas.Include(a => a.Musicas).ToListAsync();
            return View(artistas);
        }
    }
}
