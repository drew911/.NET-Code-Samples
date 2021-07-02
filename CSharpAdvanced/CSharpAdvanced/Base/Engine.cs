using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.Base
{
    // This class is just for inheritance
    public abstract class Engine
    {
        protected string EngineType { get; set; }

        public string EngineNumber { get; set; }
        protected void CheckOil()
        {

        }
    }
}
