using FactoryPattern.Example1.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Example1.Creators
{
    public class VehicleCreator
    {

        public Vehicle CreateVehicle(string order)
        {
            if (order.Equals("Helicopter"))
            {
                return new Helicopter();
            }
            else
            {
                if (order.Equals("Submarine"))
                {
                    return new Submarine();
                }
                else
                {
                    Console.WriteLine("Out of space.");

                    return null;
                }
            }
        }

    }
}
