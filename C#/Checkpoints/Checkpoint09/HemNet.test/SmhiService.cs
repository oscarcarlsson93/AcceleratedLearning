using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static HemNet.test.SmhiClasses;

namespace HemNet.test
{
    class SmhiService
    {
        //public int Temp { get; set; }
        //public int Wind { get; set; }
        //public string WeatherCondition { get; set; }
        //public bool SunOrNot { get; set; }

        public async Task<string> Get(string url)
        {
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(url))
            using (HttpContent content = response.Content)
            {
                if (!response.IsSuccessStatusCode)
                    throw new Exception(response.ReasonPhrase);

                return await content.ReadAsStringAsync();
            }
        }

        public async Task<Rootobject> GetMeteorologicalForecast(decimal longitude, decimal latitude)
        {
            string sLongitude = Math.Round(longitude, 3).ToString(new CultureInfo("en"));
            string sLatitude = Math.Round(latitude, 3).ToString(new CultureInfo("en"));

            string result = await Get("https://opendata-download-metfcst.smhi.se/api/category/pmp3g/version/2/geotype/point/lon/16.158/lat/58.5812/data.json");
            return JsonConvert.DeserializeObject<Rootobject>(result);
        }

        internal List<TimeTemp> FilterTemperature(Rootobject result, DateTime date)
        {

            return result.timeSeries.Where(x => x.validTime.Day == date.Day).Select(x => new TimeTemp
            {
                Temp = x.parameters.Single(y => y.name == "t").values[0],
                Time = x.validTime

            }).ToList();

        }
    }
}
