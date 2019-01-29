using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi6.Models
{
    public class Document
    {
        public string Firstname { get; set; }
        public int? numberOfPages { get; set; }
        public bool? Checkbox { get; set; }
        public DateTime publicDate { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; }
        public List<string> TagList{ get; set; }
        public int? Rating { get; set; }



    }
}
