using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RazorNamesApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorNamesApplication.Controllers
{
    public class NameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SubmitName(NameModel model)
        {
            // REading 
            string readModels = System.IO.File.ReadAllText("Names.json");
            List<NameModel> receivedModels = JsonConvert.DeserializeObject<List<NameModel>>(readModels);

            if (receivedModels == null)
            {
                receivedModels = new();
            }
            // Updating the models
            receivedModels.Add(model);
            // Saving the updated

            string jsonModels = JsonConvert.SerializeObject(receivedModels);

            System.IO.File.WriteAllText("Names.json", jsonModels);

            return View("NamesDisplay", receivedModels);
        }
    }
}
