using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class TextDialog : IDialog
    {

        public void DrawDialog()
        {

            Console.WriteLine("Dialog");

        }

    }
}
