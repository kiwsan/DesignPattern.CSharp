using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Factorys
{
    public class GraphicFormDialogFactory : IFormDialogFactory
    {

        public IDialog CreateDialog()
        {

            return new GraphicDialog();
        }

        public IForm CreateForm()
        {

            return new GraphicForm();
        }

    }
}
