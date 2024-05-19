using LuxGamingWebsite.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DataContext>(sql =>
{
    sql.UseSqlServer(builder.Configuration.GetConnectionString("default"));
});


var app = builder.Build();

app.MapControllerRoute("default", "{controller=home}/{action=index}/{id?}");

app.UseStaticFiles();

app.Run();
