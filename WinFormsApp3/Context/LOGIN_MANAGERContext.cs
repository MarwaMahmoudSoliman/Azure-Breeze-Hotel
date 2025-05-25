using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp3.Models;
using Microsoft.EntityFrameworkCore;
namespace WinFormsApp3.Context
{


 

    namespace WinFormsApp3.Context
    {
        public class LOGIN_MANAGERContext : DbContext
        {
            public DbSet<FrontendUser> FrontendUsers { get; set; }
            public DbSet<KitchenUser> KitchenUsers { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-1K797I9\\SQLSERVER2022;Initial Catalog=LOGIN_MANAGERr;Integrated Security=True;TrustServerCertificate=True;");
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<FrontendUser>().ToTable("frontend");
                modelBuilder.Entity<KitchenUser>().ToTable("kitchen");
            }
        }
    }

}
