using Microsoft.AspNetCore.Mvc;

namespace TrialFreelance.Controllers
{
    public class SiteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }
    }
}
