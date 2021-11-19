using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MVCAPP_DI_Samples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAPP_DI_Samples.Controllers
{
    public class ConfigureSampleController : Controller
    {


        

        //Get-Methode -> Wenn Browser eine Webseite aufruft, wird die Webseite in einer Get-Methode aufbereitet.
        //            -> Das Ergebnis (Html) wird an den Browser zurück gesendet
        public IActionResult PositionOptionsSample([FromServices] IConfiguration configuration)
        {
            PositionOptions positionOptions = new();
            configuration.GetSection(PositionOptions.StringPosition).Bind(positionOptions);
            
            return View(positionOptions);
        }


        public IActionResult WebSettingsSample([FromServices] IOptions<SampleWebSettings> settingOptions)
        {
            return View(settingOptions.Value);
        }
    }
}
