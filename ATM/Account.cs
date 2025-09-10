using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Account
    {
        public string accountNo { get; set; }
        public double balance { get; set; }
        public string password { get; set; }

        public Customer customer { get; set; }

        public Account(string accountNo, double balance, string password, Customer customer)
        {
            this.accountNo = accountNo;
            this.balance = balance;
            this.password = password;
            this.customer = customer;
        }

        public bool AddToBalance(double addition)
        {
            if (addition < 0) return false;
            balance += addition;
            return true;
        }

        public bool RemoveFromBalance(double subtraction)
        {
            if (subtraction < 0) return false;
            balance -= subtraction;
            return true;
        }

        public bool login()
        {
            if (this.accountNo == accountNo && this.password == password) return true;
            return false;
        }
    }
}
