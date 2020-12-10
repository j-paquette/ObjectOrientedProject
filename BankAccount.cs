using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProject
{
    public class BankAccount
    {
        /// <summary>
        /// This is a data member. It is private, it can only be accessed by code inside the BankAccount class.
        /// How account numbers are generated are kept private, and shared by all the BankAccount objects.
        /// </summary>
        private static int accountNumberSeed = 1234567890;

        /// <summary>
        /// Followed this tutorial: https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/intro-to-csharp/introduction-to-classes
        /// </summary>
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get; }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {

        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {

        }

        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Balance = initialBalance;
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }
    }
}
