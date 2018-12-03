using System;
using System.Collections.Generic;
using System.Text;

namespace Module7._1
{
   public class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle()
        {
            Console.WriteLine($"I'm a circle with radius");
        }
    }
}
