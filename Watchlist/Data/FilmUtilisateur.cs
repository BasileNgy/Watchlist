namespace Watchlist.Data
{
    public class FilmUtilisateur
    {
        public string IdUtilisateur {  get; set; } = string.Empty;
        public string IdFilm { get; set; } = string.Empty;
        public bool Seen {  get; set; }
        public int Rating {  get; set; }

        public virtual Utilisateur User { get; set; }
        public virtual Film Film { get; set; }
    }
}
