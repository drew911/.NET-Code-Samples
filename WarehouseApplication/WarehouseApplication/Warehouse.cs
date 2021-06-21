using System.Collections.Generic;
using System.Linq;

namespace WarehouseApplication
{
    public class Warehouse
    {
        private List<Item> Items = new List<Item>();

        public void Add(string itemName)
        {
            List<string> names = Items.Select(k => k.Name).ToList();
            bool doesExist = Items.Select(k => k.Name).Contains(itemName);

            if (!doesExist)
            {
                var newItem = new Item(itemName);

                Items.Add(newItem);
            }
            else
            {
                Item item = Items.First(i => i.Name == itemName);
                item.Quantity = item.Quantity + 1;
            }
        }

        public string GetInfo()
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
