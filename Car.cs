namespace Garage1._0
{
    public class Car : Vehicle
    {
        public string Fueltype { get; set; }

        public Car(string regno, string color, int noofwheels, string fueltype) : base(regno, color, noofwheels)
        {

            this.Fueltype = fueltype;
        }

        public  override string Toprint()
        {
            return base.Toprint() + $"Fueltype: {Fueltype}";
        }
    }
}