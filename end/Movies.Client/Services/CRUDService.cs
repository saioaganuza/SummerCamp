using Movies.Client.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Client.Services
{
    public class CRUDService : IIntegrationService
    {
        private static HttpClient httpClient = new HttpClient();

        public CRUDService() 
        {
            httpClient.BaseAddress = new Uri("http://localhost:57863/");
        }
        public async Task Run()
        {
            await EjemploGet();
        }

        private async Task EjemploGet()
        {
            var response = await httpClient.GetAsync("api/movies");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var movies = new List<Movie>();
            movies = JsonConvert.DeserializeObject<List<Movie>>(content);

        }

    }
}
