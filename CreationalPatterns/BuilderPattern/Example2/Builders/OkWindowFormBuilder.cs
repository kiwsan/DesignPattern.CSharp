using BuilderPattern.Example2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Example2.Builders
{
    public class OkWindowFormBuilder : IWindowFormBuilder
    {
        private WindowForm okWindowForm;
        public OkWindowFormBuilder()
        {
            okWindowForm = new WindowForm("OkForm");
        }

        public void BuildButton()
        {
            okWindowForm.SetOkButton();
        }

        public void BuildMessage(string message)
        {
            okWindowForm.BuildMessage(message);
        }

        public WindowForm GetOkForm()
        {
            return okWindowForm;
        }

    }
}
