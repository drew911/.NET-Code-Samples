using EmployeeRegistrationProgram.Models;
using EmployeeRegistrationProgram.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EmployeeRegistrationProgram.Controllers
{
    public class EmployeeController : Controller
    {
        private IFileService _fileService;

        public EmployeeController(IFileService fileService)
        {
            _fileService = fileService;
        }

        public IActionResult Index()
        {
            List<EmployeeModel> employees = _fileService.GetEmployees();
            return View(employees);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Add(EmployeeModel model)
        {
            List<EmployeeModel> employees = _fileService.GetEmployees();
            employees.Add(model);
            _fileService.OverwriteEmployees(employees);

            return RedirectToAction("Index");
        }
    }
}
