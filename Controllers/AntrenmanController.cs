using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebProje1.Data;
using WebProje1.Models;

namespace WebProje1.Models
{
    public class AntrenmanController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly IWebHostEnvironment _hostingEnvironment;

        public AntrenmanController(ApplicationDbContext context, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        // GET: Antrenman
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Antrenman.Include(a => a.Antrenor).Include(a => a.Brans);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Antrenman/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var antrenman = await _context.Antrenman
                .Include(a => a.Antrenor)
                .Include(a => a.Brans)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (antrenman == null)
            {
                return NotFound();
            }

            return View(antrenman);
        }

        // GET: Antrenman/Create
        public IActionResult Create()
        {
            ViewData["AntrenorId"] = new SelectList(_context.Antrenor, "Id", "AntrenorAd");
            ViewData["BransId"] = new SelectList(_context.Brans, "Id", "BransAd");
            return View();
        }

        // POST: Antrenman/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AntrenmanAd,Sure,EtkiBolgesi,KapakFoto,Video,Tarih,BransId,AntrenorId")] Antrenman antrenman)
        {
            if (ModelState.IsValid)
            {
                //******
                string webRootPath = _hostingEnvironment.WebRootPath;
                var files = HttpContext.Request.Form.Files;


                string fileName = Guid.NewGuid().ToString();
                var uploads = Path.Combine(webRootPath, @"images\antrenman");
                var extension = Path.GetExtension(files[0].FileName);

                using (var fileStream = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }
                antrenman.KapakFoto = @"\images\antrenman\" + fileName + extension;

                //********

                _context.Add(antrenman);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AntrenorId"] = new SelectList(_context.Antrenor, "Id", "AntrenorAd", antrenman.AntrenorId);
            ViewData["BransId"] = new SelectList(_context.Brans, "Id", "BransAd", antrenman.BransId);
            return View(antrenman);
        }

        // GET: Antrenman/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var antrenman = await _context.Antrenman.FindAsync(id);
            if (antrenman == null)
            {
                return NotFound();
            }
            ViewData["AntrenorId"] = new SelectList(_context.Antrenor, "Id", "AntrenorAd", antrenman.AntrenorId);
            ViewData["BransId"] = new SelectList(_context.Brans, "Id", "BransAd", antrenman.BransId);
            return View(antrenman);
        }

        // POST: Antrenman/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AntrenmanAd,Sure,EtkiBolgesi,KapakFoto,Video,Tarih,BransId,AntrenorId")] Antrenman antrenman)
        {
            if (id != antrenman.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(antrenman);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AntrenmanExists(antrenman.Id))
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
            ViewData["AntrenorId"] = new SelectList(_context.Antrenor, "Id", "AntrenorAd", antrenman.AntrenorId);
            ViewData["BransId"] = new SelectList(_context.Brans, "Id", "BransAd", antrenman.BransId);
            return View(antrenman);
        }

        // GET: Antrenman/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var antrenman = await _context.Antrenman
                .Include(a => a.Antrenor)
                .Include(a => a.Brans)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (antrenman == null)
            {
                return NotFound();
            }

            return View(antrenman);
        }

        // POST: Antrenman/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var antrenman = await _context.Antrenman.FindAsync(id);
            _context.Antrenman.Remove(antrenman);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AntrenmanExists(int id)
        {
            return _context.Antrenman.Any(e => e.Id == id);
        }
    }
}