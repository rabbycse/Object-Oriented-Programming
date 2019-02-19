using System;
using System.Collections.Generic;
using System.Text;

namespace Overloading.Overloading
{
    class Test
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
            p.Bike();

            Child c = new Child();
            c.Bike();

            Parent p1 = new Child();
            p1.Bike();

            Console.ReadLine();
        }
    }
}
