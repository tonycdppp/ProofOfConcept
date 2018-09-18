using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
            var raw = _dataProvider.HttpGet("api/data/v8.2/wnsl_events?$orderby=createdon desc&$top=10");
            if (raw.StatusCode == HttpStatusCode.OK)
            {
                var @event = JsonMapper.Deserialise<ConnectionEventModelRoot>(raw.Content.ReadAsStringAsync().Result);
                return @event.Value.ToList();
            }

            return null;
        }

        public ConnectionEventModel Insert(ConnectionEventModel model)
        {
            //this is useful because we choose what we want to update/add rather than send all the fields across
            var nameValueCollection = new Dictionary<string, string>
            {
                {"wnsl_name", model.wnsl_name},
            };
            var form = new FormUrlEncodedContent( nameValueCollection);
            
            var raw = _dataProvider.HttpPost("api/data/v8.2/wnsl_events", nameValueCollection);
            if (raw.StatusCode == HttpStatusCode.OK)
            {
                var @event = JsonMapper.Deserialise<ConnectionEventModelRoot>(raw.Content.ReadAsStringAsync().Result);
                return @event.Value.FirstOrDefault();
            }

            return null;
        }
    }
}
