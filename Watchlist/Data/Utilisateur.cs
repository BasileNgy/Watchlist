namespace Watchlist.Data
{

    public class Utilisateur : Microsoft.AspNetCore.Identity.IdentityUser
    {
        public string Name { get; set; } = string.Empty;
        public virtual ICollection<FilmUtilisateur> ListeFilms { get; set; }

        public Utilisateur() : base()
        {
            ListeFilms = new HashSet<FilmUtilisateur>();
        }
    }
}
