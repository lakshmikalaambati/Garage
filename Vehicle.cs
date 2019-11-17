using System;
using System.Collections.Generic;
namespace Garage1._0
{
    public class Vehicle 
    {
        
            public string Regno { get; set; }
            public string Color { get; set; }
            public int NoOfWheels { get; set; }

       
        public Vehicle(string regno, string color, int noofwheels)
            {
                this.Regno = regno;
                this.Color = color;
                this.NoOfWheels = noofwheels;
            }

        public Vehicle()
        {
        }

        public virtual string Toprint()
        {
            return $"Regno: {Regno} Color: {Color} No Of Wheels: {NoOfWheels} ";
        }
   
        
    }
}