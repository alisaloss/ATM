using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Customer
    {
        public string firstName {  get; set; }
        public string lastName { get; set; }
        public int customerNo { get; set; }
        public string dateOfBirth { get; set; }
        public List<string> PhoneNumbers { get; set; }
    }
}
