using Microsoft.AspNetCore.Mvc;
using StarterProject.Models;
namespace StarterProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //TaxCalculator tc = new TaxCalculator { Subtotal = 100, TaxRate = 0.10M };
            TaxCalculator tc = new TaxCalculator();
            tc.Subtotal = 100;
            tc.TaxRate = 0.10M;

            return View(tc);
        }
    }
}
