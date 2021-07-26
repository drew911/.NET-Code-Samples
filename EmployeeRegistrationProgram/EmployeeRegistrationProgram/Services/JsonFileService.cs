using EmployeeRegistrationProgram.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegistrationProgram.Services
{
    public class JsonFileService
    {
        private const string DATA_URL = "./Data/Data.json";

        public List<EmployeeModel> GetEmployees()
        {
            if (!System.IO.File.Exists(DATA_URL))
            {
                System.IO.File.WriteAllText(DATA_URL, "[]");
            }

            string itemsText = System.IO.File.ReadAllText(DATA_URL);
            return JsonConvert.DeserializeObject<List<EmployeeModel>>(itemsText);
        }

        public void OverwriteEmployees(List<EmployeeModel> employees)
        {
            string itemsText = JsonConvert.SerializeObject(employees);
            System.IO.File.WriteAllText(DATA_URL, itemsText);
        }
    }
}
