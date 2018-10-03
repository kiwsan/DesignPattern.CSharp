using AbstractFactoryPattern.Interfaces;
using AbstractFactoryPattern.Managers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Clients
{
    public class FactoryClient
    {

        public void Run()
        {

            FormDialogManager formDialogManager = new FormDialogManager();

            //Build Graphic
            IFormDialogFactory formDialogFactory = formDialogManager.GetConcreteFactory("G");
            IDialog graphicDialog = formDialogFactory.CreateDialog();
            graphicDialog.DrawDialog();
            IForm graphicForm = formDialogFactory.CreateForm();
            graphicForm.DrawForm();

            //Build Text
            formDialogFactory = formDialogManager.GetConcreteFactory("T");
            IDialog textDialog = formDialogFactory.CreateDialog();
            textDialog.DrawDialog();
            IForm textForm = formDialogFactory.CreateForm();
            textForm.DrawForm();
        }

    }
}
