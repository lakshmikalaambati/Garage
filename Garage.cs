using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Garage1._0
{
    public class Garage<T> : IEnumerable<T> where T : Vehicle
    {

        private readonly int maxcapacity;
        private  Vehicle[] vehicles;
        public Vehicle[] Rvehicles { get => vehicles; }
        public Garage(int maxcapacity)
        {

            this.maxcapacity = Math.Max(0, maxcapacity);
            vehicles = new Vehicle[(this.maxcapacity)];

            for (int i = 0; i < maxcapacity; i++)
            {    
                vehicles[i] = new Vehicle(); 
            }

            
        }
        public bool Add(T item)
        {
            int index = Array.FindIndex(vehicles,v => v.Regno is null);

            if ((index < this.maxcapacity) && (index!=-1))
            {
                vehicles[index] = item;
                return true;
            }
            else
            {
                Console.WriteLine("NO PARKING SPACES LEFT");
                return false;
            }
              
        }

        public bool Remove(string regno)
        {

            int index = Array.FindIndex(vehicles, v => v.Regno == regno);
            if (index != -1)
            {
                vehicles[index] = new Vehicle();
                return true;
            }
            else
            {
                Console.WriteLine($"Garage is not having any vehicle with Reg no :{regno}" );
                return false;
            }
        }

        public int countvehicles(Vehicle[] vehicles)
        {
            var i = Array.FindAll(vehicles, w => w.Regno != null);
            return (i.Length);
        }

        public IEnumerator<T> GetEnumerator()
        {
            //return list.GetEnumerator();
            foreach (T item in vehicles)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
        
    }

}
