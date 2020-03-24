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
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Employees
        [HttpGet]
        public async Task<IActionResult> Index(string dayToRoute = null)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            Employee currentemployee = _context.Employee.Where(e => e.IdentityUserId == userId).FirstOrDefault();
            string dayToCheck = DateTime.Now.DayOfWeek.ToString();
            if (dayToRoute != null)
            {
                dayToCheck = dayToRoute;
            }
            //var pickupDay = _context.PickupDays.Where(d => d.DayName.ToString() == dayToCheck);

            //PickupDay ourpickupDay = new PickupDay();

            //var applicationDbContext = _context.Employee.Include(e => e.IdentityUser);

            var routelist = _context.Customer.Where(c => c.Zipcode == currentemployee.RouteZipcode && c.PickupDay.DayName == dayToCheck).ToList();
            //routelist = _context.Customer.Where(c => c.PickupDay.DayName == "Monday");
            //routelist = routelist.Where(c => c.PickupDay == pickupDay);
            //int dayIntValue = _context.PickupDays.Where(d => ToString(d.DayName) == DateTime.Now.DayOfWeek.ToString().FirstOrDefault());
            //var routelist = _context.Customer.Where(c => c.PickupDay == DateTime.Now.DayOfWeek.ToString());
            //Find all customers who have null start days
            currentemployee.RoutePickUps = routelist;
            //return View(await applicationDbContext.ToListAsync());

            var routesByDay = new List<DayOfWeek>();
            routesByDay.Add(DayOfWeek.Monday);
            routesByDay.Add(DayOfWeek.Tuesday);
            routesByDay.Add(DayOfWeek.Wednesday);
            routesByDay.Add(DayOfWeek.Thursday);
            routesByDay.Add(DayOfWeek.Friday);
            routesByDay.Add(DayOfWeek.Saturday);
            routesByDay.Add(DayOfWeek.Sunday);
            currentemployee.workDays = routesByDay;

            return View(currentemployee);
        }
        public IActionResult ConfirmPickup(int id)
        {
            var customerDB = _context.Customer.Where(c => c.CustomerId == id).SingleOrDefault();
            if (customerDB != null)
            {
                customerDB.IsPickedup = true;
                customerDB.Balance += 5;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        // GET: Employees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee
                .Include(e => e.IdentityUser)
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: Employees/Create
        public IActionResult Create()
        {
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeId,IdentityUserId,FirstName,LastName,RouteZipcode")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                employee.IdentityUserId = userId;
                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employee.IdentityUserId);
            return View(employee);
        }

        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employee.IdentityUserId);
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmployeeId,IdentityUserId,FirstName,LastName,RouteZipcode")] Employee employee)
        {
            if (id != employee.EmployeeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.EmployeeId))
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
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employee.IdentityUserId);
            return View(employee);
        }

        // GET: Employees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee
                .Include(e => e.IdentityUser)
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employee.FindAsync(id);
            _context.Employee.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employee.Any(e => e.EmployeeId == id);
        }

        // GET: Employees
        [HttpGet]
        public async Task<IActionResult> Routes(string dayToRoute = null)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            Employee currentemployee = _context.Employee.Where(e => e.IdentityUserId == userId).FirstOrDefault();
            string dayToCheck = DateTime.Now.DayOfWeek.ToString();
            if (dayToRoute != null)
            {
                dayToCheck = dayToRoute;
            }
            //var pickupDay = _context.PickupDays.Where(d => d.DayName.ToString() == dayToCheck);

            //PickupDay ourpickupDay = new PickupDay();

            //var applicationDbContext = _context.Employee.Include(e => e.IdentityUser);

            var routelist = _context.Customer.Where(c => c.Zipcode == currentemployee.RouteZipcode && c.PickupDay.DayName == dayToCheck).ToList();
            //routelist = _context.Customer.Where(c => c.PickupDay.DayName == "Monday");
            //routelist = routelist.Where(c => c.PickupDay == pickupDay);
            //int dayIntValue = _context.PickupDays.Where(d => ToString(d.DayName) == DateTime.Now.DayOfWeek.ToString().FirstOrDefault());
            //var routelist = _context.Customer.Where(c => c.PickupDay == DateTime.Now.DayOfWeek.ToString());
            //Find all customers who have null start days
            currentemployee.RoutePickUps = routelist;
            currentemployee.DayToRoute = dayToCheck;

            //return View(await applicationDbContext.ToListAsync());

            var routesByDay = new List<DayOfWeek>();
            routesByDay.Add(DayOfWeek.Monday);
            routesByDay.Add(DayOfWeek.Tuesday);
            routesByDay.Add(DayOfWeek.Wednesday);
            routesByDay.Add(DayOfWeek.Thursday);
            routesByDay.Add(DayOfWeek.Friday);
            routesByDay.Add(DayOfWeek.Saturday);
            routesByDay.Add(DayOfWeek.Sunday);
            currentemployee.workDays = routesByDay;

            return View(currentemployee);
        }

        //// POST: Routes
        //[HttpPost]
        //public async Task<IActionResult> Routes(string dayToRoute = null)
        //{
        //    var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
        //    Employee currentemployee = _context.Employee.Where(e => e.IdentityUserId == userId).FirstOrDefault();
        //    string dayToCheck = DateTime.Now.DayOfWeek.ToString();
        //    if (dayToRoute != null)
        //    {
        //        dayToCheck = dayToRoute;
        //    }
        //    //var pickupDay = _context.PickupDays.Where(d => d.DayName.ToString() == dayToCheck);

        //    //PickupDay ourpickupDay = new PickupDay();

        //    //var applicationDbContext = _context.Employee.Include(e => e.IdentityUser);

        //    var routelist = _context.Customer.Where(c => c.Zipcode == currentemployee.RouteZipcode && c.PickupDay.DayName == dayToCheck).ToList();
        //    //routelist = _context.Customer.Where(c => c.PickupDay.DayName == "Monday");
        //    //routelist = routelist.Where(c => c.PickupDay == pickupDay);
        //    //int dayIntValue = _context.PickupDays.Where(d => ToString(d.DayName) == DateTime.Now.DayOfWeek.ToString().FirstOrDefault());
        //    //var routelist = _context.Customer.Where(c => c.PickupDay == DateTime.Now.DayOfWeek.ToString());
        //    //Find all customers who have null start days
        //    currentemployee.RoutePickUps = routelist;
        //    //return View(await applicationDbContext.ToListAsync());

        //    var routesByDay = new List<DayOfWeek>();
        //    routesByDay.Add(DayOfWeek.Monday);
        //    routesByDay.Add(DayOfWeek.Tuesday);
        //    routesByDay.Add(DayOfWeek.Wednesday);
        //    routesByDay.Add(DayOfWeek.Thursday);
        //    routesByDay.Add(DayOfWeek.Friday);
        //    routesByDay.Add(DayOfWeek.Saturday);
        //    routesByDay.Add(DayOfWeek.Sunday);
        //    currentemployee.workDays = routesByDay;

        //    return View(currentemployee);
        //}
        // GET: Confirm
        [HttpGet]
        public async Task<IActionResult> Confirm(string pickupsToConfirm)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            Employee currentemployee = _context.Employee.Where(e => e.IdentityUserId == userId).FirstOrDefault();
            string dayToCheck = DateTime.Now.DayOfWeek.ToString();
            //if (dayToRoute != null)
            //{
            //    dayToCheck = dayToRoute;
            //}
            //var pickupDay = _context.PickupDays.Where(d => d.DayName.ToString() == dayToCheck);

            //PickupDay ourpickupDay = new PickupDay();

            //var applicationDbContext = _context.Employee.Include(e => e.IdentityUser);

            var routelist = _context.Customer.Where(c => c.Zipcode == currentemployee.RouteZipcode && c.PickupDay.DayName == dayToCheck).ToList();
            //routelist = _context.Customer.Where(c => c.PickupDay.DayName == "Monday");
            //routelist = routelist.Where(c => c.PickupDay == pickupDay);
            //int dayIntValue = _context.PickupDays.Where(d => ToString(d.DayName) == DateTime.Now.DayOfWeek.ToString().FirstOrDefault());
            //var routelist = _context.Customer.Where(c => c.PickupDay == DateTime.Now.DayOfWeek.ToString());
            //Find all customers who have null start days
            currentemployee.RoutePickUps = routelist;
            currentemployee.DayToRoute = dayToCheck;

            //return View(await applicationDbContext.ToListAsync());

            var routesByDay = new List<DayOfWeek>();
            routesByDay.Add(DayOfWeek.Monday);
            routesByDay.Add(DayOfWeek.Tuesday);
            routesByDay.Add(DayOfWeek.Wednesday);
            routesByDay.Add(DayOfWeek.Thursday);
            routesByDay.Add(DayOfWeek.Friday);
            routesByDay.Add(DayOfWeek.Saturday);
            routesByDay.Add(DayOfWeek.Sunday);
            currentemployee.workDays = routesByDay;

            return View(currentemployee);
        }
    }
}
