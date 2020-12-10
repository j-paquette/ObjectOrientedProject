using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProject
{
    public class Transaction
    {
       
        /// <summary>
        /// Creates a type to represent a transaction, but doens't have any responsibilities.
        /// Includes a few properties.
        /// </summary>
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }

        /// <summary>
        /// This is to keep an audit, history of each account transaction.
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="date"></param>
        /// <param name="note"></param>
        public Transaction(decimal amount, DateTime date, string note)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;
        }
    }
}
