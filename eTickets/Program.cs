using eTickets.Data;
using eTickets.Data.Services;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace eTickets
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //add connectionstring to db
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnectionString") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            //create connection
            builder.Services.AddDbContext<AppDbContext>(options 
                => options.UseSqlServer(connectionString));

            //services configuration
            builder.Services.AddScoped<IActorsService, ActorsService>();
            

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }


            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            //seed database
            AppDbInitalizer.Seed(app);

            app.Run();

           
        }
    }
}