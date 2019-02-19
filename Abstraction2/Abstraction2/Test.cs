using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction2
{
    class Test
    {
        public static void Main(string[] args)
        {

            Shape r = new Rectangle(10, 20);
            r.Area();

            Shape t = new Triangle(10, 20);
            t.Area();

            Shape c = new Circle(10);
            c.Area();

            Console.ReadLine();
        }
    }
}
