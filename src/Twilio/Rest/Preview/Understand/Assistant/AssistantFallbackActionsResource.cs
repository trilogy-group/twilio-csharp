/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Preview
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



namespace Kandy.Rest.Preview.Understand.Assistant
{
    public class AssistantFallbackActionsResource : Resource
    {
    

        
        private static Request BuildFetchRequest(FetchAssistantFallbackActionsOptions options, ITwilioRestClient client)
        {
            
            string path = "/understand/Assistants/{AssistantSid}/FallbackActions";

            string PathAssistantSid = options.PathAssistantSid;
            path = path.Replace("{"+"AssistantSid"+"}", PathAssistantSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch AssistantFallbackActions parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AssistantFallbackActions </returns>
        public static AssistantFallbackActionsResource Fetch(FetchAssistantFallbackActionsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch AssistantFallbackActions parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AssistantFallbackActions </returns>
        public static async System.Threading.Tasks.Task<AssistantFallbackActionsResource> FetchAsync(FetchAssistantFallbackActionsOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> fetch </summary>
        /// <param name="pathAssistantSid">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AssistantFallbackActions </returns>
        public static AssistantFallbackActionsResource Fetch(
                                         string pathAssistantSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchAssistantFallbackActionsOptions(pathAssistantSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathAssistantSid">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AssistantFallbackActions </returns>
        public static async System.Threading.Tasks.Task<AssistantFallbackActionsResource> FetchAsync(string pathAssistantSid, ITwilioRestClient client = null)
        {
            var options = new FetchAssistantFallbackActionsOptions(pathAssistantSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildUpdateRequest(UpdateAssistantFallbackActionsOptions options, ITwilioRestClient client)
        {
            
            string path = "/understand/Assistants/{AssistantSid}/FallbackActions";

            string PathAssistantSid = options.PathAssistantSid;
            path = path.Replace("{"+"AssistantSid"+"}", PathAssistantSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Preview,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> update </summary>
        /// <param name="options"> Update AssistantFallbackActions parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AssistantFallbackActions </returns>
        public static AssistantFallbackActionsResource Update(UpdateAssistantFallbackActionsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> update </summary>
        /// <param name="options"> Update AssistantFallbackActions parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AssistantFallbackActions </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<AssistantFallbackActionsResource> UpdateAsync(UpdateAssistantFallbackActionsOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> update </summary>
        /// <param name="pathAssistantSid">  </param>
        /// <param name="fallbackActions">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AssistantFallbackActions </returns>
        public static AssistantFallbackActionsResource Update(
                                          string pathAssistantSid,
                                          object fallbackActions = null,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateAssistantFallbackActionsOptions(pathAssistantSid){ FallbackActions = fallbackActions };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> update </summary>
        /// <param name="pathAssistantSid">  </param>
        /// <param name="fallbackActions">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AssistantFallbackActions </returns>
        public static async System.Threading.Tasks.Task<AssistantFallbackActionsResource> UpdateAsync(
                                                                              string pathAssistantSid,
                                                                              object fallbackActions = null,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateAssistantFallbackActionsOptions(pathAssistantSid){ FallbackActions = fallbackActions };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a AssistantFallbackActionsResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> AssistantFallbackActionsResource object represented by the provided JSON </returns>
        public static AssistantFallbackActionsResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<AssistantFallbackActionsResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The account_sid </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The assistant_sid </summary> 
        [JsonProperty("assistant_sid")]
        public string AssistantSid { get; private set; }

        ///<summary> The url </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The data </summary> 
        [JsonProperty("data")]
        public object Data { get; private set; }



        private AssistantFallbackActionsResource() {

        }
    }
}
