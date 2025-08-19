using Microsoft.AspNetCore.Mvc;

namespace TaskTimer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/tasks/best-practices")]
        public IActionResult BestPractices()
        {
            ViewData["Title"] = "Task Best Practices";
            return View();
        }
    }
}