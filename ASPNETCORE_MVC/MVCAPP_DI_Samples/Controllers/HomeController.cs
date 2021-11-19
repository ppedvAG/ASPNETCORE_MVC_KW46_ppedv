using DependencyInversionSample;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCAPP_DI_Samples.Models;
using MVCAPP_DI_Samples.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAPP_DI_Samples.Controllers
{
    //DefaultFactory kümmert sich um das instanziieren der Controller-Klassen
    //Dabei wird der Konstruktor in Augenschein genommen -> Parameter 
    // Wenn ICar oder ITimeService als Parameter-Typen gefunden werden -> Greife auf IOC-Container zu und biete die Instanz an (Dependency Injection -> Konstruktor Injection
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

        public IActionResult ShowTime([FromServices] ITimeService timeService) //Weitere Variante
        {
            return View(timeService.GetCurrtentTime());
        }

        public IActionResult ShowTime2() //Weitere Variante
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
