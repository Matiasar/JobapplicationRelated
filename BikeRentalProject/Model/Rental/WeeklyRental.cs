namespace BikeRentalProject.Model
{
    public class WeeklyRental : IRental
    {
        public WeeklyRental(int weeks)
        {
            Weeks = weeks;
        }

        public int Weeks { get; set; }

        public decimal GetPrice()
        {
            return 60*Weeks;
        }
    }
}
