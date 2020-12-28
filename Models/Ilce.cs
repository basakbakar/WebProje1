using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebProje1.Models
{
    public class Ilce
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public string IlceAd { get; set; }

        public int? IlId { get; set; }
        public Il Il { get; set; }
    }
}
