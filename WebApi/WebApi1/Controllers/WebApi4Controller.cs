using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi1.Controllers
{
    [Route("webapi4")]

    public class WebApi4Controller : Controller
    {
        [HttpGet("Choklad")]
        public IActionResult Choklad(int personer)
        {
            if (personer >= 1)
            {

                return Ok($"Varje person får {25 / personer} bitar var");
            }
            else
            {
                return BadRequest("Mata in minst en person");
            }
        }
        [HttpGet("GetOrder")]
        public IActionResult GetOrder(string orderID)
        {
            var regex = @"^[A-Za-z]{2}-(\d{4})$";

            var match = Regex.Match(orderID, regex, RegexOptions.IgnoreCase);

            if (match.Success)
            {
                int overNumber = int.Parse(match.Groups[1].Value);

                if (overNumber > 6000)
                {
                    return NotFound("Ordern hittades inte");
                }
                return Ok($"Order {orderID} hittades i databasen");
            }
            else
            {
                return BadRequest("Fel format på orderID");

            }

        }

        [HttpGet("GetUsername")]
        public IActionResult GetUsername(string username)
        {
            string usernameLower = username.ToLower();

            if (usernameLower == "stewie")
            {
                throw new Exception("Data error!");
                //return Ok("DATA ERROR!");
            }

            if (usernameLower == "peter")
            {
                string changeColor = $"<img src=\" http://www.vst.cz/wp-content/uploads/video-poster.jpg \">";

                return Content(changeColor, "Text/html");
            }
            else if (usernameLower == "lois" || usernameLower == "meg" || usernameLower =="chris")
            {
                string thumbDown = $"<img src=\" https://previews.123rf.com/images/koya79/koya791805/koya79180500116/101829437-thumb-down-emoji-isolated-on-white-background-emoticon-giving-dislikes-3d-rendering.jpg \">";
                return Content(thumbDown, "Text/html");
            }
            else
            {
                string down = $"<img src=\" https://cdn.shopify.com/s/files/1/1061/1924/products/Thumbs_Down_Sign_Emoji_Icon_ios10_large.png?v=1542435999 \">";
                return Content(down, "Text/html");

            }

        }



    }
}