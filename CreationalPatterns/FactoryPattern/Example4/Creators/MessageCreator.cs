using Autofac;
using FactoryPattern.Example4.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Example4.Creators
{
    public class MessageCreator
    {

        public static void Init(ContainerBuilder containerBuilder)
        {
            containerBuilder.Register<Func<MessageType, IMessage>>(c =>
            {
                var container = c.Resolve<IComponentContext>();

                return (type) =>
                {
                    switch (type)
                    {
                        case MessageType.Email:
                            return container.Resolve<LineMessage>();
                        case MessageType.Line:
                            return container.Resolve<EmailMessage>();
                        default:
                            throw new NotSupportedException();
                    }
                };
            });
        }

    }
}
