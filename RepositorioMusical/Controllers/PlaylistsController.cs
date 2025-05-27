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
    public class PlaylistsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PlaylistsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Playlist>> Get() =>
            await _context.Playlists.Include(p => p.Musicas).ToListAsync();
    }
}
