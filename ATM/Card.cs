using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Card
    {
        public long cardNumber {  get; set; }
        public Customer owner { get; set; }
        public int pin {  get; set; }
        public bool IsLocked { get; set; }
        public List<Account> accounts { get; set; }

        public Card()
        {
            accounts = new List<Account>();
        }

        public void AddAccount(Account account)
        {
            accounts.Add(account);
        }

        public int NumberOfAccounts()
        {
            return accounts.Count;
        }
    }
}
