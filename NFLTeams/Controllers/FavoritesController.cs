using Microsoft.AspNetCore.Mvc;
using NFLTeams.Models;

namespace NFLTeams.Controllers
{
    public class FavoritesController : Controller
    {
        public ViewResult Index()
        {
           return View();
        }

        [HttpPost]
        public RedirectToActionResult Add(TeamsViewModel model)
        {
            // code to store favorite team in session goes here - see chapter 9

            TempData["message"] = $"{model.Team.Name} added to your favorites";

            return RedirectToAction("Index", "Home", model);
        }
    }
}