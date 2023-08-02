using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;
using System;
using System.Net.Http;
using Newtonsoft.Json;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            RonVSKanyeAPI.KanyeQuote();

            RonVSKanyeAPI.RonQuote();

            RonVSKanyeAPI.KanyeQuote();

            RonVSKanyeAPI.RonQuote();

            RonVSKanyeAPI.KanyeQuote();

            RonVSKanyeAPI.RonQuote();

            RonVSKanyeAPI.KanyeQuote();

            RonVSKanyeAPI.RonQuote();

            RonVSKanyeAPI.KanyeQuote();

            RonVSKanyeAPI.RonQuote();




            var client = new HttpClient();
            //API key = 345a4c658cfc583918c1d7cd1403b91e
            //Console.WriteLine("Please enter your API key:");

            var key = "345a4c658cfc583918c1d7cd1403b91e";




            while (true)
            {

                Console.WriteLine();
                Console.Write("Please enter the city name: ");
                var city = Console.ReadLine();
                Console.WriteLine();
                var url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={key}&units=imperial";
                //var weatherURL = $"https://api.openweathermap.org/data/2.5/forecast?q={city}&appid={key}&units=imperial";

                try
                {
                    var response = client.GetStringAsync(url).Result;
                    var formattedResponse = JObject.Parse(response).GetValue("main").ToString();
                    Console.WriteLine($"The current Temperature is {JObject.Parse(formattedResponse).GetValue("temp")} degrees in Fahrenheit.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                

                //var root = JsonConvert.DeserializeObject<Root>(response);

                //foreach (var weather in root.list)
                //{
                //    Console.WriteLine($"Temp: {weather.main.temp}");
                //    Console.WriteLine($"Date/Time: {weather.dt_txt}");
                //    Console.WriteLine();
                //}


                
                Console.WriteLine("--------------------------");
                Console.WriteLine("Would you like to exit?");
                var userInput = Console.ReadLine();
                Console.WriteLine("--------------------------");

                if (userInput.ToLower().Trim() == "yes")
                {
                    break;
                }
            }


        }
    }
}
