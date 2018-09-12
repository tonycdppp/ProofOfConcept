using System;
using ProofOfConcept.CrmWebApiIntegration.Model;
using ProofOfConcept.CrmWebApiIntegration.RestApiAccess;

namespace ProofOfConcept.CrmWebApiIntegration.Service
{
    public class ConnectionEventService : IConnectionEventService
    {
        private readonly IProvider _dataProvider;

        public ConnectionEventService(IProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }

        public ConnectionEventModel Retrieve(Guid id)
        {
            throw new NotImplementedException();
        }

        public ConnectionEventModel Retrieve()
        {
            throw new NotImplementedException();
        }
    }
}
