using System;
using ProofOfConcept.CrmWebApiIntegration.Model;

namespace ProofOfConcept.CrmWebApiIntegration
{
    public interface IConnectionEventService
    {
        ConnectionEventModel Retrieve(Guid id);
        ConnectionEventModel Retrieve();
    }
}
