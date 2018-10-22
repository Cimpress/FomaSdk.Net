using System.Net.Http;
using System.Threading.Tasks;
using Cimpress.Clients.Foma.Model;
using Cimpress.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace Cimpress.Clients.Foma
{
    public class FomaClient
    {
        private readonly HttpClient httpClient;
        private readonly ILogger logger;
        private const string baseUrl = "https://fulfillment.at.cimpress.io";

        public FomaClient(HttpClient httpClient, ILogger logger)
        {
            this.httpClient = httpClient;
            this.logger = logger;
        }

        public async Task<NotificationsResultDto> GetNotifications(string fulfillerId)
        {
            var url = $"{baseUrl}/v1/notifications?fulfillerId={fulfillerId}";
            return await GetData<NotificationsResultDto>(url);
        }

        public async Task<T> GetData<T>(string url)
        {
            using (var response = await httpClient.GetAsync(url))
            {
                await response.LogAndThrowIfNotSuccessStatusCode(logger);
                return await response.Content.ReadAsAsync<T>();
            }
        }

        public async Task<HttpResponseMessage> Download(string url)
        {
            var response = await httpClient.GetAsync(url);
            await response.LogAndThrowIfNotSuccessStatusCode(logger);
            return response;
        }

        public async Task<HttpResponseMessage> SendData<T>(string url, T data = default(T))
        {
            using (var response = await httpClient.PostAsync(url, data.ToHttpContent()))
            {
                await response.LogAndThrowIfNotSuccessStatusCode(logger);
                return response;
            }
        }
    }
}