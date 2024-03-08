using Microsoft.AspNetCore.Mvc;
using EntityFramework.Models;
using EntityFramework.Models.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

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
        //add in a create method - GET create method

        public IActionResult Create()
        {
            return View();  //will return view with same name as the method.
        }

        //polymorphic CREATE method to add to database
        [HttpPost] //postt request
        public IActionResult Create(Venue theVenue)
        {
            if (ModelState.IsValid)
            {
                //add the owner to the database
                _context.Add(theVenue);
                //update the database
                _context.SaveChanges();
                //return statement
                //post-redirect-get pattern
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Edit(int id)
        {
            var ven = _context.Venue.FirstOrDefault(m => m.VenueId == id);
            return View(ven);
        }

        [HttpPost]
        public IActionResult Edit(Venue thisVenue)
        {
            _context.Update(thisVenue);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var venue = _context.Venue.FirstOrDefault(v => v.VenueId == id);
            return View(venue);
        }

        [HttpPost,ActionName("Delete")]

        public IActionResult DeleteConfirmed(int id)
        {
            var act = _context.Venue.SingleOrDefault(v => v.VenueId == id);
            _context.Venue.Remove(act);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
