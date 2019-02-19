using System;
using System.Collections.Generic;
using System.Text;

namespace Association
{
    class Employee
    {
        private string name;

        public Employee() { }

        public Employee(string name)
        {
            this.name = name;
        }

        public string EmployeeName   
        {
            get
            {
                return name;
            }
        }

        public void display(Bank b)
        {
            b.display(this); 
        }

    }
}
