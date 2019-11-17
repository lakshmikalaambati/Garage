using System;
using System.Collections.Generic;
using System.Linq;

namespace Garage1._0
{
    public class GarageHandler 
    {
        private Garage<Vehicle> garage;
        public int indexnum = 0;
        private Vehicle[] svehicles;

        public void CreateGarage(int capacity)
        {
            garage = new Garage<Vehicle>(capacity);
        }

        public void ParkVehicle(Vehicle vehicle)
        {
            garage.Add(vehicle);
        }

        internal void UnParkVehicle(string regno)
        {
            garage.Remove(regno);
        }

        internal void Listallvehicles()
        {
            foreach (var v in garage.Rvehicles)
            {
                if (v.Regno != null)
                {
                    Console.WriteLine(v.Toprint());
                }
                else
                {
                    Console.WriteLine("Vacant Space in Garage");
                }

            }
            Console.WriteLine();
            bool flag = true;
            foreach (var var in garage.Rvehicles)
            {
                if (var.Regno != null)
                {
                    flag = false;
                }

            }
            if (flag == true)
            {
                Console.WriteLine("There are no Vehicles parked in the garage");
                Console.WriteLine();
            }
        }

        public void Findbaseonregno(string regno)
        {
            try
            {
                var v = Array.Find(garage.Rvehicles, v => v.Regno == regno);
                Console.WriteLine(v.Toprint());
            }
            catch (Exception)
            {
                Console.WriteLine($"There are no vehicles with regno:{regno}. ");
            }
        }

        
        internal void Findbaseonproperty(char c,string bcolor, int bwheels)

        {
            switch (c)
            {
                case 'B':
                    try
                    {
                        svehicles = Array.FindAll(garage.Rvehicles, v => v.NoOfWheels == bwheels && string.Equals(v.Color, bcolor, StringComparison.OrdinalIgnoreCase));
                        foreach (var item in svehicles)
                        {
                            Console.WriteLine(item.Toprint());
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine($"There are no vehicles with color: {bcolor}  and wheels: {bwheels} ");
                    }

                    break;
                case 'W':
                    try
                    {
                        svehicles = Array.FindAll(garage.Rvehicles, v => v.NoOfWheels == bwheels);
                        foreach (var item in svehicles)
                        {
                            Console.WriteLine(item.Toprint());
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine($"There are no vehicles with wheels: {bwheels} ");
                    }
                    break;
                case 'C':
                    try
                    {
                        svehicles = Array.FindAll(garage.Rvehicles, v => string.Equals(v.Color,bcolor, StringComparison.OrdinalIgnoreCase));
                        foreach (var item in svehicles)
                        {
                            Console.WriteLine(item.Toprint());
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine($"There are no vehicles with Color: {bcolor} ");
                    }
                    break;

                default:

                    break;
            }

        }
    }
}
