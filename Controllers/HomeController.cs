using Microsoft.AspNetCore.Mvc;

namespace TaskTimer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}