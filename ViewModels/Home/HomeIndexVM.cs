using LuxGamingWebsite.Models.Entities;

namespace LuxGamingWebsite.ViewModels.Home
{
    public class HomeIndexVM
    {
        public List<Feature> Features { get; set; }
        public List<Game> Games { get; set; }
        public List<Caption> Caption { get; set; }
    }
}
