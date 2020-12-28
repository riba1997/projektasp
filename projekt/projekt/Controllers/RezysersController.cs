using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using projekt.Models;

namespace projekt.Controllers
{
    public class RezysersController : Controller
    {
        private readonly projektContext _context;

        public RezysersController(projektContext context)
        {
            _context = context;
        }

        // GET: Rezysers
        public async Task<IActionResult> Index()
        {
            var projektContext = _context.Rezysers.Include(s => s.Films);
            return View(await projektContext.ToListAsync());
        }

        // GET: Rezysers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rezyser = await _context.Rezysers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rezyser == null)
            {
                return NotFound();
            }

            return View(rezyser);
        }

        // GET: Rezysers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rezysers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ImieNazwisko")] Rezyser rezyser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rezyser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rezyser);
        }

        // GET: Rezysers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rezyser = await _context.Rezysers.FindAsync(id);
            if (rezyser == null)
            {
                return NotFound();
            }
            return View(rezyser);
        }

        // POST: Rezysers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ImieNazwisko")] Rezyser rezyser)
        {
            if (id != rezyser.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rezyser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RezyserExists(rezyser.Id))
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
            return View(rezyser);
        }

        // GET: Rezysers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rezyser = await _context.Rezysers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rezyser == null)
            {
                return NotFound();
            }

            return View(rezyser);
        }

        // POST: Rezysers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rezyser = await _context.Rezysers.FindAsync(id);
            _context.Rezysers.Remove(rezyser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RezyserExists(int id)
        {
            return _context.Rezysers.Any(e => e.Id == id);
        }
    }
}
