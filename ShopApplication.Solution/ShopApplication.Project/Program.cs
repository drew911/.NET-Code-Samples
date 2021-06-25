using System;

namespace ShopApplication.Project
{
    class Program
    {

        static void Main(string[] args)
        {
            Shop shop = new Shop();

            string command = "";

            Console.WriteLine("Possible commands: Exit, Buy, Topup");
            while (command != "Exit")
            {
                command = Console.ReadLine();

                string commandName = command.Split(" ")[0];
                string argument = command.Split(" ")[1];

                switch (commandName)
                {
                    case "Buy":
                        shop.Buy(argument);
                        break;

                    case "Topup":
                        int amount = Int32.Parse(argument);
                        shop.Topup(amount);
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
