
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
using static System.Net.Mime.MediaTypeNames;
using BenchmarkTestPerformanceTest.Bogus.Bogus;
namespace BenchmarkTestPerformanceTest
{


 
            public static class Program
            {
                public static void Main()
                {
                    RunBenchmark();
                }

                public static void RunBenchmark()
                {
                     BenchmarkRunner.Run<PerformanceTest>();

                }
            }
        }


        //using var context = new FRONTEND_RESERVATIONContext();

        //context.Database.EnsureCreated(); // Ensure database is created

        //Console.WriteLine("Generating fake data...");

        //// Generate 10,000 fake reservations
        //var fakeReservations = new ReservationFaker().Generate(10000);

        //context.Reservations.AddRange(fakeReservations);
        //context.SaveChanges();

        //Console.WriteLine("10,000 Reservations added!");

