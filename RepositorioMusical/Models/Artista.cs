// Models/Artista.cs
using System.Collections.Generic;

namespace RepositorioMusical.Models
{
    public class Artista
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Genero { get; set; }
        public string Nacionalidade { get; set; }

        public List<Musica> Musicas { get; set; } = new();
    }
}
