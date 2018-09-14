using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autofac.FactoryPattern.Managers
{
    public class LineMessage : IMessage, ILineMessage
    {

        public void Send(string message)
        {
            Console.WriteLine($"Line message: {message}");
        }

    }
}
