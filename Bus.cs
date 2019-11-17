namespace Garage1._0
{
    public class Bus : Vehicle
    {
        public int Noofseats { get; set; }

        public Bus(string regno, string color, int noofwheels, int noofseats) : base(regno, color, noofwheels)
        {

            this.Noofseats = noofseats;
        }

        public  override string Toprint()
        {
            return base.Toprint() + $"No of seats: {Noofseats}";
        }
    }
}