using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Example2.Interfaces
{
    public interface IWindowFormBuilder
    {

        void BuildMessage(string message);

        void BuildButton();

    }
}
