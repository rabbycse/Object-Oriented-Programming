using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction2
{
    class Circle:Shape
    {
        public Circle(double x) : base()
        {
            this.x = x;
        }

        public override void Area()
        {
            double result =  Math.PI*x * x;
            Console.WriteLine("Circle area = {0}", result);
        }
    }
}
