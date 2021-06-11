using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using xtellurian.HubSpot;
using xtellurian.HubSpot.Contacts;
using xtellurian.HubSpot.ContactProperties;
using Xunit;
using Newtonsoft.Json;

namespace tests
{
    public class BasicTests
    {
        private const string key = "";

        [Fact]
        public async Task Test1()
        {

            var httpClient = HttpClientFactory.GetHttpClient(key);

            // httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var contacts = new ContactsClient(httpClient);

            var properties = new List<string>
            {
                "hs_lifecyclestage_subscriber_date"
            };
            var x = await contacts.CrmV3ObjectsContactsGetAsync(50, null, properties, null, false);
            Console.WriteLine(x);
        }
        
        [Fact]
        public async Task Test2()
        {

            var httpClient = HttpClientFactory.GetHttpClient(key);

            // httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            var contacts = new ContactPropertiesClient(httpClient);

            var x = await contacts.CrmV3PropertiesGetAsync("contact", false);
            Console.WriteLine(JsonConvert.SerializeObject(x));

        }
    }
}
