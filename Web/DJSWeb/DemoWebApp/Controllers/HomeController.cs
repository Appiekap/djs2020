using Microsoft.AspNetCore.Mvc;

namespace DemoWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult CountName(string name = "Unknown", int times = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["Times"] = times;

            return View();
        }
    }
}
