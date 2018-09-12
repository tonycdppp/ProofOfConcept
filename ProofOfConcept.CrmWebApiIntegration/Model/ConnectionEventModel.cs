using ProofOfConcept.CrmWebApiIntegration.DataAccess;

namespace ProofOfConcept.CrmWebApiIntegration.Model
{
    public class ConnectionEventModel : StatelessEntity
    {
        public int wnsl_eventid { get; set; }
        public string wnsl_name { get; set; }
        
    }
}