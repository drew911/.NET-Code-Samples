﻿namespace WarehouseApplication
{
    public class Item
    {
        public string Name { get; set; }

        public int Quantity { get; set; }

        public Item(string name)
        {
            Name = name;
            Quantity = 1;
        }
    }
}
