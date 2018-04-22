using System.Collections.Generic;
using System.Linq;

namespace BikeRentalProject.Model.Rental
{
    public class RentalCollection
    {
        public RentalCollection()
        {
            rentalCollection = new List<IRental>();
        }

        private IList<IRental> rentalCollection;

        public IEnumerable<IRental> Rentals { get => rentalCollection; }

        public void AddRental(IRental rental) => rentalCollection.Add(rental);

        public bool RemoveRental(IRental rental) => rentalCollection.Remove(rental);

        public decimal GetTotalPrice() => Rentals.Select(x => x.GetPrice()).Sum();
    }
}
