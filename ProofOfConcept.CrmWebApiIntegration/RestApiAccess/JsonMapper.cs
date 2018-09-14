using System.Threading.Tasks;
using Newtonsoft.Json;
using ProofOfConcept.CrmWebApiIntegration.Model;

namespace ProofOfConcept.CrmWebApiIntegration.RestApiAccess
{
    public static class JsonMapper
    {
        public static T Deserialise<T>(string json)
        {
            var deserialised = JsonConvert.DeserializeObject<T>(json);
            return deserialised;
        }
    }
}