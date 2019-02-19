using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction2
{
    class Triangle:Shape
    {
        public Triangle(double x, double y) : base()
        {
            this.x = x;
            this.y = y;
        }

        public override void Area()
        {
            double result = 0.5*x * y;
            Console.WriteLine("Triangle area = {0}", result);
        }
    }
}
