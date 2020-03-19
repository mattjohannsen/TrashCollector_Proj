using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrashCollector.Data;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    public class PickupDaysController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PickupDaysController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PickupDays
        public async Task<IActionResult> Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            return View(await _context.PickupDays.ToListAsync());
        }

        // GET: PickupDays/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pickupDay = await _context.PickupDays
                .FirstOrDefaultAsync(m => m.PickupDayId == id);
            if (pickupDay == null)
            {
                return NotFound();
            }

            return View(pickupDay);
        }

        // GET: PickupDays/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PickupDays/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PickupDayId,DayName")] PickupDay pickupDay)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pickupDay);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pickupDay);
        }

        // GET: PickupDays/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pickupDay = await _context.PickupDays.FindAsync(id);
            if (pickupDay == null)
            {
                return NotFound();
            }
            return View(pickupDay);
        }

        // POST: PickupDays/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PickupDayId,DayName")] PickupDay pickupDay)
        {
            if (id != pickupDay.PickupDayId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pickupDay);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PickupDayExists(pickupDay.PickupDayId))
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
            return View(pickupDay);
        }

        // GET: PickupDays/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pickupDay = await _context.PickupDays
                .FirstOrDefaultAsync(m => m.PickupDayId == id);
            if (pickupDay == null)
            {
                return NotFound();
            }

            return View(pickupDay);
        }

        // POST: PickupDays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pickupDay = await _context.PickupDays.FindAsync(id);
            _context.PickupDays.Remove(pickupDay);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PickupDayExists(int id)
        {
            return _context.PickupDays.Any(e => e.PickupDayId == id);
        }
    }
}
