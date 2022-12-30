using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace IpInfoGrabber
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.Title = $"IP Info Grabber - {Environment.UserName}";
            animated_write("This will grab the details and information on your IP address.\nContinue? (Y/N): ");

            if (Console.ReadKey().Key != ConsoleKey.Y)
                return;

            try
            {
                using (var httpClient = new HttpClient())
                {
                    var response = JsonConvert.DeserializeObject<Dictionary<string, string>>(await httpClient.GetStringAsync("http://ip-api.com/json/"));

                    animated_write_line($"\n\nIP Address | {response["query"]}");
                    animated_write_line($"ISP | {response["isp"]}");
                    animated_write_line($"Latitude | {response["lat"]}");
                    animated_write_line($"Longitude | {response["lon"]}");
                    animated_write_line($"Country | {response["country"]}");
                    animated_write_line($"Region | {response["regionName"]}");
                    animated_write_line($"City Name | {response["city"]}");
                    animated_write_line($"Zip Code | {response["zip"]}");
                    animated_write_line($"Timezone | {response["timezone"]}\n");
                }
            }
            catch (HttpRequestException error)
            {
                animated_write_line($"There was an error attempting to request IP details.\nStackTrace:\n\n{error.StackTrace}");
            }

            animated_write("Press any key to continue...");
            Console.ReadKey();
        }

        static void animated_write_line(string text)
        {
            foreach (var c in text + '\n')
            {
                Thread.Sleep(30);
                Console.Write(c);
            }
        }

        static void animated_write(string text)
        {
            foreach (var c in text)
            {
                Thread.Sleep(30);
                Console.Write(c);
            }
        }
    }
}
