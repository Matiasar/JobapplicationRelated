using BikeRentalProject.Model;
using BikeRentalProject.Model.Discount;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BikeRentalProjectTest
{
    [TestClass]
    public class BikeRentalTransactionTest
    {
        private const decimal hourlyRatePrice = 5;
        private const decimal dailyRatePrice = 20;
        private const decimal weeklyRatePrice = 60;

        [TestMethod]
        public void HourlyRentalPrice()
        {
            var hours = 3;

            Assert.AreEqual(hours * hourlyRatePrice, new HourlyRental(hours).GetPrice());
        }

        [TestMethod]
        public void DailyRentalPrice()
        {
            var days = 4;

            Assert.AreEqual(days * dailyRatePrice, new DailyRental(days).GetPrice());
        }

        [TestMethod]
        public void WeeklyRentalPrice()
        {
            var weeks = 2;

            Assert.AreEqual(weeks * weeklyRatePrice, new WeeklyRental(weeks).GetPrice());
        }

        [TestMethod]
        public void FamilyRentalDiscountApplied()
        {
            var transaction = new Transaction();
            transaction.Discount = new FamilyRentalDiscount();
            transaction.Rentals.AddRental(new DailyRental(2));
            transaction.Rentals.AddRental(new DailyRental(1));
            transaction.Rentals.AddRental(new DailyRental(4));
            Assert.AreEqual(98, transaction.GetPrice());
        }

        [TestMethod]
        public void OneEachRental()
        {
            var transaction = new Transaction();
            transaction.Discount = new FamilyRentalDiscount();
            transaction.Rentals.AddRental(new DailyRental(3));
            transaction.Rentals.AddRental(new WeeklyRental(5));
            transaction.Rentals.AddRental(new HourlyRental(2));
            Assert.AreEqual(259, transaction.GetPrice());
        }

        [TestMethod]
        public void MultipleRentalWithoutPromotion()
        {
            var transaction = new Transaction();
            transaction.Discount = new FamilyRentalDiscount();
            transaction.Rentals.AddRental(new DailyRental(3));
            transaction.Rentals.AddRental(new WeeklyRental(5));
            transaction.Rentals.AddRental(new HourlyRental(2));
            transaction.Rentals.AddRental(new HourlyRental(2));
            transaction.Rentals.AddRental(new HourlyRental(2));
            transaction.Rentals.AddRental(new HourlyRental(2));
            Assert.AreEqual(400, transaction.GetPrice());
        }

        [TestMethod]
        public void RentalZero()
        {
            var transaction = new Transaction();
            transaction.Rentals.AddRental(new DailyRental(0));
            Assert.AreEqual(0, transaction.GetPrice());
        }
    }
}
