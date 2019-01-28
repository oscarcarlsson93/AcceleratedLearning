using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi1.Models;

namespace WebApi1.Controllers
{       
     [Route("webapi0")]
    public class WebApiController : Controller

    {
        [Route ("Test")]
        public string Test()
        {
            return "Hi from: Server";
        }

        [Route("Test2")]
        public string Test2()
        {
            return "The clock is: ";
        }
        [Route("Test3")]
        public string Test3()
        {
            return "Hi from: Server";
        }
        
        [Route("AddPlanet")]
        public IActionResult AddPlanet()
        {
            string formContent = "";
            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                formContent = reader.ReadToEndAsync().Result;
            }

            Planet planet = ParsePlanet(formContent);
            return Ok($"Ny planet {planet.Name} skapade med storlek {planet.Size}");
        }

        private Planet ParsePlanet(string formContent)
        {
            var planet = new Planet();

            string[] splittedFormContent = formContent.Split("&");

            var name = splittedFormContent[0].Substring(splittedFormContent[0].IndexOf('=') + 1);
            var size = splittedFormContent[1].Substring(splittedFormContent[1].IndexOf('=') + 1);

            planet.Name = name;
            planet.Size = int.Parse(size);

            return planet;
            
        }

        //[Route("SearchPlanet")]
        //public IActionResult SearchPlanet()
        //{
        //    var formContent = Request.QueryString
        //    using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
        //    {
        //        formContent = reader.ReadToEndAsync().Result;
        //    }

        //    Planet planet = ParsePlanet(formContent);
        //    return Ok($"Ny planet {planet.Name} skapade med storlek {planet.Size}");
        //}

        [HttpPost("AddPlanet2")]
        public IActionResult AddPlanet2(Planet planet)
        {
            return Ok($"Ny planet {planet.Name} skapade med storlek {planet.Size}");

        }

        [HttpGet("SearchPlanet2")]
        public IActionResult SearchPlanet2(Planet planet)
        {
            return Ok($"Söker i databasen efter planeter med namn {planet.Name} och storlek {planet.Size}");
        }



    }
}
