using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApiClient.HttpClients
{
    public class MyHttpClient
    {
        private readonly HttpClient _httpClient;
        private const string BASE_URL = "http://localhost:5000/api/";

        public MyHttpClient()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> GetRequest(string url)
        {
            string endpointPath = BASE_URL + url;

            // Make the request
            HttpResponseMessage response = _httpClient.GetAsync(endpointPath).Result;

            if (!response.IsSuccessStatusCode)
                throw new ArgumentException($"The path {endpointPath} gets the following status code: " + response.StatusCode);

            return await response.Content.ReadAsStringAsync();
        }
    }
}
