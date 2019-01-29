using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi5.Models
{
    public class SimplePersonWithAttributes
    {
        [Required]
        [StringLength(20)]
        public string Firstname { get; set; }

        [Required]
        [Range(0, 120)]
        public int? Age { get; set; }
    }
}
