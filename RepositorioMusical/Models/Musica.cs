// Models/Musica.cs
using System.ComponentModel.DataAnnotations;

namespace RepositorioMusical.Models
{
    public class Musica
    {
        public int Id { get; set; }

        [Required]
        public string Titulo { get; set; }

        public string Genero { get; set; } 

        public int DuracaoSegundos { get; set; }

        public int ArtistaId { get; set; }
        public Artista Artista { get; set; }
    }
}
