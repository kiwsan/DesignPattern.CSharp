using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autofac.FactoryPattern.Startup
{
    public class NUnitTestBase
    {

        protected IContainer _container;
        [SetUp]
        public void BaseSetUp()
        {

            _container = NativeInjectorBootStrapper.Registers();

        }

        [TearDown]
        public void BaseTearDown()
        {

        }

    }
}
