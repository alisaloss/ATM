using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class CreditAccount : Account
    {
        public CreditAccount(string accountNo, double balance, string password, Customer customer) : base(accountNo, balance, password, customer)
        { 
        }

        private int creditLimit {  get; set; }
        private float creditInterestRate { get; set; }

        public void SetCreditLimit(int creditLimit)
        {
            this.creditLimit = creditLimit;
        }

        public void setCreditInterestRate(float creditInterestRate)
        {
            this.creditInterestRate = creditInterestRate;
        }

        public void ChargeInterest()
        {
            balance = balance - ((creditInterestRate/100) * balance);
        }
    }
}
