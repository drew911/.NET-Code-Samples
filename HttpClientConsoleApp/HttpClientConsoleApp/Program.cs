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
            string url = "https://www.lb.lt/webservices/ExchangeRates/ExchangeRates.asmx/getExchangeRatesByDate?Date=2011-02-02";
            
            HttpClient client = new HttpClient();

            string result = await client.GetStringAsync(url);

            ExchangeRates parsedResult =  JsonConvert.DeserializeObject<ExchangeRates>(result);
        }
    }
}
