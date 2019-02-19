using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public class UserB:MobileUser
    {
        override public void sendMessage()
        {
            Console.WriteLine("Hi, I'm UserB");
        }
    }
}
