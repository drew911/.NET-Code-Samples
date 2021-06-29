using System;

namespace AtmMachine
{
    public class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            Atm atm = new Atm();

            while (command != "Exit")
            {
                command = Console.ReadLine();
                int amount = Int32.Parse(command.Split(" ")[1]);

                if (command.StartsWith("Topup"))
                {
                    Console.WriteLine(atm.TopUp(amount));
                }
                if (command.StartsWith("Withdraw"))
                {
                    Console.WriteLine(atm.Withdraw(amount));
                }
               
            }
        }
    }
}
