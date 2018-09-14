using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProofOfConcept.CrmWebApiIntegration.RestApiAccess
{
    public class DynamicsRestApiProvider : IProvider
    {
        //private static string _serviceUrlCrmOnline = "https://mydomain.crm.dynamics.com/";  // CRM Online
        //private static string _serviceUrlIfd = "http://cwdev001:5555/ClubWembley"       // CRM Internet-Facing Deployment (IFD)
        private static string _serviceUrl = "http://cwdev001:5555/ClubWembley/";          // CRM on-premises


        //TODO: For an on-premises deployment, set your organization credentials here. (If online or IFD, you can you can disregard or set to null.)
        private const string UserAccount = "Administrator"; //CRM user account
        private const string Password = "pass@word11"; //CRM user password
        private const string Domain = "SOFTDYNAMIX"; //CRM server domain

        //TODO: For CRM Online or IFD deployments, substitute your app registration values here. (If on-premise, you can disregard or set to null.)
        private const string ClientId = "<app-reg-guid>"; //e.g. "e5cf0024-a66a-4f16-85ce-99ba97a24bb2"
        private const string RedirectUrl = "<redirect-URL>"; //e.g. "http://localhost/SdkSample"

        private HttpMessageHandler MessageHandler { get; set; }


        public DynamicsRestApiProvider()
        {
        }

        public async Task<HttpResponseMessage> HttpGetAsync(string call)
        {

            //            if (_serviceUrl.StartsWith("https://"))
            //            {
            //                _httpClientHandler = new HttpClientHandler();
            //                MessageHandler = new OAuthMessageHandler(_serviceUrl, ClientId, RedirectUrl, _httpClientHandler);
            //            }
            //            else
            //            {
            var credentials = new NetworkCredential(UserAccount, Password, Domain);
            MessageHandler = new HttpClientHandler { Credentials = credentials };
            //            }


            using (var client = new HttpClient(MessageHandler))
            {
                client.BaseAddress = new Uri(_serviceUrl);
                client.Timeout = new TimeSpan(0, 2, 0);  //2 minutes

//                client.DefaultRequestHeaders.Accept.Clear();
//                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync(call);

                return response;
            }
        }

        public async Task<HttpResponseMessage> HttpPostAsync(string call, object model)
        {
            using (var client = new HttpClient(MessageHandler))
            {
                client.BaseAddress = new Uri(_serviceUrl);
                client.Timeout = new TimeSpan(0, 2, 0);  //2 minutes
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var jsonString = JsonConvert.SerializeObject(model);
                var response = await client.PostAsync(call, new StringContent(jsonString, Encoding.UTF8, "application/json"));

                return response;
            }
        }

        public HttpResponseMessage HttpGet(string call)
        {
            return HttpGetAsync(call).Result;
        }

        public HttpResponseMessage HttpPost(string call, object model)
        {
            return HttpPostAsync(call, model).Result;
        }
    }
}