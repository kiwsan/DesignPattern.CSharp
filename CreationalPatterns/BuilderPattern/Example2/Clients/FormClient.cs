using BuilderPattern.Example2.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Example2.Clients
{
    public class FormClient
    {

        public void Run()
        {
            //Ok Form
            OkWindowFormBuilder okWindowFormBuilder = new OkWindowFormBuilder();
            FormDirector formDirector = new FormDirector(okWindowFormBuilder);
            formDirector.Construct("You Create OkForm");

            WindowForm windowForm = okWindowFormBuilder.GetOkForm();

            //Cancel Form
            OkCancelWindowFormBuilder okCancelWindowFormBuilder = new OkCancelWindowFormBuilder();
            formDirector = new FormDirector(okCancelWindowFormBuilder);
            formDirector.Construct("You Create Ok/CancelForm");

            WindowForm okCancelWindowForm = okCancelWindowFormBuilder.GetOkCancelWindowForm();
        }

    }
}
