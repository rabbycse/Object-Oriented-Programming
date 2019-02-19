using System;
using System.Collections.Generic;
using System.Text;

namespace Association
{
    class Test
    {
        public static void Main(string[] args)
        {
            Bank b = new Bank("Asia");
            Employee e = new Employee("Rabbi");

            Console.WriteLine(b.BankName);
            Console.WriteLine(e.EmployeeName);
      
            Console.ReadLine();
        }
    }
}