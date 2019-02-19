using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction2
{
    class Rectangle:Shape
    {
        public Rectangle(double x, double y) :base()
        {
            this.x = x;
            this.y = y;
        }

        public override void Area()
        {
            double result = x * y;
            Console.WriteLine("Rectangle area = {0}", result);
        }
    }
}
