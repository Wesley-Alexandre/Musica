using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepositorioMusical.Data;
using RepositorioMusical.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositorioMusical.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MusicasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MusicasController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Musica>> Get() =>
            await _context.Musicas.Include(m => m.Artista).ToListAsync();
    }
}
