using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace WineCellarManager
{

    public class WineDbContext : DbContext
    {
        public DbSet<WineBottle> WineBottles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Specifica il provider del database (ad esempio, SQL Server)
            optionsBuilder.UseSqlServer("\r\nconString = Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=M:\\desktop\\junk_cartelle\\Documents\\WineBottlesDb.mdf;Integrated Security=True;Connect Timeout=30");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configura le proprietà aggiuntive qui, se necessario
            modelBuilder.Entity<WineBottle>()
                .Property(b => b.SellingPrice)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<WineBottle>()
                .Property(b => b.BuyingPrice)
                .HasColumnType("decimal(18,2)");
        }
    }

}
