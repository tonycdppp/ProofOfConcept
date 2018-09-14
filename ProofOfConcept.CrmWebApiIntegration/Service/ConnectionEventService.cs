using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        public IEnumerable<ConnectionEventModel> Retrieve()
        {
//            var raw = _dataProvider.HttpGet("api/data/v8.2/wnsl_events");
            var raw = _dataProvider.HttpGet("api/data/v8.2/wnsl_events?$orderby=createdon&$top=10");
            if (raw.StatusCode == HttpStatusCode.OK)
            {
                var @event = JsonMapper.Deserialise<ConnectionEventModelRoot>(raw.Content.ReadAsStringAsync().Result);
                return @event.Value.ToList();
            }

            return null;
        }
    }
}
