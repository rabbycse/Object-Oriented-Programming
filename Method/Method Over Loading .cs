using System;
using System.Collections.Generic;
using System.Text;

namespace Method.Advance
{
    class Method
    {
        static void Main(string[] args)
        {
            Console.WriteLine(my_method(5, 6));
            Console.WriteLine(my_method(5, 6, 8));                // method overloading 
            Console.WriteLine(my_method(" Rabbi "));             // method overloading is same method call

            Console.ReadLine();
        }

        public static int my_method( int x, int y)
        {
            return (x + y);
        }

        public static int my_method(int x, int y, int z)
        {
            return (x + y + z);
        }

        public static string my_method(string x)
        {
            string st = "Hello";
            return (st + x);
        }

        
    }

}
