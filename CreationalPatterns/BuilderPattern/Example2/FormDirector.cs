using BuilderPattern.Example2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Example2
{
    public class FormDirector
    {
        private IWindowFormBuilder _windowFormBuilder;
        public FormDirector(IWindowFormBuilder _windowFormBuilder)
        {
            this._windowFormBuilder = _windowFormBuilder;
        }

        public void Construct(string message)
        {
            _windowFormBuilder.BuildMessage(message);
            _windowFormBuilder.BuildButton();
        }

    }
}
