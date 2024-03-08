using Microsoft.AspNetCore.Mvc;

namespace EntityFramework.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
