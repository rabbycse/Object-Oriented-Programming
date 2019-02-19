using System;
using System.Collections.Generic;
using System.Text;

namespace UML
{
    class SpaceCraft
    {
        protected string model;

        public SpaceCraft() { }
        public void display()
        {
            Console.WriteLine("Model: {0}", model);
        }
    }
}
