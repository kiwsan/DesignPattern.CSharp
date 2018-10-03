using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Factorys
{
    public class TextFormDialogFactory : IFormDialogFactory
    {

        public IDialog CreateDialog()
        {

            return new TextDialog();
        }

        public IForm CreateForm()
        {

            return new TextForm();
        }

    }
}
