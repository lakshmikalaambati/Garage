namespace Garage1._0
{
    public class Motorcycle : Vehicle
    {
        public int CylinderVolume { get; set; }

        public Motorcycle(string regno, string color, int noofwheels, int cylindervolume) : base(regno, color, noofwheels)
        {

            this.CylinderVolume = cylindervolume;
        }

        public  override string Toprint()
        {
            return base.Toprint() + $"Cylinder Volume: {CylinderVolume}";
        }
    }
}