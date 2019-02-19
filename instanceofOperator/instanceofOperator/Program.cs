using System;

namespace instanceofOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            Person p = new Person();
            Teacher t = new Teacher();

            Console.WriteLine(a is Animal);  //True -> Animal is an instance of Animal
            Console.WriteLine(p is Animal);  //True -> Person is an instance of Animal
            Console.WriteLine(t is Animal);  //True -> Teacher is an instance of Animal
            Console.WriteLine(t is Person);  //True -> Teacher is an instance of Person
            Console.WriteLine(p is Teacher); //False -> Person is not instance of Teacher

            Console.ReadLine();
        }
    }
}
