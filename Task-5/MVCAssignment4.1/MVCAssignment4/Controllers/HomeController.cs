using Microsoft.AspNetCore.Mvc;

namespace MVCAssignment4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
