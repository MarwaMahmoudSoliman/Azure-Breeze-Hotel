using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using WinFormsApp3.Models;
namespace WinFormsApp3.Context
{
   

    public class FRONTEND_RESERVATIONContext : DbContext
    {
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-1K797I9\\SQLSERVER2022;Initial Catalog=FRONTEND_RESERVATIONn;Integrated Security=True;TrustServerCertificate=True;");
        }
    }

}
