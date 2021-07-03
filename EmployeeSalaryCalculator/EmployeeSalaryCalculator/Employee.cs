using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryCalculator
{
    public abstract class Employee
    {
        public string Name { get; set; }

        public int BaseSalary { get; set; }

        public Employee()
        {
            
        }

        public abstract int GetSalary();
        
    }
}
