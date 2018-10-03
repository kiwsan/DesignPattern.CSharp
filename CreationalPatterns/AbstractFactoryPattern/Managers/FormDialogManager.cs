using AbstractFactoryPattern.Factorys;
using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Managers
{
    public class FormDialogManager
    {

        public IFormDialogFactory GetConcreteFactory(string displayMode)
        {
            if (displayMode.Equals("G"))
            {
                IFormDialogFactory formDialogFactory = new GraphicFormDialogFactory();
                return formDialogFactory;
            }
            else
            {
                IFormDialogFactory formDialogFactory = new TextFormDialogFactory();
                return formDialogFactory;
            }
        }

    }
}
