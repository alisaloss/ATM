using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class ATM_Transaction
    {
        public ATM_Machine atm {  get; set; }
        public static int transactionId { get; set; }
        public int transactionIdReceipt { get; set; }
        public DateTime transactionDateTime { get; set; }
        public string recordType { get; set; }
        public int recordAmount { get; set; }

        public ATM_Transaction(ATM_Machine atm, DateTime transactionDateTime)
        {
            this.atm = atm;
            this.transactionDateTime = transactionDateTime;
            transactionIdReceipt = transactionId++;
        }

        public void Action(Card CardInput)
        {
            Random rand = new Random();
            switch (prompt())
            {
                case "0":
                    {
                        Console.WriteLine("Invalid");
                        break;

                    }
                case "1": // Withdraw cash 
                    {
                        string selectedAccount = GetAccount(CardInput);
                        Console.WriteLine("Enter withdrawal amount");
                        int amount = int.Parse(Console.ReadLine());
                        if (amount < CardInput.accounts[int.Parse(selectedAccount)].balance)
                        {
                            CardInput.accounts[int.Parse(selectedAccount)].RemoveFromBalance(amount);
                            Console.WriteLine("Withdraw complete");
                        }
                        break;



                    }
                case "2": // Deposit cash 
                    {
                        int amount = rand.Next(0, 100);
                        string selectedAccount = GetAccount(CardInput);
                        Console.WriteLine("processing deposit");
                        CardInput.accounts[int.Parse(selectedAccount)].AddToBalance(amount);
                        Console.WriteLine("Deposited" + amount);
                        break;

                    }
                case "3": // Deposit cheque
                    {
                        break;
                    }
                case "4": // Check Balance
                    {
                        string selectedAccount = GetAccount(CardInput);
                        Console.WriteLine(CardInput.accounts[int.Parse(selectedAccount)].balance);
                        break;
                    }

            }
            Console.WriteLine("Complete. Returning Card");
            }

        public string GetAccount( Card CardInput)
        {
            Console.WriteLine("Select Account");
            int num = 0;
            if (CardInput.accounts.Count > 0)
            {
                foreach (var account in CardInput.accounts)
                {
                    Console.WriteLine(num++ + "" +account.accountNo);
                }
                return Console.ReadLine() ?? "0";
            }
            return "0";
        }

        private string prompt()
        {
            Console.WriteLine("Please select transaction:");
            Console.WriteLine("1: Withdraw Cash");
            Console.WriteLine("2: Deposit Cash");
            Console.WriteLine("3: Deposit Cheque");
            Console.WriteLine("4: Check Balance");
            Console.WriteLine("5. Cancel");
            return Console.ReadLine() ?? "0";
        }
    }
}
