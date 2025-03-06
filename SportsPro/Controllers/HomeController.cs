using Microsoft.AspNetCore.Mvc;

namespace SportsPro.Controllers
{
    public class HomeController : Controller
    {
        //Index method and current home page
        public IActionResult Index()
        {
            ViewData["ActivePage"] = "Home";
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

    }
}