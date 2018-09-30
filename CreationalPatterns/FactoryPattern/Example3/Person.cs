using FactoryPattern.Example3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Example3
{
    public class Person : INamer
    {

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            Console.WriteLine("Person is Created.");
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public void ShowName()
        {
            Console.WriteLine($"My name is {FirstName} {LastName}");
        }

    }
}
