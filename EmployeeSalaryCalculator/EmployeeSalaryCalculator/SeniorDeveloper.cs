using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryCalculator
{
    public class SeniorDeveloper : Employee
    {
        public SeniorDeveloper()
        {
            BaseSalary = 3000;
        }

        public override int GetSalary()
        {
             return BaseSalary;
        }
    }
}
