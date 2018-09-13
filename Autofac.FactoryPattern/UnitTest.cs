using Autofac.FactoryPattern.Managers;
using Autofac.FactoryPattern.Startup;
using NUnit.Framework;
using System;

namespace Autofac.FactoryPattern
{

    [TestFixture]
    public class UnitTest : NUnitTestBase
    {

        [Test]
        public void TestMethod1()
        {

            var factory = _container.Resolve<Func<MessageType, IMessage>>();

            var emailMessage = factory(MessageType.Email);
            emailMessage.Send("Hi Email..");

            var lineMessage = factory(MessageType.Line);
            lineMessage.Send("Hi Line..");

        }

    }
}
