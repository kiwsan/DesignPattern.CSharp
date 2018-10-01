using Autofac;
using FactoryPattern.Example4.Interfaces;
using FactoryPattern.Example4.Startup;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Example4.Clients
{
    public class MessageClient
    {

        public void Run()
        {

            IContainer _container = NativeInjectorBootStrapper.Registers();

            var factory = _container.Resolve<Func<MessageType, IMessage>>();

            var emailMessage = factory(MessageType.Email);
            emailMessage.Send("Hi Email..");

            var lineMessage = factory(MessageType.Line);
            lineMessage.Send("Hi Line..");

        }

    }
}
