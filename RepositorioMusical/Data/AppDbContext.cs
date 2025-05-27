using Microsoft.EntityFrameworkCore;
using RepositorioMusical.Models;

namespace RepositorioMusical.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Artista> Artistas { get; set; }
        public DbSet<Musica> Musicas { get; set; }
         public DbSet<Playlist> Playlists { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
 
        }
    }

}
