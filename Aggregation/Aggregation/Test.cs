using System;
using System.Collections.Generic;
using System.Text;

namespace Aggregation
{
    class Test
    {
        static void Main(string[] args)
        {
            Address a = new Address("Dhanmondi", "Dhaka", "Bangladesh");
            Employee e = new Employee("Rabby", 1,a);

            e.display();

            Console.ReadLine();
        }
    }
}
