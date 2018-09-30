using FactoryPattern.Example1.Abstracts;
using System;

namespace FactoryPattern.Example1
{

    public class Helicopter : Vehicle
    {
        public Helicopter()
        {

            Console.WriteLine("Hello, I am Helicopter.");

            fuelLevel = 0;
        }

        public override int GetFuel()
        {
            return fuelLevel;
        }

        public override void Move()
        {
            Console.WriteLine("Fly Fly Fly!");

            fuelLevel = fuelLevel - 20;
        }

        public override void Refuel()
        {
            Console.WriteLine("Refuel");

            fuelLevel = fuelLevel + 500;
        }

    }
}