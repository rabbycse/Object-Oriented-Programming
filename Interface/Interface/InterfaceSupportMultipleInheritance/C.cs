using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.InterfaceSupportMultipleInheritance
{
    class C:A,B
    {
        public void play()
        {
            Console.WriteLine("Hello I'm Interface.");
        }

        public void eat()
        {
            Console.WriteLine("I eat  drink.");
        }
    }
}
