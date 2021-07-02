using System;
using System.Collections.Generic;
using System.Linq;

namespace ListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>()
            {
                new Item()
                {
                    Name = "Item1",
                    Quantity = 1
                },
                new Item("Item2", 4),
                new Item()
                {
                    Name = "Item3",
                    Quantity = 6,
                    Deleted = true
                },
            };

            var item = new Item();
            item.Name = "Item1";
            item.Quantity = 4;

            var item2 = new Item()
            {
                Name = "Item1",
                Quantity = 4
            };



            List<Item> undeletedItems = items.Where(item => item.Deleted != true).ToList();
            // Names of undeleted items
            List<string> undeletedNames = items.Where(item => item.Deleted != true).Select(i => Upper(i.Name)).ToList();
            // Get all items which have quantity > 4
            List<Item> someItems = items.Where(i => i.Quantity > 4).ToList();

            // Get the item which has the most quantity
            Item largestQuantity = items.OrderByDescending(i => i.Quantity).First();

            // Get the undeleted item which has the most quantity
            Item largestUndeletedQuantity = items.Where(item => item.Deleted != true).OrderByDescending(i => i.Quantity)
                .First();

            // Get All items that are not deleted and quantity is more than 2
            List<Item> undeletedItems2 = items.Where(item => item.Deleted != true && item.Quantity > 2).ToList();


        }

        private static string Upper(string text)
        {
            return text.ToUpper();
        }
    }
}
