using System;
using System.Collections.Generic;
using System.Text;

namespace Association
{
    class Bank
    {
        private string name;

        public Bank() { }

        public Bank(string name)
        {
            this.name = name;
        }

        public string BankName 
        {
            get
            {
                return name;
            }
        }

        public void display(Employee e)
        {
            e.display(this);
        }

    }
}
