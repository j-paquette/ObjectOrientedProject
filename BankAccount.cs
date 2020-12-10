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
        /// Followed this tutorial: https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/intro-to-csharp/introduction-to-classes
        /// </summary>
        public string Number { get; }
        public string Owner { get; set; }
        
        /// <summary>
        /// Use this property to compute the balance.
        /// It sums the values of all transactions.
        /// The calculation 
        /// </summary>
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach(var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            } 
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }

        /// <summary>
        /// This is a data member. It is private, it can only be accessed by code inside the BankAccount class.
        /// How account numbers are generated are kept private, and shared by all the BankAccount objects.
        /// </summary>
        private static int accountNumberSeed = 1234567890;

        /// <summary>
        /// A constructor to assign the values. 
        /// Used to initialize objects of the BankAccount type
        /// </summary>
        /// <param name="name"></param>
        /// <param name="initialBalance"></param>
        public BankAccount(string name, decimal initialBalance)
        {
            //this.Balance = initialBalance;
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;

            this.Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        }
        /// <summary>
        /// TransactionalDeclaration
        /// </summary>
        private List<Transaction> allTransactions = new List<Transaction>();

    }
}
