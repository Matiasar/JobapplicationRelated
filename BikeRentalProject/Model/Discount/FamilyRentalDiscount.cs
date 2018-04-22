using BikeRentalProject.Model.Rental;
using System.Linq;

namespace BikeRentalProject.Model.Discount
{
    public class FamilyRentalDiscount : IDiscount
    {
        public decimal ApplyDiscount(RentalCollection rentals)
        {
            var originalPrice = rentals.GetTotalPrice();

            if (IsApplicable(rentals))
            {
                return originalPrice * 0.7m;
            }
            else
            {
                return originalPrice;
            }
        }

        private bool IsApplicable(RentalCollection rentals)
        {
            return Enumerable.Range(3, 3).Contains(rentals.Rentals.Count());
        }
    }
}
