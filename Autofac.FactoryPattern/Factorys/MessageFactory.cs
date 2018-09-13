using Autofac.FactoryPattern.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autofac.FactoryPattern.Factorys
{
    public class MessageFactory
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
