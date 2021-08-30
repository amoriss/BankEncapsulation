using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount()
        {

        }

        private double balance = 0;

        public void Deposit(double money)
        {
            balance += money;
            Console.WriteLine($" You have deposited this amount: {money} \n" +
                $"This is your balance: {balance}");
        }

        public double GetBalance()
        {
            return balance; 
        }

    }
}
