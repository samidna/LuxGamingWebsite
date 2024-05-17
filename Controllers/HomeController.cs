using LuxGamingWebsite.Models;
using LuxGamingWebsite.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;

namespace LuxGamingWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Feature> features = new List<Feature>()
            {
                new Feature{Id=1,Title="Free Storagee",IconPath="featured-01.png"},
                new Feature{Id=2,Title="User Moree",IconPath="featured-02.png"},
                new Feature{Id=3,Title="Reply Readyy",IconPath="featured-03.png"},
                new Feature{Id=4,Title="Easy Layoutt",IconPath="featured-04.png"},
            };

            List<Game> games = new List<Game>()
            {
                new Game{Id=1,Name="NFS",Category="Race",Price=24,ImagePath="trending-01.jpg"},
                new Game{Id=2,Name="CS GO",Category="Pvp",Price=50,ImagePath="trending-02.jpg"},
                new Game{Id=3,Name="My Life",Category="Adventure",Price=0,ImagePath="trending-03.jpg"},
                new Game{Id=4,Name="Fifa 24",Category="Football",Price=24,ImagePath="trending-04.jpg"},
                new Game{Id=5,Name="Sims",Category="Online",Price=24,ImagePath="trending-01.jpg"},
                new Game{Id=6,Name="Farm",Category="Arcade",Price=24,ImagePath="trending-02.jpg"},
            };

            Caption caption = new() { Id=1, Title="Welcome to hell", Description="Best Gaming Site Never!",Text="test test1 test2 test3"};
            HomeIndexVM vm = new HomeIndexVM()
            {
                Games = games,
                Features = features,
                Caption = caption
            };
            return View(vm);
        }
    }
}
