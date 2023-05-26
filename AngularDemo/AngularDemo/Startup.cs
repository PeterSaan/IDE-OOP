using AngularDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;

public class Startup
{
    public object Configuration { get; set; }
    public IConfiguration configRoot { get; }

    public Startup(IConfiguration configuration)
    {
        configRoot = configuration;
    }
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllersWithViews();
        string connectionString = Configuration.GetConnectionString("default");
        services.AddDbContext<AppDBContext>(c => c.UseSqlServer(connectionString));
    }
    public void Configure(WebApplication app, IWebHostEnvironment env)
    {
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseAuthorization();
        app.Run();
    }
}