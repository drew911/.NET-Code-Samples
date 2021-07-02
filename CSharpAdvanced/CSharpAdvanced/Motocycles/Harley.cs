using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.Motocycles
{
    public class Harley : Motocycle
    {
        public new void Drive()
        {
            Console.WriteLine("Driving Harley");
        }
    }
}
