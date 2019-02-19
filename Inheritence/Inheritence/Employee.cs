using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence
{
    class Employee : Person
    {
        private string qualification;

       
        public string getQualification
        {
            get
            {
                return qualification;
            }
        }
        public void setQualification(string qualification) 
        {
            this.qualification = qualification;
        }

        public void display()
        {
            Console.WriteLine("Name: " + getName);
            Console.WriteLine("Age: " + getAge);
            Console.WriteLine("Qualification: " + getQualification);
        }
    }
}
