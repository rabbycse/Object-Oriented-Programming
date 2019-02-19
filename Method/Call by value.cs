using System;
using System.Collections.Generic;
using System.Text;

namespace Method.Advance
{
    class Method
    {
        static void Main(string[] args)
        {
            Method obj = new Method();

            Console.WriteLine(obj.display(5,10));

            Console.ReadLine();
        }

        public int display(int a, int b)
        {
            return (a+b);
        }
    }

}
