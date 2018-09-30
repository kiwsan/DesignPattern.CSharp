using FactoryPattern.Example3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Example3.Creators
{
    public class NamerCreator
    {

        public INamer CreateNamer(string namePhrase)
        {

            int indexOfComma = namePhrase.IndexOf(",");
            int indexOfSpace = namePhrase.IndexOf(" ");

            if (indexOfComma != -1)
            {
                string name1 = namePhrase.Substring(0, indexOfComma);
                string name2 = namePhrase.Substring(indexOfComma + 1, namePhrase.Length);

                return new Couple(name1, name2);
            }

            if (indexOfSpace != -1)
            {
                string firstName = namePhrase.Substring(0, indexOfSpace);
                string lastName = namePhrase.Substring(indexOfSpace + 1, namePhrase.Length);

                return new Person(firstName, lastName);
            }

            return null;
        }

    }
}
