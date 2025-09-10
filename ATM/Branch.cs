using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Branch
    {
        public string BranchName {  get; set; }
        public int Bsb {  get; set; }
        public string Address { get; set; }
        public string Suburb { get; set; }
        public string State {  get; set; }
        public int PostCode { get; set; }

    }
}
