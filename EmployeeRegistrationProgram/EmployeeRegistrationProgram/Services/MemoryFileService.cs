using EmployeeRegistrationProgram.Models;
using System.Collections.Generic;

namespace EmployeeRegistrationProgram.Services
{
    public class MemoryFileService : IFileService
    {
        private List<EmployeeModel> _employees = new();

        public List<EmployeeModel> GetEmployees()
        {
            return _employees;
        }

        public void OverwriteEmployees(List<EmployeeModel> employees)
        {
            _employees = employees;
        }
    }
}
