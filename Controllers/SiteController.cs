using Microsoft.AspNetCore.Mvc;

namespace TrialFreelance.Controllers
{
    public class SiteController : Controller
    {
        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult SiteMap()//not implement
        {
            return View();
        }
    }
}
