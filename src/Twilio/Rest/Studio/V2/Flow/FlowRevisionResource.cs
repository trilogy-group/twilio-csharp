/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Studio
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


namespace Kandy.Rest.Studio.V2.Flow
{
    public class FlowRevisionResource : Resource
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
            public static readonly StatusEnum Draft = new StatusEnum("draft");
            public static readonly StatusEnum Published = new StatusEnum("published");

        }

        
        private static Request BuildFetchRequest(FetchFlowRevisionOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Flows/{Sid}/Revisions/{Revision}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);
            string PathRevision = options.PathRevision;
            path = path.Replace("{"+"Revision"+"}", PathRevision);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Studio,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Retrieve a specific Flow revision. </summary>
        /// <param name="options"> Fetch FlowRevision parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of FlowRevision </returns>
        public static FlowRevisionResource Fetch(FetchFlowRevisionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Retrieve a specific Flow revision. </summary>
        /// <param name="options"> Fetch FlowRevision parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of FlowRevision </returns>
        public static async System.Threading.Tasks.Task<FlowRevisionResource> FetchAsync(FetchFlowRevisionOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Retrieve a specific Flow revision. </summary>
        /// <param name="pathSid"> The SID of the Flow resource to fetch. </param>
        /// <param name="pathRevision"> Specific Revision number or can be `LatestPublished` and `LatestRevision`. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of FlowRevision </returns>
        public static FlowRevisionResource Fetch(
                                         string pathSid, 
                                         string pathRevision, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchFlowRevisionOptions(pathSid, pathRevision){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a specific Flow revision. </summary>
        /// <param name="pathSid"> The SID of the Flow resource to fetch. </param>
        /// <param name="pathRevision"> Specific Revision number or can be `LatestPublished` and `LatestRevision`. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of FlowRevision </returns>
        public static async System.Threading.Tasks.Task<FlowRevisionResource> FetchAsync(string pathSid, string pathRevision, ITwilioRestClient client = null)
        {
            var options = new FetchFlowRevisionOptions(pathSid, pathRevision){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadFlowRevisionOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Flows/{Sid}/Revisions";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Studio,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of all Flows revisions. </summary>
        /// <param name="options"> Read FlowRevision parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of FlowRevision </returns>
        public static ResourceSet<FlowRevisionResource> Read(ReadFlowRevisionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<FlowRevisionResource>.FromJson("revisions", response.Content);
            return new ResourceSet<FlowRevisionResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Flows revisions. </summary>
        /// <param name="options"> Read FlowRevision parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of FlowRevision </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<FlowRevisionResource>> ReadAsync(ReadFlowRevisionOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<FlowRevisionResource>.FromJson("revisions", response.Content);
            return new ResourceSet<FlowRevisionResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of all Flows revisions. </summary>
        /// <param name="pathSid"> The SID of the Flow resource to fetch. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of FlowRevision </returns>
        public static ResourceSet<FlowRevisionResource> Read(
                                                     string pathSid,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadFlowRevisionOptions(pathSid){ PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Flows revisions. </summary>
        /// <param name="pathSid"> The SID of the Flow resource to fetch. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of FlowRevision </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<FlowRevisionResource>> ReadAsync(
                                                                                             string pathSid,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadFlowRevisionOptions(pathSid){ PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<FlowRevisionResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<FlowRevisionResource>.FromJson("revisions", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<FlowRevisionResource> NextPage(Page<FlowRevisionResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<FlowRevisionResource>.FromJson("revisions", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<FlowRevisionResource> PreviousPage(Page<FlowRevisionResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<FlowRevisionResource>.FromJson("revisions", response.Content);
        }

    
        /// <summary>
        /// Converts a JSON string into a FlowRevisionResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> FlowRevisionResource object represented by the provided JSON </returns>
        public static FlowRevisionResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<FlowRevisionResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The unique string that we created to identify the Flow resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Flow resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The string that you assigned to describe the Flow. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> JSON representation of flow definition. </summary> 
        [JsonProperty("definition")]
        public object Definition { get; private set; }

        
        [JsonProperty("status")]
        public FlowRevisionResource.StatusEnum Status { get; private set; }

        ///<summary> The latest revision number of the Flow's definition. </summary> 
        [JsonProperty("revision")]
        public int? Revision { get; private set; }

        ///<summary> Description of change made in the revision. </summary> 
        [JsonProperty("commit_message")]
        public string CommitMessage { get; private set; }

        ///<summary> Boolean if the flow definition is valid. </summary> 
        [JsonProperty("valid")]
        public bool? Valid { get; private set; }

        ///<summary> List of error in the flow definition. </summary> 
        [JsonProperty("errors")]
        public List<object> Errors { get; private set; }

        ///<summary> The date and time in GMT when the resource was created specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT when the resource was last updated specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The absolute URL of the resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private FlowRevisionResource() {

        }
    }
}
