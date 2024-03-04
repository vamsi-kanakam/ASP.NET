using Microsoft.AspNetCore.Mvc;
using EntityFramework.Models;
using EntityFramework.Models.DAL;

namespace EntityFramework.Controllers
{
    public class VenuesController : Controller
    {
        private EntityFrameworkContext _context;
        public VenuesController(EntityFrameworkContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Venue.ToList());
        }
    }
}
