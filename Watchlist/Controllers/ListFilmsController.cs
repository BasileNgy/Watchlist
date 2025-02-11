using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Watchlist.Data;
using Watchlist.Models;

namespace Watchlist.Controllers
{
    public class ListFilmsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Utilisateur> _userManager;
        
        public ListFilmsController(ApplicationDbContext context, UserManager<Utilisateur> userManager) 
        {
            _context = context;
            _userManager = userManager;
        }

        private Task<Utilisateur> GetCurrentUserAsync() =>
            _userManager.GetUserAsync(HttpContext.User);

        public async Task<string> GetCurrentIdUser()
        {
            Utilisateur user = await GetCurrentUserAsync();
            return user.Id;
        }

        public async Task<IActionResult> Index()
        {
            //on récupère l'id de l'user courant
            string id = await GetCurrentIdUser();

            var filmUser = _context.FilmUtilisateurs.Where(x => x.IdUtilisateur == id);
            
            var modele = filmUser.Select(x => new ModelViewFilm
            {
                IdFilm = x.IdFilm,
                Title = x.Film.Title,
                Year = x.Film.Year,
                Seen = x.Seen,
                IsInList = true,
                Rating = x.Rating

            }).ToList();

            return View(modele);
        }
    }
}
