/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Flex
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



namespace Kandy.Rest.FlexApi.V1
{
    public class InsightsSettingsCommentResource : Resource
    {
    

        
        private static Request BuildFetchRequest(FetchInsightsSettingsCommentOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Insights/QualityManagement/Settings/CommentTags";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.FlexApi,
                path,
                queryParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }

        /// <summary> To get the Comment Settings for an Account </summary>
        /// <param name="options"> Fetch InsightsSettingsComment parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InsightsSettingsComment </returns>
        public static InsightsSettingsCommentResource Fetch(FetchInsightsSettingsCommentOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> To get the Comment Settings for an Account </summary>
        /// <param name="options"> Fetch InsightsSettingsComment parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InsightsSettingsComment </returns>
        public static async System.Threading.Tasks.Task<InsightsSettingsCommentResource> FetchAsync(FetchInsightsSettingsCommentOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> To get the Comment Settings for an Account </summary>
        /// <param name="authorization"> The Authorization HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of InsightsSettingsComment </returns>
        public static InsightsSettingsCommentResource Fetch(
                                         string authorization = null, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchInsightsSettingsCommentOptions(){ Authorization = authorization };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> To get the Comment Settings for an Account </summary>
        /// <param name="authorization"> The Authorization HTTP request header </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of InsightsSettingsComment </returns>
        public static async System.Threading.Tasks.Task<InsightsSettingsCommentResource> FetchAsync(string authorization = null, ITwilioRestClient client = null)
        {
            var options = new FetchInsightsSettingsCommentOptions(){ Authorization = authorization };
            return await FetchAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a InsightsSettingsCommentResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> InsightsSettingsCommentResource object represented by the provided JSON </returns>
        public static InsightsSettingsCommentResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<InsightsSettingsCommentResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Flex Insights resource and owns this resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The comments </summary> 
        [JsonProperty("comments")]
        public object Comments { get; private set; }

        ///<summary> The url </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private InsightsSettingsCommentResource() {

        }
    }
}
