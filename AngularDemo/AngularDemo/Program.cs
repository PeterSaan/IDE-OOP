using AngularDemo.Models;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

string connectionString = Configuration.GetConnectionString("default");
builder.services.AddDbContext<AppDBContext>(c => c.UseSqlServer(connectionString));

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
}

app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
