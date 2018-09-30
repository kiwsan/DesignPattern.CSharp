using FactoryPattern.Example2.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Example2
{
    public class NormalCalculator : Calculator
    {

        public NormalCalculator()
        {
            Console.WriteLine("Normal Calculator is Created.");
        }

        public override float Calculate(int a, int b, int angle)
        {
            if (angle == 0)
            {
                return b;
            }
            else if (angle == 90)
            {
                return a;
            }
            else
            {
                return 0;
            }
        }

    }
}
