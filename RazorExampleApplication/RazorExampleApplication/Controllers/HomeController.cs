using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RazorExampleApplication.Models;
using System.Diagnostics;

namespace RazorExampleApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            IndexModel model = new IndexModel()
            {
                Name = "Jonas",
                Profession = "Developer"
            };
            return View(model);
        }

        public IActionResult Privacy()
        {

            return View();
        }

        public IActionResult Registration()
        {
            IndexModel model = new IndexModel()
            {

            };
            return View(model);
        }

        public IActionResult FakeLogin()
        {
            FakeLoginModel model = new FakeLoginModel();
            return View(model);
        }

        public IActionResult Authenticate(FakeLoginModel model)
        {
            // authenticating the user
            if (model.Username == "Jaunius" && model.Password == "Pinelis")
            {
                return View();
            }
            else
            {
                return View("AuthenticationFailed");
            }

        }

        public IActionResult DisplayRegister(IndexModel model)
        {
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
