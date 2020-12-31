using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using WebProje1.Data;
using WebProje1.Models;
using System.IO;

namespace WebProje1.Controllers
{
    public class BransController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly IWebHostEnvironment _hostingEnvironment;

        public BransController(ApplicationDbContext context, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        // GET: Brans
        public async Task<IActionResult> Index()
        {
            return View(await _context.Brans.ToListAsync());
        }

        // GET: Brans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brans = await _context.Brans
                .FirstOrDefaultAsync(m => m.Id == id);
            if (brans == null)
            {
                return NotFound();
            }

            return View(brans);
        }

        // GET: Brans/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Brans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BransAd,Foto")] Brans brans)
        {
            if (ModelState.IsValid)
            {
                //******
                //string webRootPath = _hostingEnvironment.WebRootPath;
                //var files = HttpContext.Request.Form.Files;


                //string fileName = Guid.NewGuid().ToString();
                //var uploads = Path.Combine(webRootPath, @"images\brans");
                //var extension = Path.GetExtension(files[0].FileName);

                //using (var fileStream = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                //{
                //    files[0].CopyTo(fileStream);
                //}
                //brans.Foto = @"\images\brans\" + fileName + extension;

                //********

                _context.Add(brans);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(brans);
        }

        // GET: Brans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brans = await _context.Brans.FindAsync(id);
            if (brans == null)
            {
                return NotFound();
            }
            return View(brans);
        }

        // POST: Brans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BransAd,Foto")] Brans brans)
        {
            if (id != brans.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(brans);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BransExists(brans.Id))
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
            return View(brans);
        }

        // GET: Brans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brans = await _context.Brans
                .FirstOrDefaultAsync(m => m.Id == id);
            if (brans == null)
            {
                return NotFound();
            }

            return View(brans);
        }

        // POST: Brans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var brans = await _context.Brans.FindAsync(id);
            _context.Brans.Remove(brans);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BransExists(int id)
        {
            return _context.Brans.Any(e => e.Id == id);
        }
    }
}
