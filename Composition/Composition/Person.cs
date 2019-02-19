using System;
using System.Collections.Generic;
using System.Text;

namespace Composition
{
    class Person
    {
        private Job job;
        public Boolean IsSuccess = false;

        public Person(Job job)
        {
            this.job = job;
        }

        public bool IsSuccess
        {
            get { return IsSuccess; }
            set { IsSuccess = value;

                if(value)
                {
                    this.job.salary++;
                }
                else
                {
                    this.job.salary--;
                }
            }

    }
}
