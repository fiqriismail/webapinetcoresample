using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

using WebClientConsole.Models;

namespace WebClientConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Accessing my web services");

            var client = new HttpClient();

            var responseMessage = await client.GetAsync("https://localhost:44301/api/product/catalog");

            var message = await responseMessage.Content.ReadAsStringAsync();

            var catalog = JsonConvert.DeserializeObject<List<Product>>(message);

            foreach (var product in catalog)
            {
                Console.WriteLine($"{product.Id} {product.Title} : {product.Price}");
            }

            Console.WriteLine("Response from server - {0}", message);
            Console.WriteLine("All done.");
        }
    }
}
