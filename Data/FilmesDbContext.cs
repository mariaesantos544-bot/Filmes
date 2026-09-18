using Microsoft.EntityFrameworkCore;
using Filmes.Models;

namespace Filmes.Data
{
    public class FilmesDbContext : DbContext
    {
        public FilmesDbContext(DbContextOptions<FilmesDbContext> options): base(options){}

        public DbSet<Diretor> Diretores { get; set; }

        public DbSet<Filme> Filmes { get; set; }

        public DbSet<Genero> Generos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Filme>()
                .HasOne(f => f.Diretor)
                .WithMany(d => d.Filmes)
                .HasForeignKey(f => f.DiretorId);

            modelBuilder.Entity<Filme>()
                .HasMany(f => f.Generos)
                .WithMany(g => g.Filmes);
        }
    }
}