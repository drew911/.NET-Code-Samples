using EmployeeRegistrationProgram.Models;
using EmployeeRegistrationProgram.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegistrationProgram.Controllers
{
    public class EmployeeController : Controller
    {
        private JsonFileService _jsonFileService;

        public EmployeeController(JsonFileService jsonFileService)
        {
            _jsonFileService = jsonFileService;
        }

        public IActionResult Index()
        {
            List<EmployeeModel> employees = _jsonFileService.GetEmployees();
            return View(employees);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Add(EmployeeModel model)
        {
            List<EmployeeModel> employees = _jsonFileService.GetEmployees();
            employees.Add(model);
            _jsonFileService.OverwriteEmployees(employees);

            return RedirectToAction("Index");
        }
    }
}
