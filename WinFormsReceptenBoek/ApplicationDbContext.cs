using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WinFormsReceptenBoek
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Recept> Recepten { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=..\..\..\Files\ReceptenDatabase.db");
        }
    }
}
