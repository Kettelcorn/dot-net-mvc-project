using System.Net.Mime;
using System.Text;

namespace WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Dependency injection to support controllers with views
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Routing middleware
            app.UseRouting();

            // Allow to set up mapping to controller method
            app.MapControllerRoute(
                name: "default",
                // Home maps to "HomeController.cs"
                // Index maps to the method in the HomeController class that is named Index
                pattern: "{controller=Home}/{action=Index}/{id?}"
                );

            app.Run();
        }
    }
}
