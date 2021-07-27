using EmployeeRegistrationProgram.Models;
using System.Collections.Generic;

namespace EmployeeRegistrationProgram.Services
{
    public interface IFileService
    {
        List<EmployeeModel> GetEmployees();
        void OverwriteEmployees(List<EmployeeModel> employees);
    }
}