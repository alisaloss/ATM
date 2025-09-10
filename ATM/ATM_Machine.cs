using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class ATM_Machine
    {
        public int id {  get; set; }
        public Branch branch { get; set; }

        public ATM_Machine (int id, Branch branch)
        {
            this.id = id;
            this.branch = branch;
        }

        public void prompt()
        {
            Console.WriteLine("Please insert your card");
        }

        public bool ValidatePin(int pin, Card card)
        {
            if (pin == card.pin) return true;
            return false;
        }

        public bool AcceptCard(Card card)
        {
            if (card.IsLocked)
            {
                Console.WriteLine("Your card is locked");
                return false;
            }
            Console.WriteLine("Enter PIN");
            int pinCode;
            int.TryParse(Console.ReadLine(), out pinCode);
            if (!ValidatePin(pinCode, card)) return false;
            return true;
        }

        public void LockCard(Card card)
        {
            
        }
    }
}
