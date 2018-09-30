using FactoryPattern.Example3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Example3
{
    public class Couple : INamer
    {

        public Couple(string name1, string name2)
        {
            Name1 = name1;
            Name2 = name2;

            Console.WriteLine("Couple is Created.");
        }

        public string Name1 { get; private set; }

        public string Name2 { get; private set; }

        public void ShowName()
        {
            Console.WriteLine($"We Are {Name1} And {Name2}");
        }

    }
}
