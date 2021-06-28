using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApplication.Project
{
    public class Shop
    {
        private readonly Customer _customer = new Customer();

        private List<Item> _items = new List<Item>()
        {
            new Item()
            {
                Name = "Candy",
                Price = 4
            },
            new Item()
            {
                Name = "Book",
                Price = 8
            },
            new Item()
            {
                Name = "Juice",
                Price = 2
            },
        };

        public void Buy(string itemName)
        {
            // Find the item by itemName
            Item item = _items.FirstOrDefault(i => i.Name == itemName);
            if (item == null)
            {
                Console.WriteLine("Item was not found");
            }
            else
            {
                if (_customer.Balance >= item.Price)
                {
                    // update customer balance with item price
                    //_customer.Balance = _customer.Balance - item.Price;
                    _customer.Balance -= item.Price;
                    Console.WriteLine($"Customer's balance: {_customer.Balance}");
                }
                else
                {
                    Console.WriteLine("Not enough money");
                }
               
            }
            
        }

        public void Topup(int amount)
        {
            _customer.Balance += amount;
            Console.WriteLine($"Customer balance: {_customer.Balance}");
        }
    }
}
