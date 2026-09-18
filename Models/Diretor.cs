namespace Filmes.Models
{
    public class Diretor
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public ICollection<Filme> Filmes { get; set; } = new List<Filme>();
    }
}
