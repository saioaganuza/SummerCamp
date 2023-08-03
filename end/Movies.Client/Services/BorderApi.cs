
using Movies.API.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;


namespace Movies.Client.Services
{
    
    public class BorderApi : IIntegrationService
    {
        private static HttpClient httpClient = new HttpClient();

        public async Task Run()
        {
            await EjemploGet();
        }
        public BorderApi()
        {
            
             httpClient.BaseAddress = new Uri("https://www.boredapi.com/api/");
        }
        private async Task EjemploGet()
        {
            var response = await httpClient.GetAsync("activity/");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            //var activities = new List<Activity>();
            //activities = JsonConvert.DeserializeObject<List<Activity>>(content);
            var activity = JsonConvert.DeserializeObject<Actividad> (content);
        }

    }
}
