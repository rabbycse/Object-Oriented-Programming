using System;
using System.Collections.Generic;
using System.Text;

namespace Method.Advance
{
    class Method
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 15;

            int result = display(a, b); 

            Console.WriteLine("Sum = {0}", result);

            Console.ReadLine();
        }

        public static int display(int x, int y) // static method
        {
            return (x+y);
        }
    }

}
