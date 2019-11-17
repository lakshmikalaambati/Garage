using System;
using System.Collections.Generic;
namespace Garage1._0
{
    internal class Airplane : Vehicle
    {
        
        public int NoOfEngines { get; set; }
        
        public Airplane(string regno, string color, int noofwheels,int noOfEngines) : base(regno, color, noofwheels)  
        {

            this.NoOfEngines = noOfEngines;
        }


        
        public  override string Toprint()
        {
            return base.Toprint() + $"No Of Engines: {NoOfEngines}";
        }

        

    }
}