using System.Collections.Generic;
using System.Linq;

namespace WarehouseApplication
{
    public class Warehouse
    {
        private List<Item> Items = new List<Item>();

        public void Add(string itemName)
        {
            bool doesExist = Items.Select(k => k.Name).Contains(itemName);
            if (!doesExist)
            {
                var newItem = new Item()
                {
                    Name = itemName
                };

                Items.Add(newItem);
            }
            else
            {
                var item = Items.First(i => i.Name == itemName);
                item.Quantity = item.Quantity + 1;
            }
        }

        public string List()
        {
            //return string.Join(", ", Items); // List items with ,
            var output = "";
            foreach (var item in Items)
            {
                string itemInfo = $"{item.Name} {item.Quantity} \n";
                output = output + itemInfo;
            }

            return output;
        }

        public bool Remove(string itemName)
        {
            bool doesExist = Items.Select(k => k.Name).Contains(itemName);
            if (!doesExist)
            {
                return false;
            }

            //Deleting regardless quantity
            Items = Items.Where(i => i.Name != itemName).ToList();

            return true;

        }
    }
}
