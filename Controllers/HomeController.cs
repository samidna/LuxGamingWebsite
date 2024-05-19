using LuxGamingWebsite.Models;
using LuxGamingWebsite.Models.Entities;
using LuxGamingWebsite.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;

namespace LuxGamingWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _db;

        public HomeController(DataContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var features = _db.Features.ToList();
            var games = _db.Games.ToList();
            var captions = _db.Captions.ToList();
            HomeIndexVM vm = new HomeIndexVM()
            {
                Games = games,
                Features = features,
                Caption = captions
            };
            return View(vm);
        }
    }
}
