using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi5.Models;

namespace WebApi1.Controllers
{
    [Route("webapi5")]
    public class WebApi5Controller : Controller
    {   [HttpPost("AddPerson")]
        public IActionResult AddPerson(SimplePerson person)
        {
            return Ok($"{person.Firstname} som är {person.Age} år lades till i databasen");
        }

        [HttpPost("AddPersonValidate")]
        public IActionResult AddPersonValidate(SimplePerson person)
        {
            if (person.Firstname == null || person.Age == null)
            {
                return BadRequest("Du måste ange både förnamn och ålder");
            }
            if (person.Firstname.Length > 20 )
            {
                return BadRequest("För långt förnamn");
            }
            if (person.Age < 0 || person.Age > 120 )
            {
                return BadRequest("Fyll i rätt ålder");
            }
            return Ok($"{person.Firstname} som är {person.Age} år lades till i databasen");
        }

        [HttpPost("AddPersonValidateAttribute")]
        public IActionResult AddPersonValidateAttribute(SimplePersonWithAttributes person)
        {
            if (ModelState.IsValid)
            {
            return Ok($"{person.Firstname} som är {person.Age} år lades till i databasen");
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
