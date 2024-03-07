using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EventPlanner.DAL;
using EventPlanner.Models;

namespace EventPlanner.Controllers
{
    public class ProductionCompaniesController : Controller
    {
        private readonly EventPlannerContext _context;

        public ProductionCompaniesController(EventPlannerContext context)
        {
            _context = context;
        }

        // GET: ProductionCompanies
        public async Task<IActionResult> Index()
        {
              return View(await _context.ProductionCompanies.ToListAsync());
        }

        // GET: ProductionCompanies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ProductionCompanies == null)
            {
                return NotFound();
            }

            var productionCompany = await _context.ProductionCompanies
                .FirstOrDefaultAsync(m => m.ProductionCompanyId == id);
            if (productionCompany == null)
            {
                return NotFound();
            }

            return View(productionCompany);
        }

        // GET: ProductionCompanies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProductionCompanies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductionCompanyId,Name,Address,StaffSize")] ProductionCompany productionCompany)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productionCompany);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productionCompany);
        }

        // GET: ProductionCompanies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ProductionCompanies == null)
            {
                return NotFound();
            }

            var productionCompany = await _context.ProductionCompanies.FindAsync(id);
            if (productionCompany == null)
            {
                return NotFound();
            }
            return View(productionCompany);
        }

        // POST: ProductionCompanies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductionCompanyId,Name,Address,StaffSize")] ProductionCompany productionCompany)
        {
            if (id != productionCompany.ProductionCompanyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productionCompany);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductionCompanyExists(productionCompany.ProductionCompanyId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(productionCompany);
        }

        // GET: ProductionCompanies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ProductionCompanies == null)
            {
                return NotFound();
            }

            var productionCompany = await _context.ProductionCompanies
                .FirstOrDefaultAsync(m => m.ProductionCompanyId == id);
            if (productionCompany == null)
            {
                return NotFound();
            }

            return View(productionCompany);
        }

        // POST: ProductionCompanies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ProductionCompanies == null)
            {
                return Problem("Entity set 'EventPlannerContext.ProductionCompanies'  is null.");
            }
            var productionCompany = await _context.ProductionCompanies.FindAsync(id);
            if (productionCompany != null)
            {
                _context.ProductionCompanies.Remove(productionCompany);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductionCompanyExists(int id)
        {
          return _context.ProductionCompanies.Any(e => e.ProductionCompanyId == id);
        }
    }
}
