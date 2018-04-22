namespace BikeRentalProject.Model
{
    public class HourlyRental : IRental
    {
        public HourlyRental(int hours)
        {
            Hours = hours;
        }

        public int Hours { get; set; }

        public decimal GetPrice()
        {
            return 5*Hours;
        }
    }
}
