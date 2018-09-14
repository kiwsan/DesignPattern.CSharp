using Autofac.FactoryPattern.Factorys;
using Autofac.FactoryPattern.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autofac.FactoryPattern.Startup
{
    public class NativeInjectorBootStrapper
    {

        public static IContainer Registers()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<EmailMessage>().As<IEmailMessage>();
            builder.RegisterType<LineMessage>().As<ILineMessage>();
            builder.RegisterType<EmailMessage>().AsSelf();
            builder.RegisterType<LineMessage>().AsSelf();

            MessageFactory.Init(builder);

            return builder.Build();
        }

    }
}
