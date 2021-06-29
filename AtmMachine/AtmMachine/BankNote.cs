using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmMachine
{
    public class BankNote
    {
        public int Nominal { get; set; }

        public int Quantity { get; set; } = 0;

        public BankNote(int nominal)
        {
            Nominal = nominal;
        }
    }
}
