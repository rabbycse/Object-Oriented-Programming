using System;
using System.Collections.Generic;
using System.Text;

namespace Method.Advance
{
    class Room
    {
        public double height;
        public double width;

        public double Area()
        {
            return height * width;
        }
    }

    class ClassObject
    {
        static void Main(string[] args)
        {
            Room obj1 = new Room();
            obj1.height = 20;
            obj1.width = 10;
            double result1 = obj1.Area();
            Console.WriteLine("Bed room area = {0}", result1);

            Room obj2 = new Room();
            obj2.height = 10;
            obj2.width = 8;
            double result2 = obj2.Area();
            Console.WriteLine("Wash room area = {0}", result2);

            Room obj3 = new Room();
            obj3.height = 5;
            obj3.width = 4;
            double result3 = obj3.Area();
            Console.WriteLine("Kitchen room area = {0}", result3);

            Console.ReadLine();
        }
    }
}
