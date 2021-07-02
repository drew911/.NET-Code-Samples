using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPractice
{
    public class Item
    {

        private string Name { get; set; }

        public int Quantity { get; set; }

        public bool Deleted { get; set; }

        public Item()
        {
            Deleted = false;
            Quantity = 0;
        }

        public Item(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }


    }
}
