using BikeRentalProject.Model.Rental;

namespace BikeRentalProject.Model.Discount
{
    public interface IDiscount
    {
        decimal ApplyDiscount(RentalCollection rentals);
    }
}
