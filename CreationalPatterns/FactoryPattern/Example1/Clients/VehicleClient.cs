using FactoryPattern.Example1.Abstracts;
using FactoryPattern.Example1.Creators;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Example1.Clients
{
    public class VehicleClient
    {

        public void Run()
        {

            VehicleCreator vehicleCreator = new VehicleCreator();
            int fuelLevel;

            Console.WriteLine("Product First Masterpiece");

            Vehicle helicopter = vehicleCreator.CreateVehicle("Helicopter");
            helicopter.Refuel();

            fuelLevel = helicopter.GetFuel();
            Console.WriteLine($"Current Fuel Level Is : {fuelLevel}");
            helicopter.Move();

            fuelLevel = helicopter.GetFuel();
            Console.WriteLine($"Current Fuel Level Is : {fuelLevel}");

            Console.WriteLine("");
            Console.WriteLine("Product Second Masterpiece");

            Vehicle submarine = vehicleCreator.CreateVehicle("Submarine");
            submarine.Refuel();

            fuelLevel = submarine.GetFuel();
            Console.WriteLine($"Current Fuel Level Is : {fuelLevel}");

            submarine.Move();

            fuelLevel = submarine.GetFuel();
            Console.WriteLine($"Current Fuel Level Is : {fuelLevel}");

            Console.WriteLine("");
            Console.WriteLine("Product Third Masterpiece");

            Vehicle sportCar = vehicleCreator.CreateVehicle("Sport Car");
        }

    }
}
