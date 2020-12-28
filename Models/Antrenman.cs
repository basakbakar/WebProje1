using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebProje1.Models
{
    public class Antrenman
    {
        public int Id { get; set; }

        public string AntrenmanAd { get; set; }

        public int? Sure { get; set; }

        public string EtkiBolgesi { get; set; }

        public string KapakFoto { get; set; }

        public string Video { get; set; }

        public int BransId { get; set; }
        public Brans Brans { get; set; }

        public int AntrenorId { get; set; }
        public Antrenor Antrenor { get; set; }
    }
}
