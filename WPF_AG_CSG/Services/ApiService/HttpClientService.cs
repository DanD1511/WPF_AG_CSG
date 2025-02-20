using System;
using System.Net.Http;

namespace WPF_AG_CSG.Services.ApiService
{
    public class HttpClientService
    {
        private readonly HttpClient _httpClient;

        public HttpClientService(string baseUri)
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(baseUri)
            };
        }

        public HttpClient GetClient()
        {
            return _httpClient;
        }
    }
}
