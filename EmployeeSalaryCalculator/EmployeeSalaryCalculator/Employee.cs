using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryCalculator
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Experience { get; set; }

        public EmployeeRole Role { get; set; }

  
        public int GetSalary()
        {
            double salary = Role.BaseSalary;
            for (int i = 0; i < Experience; i++)
            {
                salary = salary * (1 + (Role.Range / 100.0));
            }
            return (int)salary;
        }
        
    }
}
