using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TestWeatheAPI
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string apiKey = "5869LJUHW5XPFWVFP9KN9UUQV";
            string location = "Paris"; // Example location
            string url = $"https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/{location}?unitGroup=metric&contentType=json&key={apiKey}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();
                    dynamic weatherData = JsonConvert.DeserializeObject(responseBody);

                    foreach (var day in weatherData.days)
                    {
                        Console.WriteLine($"Date: {day.datetime}");
                        Console.WriteLine($"Max Temp: {day.tempmax}");
                        Console.WriteLine($"Min Temp: {day.tempmin}");
                        Console.WriteLine($"Description: {day.description}");
                        Console.WriteLine("--------------------------------");
                    }
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Request error: {e.Message}");
                }
            }
        }
    }
}
