/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Serverless
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
using Twilio.Types;


namespace Kandy.Rest.Serverless.V1.Service.Build
{
    public class BuildStatusResource : Resource
    {
    
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class StatusEnum : StringEnum
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
            public static implicit operator StatusEnum(string value)
            {
                return new StatusEnum(value);
            }
            public static readonly StatusEnum Building = new StatusEnum("building");
            public static readonly StatusEnum Completed = new StatusEnum("completed");
            public static readonly StatusEnum Failed = new StatusEnum("failed");

        }

        
        private static Request BuildFetchRequest(FetchBuildStatusOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services/{ServiceSid}/Builds/{Sid}/Status";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Serverless,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Retrieve a specific Build resource. </summary>
        /// <param name="options"> Fetch BuildStatus parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BuildStatus </returns>
        public static BuildStatusResource Fetch(FetchBuildStatusOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Retrieve a specific Build resource. </summary>
        /// <param name="options"> Fetch BuildStatus parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BuildStatus </returns>
        public static async System.Threading.Tasks.Task<BuildStatusResource> FetchAsync(FetchBuildStatusOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Retrieve a specific Build resource. </summary>
        /// <param name="pathServiceSid"> The SID of the Service to fetch the Build resource from. </param>
        /// <param name="pathSid"> The SID of the Build resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BuildStatus </returns>
        public static BuildStatusResource Fetch(
                                         string pathServiceSid, 
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchBuildStatusOptions(pathServiceSid, pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a specific Build resource. </summary>
        /// <param name="pathServiceSid"> The SID of the Service to fetch the Build resource from. </param>
        /// <param name="pathSid"> The SID of the Build resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BuildStatus </returns>
        public static async System.Threading.Tasks.Task<BuildStatusResource> FetchAsync(string pathServiceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchBuildStatusOptions(pathServiceSid, pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a BuildStatusResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> BuildStatusResource object represented by the provided JSON </returns>
        public static BuildStatusResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<BuildStatusResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The unique string that we created to identify the Build resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Build resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The SID of the Service that the Build resource is associated with. </summary> 
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }

        
        [JsonProperty("status")]
        public BuildStatusResource.StatusEnum Status { get; private set; }

        ///<summary> The absolute URL of the Build Status resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private BuildStatusResource() {

        }
    }
}
