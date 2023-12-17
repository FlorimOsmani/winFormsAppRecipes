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
            optionsBuilder.UseSqlite(@"Data Source=.\Files\ReceptenDatabase.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your entities, relationships, and properties here
            modelBuilder.Entity<Recept>(entity =>
            {
                // Configure properties
                entity.Property(e => e.Naam).IsRequired();
                entity.Property(e => e.Ingrediënten).IsRequired();
                entity.Property(e => e.Instructies).IsRequired();
                entity.Property(e => e.ImageLink).HasColumnName("ImgurLink"); // Configure ImageLink to map to the existing ImgurLink column
            });
        }
    }
}