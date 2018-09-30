using FactoryPattern.Example2.Abstracts;
using FactoryPattern.Example2.Creators;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Example2.Clients
{
    public class CalculatorClient
    {

        public void Run()
        {
            int a = 100, b = 500, angle = 90;

            CalculatorCreator calculatorCreator = new CalculatorCreator();
            Calculator calculator = calculatorCreator.CreateCalculator(angle);

            float result = calculator.Calculate(a, b, angle);

            Console.WriteLine($"Result: if Angle is {angle} is {result}");
            Console.WriteLine("*******");

            angle = 0;

            calculator = calculatorCreator.CreateCalculator(angle);

            result = calculator.Calculate(a, b, angle);

            Console.WriteLine($"Result: if Angle is {angle} is {result}");
            Console.WriteLine("*******");

            angle = 30;

            calculator = calculatorCreator.CreateCalculator(angle);

            result = calculator.Calculate(a, b, angle);

            Console.WriteLine($"Result: if Angle is {angle} is {result}");
            Console.WriteLine("*******");
        }

    }
}
