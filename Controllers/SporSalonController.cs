using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebProje1.Data;
using WebProje1.Models;

namespace WebProje1.Controllers
{
    public class SporSalonController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SporSalonController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SporSalon
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.SporSalon.Include(s => s.Ilce);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: SporSalon/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sporSalon = await _context.SporSalon
                .Include(s => s.Ilce)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sporSalon == null)
            {
                return NotFound();
            }

            return View(sporSalon);
        }

        // GET: SporSalon/Create
        public IActionResult Create()
        {
            ViewData["IlceId"] = new SelectList(_context.Ilce, "Id", "Id");
            return View();
        }

        // POST: SporSalon/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SporSalonAd,IlceId,Iletisim,Adres")] SporSalon sporSalon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sporSalon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IlceId"] = new SelectList(_context.Ilce, "Id", "Id", sporSalon.IlceId);
            return View(sporSalon);
        }

        // GET: SporSalon/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sporSalon = await _context.SporSalon.FindAsync(id);
            if (sporSalon == null)
            {
                return NotFound();
            }
            ViewData["IlceId"] = new SelectList(_context.Ilce, "Id", "Id", sporSalon.IlceId);
            return View(sporSalon);
        }

        // POST: SporSalon/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SporSalonAd,IlceId,Iletisim,Adres")] SporSalon sporSalon)
        {
            if (id != sporSalon.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sporSalon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SporSalonExists(sporSalon.Id))
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
            ViewData["IlceId"] = new SelectList(_context.Ilce, "Id", "Id", sporSalon.IlceId);
            return View(sporSalon);
        }

        // GET: SporSalon/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sporSalon = await _context.SporSalon
                .Include(s => s.Ilce)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sporSalon == null)
            {
                return NotFound();
            }

            return View(sporSalon);
        }

        // POST: SporSalon/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sporSalon = await _context.SporSalon.FindAsync(id);
            _context.SporSalon.Remove(sporSalon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SporSalonExists(int id)
        {
            return _context.SporSalon.Any(e => e.Id == id);
        }
    }
}
