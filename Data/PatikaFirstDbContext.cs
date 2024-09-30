using CodeFirstEFCorePatika.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEFCorePatika.Data
{
    public class PatikaFirstDbContext:DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MERT_TOPCU\\SQLEXPRESS;Database= PatikaCodeFirstDb1;TrustServerCertificate=True;Trusted_Connection=True;");
         
        }
    }
}
