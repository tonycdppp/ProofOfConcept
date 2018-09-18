using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ProofOfConcept.CrmWebApiIntegration.Model
{
    public class ConnectionEventModel
    {
        [JsonProperty("@odata.etag")]
        public string ODataETag { get; set; }
        public int statecode { get; set; }
        public int statuscode { get; set; }
        public bool wnsl_coreeventonly { get; set; }
        public DateTime createdon { get; set; }
        public bool chrys_ticketresalespermitted { get; set; }
        public bool chrys_tickettransferspermitted { get; set; }
        public string wnsl_eventid { get; set; }
        public bool wnsl_shortseason { get; set; }
        public string wnsl_name { get; set; }
        public bool wnsl_productscreated { get; set; }
        public string _stageid_value { get; set; }
        public bool wnsl_alleventbox { get; set; }
        public bool wnsl_england10 { get; set; }
        public bool wnsl_international { get; set; }
        public int versionnumber { get; set; }
        public string traversedpath { get; set; }
        public bool wnsl_core { get; set; }
        public bool chrys_inventoryincrm { get; set; }
        public string _modifiedby_value { get; set; }
        public DateTime modifiedon { get; set; }
        public int wnsl_eventtype { get; set; }
        public bool wnsl_englandfinals { get; set; }
        public string _createdby_value { get; set; }
        public string _organizationid_value { get; set; }
        public bool wnsl_other { get; set; }
        public string processid { get; set; }
        public bool wnsl_nonlicenceevent { get; set; }
        public object chrys_fortresseventcode { get; set; }
        public int? timezoneruleversionnumber { get; set; }
        public object wnsl_seasoncode { get; set; }
        public object chrys_tickettransferwindowopens { get; set; }
        public int? chrys_availableplaces { get; set; }
        public object wnsl_position { get; set; }
        public object chrys_donationwindowcloses { get; set; }
        public object chrys_tickettransferwindowcloses { get; set; }
        public object chrys_boxresalewindowopens { get; set; }
        public object chrys_avmastereventid { get; set; }
        public DateTime? chrys_rsvpwindowclosedate { get; set; }
        public DateTime? wnsl_dateandtime { get; set; }
        public object _createdonbehalfby_value { get; set; }
        public string _chrys_eventsid_value { get; set; }
        public object chrys_eventregistrationcloseddate { get; set; }
        public object _modifiedonbehalfby_value { get; set; }
        public object overriddencreatedon { get; set; }
        public object chrys_eventregistrationopendate { get; set; }
        public object chrys_eventcategory { get; set; }
        public int? chrys_allocationmethod { get; set; }
        public object chrys_fortressmastereventid { get; set; }
        public DateTime? chrys_registrationopendate { get; set; }
        public string _wnsl_seasonid_value { get; set; }
        public DateTime? chrys_registrationclosedate { get; set; }
        public int? utcconversiontimezonecode { get; set; }
        public object chrys_resalewindowcloses { get; set; }
        public string chrys_description { get; set; }
        public object _chrys_stadiumseatmapid_value { get; set; }
        public object chrys_occupiedplaces { get; set; }
        public object chrys_resalewindowopens { get; set; }
        public object importsequencenumber { get; set; }
        public int? chrys_tickettransferlimit { get; set; }
        public int? chrys_numberofguestsallowedpermember { get; set; }
        public string _chrys_manager_value { get; set; }
        public object chrys_nametoappearonitinerary { get; set; }
        public object wnsl_eventcode { get; set; }
        public object chrys_ticketresalelimit { get; set; }
        public object chrys_donationwindowopens { get; set; }
        public object chrys_boxresalewindowcloses { get; set; }
    }

    public class ConnectionEventModelRoot
    {
        [JsonProperty("@odata.context")]
        public string ODataContext { get; set; }
        public List<ConnectionEventModel> Value { get; set; }
    }
}