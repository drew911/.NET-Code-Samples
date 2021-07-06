using HttpClientConsoleApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClientConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string url = "https://jsonplaceholder.typicode.com/users";

            HttpClient client = new HttpClient();

            string result = await client.GetStringAsync(url);

            List<UserModel> parsedResult =  JsonConvert.DeserializeObject<List<UserModel>>(result);

        }
    }
}
