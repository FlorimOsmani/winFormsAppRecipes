using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            if (IsRunningInVisualStudio())
            {
                // For development
                optionsBuilder.UseSqlite(@"Data Source=..\..\..\Files\ReceptenDatabase.db");
            }
            else
            {
                // For live application
                optionsBuilder.UseSqlite(@"Data Source=.\Files\ReceptenDatabase.db");
            }            
        }

        private bool IsRunningInVisualStudio()
        {
            var processName = Process.GetCurrentProcess().ProcessName;
            return processName.ToLower().Contains("devenv");
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