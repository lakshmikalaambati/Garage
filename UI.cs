using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Garage1._0
{
    public class UI
    {

        public enum vehicletypes { airplane, bus, boat, car ,motorcycle};
        public enum optiontypes { color, wheels, both };
        internal static void Run()
        {
            var garagehandler = new GarageHandler();
            int capacity = Util.AskForInt("Please Enter Capacity of Garage to be created: ");
            garagehandler.CreateGarage(capacity);

            bool ExitProgram = false;
            while (!ExitProgram)
            {
                Console.WriteLine("Please Insert through the menu by inputting the number \n(1, 2, 3 ,4,5, 0) of your choice"
                     + "\n1. park the Vehicles"
                     + "\n2. Unpark the Vehicle"
                     + "\n3. List all vehicles parked"
                     + "\n4. Find Vehicles based on Properties "
                     + "\n5. Search based on regno"
                     + "\n0. Exit the application");

                char input=' ';
                try 
                { 
                     input = Console.ReadLine()[0];
                }
                catch (Exception)
                { 
                    Console.WriteLine("Enter valid value beteen 0 to 5"); 
                }
                
                switch (input)
                {


                    case '1':
                        ParkVehicleToGarage(garagehandler);
                        break;

                    case '2':
                        UnParkVehicleToGarage(garagehandler);
                        break;

                    case '3':
                        ListAllVehiclesParked(garagehandler);
                        break;

                    case '4':
                        FindVehiclesbasedonProperties(garagehandler);
                        break;

                    case '5':
                        FindVehiclebasedonregno(garagehandler);

                        break;
                    case '0':
                        ExitProgram = true;
                        break;
                    default:
                        Console.WriteLine($"An unexpected input menu ({input})" +
                            $"Enter valid value between 0 to 5 ");
                        break;
                }

            }


        }

        private static void FindVehiclesbasedonProperties(GarageHandler garagehandler)
        {

            string searchinput = Util.AskForString("Do you want to searchbased on " +
                " color " +
                " wheels " +
                " both ");

            if (Enum.IsDefined(typeof(optiontypes), searchinput))
            {
                switch (searchinput.ToLower())
                {
                    case "color":
                        string coloroption = Util.AskForString("based on which color you want to search");
                        garagehandler.Findbaseonproperty('C', coloroption, 0);
                        break;

                    case "wheels":
                        int noofwheelsoption = Util.AskForInt("based on how many no of wheels you want to search");
                        garagehandler.Findbaseonproperty('W', "all", noofwheelsoption);
                        break;

                    case "both":

                        string bothcolor = Util.AskForString("please specify color");
                        int bothwheels = Util.AskForInt("please specify how many wheels");
                        garagehandler.Findbaseonproperty('B', bothcolor, bothwheels);
                        break;

                    default:
                        Console.WriteLine("please enter either color or wheels or both");
                        break;
                }
            }
            else
            {
                Console.WriteLine($"you have enter value:{searchinput}. please enter valid input" +
                    $"  car  or  wheels or both");
                Console.WriteLine();
            }
        }
        

        private static void FindVehiclebasedonregno(GarageHandler garagehandler)
        {
            
            string regno = Util.AskForString("Please Specify Reg No of Vehicle to be searched");
            garagehandler.Findbaseonregno(regno);
        }

        private static void ListAllVehiclesParked(GarageHandler garagehandler)
        {
            garagehandler.Listallvehicles();
        }

        private static void UnParkVehicleToGarage(GarageHandler garagehandler)
        {
            
            string regno = Util.AskForString("Please Specify Reg No of Vehicle to be unParked");
            garagehandler.UnParkVehicle(regno);
        }

       
        private static void ParkVehicleToGarage(GarageHandler garagehandler)
        {

           
                string Vehicletype = Util.AskForString("Please Specify which Vehicle to be Parked" +
                "\nAirplane" +
                "\nMotorCycle" +
                "\nCar" +
                "\nBus" +
                "\nBoat");
            if (Enum.IsDefined(typeof(vehicletypes), Vehicletype))
            {
                string regNo = Util.AskForString("Reg No of the Vehicle");
                string color = Util.AskForString("Color of the Vehicle");
                int noofwheels = Util.AskForInt("number of wheels");

                switch (Vehicletype.ToLower())
                {
                    case "airplane":

                        int noofengines = Util.AskForInt("number of Engines of airplane");
                        var airplane = new Airplane(regNo, color, noofwheels, noofengines);
                        garagehandler.ParkVehicle(airplane);

                        break;

                    case "motorcycle":

                        int cylindervolume = Util.AskForInt("CylinderVolume of motorcycle");
                        var motorcycle = new Motorcycle(regNo, color, noofwheels, cylindervolume);
                        garagehandler.ParkVehicle(motorcycle);
                        break;

                    case "car":

                        string fueltype = Util.AskForString("FuelType of car");
                        var car = new Car(regNo, color, noofwheels, fueltype);
                        garagehandler.ParkVehicle(car);
                        break;

                    case "bus":

                        int noofseats = Util.AskForInt("No of Seats in bus");
                        var bus = new Bus(regNo, color, noofwheels, noofseats);
                        garagehandler.ParkVehicle(bus);
                        break;

                    case "boat":

                        int length = Util.AskForInt("Length of boat");
                        var boat = new Boat(regNo, color, noofwheels, length);
                        garagehandler.ParkVehicle(boat);
                        break;


                    default:
                        break;
                }

            }
            else
            {
                Console.WriteLine($"you have enter value:{Vehicletype}. please enter valid input");
                Console.WriteLine();
            }
              
           
            
            }
    }
}
