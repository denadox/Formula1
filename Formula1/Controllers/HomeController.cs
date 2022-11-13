using Microsoft.AspNetCore.Mvc;

namespace Formula1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("All", "Movies");
            }

            return View();
        }
    }
}
