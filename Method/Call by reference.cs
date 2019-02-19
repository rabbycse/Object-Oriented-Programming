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
            int a = 0;

            Console.WriteLine(obj.display(ref a));
            Console.WriteLine(a);

            Console.ReadLine();
        }

        public int display(ref int x)
        {
            return x = 15;
        }
    }

}
