using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using WinFormsApp3.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace WinFormsApp3.Managers
{
    public class ReservationManager : IManager<Reservation>
    {
        private readonly string _connectionString = "Data Source=DESKTOP-1K797I9\\SQLSERVER2022;Initial Catalog=FRONTEND_RESERVATIONn;Integrated Security=True;TrustServerCertificate=True;";
        public bool Add(Reservation item)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = @"
            INSERT INTO Reservations (
                FirstName, LastName, BirthDay, Gender, PhoneNumber, EmailAddress, 
                NumberGuest, StreetAddress, AptSuite, City, State, ZipCode, 
                RoomType, RoomFloor, RoomNumber, TotalBill, PaymentType, 
                CardType, CardNumber, CardExp, CardCvc, ArrivalTime, LeavingTime, 
                CheckIn, Breakfast, Lunch, Dinner, Cleaning, Towel, s_surprise, 
                SupplyStatus, FoodBill
            ) VALUES (
                @FirstName, @LastName, @BirthDay, @Gender, @PhoneNumber, @EmailAddress, 
                @NumberGuest, @StreetAddress, @AptSuite, @City, @State, @ZipCode, 
                @RoomType, @RoomFloor, @RoomNumber, @TotalBill, @PaymentType, 
                @CardType, @CardNumber, @CardExp, @CardCvc, @ArrivalTime, @LeavingTime, 
                @CheckIn, @Breakfast, @Lunch, @Dinner, @Cleaning, @Towel, @s_surprise, 
                @SupplyStatus, @FoodBill
            )";

                int rowsAffected = connection.Execute(query, item);
                return rowsAffected > 0;
            }
        }


        public bool Delete(long id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM Reservations WHERE Id = @Id";
                int rowsAffected = connection.Execute(query, new { Id = id });
                return rowsAffected > 0;
            }
        }

        public List<Reservation> GetAll()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Reservations";
                return connection.Query<Reservation>(query).ToList();
            }
        }

        public Reservation GetByID(long id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Reservations WHERE Id = @Id";
                return connection.QueryFirstOrDefault<Reservation>(query, new { Id = id });
            }
        }

        public bool Update(Reservation reservation)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string updateQuery = @"
                    UPDATE Reservations
                    SET FirstName = @FirstName,
                        LastName = @LastName,
                        BirthDay = @BirthDay,
                        Gender = @Gender,
                        PhoneNumber = @PhoneNumber,
                        EmailAddress = @EmailAddress,
                        NumberGuest = @NumberGuest,
                        StreetAddress = @StreetAddress,
                        AptSuite = @AptSuite,
                        City = @City,
                        State = @State,
                        ZipCode = @ZipCode,
                        RoomType = @RoomType,
                        RoomFloor = @RoomFloor,
                        RoomNumber = @RoomNumber,
                        TotalBill = @TotalBill,
                        PaymentType = @PaymentType,
                        CardType = @CardType,
                        CardNumber = @CardNumber,
                        CardExp = @CardExp,
                        CardCvc = @CardCvc,
                        ArrivalTime = @ArrivalTime,
                        LeavingTime = @LeavingTime,
                        CheckIn = @CheckIn,
                        SupplyStatus = @SupplyStatus,
                        Cleaning = @Cleaning,
                        Towel = @Towel,
                        s_surprise = @s_surprise,
                        Breakfast = @Breakfast,
                        Lunch = @Lunch,
                        Dinner = @Dinner,
                        FoodBill = @FoodBill
                    WHERE Id = @Id";

                int rowsAffected = db.Execute(updateQuery, reservation);
                return rowsAffected > 0;
            }
        }
    }
}


