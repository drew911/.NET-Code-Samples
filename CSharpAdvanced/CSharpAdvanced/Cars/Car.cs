using CSharpAdvanced.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.Cars
{
    public class Car : Vehicle
    {
        protected string Brand { get; set; }

        public Car()
        {
           
        }

        public void OpenTrunk()
        {
            Console.WriteLine("Opening trunk");
        }
    }
}
