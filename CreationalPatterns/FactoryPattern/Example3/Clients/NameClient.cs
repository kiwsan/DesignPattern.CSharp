using FactoryPattern.Example3.Creators;
using FactoryPattern.Example3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Example3.Clients
{
    public class NameClient
    {

        public void Run()
        {

            NamerCreator namerCreator = new NamerCreator();
            INamer namer = namerCreator.CreateNamer("Hellen Hunt");
            namer.ShowName();

            namer = namerCreator.CreateNamer("Peter,Brian");
            namer.ShowName();

        }

    }
}
