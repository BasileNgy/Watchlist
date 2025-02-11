using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Watchlist.Models;

namespace Watchlist.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<FilmUtilisateur> FilmUtilisateurs {get; set;}


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<FilmUtilisateur>().HasKey(t => new { t.IdUtilisateur, t.IdFilm });
        }
        public DbSet<Watchlist.Models.ModelViewFilm> ModelViewFilm { get; set; } = default!;
    }
}
