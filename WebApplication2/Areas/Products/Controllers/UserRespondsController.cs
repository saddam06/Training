using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Training.Web.Data;
using Training.Web.Models;

namespace Training.Web.Areas.Products.Controllers
{
    [Area("Products")]
    public class UserRespondsController : Controller
    {
        private readonly TrainingWebContext _context;

        public UserRespondsController(TrainingWebContext context)
        {
            _context = context;
        }

        // GET: Products/UserResponds
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserResponds.ToListAsync());
        }

        // GET: Products/UserResponds/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userResponds = await _context.UserResponds
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (userResponds == null)
            {
                return NotFound();
            }

            return View(userResponds);
        }

        // GET: Products/UserResponds/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/UserResponds/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,UserFirstName,UserLastName,UserMessage")] UserResponds userResponds)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userResponds);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userResponds);
        }

        // GET: Products/UserResponds/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userResponds = await _context.UserResponds.FindAsync(id);
            if (userResponds == null)
            {
                return NotFound();
            }
            return View(userResponds);
        }

        // POST: Products/UserResponds/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,UserFirstName,UserLastName,UserMessage")] UserResponds userResponds)
        {
            if (id != userResponds.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userResponds);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserRespondsExists(userResponds.UserId))
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
            return View(userResponds);
        }

        // GET: Products/UserResponds/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userResponds = await _context.UserResponds
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (userResponds == null)
            {
                return NotFound();
            }

            return View(userResponds);
        }

        // POST: Products/UserResponds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userResponds = await _context.UserResponds.FindAsync(id);
            _context.UserResponds.Remove(userResponds);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserRespondsExists(int id)
        {
            return _context.UserResponds.Any(e => e.UserId == id);
        }
    }
}
