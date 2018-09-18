using System;
using System.Collections.Generic;
using ProofOfConcept.CrmWebApiIntegration.Model;

namespace ProofOfConcept.CrmWebApiIntegration
{
    public interface IConnectionEventService
    {
        ConnectionEventModel Retrieve(Guid id);
        IEnumerable<ConnectionEventModel> Retrieve();
        ConnectionEventModel Insert(ConnectionEventModel model);
    }
}
