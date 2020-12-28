using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProje1.Models
{
    public class AntrenorAntrenman
    {
        public int Id { get; set; }

        public int AntrenorId { get; set; }
        public int AntrenmanId { get; set; }

        public  Antrenman Antrenman { get; set; }
        public Antrenor Antrenor { get; set; }
    }
}
