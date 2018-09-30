using FactoryPattern.Example1.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Example1
{
    public class Submarine : Vehicle
    {

        public Submarine()
        {

            Console.WriteLine("Hello, I am Submarine.");

            fuelLevel = 0;

        }

        public override int GetFuel()
        {
            return fuelLevel;
        }

        public override void Move()
        {
            Console.WriteLine("Drive Drive Drive!");

            fuelLevel = fuelLevel - 30;
        }

        public override void Refuel()
        {
            Console.WriteLine("Refuel");

            fuelLevel = fuelLevel + 1000;
        }

    }
}
