using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebProje1.Data;

namespace WebProje1.Controllers
{
    public class AntrenmanSayfaController : Controller
    {
        private ApplicationDbContext _context;
        public AntrenmanSayfaController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var antrenmanList = (from f in _context.Antrenman
                                 select new AntrenmanDTO
                                 {
                                     AntrenmanID = f.Id,
                                     Adi = f.AntrenmanAd,
                                     Antrenor=f.Antrenor.AntrenorAd,
                                     Sure = f.Sure,
                                     Tur=f.Brans.BransAd,
                                     EtkiBolgesi = f.EtkiBolgesi,
                                     KapakFoto = f.KapakFoto,
                                     Video = f.Video,
                                     Tarih = f.Tarih
                                 })
                                .OrderBy(x => x.Tarih).ToList();
            var hepsi = antrenmanList.Where(x => (x.Tarih <= DateTime.Now)).ToList();

            return View(hepsi);
        }

        public class AntrenmanDTO
        {
            public int AntrenmanID { get; internal set; }
            public string Adi { get; internal set; }

            public string Antrenor { get; internal set; }

            public int? Sure { get; internal set; }

            public string Tur { get; internal set; }

            public string EtkiBolgesi { get; internal set; }

            public string KapakFoto { get; internal set; }

            public string Video { get; internal set; }

            public DateTime? Tarih { get; internal set; }

        }
    }
}
