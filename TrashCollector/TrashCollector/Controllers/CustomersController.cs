using System;
using System.Collections.Generic;
using System.Globalization;
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
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Customers
        public async Task<IActionResult> Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            //var applicationDbContext = _context.Customer.Include(c => c.IdentityUser).Include(c => c.PickupDay);
            //return View(await applicationDbContext.ToListAsync());
            Customer customer = _context.Customer.Where(c => c.IdentityUserId == userId).FirstOrDefault();
            if (customer == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                return View(customer);
                //return RedirectToAction("Index", customer);
            }
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .Include(c => c.IdentityUser)
                .Include(c => c.PickupDay)
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            ViewData["WeeklyPickUp"] = new SelectList(_context.PickupDays, "PickupDayId", "DayName");
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerId,IdentityUserId,FirstName,LastName,Address,City,State,Zipcode,WeeklyPickUp,StartHold,EndHold,ExtraPickupDay,Balance")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                customer.IdentityUserId = userId;
                //decimal initialBalance = 0;
                customer.Balance = 0;
                _context.Add(customer);
                await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));
                return RedirectToAction("Index", new { id = customer.CustomerId });
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", customer.IdentityUserId);
            ViewData["WeeklyPickUp"] = new SelectList(_context.PickupDays, "PickupDayId", "PickupDayId", customer.WeeklyPickUp);
            //return View(customer);
            return RedirectToAction("Index", new { id = customer.CustomerId });
        }
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(customer);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", customer.IdentityUserId);
        //    ViewData["WeeklyPickUp"] = new SelectList(_context.PickupDays, "PickupDayId", "PickupDayId", customer.WeeklyPickUp);
        //    return View(customer);
        //}

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer customer = await _context.Customer.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            //ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", customer.IdentityUserId);
            //ViewData["WeeklyPickUp"] = new SelectList(_context.PickupDays, "PickupDayId", "PickupDayId", customer.WeeklyPickUp);
            customer.PickupDays = _context.PickupDays;
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerId,IdentityUserId,FirstName,LastName,Address,City,State,Zipcode,WeeklyPickUp,StartHold,EndHold,ExtraPickupDay,Balance")] Customer customer)
        {
            if (id != customer.CustomerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                    customer.IdentityUserId = userId;
                    CultureInfo MyCultureInfo = new CultureInfo("en-US");
                    var whatthedate = Request.Form["StartHold"];
                    if (Request.Form["StartHold"] == "")
                    {
                        customer.StartHold = null;
                    }
                    else
                    {
                        customer.StartHold = DateTime.Parse(Request.Form["StartHold"]);
                    }
                    if (Request.Form["EndHold"] == "")
                    {
                        customer.EndHold = null;
                    }
                    else
                    {
                        customer.EndHold = DateTime.Parse(Request.Form["EndHold"]);
                    }
                    if (Request.Form["ExtraPickupDay"] == "")
                    {
                        customer.ExtraPickupDay = null;
                    }
                    else
                    {
                        customer.ExtraPickupDay = DateTime.Parse(Request.Form["ExtraPickupDay"]);
                    }
                    //customer.StartHold = DateTime.ParseExact(Request.Form["StartHold"], "d", MyCultureInfo);
                    //customer.EndHold = DateTime.Parse(Request.Form["EndHold"]);
                    //customer.ExtraPickupDay = DateTime.Parse(Request.Form["ExtraPickupDay"]);
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.CustomerId))
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
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", customer.IdentityUserId);
            ViewData["WeeklyPickUp"] = new SelectList(_context.PickupDays, "PickupDayId", "PickupDayId", customer.WeeklyPickUp);
            return View(customer);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .Include(c => c.IdentityUser)
                .Include(c => c.PickupDay)
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customer.FindAsync(id);
            _context.Customer.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
            return _context.Customer.Any(e => e.CustomerId == id);
        }
    }
}
