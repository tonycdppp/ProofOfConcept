﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProofOfConcept.CrmWebApiIntegration.Model;
using ProofOfConcept.CrmWebApiIntegration.RestApiAccess;

namespace ProffOfConcept.Tests.CrmWebApiIntegration.RestApiAccess
{
    [TestClass]
    public class JsonMapperTests
    {
        [TestMethod]
        public void Converts_Json_object_to_proper_object()
        {

            string jsonString = @"{
	""@odata.context"": ""http://cwdev001:5555/ClubWembley/api/data/v8.2/$metadata#wnsl_events"",
	""value"": [{
		""@odata.etag"": ""W/\""354702280\"""",
		""statecode"": 0,
		""statuscode"": 1,
		""wnsl_coreeventonly"": false,
		""createdon"": ""2018-09-18T13:46:58Z"",
		""chrys_ticketresalespermitted"": true,
		""chrys_tickettransferspermitted"": true,
		""wnsl_eventid"": ""e2156e4b-49bb-e811-9caf-080027f7cdc0"",
		""wnsl_shortseason"": false,
		""wnsl_name"": ""tonsdfsdfy"",
		""wnsl_productscreated"": false,
		""_stageid_value"": ""c63478e6-52ec-4119-a80a-27166442eb5a"",
		""wnsl_alleventbox"": false,
		""wnsl_england10"": false,
		""wnsl_international"": false,
		""versionnumber"": 354702280,
		""traversedpath"": ""c63478e6-52ec-4119-a80a-27166442eb5a"",
		""wnsl_core"": false,
		""chrys_inventoryincrm"": false,
		""_modifiedby_value"": ""c47efd9f-72e1-e711-966a-005056b77c04"",
		""modifiedon"": ""2018-09-18T13:46:58Z"",
		""wnsl_eventtype"": 2,
		""wnsl_englandfinals"": false,
		""_createdby_value"": ""c47efd9f-72e1-e711-966a-005056b77c04"",
		""_organizationid_value"": ""e8e1d7f5-9998-e311-ae5a-0050568a0034"",
		""wnsl_other"": false,
		""processid"": ""ee0971cf-bd28-4264-b1b7-fc7919c2367a"",
		""wnsl_nonlicenceevent"": false,
		""chrys_fortresseventcode"": null,
		""timezoneruleversionnumber"": null,
		""wnsl_seasoncode"": null,
		""chrys_tickettransferwindowopens"": null,
		""chrys_availableplaces"": null,
		""wnsl_position"": null,
		""chrys_donationwindowcloses"": null,
		""chrys_tickettransferwindowcloses"": null,
		""chrys_boxresalewindowopens"": null,
		""chrys_avmastereventid"": null,
		""chrys_rsvpwindowclosedate"": null,
		""wnsl_dateandtime"": null,
		""_createdonbehalfby_value"": null,
		""_chrys_eventsid_value"": null,
		""chrys_eventregistrationcloseddate"": null,
		""_modifiedonbehalfby_value"": null,
		""overriddencreatedon"": null,
		""chrys_eventregistrationopendate"": null,
		""chrys_eventcategory"": null,
		""chrys_allocationmethod"": null,
		""chrys_fortressmastereventid"": null,
		""chrys_registrationopendate"": null,
		""_wnsl_seasonid_value"": null,
		""chrys_registrationclosedate"": null,
		""utcconversiontimezonecode"": null,
		""chrys_resalewindowcloses"": null,
		""chrys_description"": null,
		""_chrys_stadiumseatmapid_value"": null,
		""chrys_occupiedplaces"": null,
		""chrys_resalewindowopens"": null,
		""importsequencenumber"": null,
		""chrys_tickettransferlimit"": null,
		""chrys_numberofguestsallowedpermember"": null,
		""_chrys_manager_value"": null,
		""chrys_nametoappearonitinerary"": null,
		""wnsl_eventcode"": null,
		""chrys_ticketresalelimit"": null,
		""chrys_donationwindowopens"": null,
		""chrys_boxresalewindowcloses"": null
	}, {
		""@odata.etag"": ""W/\""354702273\"""",
		""statecode"": 0,
		""statuscode"": 1,
		""wnsl_coreeventonly"": false,
		""createdon"": ""2018-09-18T13:46:51Z"",
		""chrys_ticketresalespermitted"": true,
		""chrys_tickettransferspermitted"": true,
		""wnsl_eventid"": ""df156e4b-49bb-e811-9caf-080027f7cdc0"",
		""wnsl_shortseason"": false,
		""wnsl_name"": ""tony"",
		""wnsl_productscreated"": false,
		""_stageid_value"": ""c63478e6-52ec-4119-a80a-27166442eb5a"",
		""wnsl_alleventbox"": false,
		""wnsl_england10"": false,
		""wnsl_international"": false,
		""versionnumber"": 354702273,
		""traversedpath"": ""c63478e6-52ec-4119-a80a-27166442eb5a"",
		""wnsl_core"": false,
		""chrys_inventoryincrm"": false,
		""_modifiedby_value"": ""c47efd9f-72e1-e711-966a-005056b77c04"",
		""modifiedon"": ""2018-09-18T13:46:51Z"",
		""wnsl_eventtype"": 2,
		""wnsl_englandfinals"": false,
		""_createdby_value"": ""c47efd9f-72e1-e711-966a-005056b77c04"",
		""_organizationid_value"": ""e8e1d7f5-9998-e311-ae5a-0050568a0034"",
		""wnsl_other"": false,
		""processid"": ""ee0971cf-bd28-4264-b1b7-fc7919c2367a"",
		""wnsl_nonlicenceevent"": false,
		""chrys_fortresseventcode"": null,
		""timezoneruleversionnumber"": null,
		""wnsl_seasoncode"": null,
		""chrys_tickettransferwindowopens"": null,
		""chrys_availableplaces"": null,
		""wnsl_position"": null,
		""chrys_donationwindowcloses"": null,
		""chrys_tickettransferwindowcloses"": null,
		""chrys_boxresalewindowopens"": null,
		""chrys_avmastereventid"": null,
		""chrys_rsvpwindowclosedate"": null,
		""wnsl_dateandtime"": null,
		""_createdonbehalfby_value"": null,
		""_chrys_eventsid_value"": null,
		""chrys_eventregistrationcloseddate"": null,
		""_modifiedonbehalfby_value"": null,
		""overriddencreatedon"": null,
		""chrys_eventregistrationopendate"": null,
		""chrys_eventcategory"": null,
		""chrys_allocationmethod"": null,
		""chrys_fortressmastereventid"": null,
		""chrys_registrationopendate"": null,
		""_wnsl_seasonid_value"": null,
		""chrys_registrationclosedate"": null,
		""utcconversiontimezonecode"": null,
		""chrys_resalewindowcloses"": null,
		""chrys_description"": null,
		""_chrys_stadiumseatmapid_value"": null,
		""chrys_occupiedplaces"": null,
		""chrys_resalewindowopens"": null,
		""importsequencenumber"": null,
		""chrys_tickettransferlimit"": null,
		""chrys_numberofguestsallowedpermember"": null,
		""_chrys_manager_value"": null,
		""chrys_nametoappearonitinerary"": null,
		""wnsl_eventcode"": null,
		""chrys_ticketresalelimit"": null,
		""chrys_donationwindowopens"": null,
		""chrys_boxresalewindowcloses"": null
	}, {
		""@odata.etag"": ""W/\""354702266\"""",
		""statecode"": 0,
		""statuscode"": 1,
		""wnsl_coreeventonly"": false,
		""createdon"": ""2018-09-18T13:46:28Z"",
		""chrys_ticketresalespermitted"": true,
		""chrys_tickettransferspermitted"": true,
		""wnsl_eventid"": ""297a903d-49bb-e811-9caf-080027f7cdc0"",
		""wnsl_shortseason"": false,
		""wnsl_name"": ""tony"",
		""wnsl_productscreated"": false,
		""_stageid_value"": ""c63478e6-52ec-4119-a80a-27166442eb5a"",
		""wnsl_alleventbox"": false,
		""wnsl_england10"": false,
		""wnsl_international"": false,
		""versionnumber"": 354702266,
		""traversedpath"": ""c63478e6-52ec-4119-a80a-27166442eb5a"",
		""wnsl_core"": false,
		""chrys_inventoryincrm"": false,
		""_modifiedby_value"": ""c47efd9f-72e1-e711-966a-005056b77c04"",
		""modifiedon"": ""2018-09-18T13:46:28Z"",
		""wnsl_eventtype"": 2,
		""wnsl_englandfinals"": false,
		""_createdby_value"": ""c47efd9f-72e1-e711-966a-005056b77c04"",
		""_organizationid_value"": ""e8e1d7f5-9998-e311-ae5a-0050568a0034"",
		""wnsl_other"": false,
		""processid"": ""ee0971cf-bd28-4264-b1b7-fc7919c2367a"",
		""wnsl_nonlicenceevent"": false,
		""chrys_fortresseventcode"": null,
		""timezoneruleversionnumber"": null,
		""wnsl_seasoncode"": null,
		""chrys_tickettransferwindowopens"": null,
		""chrys_availableplaces"": null,
		""wnsl_position"": null,
		""chrys_donationwindowcloses"": null,
		""chrys_tickettransferwindowcloses"": null,
		""chrys_boxresalewindowopens"": null,
		""chrys_avmastereventid"": null,
		""chrys_rsvpwindowclosedate"": null,
		""wnsl_dateandtime"": null,
		""_createdonbehalfby_value"": null,
		""_chrys_eventsid_value"": null,
		""chrys_eventregistrationcloseddate"": null,
		""_modifiedonbehalfby_value"": null,
		""overriddencreatedon"": null,
		""chrys_eventregistrationopendate"": null,
		""chrys_eventcategory"": null,
		""chrys_allocationmethod"": null,
		""chrys_fortressmastereventid"": null,
		""chrys_registrationopendate"": null,
		""_wnsl_seasonid_value"": null,
		""chrys_registrationclosedate"": null,
		""utcconversiontimezonecode"": null,
		""chrys_resalewindowcloses"": null,
		""chrys_description"": null,
		""_chrys_stadiumseatmapid_value"": null,
		""chrys_occupiedplaces"": null,
		""chrys_resalewindowopens"": null,
		""importsequencenumber"": null,
		""chrys_tickettransferlimit"": null,
		""chrys_numberofguestsallowedpermember"": null,
		""_chrys_manager_value"": null,
		""chrys_nametoappearonitinerary"": null,
		""wnsl_eventcode"": null,
		""chrys_ticketresalelimit"": null,
		""chrys_donationwindowopens"": null,
		""chrys_boxresalewindowcloses"": null
	}, {
		""@odata.etag"": ""W/\""354702259\"""",
		""statecode"": 0,
		""statuscode"": 1,
		""wnsl_coreeventonly"": false,
		""createdon"": ""2018-09-18T13:46:17Z"",
		""chrys_ticketresalespermitted"": true,
		""chrys_tickettransferspermitted"": true,
		""wnsl_eventid"": ""ff402037-49bb-e811-9caf-080027f7cdc0"",
		""wnsl_shortseason"": false,
		""wnsl_name"": ""Carling Cup Final 2009"",
		""wnsl_productscreated"": false,
		""_stageid_value"": ""c63478e6-52ec-4119-a80a-27166442eb5a"",
		""wnsl_alleventbox"": false,
		""wnsl_england10"": false,
		""wnsl_international"": false,
		""versionnumber"": 354702259,
		""traversedpath"": ""c63478e6-52ec-4119-a80a-27166442eb5a"",
		""wnsl_core"": false,
		""chrys_inventoryincrm"": false,
		""_modifiedby_value"": ""c47efd9f-72e1-e711-966a-005056b77c04"",
		""modifiedon"": ""2018-09-18T13:46:17Z"",
		""wnsl_eventtype"": 2,
		""wnsl_englandfinals"": false,
		""_createdby_value"": ""c47efd9f-72e1-e711-966a-005056b77c04"",
		""_organizationid_value"": ""e8e1d7f5-9998-e311-ae5a-0050568a0034"",
		""wnsl_other"": false,
		""processid"": ""ee0971cf-bd28-4264-b1b7-fc7919c2367a"",
		""wnsl_nonlicenceevent"": false,
		""chrys_fortresseventcode"": null,
		""timezoneruleversionnumber"": null,
		""wnsl_seasoncode"": null,
		""chrys_tickettransferwindowopens"": null,
		""chrys_availableplaces"": null,
		""wnsl_position"": null,
		""chrys_donationwindowcloses"": null,
		""chrys_tickettransferwindowcloses"": null,
		""chrys_boxresalewindowopens"": null,
		""chrys_avmastereventid"": null,
		""chrys_rsvpwindowclosedate"": null,
		""wnsl_dateandtime"": null,
		""_createdonbehalfby_value"": null,
		""_chrys_eventsid_value"": null,
		""chrys_eventregistrationcloseddate"": null,
		""_modifiedonbehalfby_value"": null,
		""overriddencreatedon"": null,
		""chrys_eventregistrationopendate"": null,
		""chrys_eventcategory"": null,
		""chrys_allocationmethod"": null,
		""chrys_fortressmastereventid"": null,
		""chrys_registrationopendate"": null,
		""_wnsl_seasonid_value"": null,
		""chrys_registrationclosedate"": null,
		""utcconversiontimezonecode"": null,
		""chrys_resalewindowcloses"": null,
		""chrys_description"": null,
		""_chrys_stadiumseatmapid_value"": null,
		""chrys_occupiedplaces"": null,
		""chrys_resalewindowopens"": null,
		""importsequencenumber"": null,
		""chrys_tickettransferlimit"": null,
		""chrys_numberofguestsallowedpermember"": null,
		""_chrys_manager_value"": null,
		""chrys_nametoappearonitinerary"": null,
		""wnsl_eventcode"": null,
		""chrys_ticketresalelimit"": null,
		""chrys_donationwindowopens"": null,
		""chrys_boxresalewindowcloses"": null
	}, {
		""@odata.etag"": ""W/\""354702252\"""",
		""statecode"": 0,
		""statuscode"": 1,
		""wnsl_coreeventonly"": false,
		""createdon"": ""2018-09-18T13:25:48Z"",
		""chrys_ticketresalespermitted"": true,
		""chrys_tickettransferspermitted"": true,
		""wnsl_eventid"": ""3bcb5f5a-46bb-e811-9caf-080027f7cdc0"",
		""wnsl_shortseason"": false,
		""wnsl_name"": ""Carling Cup Final 2009"",
		""wnsl_productscreated"": false,
		""_stageid_value"": ""c63478e6-52ec-4119-a80a-27166442eb5a"",
		""wnsl_alleventbox"": false,
		""wnsl_england10"": false,
		""wnsl_international"": false,
		""versionnumber"": 354702252,
		""traversedpath"": ""c63478e6-52ec-4119-a80a-27166442eb5a"",
		""wnsl_core"": false,
		""chrys_inventoryincrm"": false,
		""_modifiedby_value"": ""c47efd9f-72e1-e711-966a-005056b77c04"",
		""modifiedon"": ""2018-09-18T13:25:48Z"",
		""wnsl_eventtype"": 2,
		""wnsl_englandfinals"": false,
		""_createdby_value"": ""c47efd9f-72e1-e711-966a-005056b77c04"",
		""_organizationid_value"": ""e8e1d7f5-9998-e311-ae5a-0050568a0034"",
		""wnsl_other"": false,
		""processid"": ""ee0971cf-bd28-4264-b1b7-fc7919c2367a"",
		""wnsl_nonlicenceevent"": false,
		""chrys_fortresseventcode"": null,
		""timezoneruleversionnumber"": null,
		""wnsl_seasoncode"": null,
		""chrys_tickettransferwindowopens"": null,
		""chrys_availableplaces"": null,
		""wnsl_position"": null,
		""chrys_donationwindowcloses"": null,
		""chrys_tickettransferwindowcloses"": null,
		""chrys_boxresalewindowopens"": null,
		""chrys_avmastereventid"": null,
		""chrys_rsvpwindowclosedate"": null,
		""wnsl_dateandtime"": null,
		""_createdonbehalfby_value"": null,
		""_chrys_eventsid_value"": null,
		""chrys_eventregistrationcloseddate"": null,
		""_modifiedonbehalfby_value"": null,
		""overriddencreatedon"": null,
		""chrys_eventregistrationopendate"": null,
		""chrys_eventcategory"": null,
		""chrys_allocationmethod"": null,
		""chrys_fortressmastereventid"": null,
		""chrys_registrationopendate"": null,
		""_wnsl_seasonid_value"": null,
		""chrys_registrationclosedate"": null,
		""utcconversiontimezonecode"": null,
		""chrys_resalewindowcloses"": null,
		""chrys_description"": null,
		""_chrys_stadiumseatmapid_value"": null,
		""chrys_occupiedplaces"": null,
		""chrys_resalewindowopens"": null,
		""importsequencenumber"": null,
		""chrys_tickettransferlimit"": null,
		""chrys_numberofguestsallowedpermember"": null,
		""_chrys_manager_value"": null,
		""chrys_nametoappearonitinerary"": null,
		""wnsl_eventcode"": null,
		""chrys_ticketresalelimit"": null,
		""chrys_donationwindowopens"": null,
		""chrys_boxresalewindowcloses"": null
	}, {
		""@odata.etag"": ""W/\""354701433\"""",
		""statecode"": 0,
		""statuscode"": 1,
		""wnsl_coreeventonly"": false,
		""createdon"": ""2018-09-16T20:31:28Z"",
		""chrys_ticketresalespermitted"": true,
		""chrys_tickettransferspermitted"": true,
		""wnsl_eventid"": ""f0ccee7c-efb9-e811-9cae-080027f7cdc0"",
		""wnsl_shortseason"": false,
		""wnsl_name"": ""Anthony v Joshua"",
		""wnsl_productscreated"": false,
		""_stageid_value"": ""c0042f4a-6768-43c0-a62b-2ff773e2bf2d"",
		""wnsl_alleventbox"": false,
		""wnsl_england10"": false,
		""wnsl_international"": false,
		""versionnumber"": 354701433,
		""traversedpath"": ""c63478e6-52ec-4119-a80a-27166442eb5a,c0042f4a-6768-43c0-a62b-2ff773e2bf2d"",
		""wnsl_core"": false,
		""chrys_inventoryincrm"": false,
		""_modifiedby_value"": ""c47efd9f-72e1-e711-966a-005056b77c04"",
		""modifiedon"": ""2018-09-16T20:31:32Z"",
		""wnsl_eventtype"": 2,
		""wnsl_englandfinals"": false,
		""_createdby_value"": ""c47efd9f-72e1-e711-966a-005056b77c04"",
		""_organizationid_value"": ""e8e1d7f5-9998-e311-ae5a-0050568a0034"",
		""wnsl_other"": false,
		""processid"": ""ee0971cf-bd28-4264-b1b7-fc7919c2367a"",
		""wnsl_nonlicenceevent"": false,
		""chrys_fortresseventcode"": null,
		""timezoneruleversionnumber"": 0,
		""wnsl_seasoncode"": null,
		""chrys_tickettransferwindowopens"": null,
		""chrys_availableplaces"": null,
		""wnsl_position"": null,
		""chrys_donationwindowcloses"": null,
		""chrys_tickettransferwindowcloses"": null,
		""chrys_boxresalewindowopens"": null,
		""chrys_avmastereventid"": null,
		""chrys_rsvpwindowclosedate"": null,
		""wnsl_dateandtime"": ""2018-09-22T16:30:00Z"",
		""_createdonbehalfby_value"": null,
		""_chrys_eventsid_value"": ""6edd0611-6a33-e411-bebe-005056b10cd1"",
		""chrys_eventregistrationcloseddate"": null,
		""_modifiedonbehalfby_value"": null,
		""overriddencreatedon"": null,
		""chrys_eventregistrationopendate"": null,
		""chrys_eventcategory"": null,
		""chrys_allocationmethod"": 608050000,
		""chrys_fortressmastereventid"": null,
		""chrys_registrationopendate"": null,
		""_wnsl_seasonid_value"": ""6e51741a-6283-e311-8a9d-0050568a0081"",
		""chrys_registrationclosedate"": null,
		""utcconversiontimezonecode"": 85,
		""chrys_resalewindowcloses"": null,
		""chrys_description"": ""This is a boxing event which is going to held at wembley stadium on 22nd September 2018"",
		""_chrys_stadiumseatmapid_value"": null,
		""chrys_occupiedplaces"": null,
		""chrys_resalewindowopens"": null,
		""importsequencenumber"": null,
		""chrys_tickettransferlimit"": null,
		""chrys_numberofguestsallowedpermember"": null,
		""_chrys_manager_value"": ""c47efd9f-72e1-e711-966a-005056b77c04"",
		""chrys_nametoappearonitinerary"": null,
		""wnsl_eventcode"": null,
		""chrys_ticketresalelimit"": null,
		""chrys_donationwindowopens"": null,
		""chrys_boxresalewindowcloses"": null
	}, {
		""@odata.etag"": ""W/\""354701105\"""",
		""statecode"": 0,
		""statuscode"": 1,
		""wnsl_coreeventonly"": false,
		""createdon"": ""2018-09-14T10:26:54Z"",
		""chrys_ticketresalespermitted"": true,
		""chrys_tickettransferspermitted"": true,
		""wnsl_eventid"": ""9ab98db2-08b8-e811-9cae-080027f7cdc0"",
		""wnsl_shortseason"": false,
		""wnsl_name"": ""England Rugby Training"",
		""wnsl_productscreated"": false,
		""_stageid_value"": ""ab06b69c-ba4a-4de7-84ae-91591c49c07e"",
		""wnsl_alleventbox"": false,
		""wnsl_england10"": false,
		""wnsl_international"": false,
		""versionnumber"": 354701105,
		""traversedpath"": ""c63478e6-52ec-4119-a80a-27166442eb5a,c0042f4a-6768-43c0-a62b-2ff773e2bf2d,a8d25252-320d-425c-aae1-6afe0f59079e,c9203c1b-c07b-4b4c-af97-5a0fa60720a2,c42ccfe6-a918-4c31-b631-60c717c44e49,ab06b69c-ba4a-4de7-84ae-91591c49c07e"",
		""wnsl_core"": false,
		""chrys_inventoryincrm"": false,
		""_modifiedby_value"": ""c47efd9f-72e1-e711-966a-005056b77c04"",
		""modifiedon"": ""2018-09-14T10:40:42Z"",
		""wnsl_eventtype"": 2,
		""wnsl_englandfinals"": false,
		""_createdby_value"": ""c47efd9f-72e1-e711-966a-005056b77c04"",
		""_organizationid_value"": ""e8e1d7f5-9998-e311-ae5a-0050568a0034"",
		""wnsl_other"": false,
		""processid"": ""ee0971cf-bd28-4264-b1b7-fc7919c2367a"",
		""wnsl_nonlicenceevent"": false,
		""chrys_fortresseventcode"": null,
		""timezoneruleversionnumber"": 0,
		""wnsl_seasoncode"": null,
		""chrys_tickettransferwindowopens"": null,
		""chrys_availableplaces"": 2000,
		""wnsl_position"": null,
		""chrys_donationwindowcloses"": null,
		""chrys_tickettransferwindowcloses"": null,
		""chrys_boxresalewindowopens"": null,
		""chrys_avmastereventid"": null,
		""chrys_rsvpwindowclosedate"": ""2018-09-17T07:00:00Z"",
		""wnsl_dateandtime"": ""2018-09-30T07:00:00Z"",
		""_createdonbehalfby_value"": null,
		""_chrys_eventsid_value"": ""6edd0611-6a33-e411-bebe-005056b10cd1"",
		""chrys_eventregistrationcloseddate"": null,
		""_modifiedonbehalfby_value"": null,
		""overriddencreatedon"": null,
		""chrys_eventregistrationopendate"": null,
		""chrys_eventcategory"": null,
		""chrys_allocationmethod"": 608050000,
		""chrys_fortressmastereventid"": null,
		""chrys_registrationopendate"": ""2018-09-20T07:00:00Z"",
		""_wnsl_seasonid_value"": ""6e51741a-6283-e311-8a9d-0050568a0081"",
		""chrys_registrationclosedate"": ""2018-09-21T07:00:00Z"",
		""utcconversiontimezonecode"": 85,
		""chrys_resalewindowcloses"": null,
		""chrys_description"": ""testtmsd;jl;sdjfl"",
		""_chrys_stadiumseatmapid_value"": null,
		""chrys_occupiedplaces"": null,
		""chrys_resalewindowopens"": null,
		""importsequencenumber"": null,
		""chrys_tickettransferlimit"": null,
		""chrys_numberofguestsallowedpermember"": 1,
		""_chrys_manager_value"": ""c47efd9f-72e1-e711-966a-005056b77c04"",
		""chrys_nametoappearonitinerary"": null,
		""wnsl_eventcode"": null,
		""chrys_ticketresalelimit"": null,
		""chrys_donationwindowopens"": null,
		""chrys_boxresalewindowcloses"": null
	}, {
		""@odata.etag"": ""W/\""354700896\"""",
		""statecode"": 0,
		""statuscode"": 1,
		""wnsl_coreeventonly"": false,
		""createdon"": ""2018-09-14T09:11:07Z"",
		""chrys_ticketresalespermitted"": true,
		""chrys_tickettransferspermitted"": true,
		""wnsl_eventid"": ""dc43b21c-feb7-e811-9cae-080027f7cdc0"",
		""wnsl_shortseason"": false,
		""wnsl_name"": ""Test"",
		""wnsl_productscreated"": false,
		""_stageid_value"": ""c63478e6-52ec-4119-a80a-27166442eb5a"",
		""wnsl_alleventbox"": false,
		""wnsl_england10"": false,
		""wnsl_international"": false,
		""versionnumber"": 354700896,
		""traversedpath"": ""c63478e6-52ec-4119-a80a-27166442eb5a"",
		""wnsl_core"": false,
		""chrys_inventoryincrm"": false,
		""_modifiedby_value"": ""c47efd9f-72e1-e711-966a-005056b77c04"",
		""modifiedon"": ""2018-09-14T09:13:22Z"",
		""wnsl_eventtype"": 2,
		""wnsl_englandfinals"": false,
		""_createdby_value"": ""c47efd9f-72e1-e711-966a-005056b77c04"",
		""_organizationid_value"": ""e8e1d7f5-9998-e311-ae5a-0050568a0034"",
		""wnsl_other"": false,
		""processid"": ""ee0971cf-bd28-4264-b1b7-fc7919c2367a"",
		""wnsl_nonlicenceevent"": false,
		""chrys_fortresseventcode"": null,
		""timezoneruleversionnumber"": 0,
		""wnsl_seasoncode"": null,
		""chrys_tickettransferwindowopens"": null,
		""chrys_availableplaces"": null,
		""wnsl_position"": null,
		""chrys_donationwindowcloses"": null,
		""chrys_tickettransferwindowcloses"": null,
		""chrys_boxresalewindowopens"": null,
		""chrys_avmastereventid"": null,
		""chrys_rsvpwindowclosedate"": null,
		""wnsl_dateandtime"": ""2018-09-30T07:00:00Z"",
		""_createdonbehalfby_value"": null,
		""_chrys_eventsid_value"": ""6edd0611-6a33-e411-bebe-005056b10cd1"",
		""chrys_eventregistrationcloseddate"": null,
		""_modifiedonbehalfby_value"": null,
		""overriddencreatedon"": null,
		""chrys_eventregistrationopendate"": null,
		""chrys_eventcategory"": null,
		""chrys_allocationmethod"": 608050000,
		""chrys_fortressmastereventid"": null,
		""chrys_registrationopendate"": null,
		""_wnsl_seasonid_value"": ""6e51741a-6283-e311-8a9d-0050568a0081"",
		""chrys_registrationclosedate"": null,
		""utcconversiontimezonecode"": 85,
		""chrys_resalewindowcloses"": null,
		""chrys_description"": null,
		""_chrys_stadiumseatmapid_value"": null,
		""chrys_occupiedplaces"": null,
		""chrys_resalewindowopens"": null,
		""importsequencenumber"": null,
		""chrys_tickettransferlimit"": null,
		""chrys_numberofguestsallowedpermember"": null,
		""_chrys_manager_value"": ""c47efd9f-72e1-e711-966a-005056b77c04"",
		""chrys_nametoappearonitinerary"": null,
		""wnsl_eventcode"": null,
		""chrys_ticketresalelimit"": null,
		""chrys_donationwindowopens"": null,
		""chrys_boxresalewindowcloses"": null
	}, {
		""@odata.etag"": ""W/\""354700023\"""",
		""statecode"": 0,
		""statuscode"": 1,
		""wnsl_coreeventonly"": false,
		""createdon"": ""2018-09-13T12:49:48Z"",
		""chrys_ticketresalespermitted"": true,
		""chrys_tickettransferspermitted"": true,
		""wnsl_eventid"": ""4ec4377f-53b7-e811-9cad-080027f7cdc0"",
		""wnsl_shortseason"": false,
		""wnsl_name"": ""test 1"",
		""wnsl_productscreated"": false,
		""_stageid_value"": ""c63478e6-52ec-4119-a80a-27166442eb5a"",
		""wnsl_alleventbox"": false,
		""wnsl_england10"": false,
		""wnsl_international"": false,
		""versionnumber"": 354700023,
		""traversedpath"": ""c63478e6-52ec-4119-a80a-27166442eb5a"",
		""wnsl_core"": false,
		""chrys_inventoryincrm"": false,
		""_modifiedby_value"": ""c47efd9f-72e1-e711-966a-005056b77c04"",
		""modifiedon"": ""2018-09-14T06:41:19Z"",
		""wnsl_eventtype"": 2,
		""wnsl_englandfinals"": false,
		""_createdby_value"": ""c47efd9f-72e1-e711-966a-005056b77c04"",
		""_organizationid_value"": ""e8e1d7f5-9998-e311-ae5a-0050568a0034"",
		""wnsl_other"": false,
		""processid"": ""ee0971cf-bd28-4264-b1b7-fc7919c2367a"",
		""wnsl_nonlicenceevent"": false,
		""chrys_fortresseventcode"": null,
		""timezoneruleversionnumber"": 0,
		""wnsl_seasoncode"": null,
		""chrys_tickettransferwindowopens"": null,
		""chrys_availableplaces"": 200,
		""wnsl_position"": null,
		""chrys_donationwindowcloses"": null,
		""chrys_tickettransferwindowcloses"": null,
		""chrys_boxresalewindowopens"": null,
		""chrys_avmastereventid"": null,
		""chrys_rsvpwindowclosedate"": ""2018-09-25T07:00:00Z"",
		""wnsl_dateandtime"": ""2018-09-30T07:00:00Z"",
		""_createdonbehalfby_value"": null,
		""_chrys_eventsid_value"": ""4aebbfda-6933-e411-bebe-005056b10cd1"",
		""chrys_eventregistrationcloseddate"": null,
		""_modifiedonbehalfby_value"": null,
		""overriddencreatedon"": null,
		""chrys_eventregistrationopendate"": null,
		""chrys_eventcategory"": null,
		""chrys_allocationmethod"": 608050000,
		""chrys_fortressmastereventid"": null,
		""chrys_registrationopendate"": ""2018-09-30T07:00:00Z"",
		""_wnsl_seasonid_value"": ""6e51741a-6283-e311-8a9d-0050568a0081"",
		""chrys_registrationclosedate"": ""2018-09-26T07:00:00Z"",
		""utcconversiontimezonecode"": 85,
		""chrys_resalewindowcloses"": null,
		""chrys_description"": null,
		""_chrys_stadiumseatmapid_value"": null,
		""chrys_occupiedplaces"": null,
		""chrys_resalewindowopens"": null,
		""importsequencenumber"": null,
		""chrys_tickettransferlimit"": null,
		""chrys_numberofguestsallowedpermember"": 1,
		""_chrys_manager_value"": ""18533a46-7a41-e811-9c7c-0800276289af"",
		""chrys_nametoappearonitinerary"": null,
		""wnsl_eventcode"": null,
		""chrys_ticketresalelimit"": null,
		""chrys_donationwindowopens"": null,
		""chrys_boxresalewindowcloses"": null
	}, {
		""@odata.etag"": ""W/\""354695815\"""",
		""statecode"": 0,
		""statuscode"": 1,
		""wnsl_coreeventonly"": false,
		""createdon"": ""2018-09-13T11:13:54Z"",
		""chrys_ticketresalespermitted"": true,
		""chrys_tickettransferspermitted"": true,
		""wnsl_eventid"": ""9e017f19-46b7-e811-9cad-080027f7cdc0"",
		""wnsl_shortseason"": false,
		""wnsl_name"": ""Test 2"",
		""wnsl_productscreated"": false,
		""_stageid_value"": ""81080bad-16ff-4c7a-9801-2e5b21a57ae4"",
		""wnsl_alleventbox"": false,
		""wnsl_england10"": false,
		""wnsl_international"": false,
		""versionnumber"": 354695815,
		""traversedpath"": ""81080bad-16ff-4c7a-9801-2e5b21a57ae4"",
		""wnsl_core"": false,
		""chrys_inventoryincrm"": false,
		""_modifiedby_value"": ""c47efd9f-72e1-e711-966a-005056b77c04"",
		""modifiedon"": ""2018-09-13T11:17:24Z"",
		""wnsl_eventtype"": 2,
		""wnsl_englandfinals"": false,
		""_createdby_value"": ""c47efd9f-72e1-e711-966a-005056b77c04"",
		""_organizationid_value"": ""e8e1d7f5-9998-e311-ae5a-0050568a0034"",
		""wnsl_other"": false,
		""processid"": ""3ca9e55a-d32d-40d6-92f0-ccd144ebff02"",
		""wnsl_nonlicenceevent"": false,
		""chrys_fortresseventcode"": null,
		""timezoneruleversionnumber"": 0,
		""wnsl_seasoncode"": null,
		""chrys_tickettransferwindowopens"": null,
		""chrys_availableplaces"": null,
		""wnsl_position"": null,
		""chrys_donationwindowcloses"": null,
		""chrys_tickettransferwindowcloses"": null,
		""chrys_boxresalewindowopens"": null,
		""chrys_avmastereventid"": null,
		""chrys_rsvpwindowclosedate"": null,
		""wnsl_dateandtime"": ""2018-09-13T07:00:00Z"",
		""_createdonbehalfby_value"": null,
		""_chrys_eventsid_value"": ""6edd0611-6a33-e411-bebe-005056b10cd1"",
		""chrys_eventregistrationcloseddate"": null,
		""_modifiedonbehalfby_value"": null,
		""overriddencreatedon"": null,
		""chrys_eventregistrationopendate"": null,
		""chrys_eventcategory"": null,
		""chrys_allocationmethod"": 608050000,
		""chrys_fortressmastereventid"": null,
		""chrys_registrationopendate"": null,
		""_wnsl_seasonid_value"": ""6e51741a-6283-e311-8a9d-0050568a0081"",
		""chrys_registrationclosedate"": null,
		""utcconversiontimezonecode"": 85,
		""chrys_resalewindowcloses"": null,
		""chrys_description"": null,
		""_chrys_stadiumseatmapid_value"": null,
		""chrys_occupiedplaces"": null,
		""chrys_resalewindowopens"": null,
		""importsequencenumber"": null,
		""chrys_tickettransferlimit"": 2,
		""chrys_numberofguestsallowedpermember"": null,
		""_chrys_manager_value"": ""18533a46-7a41-e811-9c7c-0800276289af"",
		""chrys_nametoappearonitinerary"": null,
		""wnsl_eventcode"": null,
		""chrys_ticketresalelimit"": null,
		""chrys_donationwindowopens"": null,
		""chrys_boxresalewindowcloses"": null
	}]
}";
           var rootObject =  JsonMapper.Deserialise<ConnectionEventModelRoot>(jsonString);
            
            Assert.IsNotNull(rootObject);

        }
    }
}