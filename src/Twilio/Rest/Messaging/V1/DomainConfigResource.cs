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



namespace Twilio.Rest.Messaging.V1
{
    public class DomainConfigResource : Resource
    {
    

        
        private static Request BuildFetchRequest(FetchDomainConfigOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/LinkShortening/Domains/{DomainSid}/Config";

            string PathDomainSid = options.PathDomainSid;
            path = path.Replace("{"+"DomainSid"+"}", PathDomainSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Messaging,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch DomainConfig parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of DomainConfig </returns>
        public static DomainConfigResource Fetch(FetchDomainConfigOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch DomainConfig parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of DomainConfig </returns>
        public static async System.Threading.Tasks.Task<DomainConfigResource> FetchAsync(FetchDomainConfigOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> fetch </summary>
        /// <param name="pathDomainSid"> Unique string used to identify the domain that this config should be associated with. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of DomainConfig </returns>
        public static DomainConfigResource Fetch(
                                         string pathDomainSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchDomainConfigOptions(pathDomainSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathDomainSid"> Unique string used to identify the domain that this config should be associated with. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of DomainConfig </returns>
        public static async System.Threading.Tasks.Task<DomainConfigResource> FetchAsync(string pathDomainSid, ITwilioRestClient client = null)
        {
            var options = new FetchDomainConfigOptions(pathDomainSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildUpdateRequest(UpdateDomainConfigOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/LinkShortening/Domains/{DomainSid}/Config";

            string PathDomainSid = options.PathDomainSid;
            path = path.Replace("{"+"DomainSid"+"}", PathDomainSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Messaging,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> update </summary>
        /// <param name="options"> Update DomainConfig parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of DomainConfig </returns>
        public static DomainConfigResource Update(UpdateDomainConfigOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> update </summary>
        /// <param name="options"> Update DomainConfig parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of DomainConfig </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<DomainConfigResource> UpdateAsync(UpdateDomainConfigOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> update </summary>
        /// <param name="pathDomainSid"> Unique string used to identify the domain that this config should be associated with. </param>
        /// <param name="fallbackUrl"> Any requests we receive to this domain that do not match an existing shortened message will be redirected to the fallback url. These will likely be either expired messages, random misdirected traffic, or intentional scraping. </param>
        /// <param name="callbackUrl"> URL to receive click events to your webhook whenever the recipients click on the shortened links </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of DomainConfig </returns>
        public static DomainConfigResource Update(
                                          string pathDomainSid,
                                          Uri fallbackUrl = null,
                                          Uri callbackUrl = null,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateDomainConfigOptions(pathDomainSid){ FallbackUrl = fallbackUrl, CallbackUrl = callbackUrl };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> update </summary>
        /// <param name="pathDomainSid"> Unique string used to identify the domain that this config should be associated with. </param>
        /// <param name="fallbackUrl"> Any requests we receive to this domain that do not match an existing shortened message will be redirected to the fallback url. These will likely be either expired messages, random misdirected traffic, or intentional scraping. </param>
        /// <param name="callbackUrl"> URL to receive click events to your webhook whenever the recipients click on the shortened links </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of DomainConfig </returns>
        public static async System.Threading.Tasks.Task<DomainConfigResource> UpdateAsync(
                                                                              string pathDomainSid,
                                                                              Uri fallbackUrl = null,
                                                                              Uri callbackUrl = null,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateDomainConfigOptions(pathDomainSid){ FallbackUrl = fallbackUrl, CallbackUrl = callbackUrl };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a DomainConfigResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> DomainConfigResource object represented by the provided JSON </returns>
        public static DomainConfigResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<DomainConfigResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The unique string that we created to identify the Domain resource. </summary> 
        [JsonProperty("domain_sid")]
        public string DomainSid { get; private set; }

        ///<summary> The unique string that we created to identify the Domain config (prefix ZK). </summary> 
        [JsonProperty("config_sid")]
        public string ConfigSid { get; private set; }

        ///<summary> Any requests we receive to this domain that do not match an existing shortened message will be redirected to the fallback url. These will likely be either expired messages, random misdirected traffic, or intentional scraping. </summary> 
        [JsonProperty("fallback_url")]
        public Uri FallbackUrl { get; private set; }

        ///<summary> URL to receive click events to your webhook whenever the recipients click on the shortened links. </summary> 
        [JsonProperty("callback_url")]
        public Uri CallbackUrl { get; private set; }

        ///<summary> Date this Domain Config was created. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> Date that this Domain Config was last updated. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The url </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private DomainConfigResource() {

        }
    }
}

