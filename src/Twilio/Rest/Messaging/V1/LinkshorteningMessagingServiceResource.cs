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


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;



namespace Kandy.Rest.Messaging.V1
{
    public class LinkshorteningMessagingServiceResource : Resource
    {
    

        
        private static Request BuildCreateRequest(CreateLinkshorteningMessagingServiceOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/LinkShortening/Domains/{DomainSid}/MessagingServices/{MessagingServiceSid}";

            string PathDomainSid = options.PathDomainSid;
            path = path.Replace("{"+"DomainSid"+"}", PathDomainSid);
            string PathMessagingServiceSid = options.PathMessagingServiceSid;
            path = path.Replace("{"+"MessagingServiceSid"+"}", PathMessagingServiceSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Messaging,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> create </summary>
        /// <param name="options"> Create LinkshorteningMessagingService parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of LinkshorteningMessagingService </returns>
        public static LinkshorteningMessagingServiceResource Create(CreateLinkshorteningMessagingServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="options"> Create LinkshorteningMessagingService parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of LinkshorteningMessagingService </returns>
        public static async System.Threading.Tasks.Task<LinkshorteningMessagingServiceResource> CreateAsync(CreateLinkshorteningMessagingServiceOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> create </summary>
        /// <param name="pathDomainSid"> The domain SID to associate with a messaging service. With URL shortening enabled, links in messages sent with the associated messaging service will be shortened to the provided domain </param>
        /// <param name="pathMessagingServiceSid"> A messaging service SID to associate with a domain. With URL shortening enabled, links in messages sent with the provided messaging service will be shortened to the associated domain </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of LinkshorteningMessagingService </returns>
        public static LinkshorteningMessagingServiceResource Create(
                                          string pathDomainSid,
                                          string pathMessagingServiceSid,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateLinkshorteningMessagingServiceOptions(pathDomainSid, pathMessagingServiceSid){  };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="pathDomainSid"> The domain SID to associate with a messaging service. With URL shortening enabled, links in messages sent with the associated messaging service will be shortened to the provided domain </param>
        /// <param name="pathMessagingServiceSid"> A messaging service SID to associate with a domain. With URL shortening enabled, links in messages sent with the provided messaging service will be shortened to the associated domain </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of LinkshorteningMessagingService </returns>
        public static async System.Threading.Tasks.Task<LinkshorteningMessagingServiceResource> CreateAsync(
                                                                                  string pathDomainSid,
                                                                                  string pathMessagingServiceSid,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateLinkshorteningMessagingServiceOptions(pathDomainSid, pathMessagingServiceSid){  };
            return await CreateAsync(options, client);
        }
        #endif
        
        /// <summary> delete </summary>
        /// <param name="options"> Delete LinkshorteningMessagingService parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of LinkshorteningMessagingService </returns>
        private static Request BuildDeleteRequest(DeleteLinkshorteningMessagingServiceOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/LinkShortening/Domains/{DomainSid}/MessagingServices/{MessagingServiceSid}";

            string PathDomainSid = options.PathDomainSid;
            path = path.Replace("{"+"DomainSid"+"}", PathDomainSid);
            string PathMessagingServiceSid = options.PathMessagingServiceSid;
            path = path.Replace("{"+"MessagingServiceSid"+"}", PathMessagingServiceSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Messaging,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> delete </summary>
        /// <param name="options"> Delete LinkshorteningMessagingService parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of LinkshorteningMessagingService </returns>
        public static bool Delete(DeleteLinkshorteningMessagingServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> delete </summary>
        /// <param name="options"> Delete LinkshorteningMessagingService parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of LinkshorteningMessagingService </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteLinkshorteningMessagingServiceOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> delete </summary>
        /// <param name="pathDomainSid"> The domain SID to dissociate from a messaging service. With URL shortening enabled, links in messages sent with the associated messaging service will be shortened to the provided domain </param>
        /// <param name="pathMessagingServiceSid"> A messaging service SID to dissociate from a domain. With URL shortening enabled, links in messages sent with the provided messaging service will be shortened to the associated domain </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of LinkshorteningMessagingService </returns>
        public static bool Delete(string pathDomainSid, string pathMessagingServiceSid, ITwilioRestClient client = null)
        {
            var options = new DeleteLinkshorteningMessagingServiceOptions(pathDomainSid, pathMessagingServiceSid)        ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> delete </summary>
        /// <param name="pathDomainSid"> The domain SID to dissociate from a messaging service. With URL shortening enabled, links in messages sent with the associated messaging service will be shortened to the provided domain </param>
        /// <param name="pathMessagingServiceSid"> A messaging service SID to dissociate from a domain. With URL shortening enabled, links in messages sent with the provided messaging service will be shortened to the associated domain </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of LinkshorteningMessagingService </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathDomainSid, string pathMessagingServiceSid, ITwilioRestClient client = null)
        {
            var options = new DeleteLinkshorteningMessagingServiceOptions(pathDomainSid, pathMessagingServiceSid) ;
            return await DeleteAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a LinkshorteningMessagingServiceResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> LinkshorteningMessagingServiceResource object represented by the provided JSON </returns>
        public static LinkshorteningMessagingServiceResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<LinkshorteningMessagingServiceResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The unique string identifies the domain resource </summary> 
        [JsonProperty("domain_sid")]
        public string DomainSid { get; private set; }

        ///<summary> The unique string that identifies the messaging service </summary> 
        [JsonProperty("messaging_service_sid")]
        public string MessagingServiceSid { get; private set; }

        ///<summary> The url </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private LinkshorteningMessagingServiceResource() {

        }
    }
}
