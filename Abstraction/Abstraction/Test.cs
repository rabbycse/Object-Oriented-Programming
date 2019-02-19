using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    class Test
    {
        public static void Main(string[] args)
        {
            MobileUser a = new UserA();
            a.call();
            a.sendMessage();

            MobileUser b = new UserB();
            b.sendMessage();

            Console.ReadLine();
        }
    }
}
