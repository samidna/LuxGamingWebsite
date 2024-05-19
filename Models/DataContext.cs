using LuxGamingWebsite.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace LuxGamingWebsite.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }
        public DbSet<Game> Games { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Caption> Captions { get; set; }
    }
}
