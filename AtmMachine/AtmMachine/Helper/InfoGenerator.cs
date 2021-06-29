using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmMachine
{
    public static class InfoGenerator
    {
        public static string ConvertToString(List<BankNote> bankNotes)
        {
            string info = ""; 

            foreach (BankNote bankNote in bankNotes.Where(b => b.Quantity != 0))
            {
                info += $"Nominal: {bankNote.Nominal}, Quantity: {bankNote.Quantity}\n";
            }

            return info;
        }
    }
}
