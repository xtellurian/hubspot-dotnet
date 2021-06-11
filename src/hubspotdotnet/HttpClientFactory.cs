using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace xtellurian.HubSpot
{
    public static class HttpClientFactory
    {
        public static HttpClient GetHttpClient()
        {
            return new HttpClient();
        }

        public static HttpClient GetHttpClient(string apiKey)
        {
            return new HttpClient(new HubspotApiKeyHttpClientHandler(apiKey));
        }
    }

    public class HubspotApiKeyHttpClientHandler : HttpClientHandler
    {
        private string apiKey;
        public HubspotApiKeyHttpClientHandler(string apiKey)
        {
            this.apiKey = apiKey;
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var requestUrl = request.RequestUri.ToString();
            if (requestUrl.Contains("?"))
            {
                requestUrl = $"{requestUrl}&hapikey={this.apiKey}";
            }
            else
            {
                requestUrl = $"{requestUrl}?hapikey={this.apiKey}";
            }
            request.RequestUri = new Uri(requestUrl);
            return base.SendAsync(request, cancellationToken);
        }
    }
}