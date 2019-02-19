using System;
using System.Collections.Generic;
using System.Text;

namespace Composition
{
    class Job
    {
        private string name;
        private double salary;

        public Job()
        {
            Person = new Person(this);
        }

        public Job(string name, double salary)
        {
            this.name = name;
            this.salary = salary;
        }

        private string getName 
        {
            get
            {
                return name;
            }

        }

        public void HowIsTheJob(bool good)
        {
            if(good)
            {
                Person.IsSuccess = true;
            }
            else
            {
                Person.IsSuccess = false;
            }
        }      
    }
}
