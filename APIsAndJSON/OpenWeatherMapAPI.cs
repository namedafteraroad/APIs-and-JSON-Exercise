using Newtonsoft.Json.Linq;
using System.Net.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace APIsAndJSON
{
    internal class OpenWeatherMapAPI
    {
        public void WeatherCheck()
        {

            HttpClient weatherClient = new HttpClient();
            var cityName = "Aspen, US";
            var API_key = "2cbd61e9749ac806b518127704b6fdce";
            //endpoint
            string weatherEnd = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={API_key}&units=imperial";
            //get
            var weatherGet = weatherClient.GetStringAsync(weatherEnd).Result;

            //parse
            var weatherParse = JObject.Parse(weatherGet)["main"]["temp"];
            //write
            Console.WriteLine($"Today's temp in Aspen, CO is {weatherParse}");




        }



    }
}
//Create an OpenWeatherMap account to get a free API Key
//Add the NewtonSoft.Json Nuget Package to your Console App
//Figure out how to get the CURRENT weather for the City you specify in degrees fahrenheit
//Creatively display & organize the response
