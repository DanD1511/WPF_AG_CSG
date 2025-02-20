using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WPF_AG_CSG.Domain.Interfaces;

namespace WPF_AG_CSG.Services.ApiService
{
    public class ApiService : IApiService
    {
        private readonly HttpClient? _httpClient;
        private readonly HttpClientService? _httpClientService;

        public ApiService()
        {
            _httpClientService = new HttpClientService("http://127.0.0.1:8000/");
            _httpClient = _httpClientService.GetClient();
        }

        public async Task<string> Post(string uri, Dictionary<string, object> data)
        {
            try
            {
                string jsonData = JsonConvert.SerializeObject(data);
                HttpContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _httpClient.PostAsync(uri, content);
                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
    }
}
