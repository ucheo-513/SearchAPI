
using PartSearchAPI.Repository;
using PartSearchAPI.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IPartSearchRepository, PartSearchRepository>();

// Add services to the container.
builder.Services.AddScoped<IPartSearchService, PartSearchService>();

var app = builder.Build();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");



app.Run();
