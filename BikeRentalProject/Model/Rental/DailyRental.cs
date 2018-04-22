namespace BikeRentalProject.Model
{
    public class DailyRental : IRental
    {
        public DailyRental(int days)
        {
            Days = days;
        }

        public int Days { get; set; } 

        public decimal GetPrice()
        {
            return 20*Days;
        }
    }
}
