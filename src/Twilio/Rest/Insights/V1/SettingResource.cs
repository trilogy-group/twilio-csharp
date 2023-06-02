/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Insights
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



namespace Kandy.Rest.Insights.V1
{
    public class SettingResource : Resource
    {
    

        
        private static Request BuildFetchRequest(FetchSettingOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Voice/Settings";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Insights,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Setting parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Setting </returns>
        public static SettingResource Fetch(FetchSettingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Setting parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Setting </returns>
        public static async System.Threading.Tasks.Task<SettingResource> FetchAsync(FetchSettingOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> fetch </summary>
        /// <param name="subaccountSid">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Setting </returns>
        public static SettingResource Fetch(
                                         string subaccountSid = null, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchSettingOptions(){ SubaccountSid = subaccountSid };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="subaccountSid">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Setting </returns>
        public static async System.Threading.Tasks.Task<SettingResource> FetchAsync(string subaccountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchSettingOptions(){ SubaccountSid = subaccountSid };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildUpdateRequest(UpdateSettingOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Voice/Settings";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Insights,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> update </summary>
        /// <param name="options"> Update Setting parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Setting </returns>
        public static SettingResource Update(UpdateSettingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> update </summary>
        /// <param name="options"> Update Setting parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Setting </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<SettingResource> UpdateAsync(UpdateSettingOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> update </summary>
        /// <param name="advancedFeatures">  </param>
        /// <param name="voiceTrace">  </param>
        /// <param name="subaccountSid">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Setting </returns>
        public static SettingResource Update(
                                          bool? advancedFeatures = null,
                                          bool? voiceTrace = null,
                                          string subaccountSid = null,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateSettingOptions(){ AdvancedFeatures = advancedFeatures, VoiceTrace = voiceTrace, SubaccountSid = subaccountSid };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> update </summary>
        /// <param name="advancedFeatures">  </param>
        /// <param name="voiceTrace">  </param>
        /// <param name="subaccountSid">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Setting </returns>
        public static async System.Threading.Tasks.Task<SettingResource> UpdateAsync(
                                                                              bool? advancedFeatures = null,
                                                                              bool? voiceTrace = null,
                                                                              string subaccountSid = null,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateSettingOptions(){ AdvancedFeatures = advancedFeatures, VoiceTrace = voiceTrace, SubaccountSid = subaccountSid };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a SettingResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> SettingResource object represented by the provided JSON </returns>
        public static SettingResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<SettingResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The account_sid </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The advanced_features </summary> 
        [JsonProperty("advanced_features")]
        public bool? AdvancedFeatures { get; private set; }

        ///<summary> The voice_trace </summary> 
        [JsonProperty("voice_trace")]
        public bool? VoiceTrace { get; private set; }

        ///<summary> The url </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private SettingResource() {

        }
    }
}
