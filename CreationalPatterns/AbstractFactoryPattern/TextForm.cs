using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class TextForm : IForm
    {

        public void DrawForm()
        {
            Console.WriteLine("Draw Form");
        }

    }
}
