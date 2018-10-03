using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Interfaces
{
    public interface IFormDialogFactory
    {

        IForm CreateForm();

        IDialog CreateDialog();

    }
}
