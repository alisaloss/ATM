using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Cheque_Account : Account
    {
        public Cheque_Account(string accountNo, double balance, string password, Customer customer) : base(accountNo, balance, password, customer)
        {
        }
    }
}
