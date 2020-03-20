using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrashCollector.Data;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    public class SuspensionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SuspensionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Suspensions
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Suspension.Include(s => s.Customer);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Suspensions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suspension = await _context.Suspension
                .Include(s => s.Customer)
                .FirstOrDefaultAsync(m => m.SuspensionId == id);
            if (suspension == null)
            {
                return NotFound();
            }

            return View(suspension);
        }

        // GET: Suspensions/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "CustomerId");
            return View();
        }

        // POST: Suspensions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SuspensionId,CustomerId,StartSuspension,EndSuspension")] Suspension suspension)
        {
            if (ModelState.IsValid)
            {
                _context.Add(suspension);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "CustomerId", suspension.CustomerId);
            return View(suspension);
        }

        // GET: Suspensions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suspension = await _context.Suspension.FindAsync(id);
            if (suspension == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "CustomerId", suspension.CustomerId);
            return View(suspension);
        }

        // POST: Suspensions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SuspensionId,CustomerId,StartSuspension,EndSuspension")] Suspension suspension)
        {
            if (id != suspension.SuspensionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(suspension);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SuspensionExists(suspension.SuspensionId))
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
            ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "CustomerId", suspension.CustomerId);
            return View(suspension);
        }

        // GET: Suspensions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suspension = await _context.Suspension
                .Include(s => s.Customer)
                .FirstOrDefaultAsync(m => m.SuspensionId == id);
            if (suspension == null)
            {
                return NotFound();
            }

            return View(suspension);
        }

        // POST: Suspensions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var suspension = await _context.Suspension.FindAsync(id);
            _context.Suspension.Remove(suspension);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SuspensionExists(int id)
        {
            return _context.Suspension.Any(e => e.SuspensionId == id);
        }
    }
}
