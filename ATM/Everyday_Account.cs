using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Everyday_Account : Account
    {
        public Everyday_Account(string accountNo, double balance, string password, Customer customer) : base(accountNo, balance, password, customer)
        {
        }
    }
}