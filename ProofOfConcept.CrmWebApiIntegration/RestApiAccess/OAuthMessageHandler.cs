using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace ProofOfConcept.CrmWebApiIntegration.RestApiAccess
{
    public class OAuthMessageHandler : DelegatingHandler
    {
        private readonly AuthenticationHeaderValue _authHeader;

        public OAuthMessageHandler(string serviceUrl, string clientId, string redirectUrl, HttpMessageHandler innerHandler) : base(innerHandler)
        {
            // Obtain the Azure Active Directory Authentication Library (ADAL) authentication context.
            var ap = AuthenticationParameters.CreateFromResourceUrlAsync(new Uri(serviceUrl + "api/data/")).Result;
            var authContext = new AuthenticationContext(ap.Authority, false);
            
            //Note that an Azure AD access token has finite lifetime, default expiration is 60 minutes.
            var sendX5C = new Uri(redirectUrl);
            var authResult = authContext.AcquireTokenAsync(serviceUrl, clientId, sendX5C, null).Result;
            _authHeader = new AuthenticationHeaderValue("Bearer", authResult.AccessToken);
        }

        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
        {
            request.Headers.Authorization = _authHeader;
            return base.SendAsync(request, cancellationToken);
        }
    }
}