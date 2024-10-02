using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        // IActionResult represents return type of any action method
        // Basically can return all return types.
        public IActionResult Index()
        {
            // If you don't pass in the view name, it will default
            // to the action method name "Index". If you want to have a 
            // specific view, do return View("Index");
            return View();
        }

    }
}
