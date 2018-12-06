using System;
using System.Collections.Generic;
using MethodsAndLists.Core.Models;

namespace MethodsAndLists.Core
{
    public class StringToObjectList
    {
        public List<City> ParseCities(string input)
        {
            List<City> cities = new List<City>();

            if (string.IsNullOrWhiteSpace(input) && input != null)
            {
                return cities;
            }
            if (input == null)
            {
                throw new ArgumentException();
            }

            string[] stad = input.Split(';');
                                     
            foreach (var item in stad)
            {
                var City = new City();

                string[] ensam = item.Split(',');

                City.Name = ensam[0];
                City.Population = int.Parse(ensam[1]);
                cities.Add(City);
            }
            return cities;
        }
        
        
            
        
    }
}
