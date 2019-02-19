using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat();
            c.eat();
            Dog d = new Dog();
            d.eat();

            Console.ReadLine();
        }
    }
}
