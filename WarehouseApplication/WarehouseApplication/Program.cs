using System;

namespace WarehouseApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            var warehouse = new Warehouse();

            while (command != "Exit")
            {

                Console.WriteLine("");
                command = Console.ReadLine();

                if (command.StartsWith("Add")) //input 'Add Item1'
                {
                    var itemName = command.Split(" ")[1];
                    warehouse.Add(itemName);
                }
                if (command == "List")
                {
                    Console.WriteLine(warehouse.List());
                }
                if (command.StartsWith("Remove"))
                {
                    var itemName = command.Split(" ")[1];
                    if (!warehouse.Remove(itemName))
                    {
                        Console.WriteLine("sorry item does not exist");
                    }
                }
            }
        }
    }
}
