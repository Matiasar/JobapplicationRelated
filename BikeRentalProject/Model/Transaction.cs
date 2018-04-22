using BikeRentalProject.Model.Discount;
using BikeRentalProject.Model.Rental;
using System;

namespace BikeRentalProject.Model
{
    public class Transaction
    {
        public Transaction()
        {
            Rentals = new RentalCollection();
        }

        public RentalCollection Rentals { get; set; }

        public IDiscount Discount { get; set; }

        public DateTime Moment { get; set; }

        public Boolean Paid { get; set; }

        public Customer Customer { get; set; }

        public decimal GetPrice()
        {
            decimal? rentalPrice = Rentals.GetTotalPrice();

            if (rentalPrice.HasValue)
            {
                decimal? priceAfterDiscount = Discount?.ApplyDiscount(Rentals);

                return priceAfterDiscount.HasValue ? priceAfterDiscount.Value : rentalPrice.Value;
            }

            else
            {
                return 0;
            }
        }
    }
}
