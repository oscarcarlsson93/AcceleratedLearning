using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using static HemNet.test.SmhiClasses;

namespace HemNet.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void get_forecast_as_string()
        {
            var service = new SmhiService();
            string forecast = service.Get("https://opendata-download-metfcst.smhi.se/api/category/pmp3g/version/2/geotype/point/lon/16.158/lat/58.5812/data.json").Result;
        }

        [TestMethod]
        public void get_forecast_as_longlat()
        {
            var service = new SmhiService();

            Rootobject result = service.GetMeteorologicalForecast(57.08870M, 11.974560M).Result;

            Timesery firstTimeSeries = result.timeSeries[0];

            DateTime time = result.timeSeries[0].validTime;
            Parameter param = result.timeSeries[0].parameters.Single(p => p.name == "t");
            decimal temperature = param.values[0];
        }

        [TestMethod]
        public void get_all_temperature_for_a_position_a_given_day()
        {
            var service = new SmhiService();

            Rootobject result = service.GetMeteorologicalForecast(57.08870M, 11.974560M).Result;

            List<TimeTemp> timetemps = service.FilterTemperature(result, DateTime.Now);
        }
    }
}
