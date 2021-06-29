using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmMachine
{
    public class Atm
    {
        private int _balance = 2000;

        private List<BankNote> _bankNotes = new()
        {
            new(50),
            new(20),
            new(10),
            new(5),
        };

        public string TopUp(int amount)
        {
            _balance += amount;

            return $"Your balance is {_balance}";
        }

        public string Withdraw(int amount)
        {
            _bankNotes.ForEach(b => b.Quantity = 0);

            _balance -= amount;

            foreach (BankNote bankNote in _bankNotes)
            {
                if (amount >= bankNote.Nominal)
                {
                    bankNote.Quantity = amount / bankNote.Nominal;
                    amount -= bankNote.Nominal * bankNote.Quantity;
                }
            }

            return GenerateInfo();
        }

        private string GenerateInfo()
        {
            string balanceInfo = $"Your balance is {_balance}\n";
            string notesInfo = InfoGenerator.ConvertToString(_bankNotes);

            return balanceInfo + notesInfo;

        }

        public static string GetInfo()
        {
            return "info";
        }
    }
}
