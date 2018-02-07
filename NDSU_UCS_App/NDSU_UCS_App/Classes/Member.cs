using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDSU_UCS_App.Classes
{
    [Serializable]
    public class Member
    {
        //private static int idCounter = 0;
        public int ID { get; private set; }
        public String Name { get; set; }
        public int CurrentBalance { get; private set; } //stored in terms of pennies to avoid decimal issues
        public List<Transaction> Transactions { get; }

        /*public Member ()
        {
            setId();
            Transactions = new List<Transaction>();
            Transactions.Add(new Transaction(0, "Account Created", DateTime.Now));
            CurrentBalance = 0;
        }*/
        public Member(string name, int iD)
        {
            Name = name;
            ID = iD; //only because I can't serialize static variables
            Transactions = new List<Transaction>();
            Transactions.Add(new Transaction(0, "Account Created", DateTime.Now));
            CurrentBalance = 0;
        }

        public void AddTransaction (int amount, string description)
        {
            Transactions.Add(new Transaction(amount, description, DateTime.Now));
            CurrentBalance = CurrentBalance + amount;
        }

        public void SortTransactions ()
        {
            if (Transactions.Count > 1)
            {
                Transactions.Sort((x, y) => x.CompareTo(y));
            }
        }
        public int CompareTo (Member member)
        {
            return Name.CompareTo(member.Name);
        }
    }
}
