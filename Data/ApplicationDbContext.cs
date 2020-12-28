using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebProje1.Models;

namespace WebProje1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Antrenman> Antrenman { get; set; }

        public DbSet<Antrenor> Antrenor { get; set; }

        public DbSet<Brans> Brans { get; set; }
    }
}
