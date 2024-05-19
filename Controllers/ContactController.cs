using LuxGamingWebsite.Models;
using LuxGamingWebsite.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LuxGamingWebsite.Controllers
{
    public class ContactController : Controller
    {
        private readonly DataContext _db;
        public ContactController(DataContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var contacts = _db.Contacts.ToList();
            return View(contacts);
        }
    }
}
