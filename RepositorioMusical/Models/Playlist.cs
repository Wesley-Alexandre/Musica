using System.Collections.Generic;

namespace RepositorioMusical.Models
{
    public class Playlist
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Musica> Musicas { get; set; }
    }
}
