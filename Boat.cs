namespace Garage1._0
{
    public class Boat : Vehicle
    {
        public int Length { get; set; }

        public Boat(string regno, string color, int noofwheels, int length) : base(regno, color, noofwheels)
        {

            this.Length = length;
        }

        public  override string Toprint()
        {
            return base.Toprint() + $"Length: {Length}";
        }
    }
}