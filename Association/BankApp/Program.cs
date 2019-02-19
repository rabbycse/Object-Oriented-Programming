using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account anAccount = new Account();
            anAccount.AccountNo = "R007";
            anAccount.OpeningDate = "04/02/2019";

            Customer aCustomer = new Customer();
            aCustomer.Name = "Rabbi";
            aCustomer.Email = "rabby@yahoo.com";
            aCustomer.BankAccount = anAccount;

            aCustomer.BankAccount.Deposit(10000); // When a object with another object relation is called by assocition
            aCustomer.BankAccount.Withdraw(500);
        }
    }
}
