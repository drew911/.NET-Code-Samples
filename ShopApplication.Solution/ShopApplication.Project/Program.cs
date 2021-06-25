using System;

namespace ShopApplication.Project
{
    class Program
    {

        static void Main(string[] args)
        {
            Shop shop = new Shop();

            string command = "";

            Console.WriteLine("Possible commands: Exit, Buy");
            while (command != "Exit")
            {
                command = Console.ReadLine();

                if (command.StartsWith("Buy"))
                {
                    string itemName = command.Split(" ")[1];
                    shop.Buy(itemName);
                }
            }
        }
    }
}
