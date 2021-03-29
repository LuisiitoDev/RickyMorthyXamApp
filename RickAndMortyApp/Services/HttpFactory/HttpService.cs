using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RickAndMortyApp.Services.HttpFactory
{
    public class HttpService
    {
        string baseAdress;

        public HttpService(string baseAdress)
        {
            this.baseAdress = baseAdress;
        }

        public async Task<(bool isError, string message, T result)> Get<T>(string endpoint)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAdress);
                var response = await client.GetAsync(endpoint);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    T result = JsonConvert.DeserializeObject<T>(content);
                    return (false, string.Empty, result);
                }

                return (true, response.ReasonPhrase, default);
            }
        }
    }
}
