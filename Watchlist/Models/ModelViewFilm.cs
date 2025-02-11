using System.ComponentModel.DataAnnotations;

namespace Watchlist.Models
{

    public class ModelViewFilm
    {
        [Key]
        public string IdFilm { get; set; }
        public string Title { get; set; } = string.Empty;
        public int Year { get; set; }
        public bool IsInList { get; set; }
        public bool Seen { get; set; }
        public int? Rating { get; set; }
    }
}
