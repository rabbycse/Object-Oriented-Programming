using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class Account
    {
        public string AccountNo { set; get; }
        public string OpeningDate { set; get; }
        public double Balance { private set; get; }

        public Account(string accountNo, string openingDate) :this()
        {
            AccountNo = accountNo;
            OpeningDate = openingDate;
        }

        public Account()
        {
            Balance = 0;                            //'has' fild level and 'uses' method parameter level
        }

        public void Deposit(double amount)
        {
            Calculator aCalculator = new Calculator();
            Balance = aCalculator.Add(Balance, amount);
        }

        public void Withdraw(double amount)
        {
            Calculator anCalculator = new Calculator();
            Balance = anCalculator.Subtract(Balance, amount);
        }
    }
}
