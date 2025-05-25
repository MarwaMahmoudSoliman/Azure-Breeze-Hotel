using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Dapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WinFormsApp3.Models;
using WinFormsApp3.Context;
using Microsoft.Data.SqlClient;
namespace Hotel_Manager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());
            if (MessageBox.Show("Run performance benchmark?", "Benchmark", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                RunBenchmark();
            }
            else
            {
                Application.Run(new Login());
            }

        }
        static void RunBenchmark()
        {
            Task.Run(() =>
            {
              
                var summary = BenchmarkRunner.Run<PerformanceTest>();
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = System.IO.Path.Combine(desktopPath, "benchmark_results.txt");

                System.IO.File.WriteAllText(filePath, summary.ToString());

                MessageBox.Show($"Benchmark saved to: {filePath}");


            });
        }
        public class PerformanceTest
        {
            private readonly string _connectionString = "Data Source=DESKTOP-1K797I9\\SQLSERVER2022;Initial Catalog=FRONTEND_RESERVATIONn;Integrated Security=True;TrustServerCertificate=True;";

            // 1. EF Core Method
            [Benchmark]
            public List<Reservation> GetReservationsEF()
            {
                using (var context = new FRONTEND_RESERVATIONContext())
                {
                    return context.Reservations.AsNoTracking().ToList();
                }
            }

            // 2. Dapper Method
            [Benchmark]
            public List<Reservation> GetReservationsDapper()
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    string query = "SELECT * FROM Reservations";
                    return connection.Query<Reservation>(query).ToList();
                }
            }
        }

    }
}
