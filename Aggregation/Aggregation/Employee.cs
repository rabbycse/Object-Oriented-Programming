using System;
using System.Collections.Generic;
using System.Text;

namespace Aggregation
{
    class Employee
    {
        public string name;
        public int id;
        public Address address;

        public Employee(string name, int id, Address address)
        {
            this.name = name;
            this.id = id;
            this.address = address;
        }

        public void display()
        {
            Console.WriteLine("Id: {0}", id);
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("City: {0}", address.City);
            Console.WriteLine("District: {0}", address.District);
            Console.WriteLine("Country: {0}", address.Country);
        }
    }
}
