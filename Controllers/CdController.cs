#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using cdStore.Data;
using cdStore.Models;

namespace cdStore.Controllers
{
    public class CdController : Controller
    {
        private readonly CdContext _context;

        public CdController(CdContext context)
        {
            _context = context;
        }

        // GET: Cd
        public async Task<IActionResult> Index(string searchString)
        {
            
            var search = from Cd in _context.Cd
                select Cd;

            if (!String.IsNullOrEmpty(searchString))
            {
                search = search.Where(s => s.CdName!.Contains(searchString));
            }
            
            return View(await search.ToListAsync());
        }

        // GET: Cd/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cd = await _context.Cd
                .Include(c => c.Artist)
                .FirstOrDefaultAsync(m => m.CdId == id);
            if (cd == null)
            {
                return NotFound();
            }

            return View(cd);
        }

        // GET: Cd/Create
        public IActionResult Create()
        {
            ViewData["ArtistId"] = new SelectList(_context.Artist, "ArtistId", "ArtistName");
            return View();
        }

        // POST: Cd/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CdId,CdName,Price,ArtistId")] Cd cd)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cd);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ArtistId"] = new SelectList(_context.Artist, "ArtistId", "ArtistName", cd.ArtistId);
            return View(cd);
        }

        // GET: Cd/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cd = await _context.Cd.FindAsync(id);
            if (cd == null)
            {
                return NotFound();
            }
            ViewData["ArtistId"] = new SelectList(_context.Artist, "ArtistId", "ArtistName", cd.ArtistId);
            return View(cd);
        }

        // POST: Cd/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CdId,CdName,Price,ArtistId")] Cd cd)
        {
            if (id != cd.CdId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cd);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CdExists(cd.CdId))
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
            ViewData["ArtistId"] = new SelectList(_context.Artist, "ArtistId", "ArtistName", cd.ArtistId);
            return View(cd);
        }

        // GET: Cd/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cd = await _context.Cd
                .Include(c => c.Artist)
                .FirstOrDefaultAsync(m => m.CdId == id);
            if (cd == null)
            {
                return NotFound();
            }

            return View(cd);
        }

        // POST: Cd/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cd = await _context.Cd.FindAsync(id);
            _context.Cd.Remove(cd);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CdExists(int id)
        {
            return _context.Cd.Any(e => e.CdId == id);
        }
    }
}
