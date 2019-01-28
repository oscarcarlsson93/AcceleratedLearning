using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi1.Controllers
{     [Route("webapi2")]

    public class WebApi2Controller : Controller
    {   [Route("HelloWorld")]
        public IActionResult Index()
        {
            Random random = new Random();

            int rndm = random.Next(1, 4);

            if (rndm == 1)
            {
            return Ok("Hello World!");

            }
            if (rndm == 2) 
            {
                return Ok("Bonjour le monde");
            }
            else
            {
                return Ok("Hei maailma");
            }
        }

        [Route("Weekday")]
        public IActionResult Weekday()
        {
            DayOfWeek DayOfWeek = DateTime.Now.DayOfWeek;
            //string today = DateTime.Now.ToString
           
            return Ok(DayOfWeek.ToString());
        }

        [Route("Buzzword")]
        public IActionResult Buzzword()
        {
            DayOfWeek DayOfWeek = DateTime.Now.DayOfWeek;
            string today = DayOfWeek.ToString();

            if (today == "Monday")
            {
                return Ok("Uh-oh. Sounds like somebody’s got a case of the mondays");
            }
            return null;

        }



    }
}