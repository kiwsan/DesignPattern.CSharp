using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Example1
{
    public class Furniture
    {

        private string furnitureType;

        public Furniture(string furnitureType)
        {
            this.furnitureType = furnitureType;
        }

        public string GetFurnitureType() {
            return furnitureType;
        }

    }
}
