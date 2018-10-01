using Autofac;
using FactoryPattern.Example4.Creators;
using FactoryPattern.Example4.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Example4.Startup
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

            //Init Factory
            MessageCreator.Init(builder);

            return builder.Build();
        }

    }
}
