using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimpleCalc.Data.Models;

namespace SimpleCalc.Data
{
    internal class SimpleCalcDbContext : DbContext
    {
        public DbSet<CalculationHistory> CalculationHistory { get; set; } // Initiate calculation history table
        public DbSet<CurrencyRate> CurrencyRate { get; set; } // Initiate currency rates table

        // Db connection config
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = simpleCalc.db"); // SQLite db file in project dir
        }

        // Table mapping config
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CalculationHistory>().ToTable("CalculationHistory");
            modelBuilder.Entity<CurrencyRate>().ToTable("CurrencyRate");
        }
       
       
    }
}
