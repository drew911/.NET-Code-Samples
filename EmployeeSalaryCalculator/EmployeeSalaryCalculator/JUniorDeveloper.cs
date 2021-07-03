using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryCalculator
{
    public class JUniorDeveloper : Employee
    {
        public JUniorDeveloper()
        {
            BaseSalary = 1000;
        }

        public override int GetSalary()
        {
             return BaseSalary;
        }
    }
}
