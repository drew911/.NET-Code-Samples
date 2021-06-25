using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPractice
{
    public class Item
    {
        public string Name { get; set; }

        public int Quantity { get; set; }

        public bool Deleted { get; set; } = false;
    }
}
