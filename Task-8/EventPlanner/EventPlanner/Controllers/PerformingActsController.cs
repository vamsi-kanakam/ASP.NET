using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EventPlanner.DAL;
using EventPlanner.Models;
using EventPlanner.ViewModels;

namespace EventPlanner.Controllers
{
    public class PerformingActsController : Controller
    {
        private readonly EventPlannerContext _context;

        public PerformingActsController(EventPlannerContext context)
        {
            _context = context;
        }

        // GET: PerformingActs
        public async Task<IActionResult> Index()
        {
              return View(await _context.PerformingActs.ToListAsync());
        }

        // GET: PerformingActs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PerformingActs == null)
            {
                return NotFound();
            }

            var performingAct = await _context.PerformingActs
                .FirstOrDefaultAsync(m => m.PerformingActId == id);
            if (performingAct == null)
            {
                return NotFound();
            }

            return View(performingAct);
        }

        // GET: PerformingActs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PerformingActs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PerformingActId,Name,NumberOfPerformers,Manager,PerformerType,AverageAttendance")] PerformingAct performingAct)
        {
            if (ModelState.IsValid)
            {
                _context.Add(performingAct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(performingAct);
        }

        // GET: PerformingActs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PerformingActs == null)
            {
                return NotFound();
            }

            var performingAct = await _context.PerformingActs.FindAsync(id);
            if (performingAct == null)
            {
                return NotFound();
            }
            return View(performingAct);
        }

        // POST: PerformingActs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PerformingActId,Name,NumberOfPerformers,Manager,PerformerType,AverageAttendance")] PerformingAct performingAct)
        {
            if (id != performingAct.PerformingActId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(performingAct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PerformingActExists(performingAct.PerformingActId))
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
            return View(performingAct);
        }

        // GET: PerformingActs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PerformingActs == null)
            {
                return NotFound();
            }

            var performingAct = await _context.PerformingActs
                .FirstOrDefaultAsync(m => m.PerformingActId == id);
            if (performingAct == null)
            {
                return NotFound();
            }

            return View(performingAct);
        }

        // POST: PerformingActs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PerformingActs == null)
            {
                return Problem("Entity set 'EventPlannerContext.PerformingActs'  is null.");
            }
            var performingAct = await _context.PerformingActs.FindAsync(id);
            if (performingAct != null)
            {
                _context.PerformingActs.Remove(performingAct);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PerformingActExists(int id)
        {
          return _context.PerformingActs.Any(e => e.PerformingActId == id);
        }

        //GET
        public IActionResult Search()
        {
            var model = new PerformingActSearchViewModel();
            return View(model);
        }

        //POST
        [HttpPost]
        public IActionResult Search(PerformingActSearchViewModel model)
        {
            var results = _context.PerformingActs.Where(pa => pa.Name.ToLower().Contains(model.PerformingAct.Name.ToLower())).ToList();

            if (results.Count <= 1)
            {
                if (results.Count == 1)
                {
                    return RedirectToAction("Details", "PerformingActs", new
                    {
                        id = results[0].PerformingActId
                    });
                }
                model.SearchError = "No performing acts found with the search criteria provided";
            }

            model.ResultList = results;
            return View(model);
        }
    }
}
