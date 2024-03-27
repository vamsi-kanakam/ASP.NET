using Microsoft.AspNetCore.Mvc;
using MVCStructure_2022.DAL;
using MVCStructure_2022.Models;

namespace MVCStructure_2022.Controllers
{
    public class HomeController : Controller
    {
        private readonly MVCStructure_2022Context _context;

        //constructor Method
        public HomeController(MVCStructure_2022Context context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
