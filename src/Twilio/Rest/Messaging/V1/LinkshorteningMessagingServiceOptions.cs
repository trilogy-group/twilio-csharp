/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Messaging
 * This is the public Twilio REST API.
 *
 * NOTE: This class is auto generated by OpenAPI Generator.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;




namespace Kandy.Rest.Messaging.V1
{

    /// <summary> create </summary>
    public class CreateLinkshorteningMessagingServiceOptions : IOptions<LinkshorteningMessagingServiceResource>
    {
        
        ///<summary> The domain SID to associate with a messaging service. With URL shortening enabled, links in messages sent with the associated messaging service will be shortened to the provided domain </summary> 
        public string PathDomainSid { get; }

        ///<summary> A messaging service SID to associate with a domain. With URL shortening enabled, links in messages sent with the provided messaging service will be shortened to the associated domain </summary> 
        public string PathMessagingServiceSid { get; }


        /// <summary> Construct a new CreateLinkshorteningMessagingServiceOptions </summary>
        /// <param name="pathDomainSid"> The domain SID to associate with a messaging service. With URL shortening enabled, links in messages sent with the associated messaging service will be shortened to the provided domain </param>
        /// <param name="pathMessagingServiceSid"> A messaging service SID to associate with a domain. With URL shortening enabled, links in messages sent with the provided messaging service will be shortened to the associated domain </param>
        public CreateLinkshorteningMessagingServiceOptions(string pathDomainSid, string pathMessagingServiceSid)
        {
            PathDomainSid = pathDomainSid;
            PathMessagingServiceSid = pathMessagingServiceSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }
    /// <summary> delete </summary>
    public class DeleteLinkshorteningMessagingServiceOptions : IOptions<LinkshorteningMessagingServiceResource>
    {
        
        ///<summary> The domain SID to dissociate from a messaging service. With URL shortening enabled, links in messages sent with the associated messaging service will be shortened to the provided domain </summary> 
        public string PathDomainSid { get; }

        ///<summary> A messaging service SID to dissociate from a domain. With URL shortening enabled, links in messages sent with the provided messaging service will be shortened to the associated domain </summary> 
        public string PathMessagingServiceSid { get; }



        /// <summary> Construct a new DeleteLinkshorteningMessagingServiceOptions </summary>
        /// <param name="pathDomainSid"> The domain SID to dissociate from a messaging service. With URL shortening enabled, links in messages sent with the associated messaging service will be shortened to the provided domain </param>
        /// <param name="pathMessagingServiceSid"> A messaging service SID to dissociate from a domain. With URL shortening enabled, links in messages sent with the provided messaging service will be shortened to the associated domain </param>
        public DeleteLinkshorteningMessagingServiceOptions(string pathDomainSid, string pathMessagingServiceSid)
        {
            PathDomainSid = pathDomainSid;
            PathMessagingServiceSid = pathMessagingServiceSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


}
