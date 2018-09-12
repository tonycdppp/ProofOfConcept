using System.Net.Http;
using System.Threading.Tasks;

namespace ProofOfConcept.CrmWebApiIntegration.RestApiAccess
{
    public interface IProvider
    {
        Task<HttpResponseMessage> HttpGetAsync(string call);
        Task<HttpResponseMessage> HttpPostAsync(string call, object model);
        HttpResponseMessage HttpGet(string call);
        HttpResponseMessage HttpPost(string call, object model);
    }
}