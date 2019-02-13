using HemNet.Data;
using HemNet.Models;
using HemNet.Models.ViewModels;
using HemNet.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static HemNet.Models.SmhiClasses;

namespace HemNet.Controllers
{
    public class WeatherController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly SiteConfig _siteConfig;
        private readonly IHostingEnvironment _hostingenvironment;

        public WeatherController(ApplicationDbContext context, SiteConfig siteConfig, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _siteConfig = siteConfig;
            _hostingenvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            return View(new WeatherVm
            {

            });
        }



        public IActionResult ShowTimeTemp(WeatherVm weather)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", weather);
            }
            else
            {



                try
                {

                    var service = new SmhiService();
                    Rootobject result = service.GetMeteorologicalForecast(weather.Longitude, weather.Latitude).Result;

                    //List<TimeTemp> timetemps = service.FilterTemperature(result, DateTime.Now);


                    weather.Temps = service.FilterTemperature(result, DateTime.Now);


                }
                catch (Exception)
                {
                    ViewData["Error"] = "FEL FEL FEL!!!!";
                }
                return View("Index", weather);
            }
        }
    }
}
