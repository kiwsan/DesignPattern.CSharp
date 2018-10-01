using FactoryPattern.Example4.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Example4
{
    public class LineMessage : IMessage, ILineMessage
    {

        public void Send(string message)
        {
            Console.WriteLine($"Line message: {message}");
        }

    }
}
