using DependencyInversionSample;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCAPP_DI_Samples.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAPP_DI_Samples.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICar _mockCar; 


        public HomeController(ILogger<HomeController> logger, ICar myCar) //ILogger > wird aus ServiceProvider.GetRequiredService gelesen
        {
            _logger = logger;
            _logger.LogInformation("Call HomeController->Konstruktor"); //Output->Debug-Fenster

            _mockCar = myCar;
        }

        public IActionResult Index()
        {
            return View(_mockCar);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
