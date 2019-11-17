using Garage1._0;
using System;
using Xunit;

namespace GarageUnitTests
{
    public class GarageTests
    {
        [Fact]
        public void CreateArray_WithCapacity_ReturnsCapacity()
        {
            const int expected = 10;
            var vehicles = new Vehicle[expected];
            //Act
            var actual = vehicles.Length;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CreateArray_WithZeroCapacity_Works()
        {
            var garage = new Garage<Vehicle>(0);
            const int expected = 0;
            var vehicles = new Vehicle[expected];
            var actual = vehicles.Length;
            var vehicle = new Vehicle( "1211", "red", 4);
            
            bool added = garage.Add(vehicle);

            Assert.Equal(expected, actual);
            Assert.False(added);
        }

        [Fact]
        public void Add_ToFullarray_Returnstrue()
        {
            const int expected = 2;
            var garage = new Garage<Vehicle>(2);
           var vehicles = new Vehicle[expected];
            var vehicle1 = new Vehicle("1211", "red", 4);
            var vehicle2 = new Vehicle("2222", "white", 4);


            var actual = vehicles.Length;
            bool added1 = garage.Add(vehicle1);
            bool added2= garage.Add(vehicle2);

            
                 
            Assert.Equal(expected, actual);
            Assert.True(added1);
            Assert.True(added1);



        }

        [Fact]
        public void Add_Tonotfullarray_Returnstrue()
        {
            const int expected = 2;
            var garage = new Garage<Vehicle>(2);
            var vehicles = new Vehicle[expected];
            var vehicle1 = new Vehicle("1211", "red", 4);
            


            var actual = vehicles.Length;
            bool added1 = garage.Add(vehicle1);
      
            Assert.Equal(expected, actual);
            Assert.True(added1);
          
        }

        [Fact]
        public void Remove_fullarray_Returnstrue()
        {
            const int expected = 1;
            var garage = new Garage<Vehicle>(1);
            var vehicles = new Vehicle[expected];
            var vehicle1 = new Vehicle("1211", "red", 4);



            var actual = vehicles.Length;
            bool added1 = garage.Add(vehicle1);
            bool remove = garage.Remove("1211");

            Assert.Equal(expected, actual);
            Assert.True(added1);
            Assert.True(remove);

        }

        [Fact]
        public void Remove_notFullarray_Returnstrue()
        {
            const int expected = 2;
            var garage = new Garage<Vehicle>(2);
            Vehicle[] vehicles = new Vehicle[]
            { new Vehicle("1111", "white", 4),
              new Vehicle("2222", "red", 4) };
          
            var actual = vehicles.Length;
            bool added1 = garage.Add(vehicles[0]);
            bool added2 = garage.Add(vehicles[1]);
            bool remove = garage.Remove("2222");
            int vehiclesremaining = garage.countvehicles(vehicles);


            Assert.Equal(expected, actual);
            Assert.True(added1);
            Assert.True(added1);
            Assert.True(remove);
            Assert.Equal(expected, actual);
           






        }

    }
}
