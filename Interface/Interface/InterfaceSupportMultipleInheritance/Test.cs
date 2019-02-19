using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.InterfaceSupportMultipleInheritance
{
    class Test
    {
        static void Main(string[] args)
        {
            C obj = new C();
            obj.play();
            obj.eat();
            
            Console.ReadLine();
        }
    }
}
