using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi1.Controllers
{
    [Route("webapi3")]
    public class WebApi3Controller : Controller
    {   
        [HttpGet("Frukostmat")]
        public IActionResult Frukostmat(string mat)
        {
            if (mat.ToLower() == "mango")
            {
                return Ok($"{mat} är gott!");
            }
            if (mat == null)
            {
                return Ok("Skriv in din frukostmat");
            }
            else
            {
                return Ok($"{mat} är äckligt!");
            }
        }

        [HttpGet("BackColor")]
        public IActionResult BackColor(string color)
        {
            string changeColor = $"<body style=\"background-color:{color};\">";




            return Content(changeColor, "Text/html");
        }

        [HttpGet("Kvadrera")]
        public IActionResult Kvadrera(int number)
        {
            double sqr = Math.Pow(number, 2);
            return Ok(sqr);
        }

        [HttpGet("ListWithNumbers")]
        public IActionResult ListWithNumbers(int number, int number2)
        {
            var x = Enumerable.Range(number, number2);
            return Ok(string.Join(", ", x));
            
        }

        

    }
}