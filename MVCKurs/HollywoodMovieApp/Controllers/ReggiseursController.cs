#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HollywoodMovieApp.Data;
using HollywoodMovieApp.Models;

namespace HollywoodMovieApp.Controllers
{
    public class ReggiseursController : Controller
    {
        private readonly HollywoodDbContext _context;

        public ReggiseursController(HollywoodDbContext context)
        {
            _context = context;
        }

        // GET: Reggiseurs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Reggiseur.ToListAsync());
        }

        // GET: Reggiseurs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reggiseur = await _context.Reggiseur
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reggiseur == null)
            {
                return NotFound();
            }

            return View(reggiseur);
        }

        // GET: Reggiseurs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Reggiseurs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName")] Reggiseur reggiseur)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reggiseur);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reggiseur);
        }

        // GET: Reggiseurs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reggiseur = await _context.Reggiseur.FindAsync(id);
            if (reggiseur == null)
            {
                return NotFound();
            }
            return View(reggiseur);
        }

        // POST: Reggiseurs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName")] Reggiseur reggiseur)
        {
            if (id != reggiseur.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reggiseur);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReggiseurExists(reggiseur.Id))
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
            return View(reggiseur);
        }

        // GET: Reggiseurs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reggiseur = await _context.Reggiseur
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reggiseur == null)
            {
                return NotFound();
            }

            return View(reggiseur);
        }

        // POST: Reggiseurs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reggiseur = await _context.Reggiseur.FindAsync(id);
            _context.Reggiseur.Remove(reggiseur);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReggiseurExists(int id)
        {
            return _context.Reggiseur.Any(e => e.Id == id);
        }
    }
}
