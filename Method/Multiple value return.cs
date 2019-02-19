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

            int sum, sub;

            My_method(a, b, out sum, out sub);  // multiple value

            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Sub = {0}", sub);

            Console.ReadLine();
        }

        public static void My_method(int a, int b, out int sum, out int sub)
        {
            sum = a + b;
            sub = a - b;
        }

        
    }

}
