using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WinFormsApp3.Context;
using WinFormsApp3.Models;
namespace BenchmarkTestPerformanceTest
{
    public class PerformanceTest
    {
        private readonly string _connectionString = "Data Source=DESKTOP-1K797I9\\SQLSERVER2022;Initial Catalog=FRONTEND_RESERVATIONn;Integrated Security=True;TrustServerCertificate=True;";
       
         private readonly int _id = 4;

    [Benchmark]
    public Reservation? GetReservationByIdEF()
    {
        using (var context = new FRONTEND_RESERVATIONContext())
        {
            return context.Reservations.FirstOrDefault(r => r.Id == _id);
        }
    }

    [Benchmark]
    public Reservation? GetReservationByIdDapper()
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM Reservations WHERE Id = @Id";
            return connection.QueryFirstOrDefault<Reservation>(query, new { Id = _id });
        }
    }

        [Benchmark]
        public List<Reservation> GetReservationsByGenderDapper()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Reservations WHERE Gender = @Gender";
                return connection.Query<Reservation>(query, new { Gender = "Male" }).ToList();
            }
        }

        [Benchmark]
        public List<Reservation> GetReservationsByGenderEF()
        {
            using (var context = new FRONTEND_RESERVATIONContext())
            {
                return context.Reservations
                              .Where(r => r.Gender == "Male")
                              .ToList();
            }
        }


        // EF Core Method
        [Benchmark]
        public List<Reservation> GetReservationsEF()
        {
            using (var context = new FRONTEND_RESERVATIONContext())
            {
                return context.Reservations.ToList();
            }
        }

        // Dapper Method
        [Benchmark]
        public List<Reservation> GetReservationsDapper()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Reservations";
                return connection.Query<Reservation>(query).ToList();
            }
        }


        [Benchmark]
        public Reservation GetReservationByyIdEF()
        {
            using (var context = new FRONTEND_RESERVATIONContext())
            {
                return context.Reservations.Single(r => r.Id == 4);
            }
        }

        [Benchmark]
        public Reservation GetReservationByyIdDapper()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Reservations WHERE Id = @Id";
                return connection.QuerySingle<Reservation>(query, new { Id = 4 });
            }
        }
    }

}

