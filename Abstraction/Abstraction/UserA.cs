using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    class UserA:MobileUser
    {

        override public void sendMessage()
        {
            Console.WriteLine("Hi, I'm UserA");
        }
    }
}
