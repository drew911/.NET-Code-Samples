using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.Base
{
    public abstract class Vehicle : Engine //Transporto priemone
    {
        public virtual void Drive()
        {
            Console.WriteLine("Driving");
        }

        public void Break()
        {
            Console.WriteLine("Breaking");
        }
    }
}
