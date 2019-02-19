using System;

namespace Inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.setName("Rabbi");
            e.setAge(22);
            e.setQualification("B.Sc in CSE");
            e.display();
            
            

            Console.ReadLine();
        }
    }
}
