using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BenchmarkTestPerformanceTest.Bogus;
using WinFormsApp3.Models;
using System;
using Bogus;

namespace BenchmarkTestPerformanceTest.Bogus.Bogus
{
    public class ReservationFaker : Faker<Reservation>
    {
        public ReservationFaker()
        {
            RuleFor(r => r.FirstName, f => f.Name.FirstName());
            RuleFor(r => r.LastName, f => f.Name.LastName());
            RuleFor(r => r.BirthDay, f => f.Date.Past(30).ToShortDateString());
            RuleFor(r => r.Gender, f => f.PickRandom("Male", "Female"));
            RuleFor(r => r.PhoneNumber, f => f.Phone.PhoneNumber());
            RuleFor(r => r.EmailAddress, f => f.Internet.Email());
            RuleFor(r => r.NumberGuest, f => f.Random.Int(1, 10));
            RuleFor(r => r.StreetAddress, f => f.Address.StreetAddress());
            RuleFor(r => r.AptSuite, f => f.Address.SecondaryAddress());
            RuleFor(r => r.City, f => f.Address.City());
            RuleFor(r => r.State, f => f.Address.State());
            RuleFor(r => r.ZipCode, f => f.Address.ZipCode());
            RuleFor(r => r.RoomType, f => f.PickRandom("Deluxe", "Suite", "Standard"));
            RuleFor(r => r.RoomFloor, f => f.Random.Int(1, 10).ToString());
            RuleFor(r => r.RoomNumber, f => f.Random.Int(100, 999).ToString());
            RuleFor(r => r.TotalBill, f => f.Random.Double(100, 5000));
            RuleFor(r => r.PaymentType, f => f.PickRandom("Credit", "Cash", "Debit"));
            RuleFor(r => r.CardType, f => f.PickRandom("Visa", "MasterCard", "Amex"));
            RuleFor(r => r.CardNumber, f => f.Finance.CreditCardNumber());
            RuleFor(r => r.CardExp, f => f.Date.Future().ToString("MM/yy"));
            RuleFor(r => r.CardCvc, f => f.Random.Int(100, 999).ToString());
            RuleFor(r => r.ArrivalTime, f => f.Date.Past());
            RuleFor(r => r.LeavingTime, f => f.Date.Future());
            RuleFor(r => r.CheckIn, f => f.Random.Bool());
            RuleFor(r => r.Breakfast, f => f.Random.Int(0, 1));
            RuleFor(r => r.Lunch, f => f.Random.Int(0, 1));
            RuleFor(r => r.Dinner, f => f.Random.Int(0, 1));
            RuleFor(r => r.Cleaning, f => f.Random.Bool());
            RuleFor(r => r.Towel, f => f.Random.Bool());
            RuleFor(r => r.s_surprise, f => f.Random.Bool());
            RuleFor(r => r.SupplyStatus, f => f.Random.Bool());
            RuleFor(r => r.FoodBill, f => f.Random.Int(50, 500));
        }
    }
}


