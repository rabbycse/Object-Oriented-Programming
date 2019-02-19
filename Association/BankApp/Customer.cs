using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class Customer
    {
        public string Name { set; get; }
        public string Email { set; get; }

        public Account BankAccount { set; get; }  // Assocition 
    }
}
