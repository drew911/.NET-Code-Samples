using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalaryCalculator
{
    class Program
    {
        private static List<EmployeeRole> _roles = new()
        {
            new EmployeeRole()
            {
                Name = "JuniorDeveloper",
                BaseSalary = 1000,
                Range = 5
            },
            new EmployeeRole()
            {
                Name = "Developer",
                BaseSalary = 2000,
                Range = 10
            },
            new EmployeeRole()
            {
                Name = "SeniorDeveloper",
                BaseSalary = 2500,
                Range = 12
            },
            new EmployeeRole()
            {
                Name = "Architect",
                BaseSalary = 3500,
                Range = 20
            }
        };

        private static List<Employee> _employees = new List<Employee>();

        static async Task Main(string[] args)
        {
            //// Add
            //EmployeeRole role = _roles.FirstOrDefault(r => r.Name == "Junior");

            //Employee employee = new Employee()
            //{
            //    Name = "Jaunius Pinelis",
            //    Experience = 9,
            //    Role = role
            //};

            //_employees.Add(employee);

            ////Show

            //Employee employee1 = _employees.FirstOrDefault();
            //Console.WriteLine(employee1.GetSalary());

            string command = "";


            while (command != "Exit")
            {
                command = Console.ReadLine();

                string[] inputs = command.Split(" ");

                if (command.StartsWith("Add"))
                {

                    string firstName = inputs[1];
                    string lastName = inputs[2];
                    string roleName = inputs[3];
                    int experience = Int32.Parse(inputs[4]);


                    EmployeeRole role = _roles.First(r => r.Name == roleName);

                    _employees.Add(new Employee()
                    {
                        Experience = experience,
                        FirstName = firstName,
                        LastName = lastName,
                        Role = role
                    });

                    Console.WriteLine($"{firstName} {lastName} has been added");
                
                }
                if (command.StartsWith("Show"))
                {
                    string firstName = inputs[1];
                    string lastName = inputs[2];

                    Employee employee = _employees.First(e => e.FirstName == firstName && e.LastName == lastName);
                    Console.WriteLine($"{employee.FirstName} {employee.LastName} earns {employee.GetSalary()} a month");
                }
                
            }
        }
    }
}
