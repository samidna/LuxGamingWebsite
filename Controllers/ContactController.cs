using LuxGamingWebsite.Models;
using Microsoft.AspNetCore.Mvc;

namespace LuxGamingWebsite.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            Contact contact = new() { Id=1, Title="Contact them", Text="Say GoodBye!", Description="lorem lorem lorem lorem lorem lorem", Adress="Baku,Yasamal,Prospekt", Phone="+9943457126", Email="prospekt@gmail.com" }; 
            return View(contact);
        }
    }
}
