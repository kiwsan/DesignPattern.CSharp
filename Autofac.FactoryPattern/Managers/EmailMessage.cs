using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autofac.FactoryPattern.Managers
{
    public class EmailMessage : IMessage
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email message: {message}");
        }
    }
}
