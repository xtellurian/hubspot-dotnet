
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace xtellurian.HubSpot.OAuth
{
    public class OAuthClient
    {
        private readonly HttpClient httpClient;

        public OAuthClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<HubspotOAuthResponse> ExchangeCode(string clientId, string clientSecret, string redirectUri, string code)
        {

            var url = "https://api.hubapi.com/oauth/v1/token";
            var data = new Dictionary<string, string>
            {
                {"grant_type","authorization_code"},
                {"client_id", clientId},
                {"client_secret",clientSecret},
                {"redirect_uri",redirectUri},
                {"code",code}
            };

            try
            {
                using (HttpContent formContent = new FormUrlEncodedContent(data))
                {
                    using (HttpResponseMessage response = await httpClient.PostAsync(url, formContent).ConfigureAwait(false))
                    {
                        response.EnsureSuccessStatusCode();
                        var content = await response.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<HubspotOAuthResponse>(content);
                    }
                }
            }
            catch (System.Exception ex)
            {
                throw new OAuthException("Error exchanging code", ex);
            }
        }

        public async Task<HubspotOAuthResponse> UseRefreshToken(string clientId, string clientSecret, string refreshToken)
        {
            var url = "https://api.hubapi.com/oauth/v1/token";
            var data = new Dictionary<string, string>
            {
                {"grant_type","refresh_token"},
                {"client_id", clientId},
                {"client_secret",clientSecret},
                {"refresh_token",refreshToken}
            };

            try
            {
                using (HttpContent formContent = new FormUrlEncodedContent(data))
                {
                    using (HttpResponseMessage response = await httpClient.PostAsync(url, formContent).ConfigureAwait(false))
                    {
                        response.EnsureSuccessStatusCode();
                        var content = await response.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<HubspotOAuthResponse>(content);
                    }
                }
            }
            catch (System.Exception ex)
            {
                throw new OAuthException("Error exchanging code", ex);
            }
        }
    }

    public class HubspotOAuthResponse
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }
        [JsonProperty("expires_in")]
        public long ExpiresIn { get; set; }

    }

    public class OAuthException : System.Exception
    {
        public OAuthException(string message, System.Exception innerExeption) : base(message, innerExeption)
        { }
    }
}