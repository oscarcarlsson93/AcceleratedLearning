using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HemNet.Models.ViewModels
{
    public class WeatherVm
    {
        [Required]
        public decimal Longitude { get; set; }
        [Required]
        public decimal Latitude { get; set; }

        public List<TimeTemp> Temps { get; set; } = new List<TimeTemp>();

        

    }
}
