using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {
        public static void WeatherAPI(string[] args)
        {
            var client = new HttpClient();
        //API key = 345a4c658cfc583918c1d7cd1403b91e
             //Console.WriteLine("Please enter your API key:");
            var key = "345a4c658cfc583918c1d7cd1403b91e";
            var city = "Philadelphia";

            var weatherURL = $"https://api.openweathermap.org/data/2.5/forecast?q={city}&appid={key}&units=imperial";

            var response = client.GetStringAsync(weatherURL).Result;
            Console.WriteLine(response);

            //JObject formattedResponse = JObject.Parse(response);
            //var temp = formattedResponse["list"][0]["main"]["temp"];
            //Console.WriteLine(temp);
        }
        
    }
}
