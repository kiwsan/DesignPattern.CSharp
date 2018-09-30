using FactoryPattern.Example2.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Example2
{
    public class AngleCalculator : Calculator
    {

        public AngleCalculator()
        {
            Console.WriteLine("Angle Calculator is Created.");
        }

        public override float Calculate(int a, int b, int angle)
        {

            return (float)(a * Math.Sin(angle) + b * Math.Cos(angle));

        }

    }
}
