using LuxGamingWebsite.Models;
using Microsoft.AspNetCore.Mvc;

namespace LuxGamingWebsite.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            List<Game> games = new List<Game>()
            {
                new Game{Id=1,Category="a",Price=20,Name="test",ImagePath="trending-01.jpg"},
                new Game{Id=2,Category="b",Price=25,Name="test1",ImagePath="trending-02.jpg"},
                new Game{Id=3,Category="c",Price=30,Name="test2",ImagePath="trending-03.jpg"},
                new Game{Id=4,Category="d",Price=35,Name="test3",ImagePath="trending-04.jpg"},
                new Game{Id=5,Category="a",Price=46,Name="test4",ImagePath="trending-03.jpg"},
                new Game{Id=6,Category="b",Price=13,Name="test5",ImagePath="trending-02.jpg"},
                new Game{Id=7,Category="c",Price=98,Name="test6",ImagePath="trending-01.jpg"},
            };

            return View();
        }
    }
}
