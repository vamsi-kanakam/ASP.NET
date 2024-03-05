using Microsoft.AspNetCore.Mvc;
using MVCAssignment4.DAL;
using MVCAssignment4.Models;
using Microsoft.EntityFrameworkCore;

namespace MVCAssignment4.Controllers
{
    public class OwnerController : Controller
    {
        private MVCAssignment4Context _context;

        public OwnerController(MVCAssignment4Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Owner.ToList());
        }

            //add in a create method - GET create method

            public IActionResult Create()
            {
                return View();  //will return view with same name as the method.
            }

            //polymorphic CREATE method to add to database
            [HttpPost] //postt request
            public IActionResult Create(Owner theOwner)
            {
                //add the owner to the database
                _context.Add(theOwner);
                //update the database
                _context.SaveChanges();
                //return statement
                //post-redirect-get pattern
                return RedirectToAction("Index");
            }
    }
}
