using BuilderPattern.Example2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Example2.Builders
{
    public class OkCancelWindowFormBuilder : IWindowFormBuilder
    {
        private WindowForm okCancelWindowForm;
        public OkCancelWindowFormBuilder()
        {
            okCancelWindowForm = new WindowForm("OkCancelWindowForm");
        }

        public void BuildButton()
        {
            okCancelWindowForm.SetOkButton();
            okCancelWindowForm.SetCancelButton();
        }

        public void BuildMessage(string message)
        {
            okCancelWindowForm.BuildMessage(message);
        }

        public WindowForm GetOkCancelWindowForm()
        {
            return okCancelWindowForm;
        }

    }
}
