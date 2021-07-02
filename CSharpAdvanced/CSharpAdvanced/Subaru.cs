using CSharpAdvanced.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    public class Subaru : ModernCar
    {
        public Subaru()
        {
            Brand = "Subaru";
            CheckOil();
        }
    }
}
