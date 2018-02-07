using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDSU_UCS_App.Classes
{
    [Serializable]
    public class Transaction
    {
        public int Amount { get; } //stored in terms of pennies to avoid decimal issues
        public string Description { get; }
        public DateTime DateTime { get; }

        public Transaction(int amount, string description, DateTime dateTime)
        {
            Amount = amount;
            Description = description;
            DateTime = dateTime;
        }
        public int CompareTo(Transaction transaction)
        {
            return DateTime.CompareTo(transaction.DateTime);
        }
    }
}
