using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public abstract class MobileUser
    {
        public abstract void sendMessage();

        public void call()
        {
            Console.WriteLine("Hi, I'm Non-Abstract Method");
        }
    }
}
