using FactoryPattern.Example2.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Example2.Creators
{
    public class CalculatorCreator
    {

        public Calculator CreateCalculator(int angle)
        {
            if (angle == 0 || angle == 90)
            {
                return new NormalCalculator();
            }
            else
            {
                return new AngleCalculator();
            }
        }

    }
}
