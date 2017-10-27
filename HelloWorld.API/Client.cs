using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.API
{
    public class Client : IClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseAddress;
        private const string MESSAGE_ROUTE_PREFIX = "api/message/";

        public Client(HttpClient httpClient, string baseAddress)
        {
            _httpClient = httpClient;
            _baseAddress = baseAddress;
        }
        public async Task<string> GetHelloWorldAsync()
        {
            var response = await _httpClient.GetAsync($"{_baseAddress}{MESSAGE_ROUTE_PREFIX}/helloworld");
            response.EnsureSuccessStatusCode();

            var message = await response.Content.ReadAsStringAsync();
            return message;
        }
    }
}
