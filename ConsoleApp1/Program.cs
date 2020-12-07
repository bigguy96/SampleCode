using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    internal class Program
    {
        private static readonly HttpClient Client = new HttpClient();

        private static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var response = await Client.GetAsync("https://localhost:44325/api/values1");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var user = JsonSerializer.Deserialize<User>(json);
                user.Result = "OK";

                Console.WriteLine(user.FirstName);
                Console.WriteLine(user.LastName);
                Console.WriteLine(user.Result);
            }
            else
            {
                var user = new User {Result = "Failed"};

                Console.WriteLine(user.FirstName);
                Console.WriteLine(user.LastName);
                Console.WriteLine(user.Result);
            }

            Console.ReadLine();
        }
    }
}