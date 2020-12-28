using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProje1.Models
{
    public class SporSalon
    {
        public int Id { get; set; }

        public string SporSalonAd { get; set; }

        public int? IlceId { get; set; }
        public Ilce Ilce { get; set; }

        public string Iletisim { get; set; }

        public string Adres { get; set; }

    }
}
