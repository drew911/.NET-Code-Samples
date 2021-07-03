using System;
using System.Collections.Generic;

namespace EmployeeSalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            var jaunius = new JUniorDeveloper();

            employees.Add(jaunius);

            var marija = new SeniorDeveloper();

            employees.Add(marija);

            Console.WriteLine("Hello World!");

            employees.ForEach(e => Console.WriteLine(e.GetSalary()));
            
        }
    }
}
