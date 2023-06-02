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


namespace Kandy.Rest.Studio.V1.Flow
{
    public class EngagementResource : Resource
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
            public static readonly StatusEnum Active = new StatusEnum("active");
            public static readonly StatusEnum Ended = new StatusEnum("ended");

        }

        
        private static Request BuildCreateRequest(CreateEngagementOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Flows/{FlowSid}/Engagements";

            string PathFlowSid = options.PathFlowSid;
            path = path.Replace("{"+"FlowSid"+"}", PathFlowSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Studio,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Triggers a new Engagement for the Flow </summary>
        /// <param name="options"> Create Engagement parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Engagement </returns>
        public static EngagementResource Create(CreateEngagementOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Triggers a new Engagement for the Flow </summary>
        /// <param name="options"> Create Engagement parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Engagement </returns>
        public static async System.Threading.Tasks.Task<EngagementResource> CreateAsync(CreateEngagementOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Triggers a new Engagement for the Flow </summary>
        /// <param name="pathFlowSid"> The SID of the Flow. </param>
        /// <param name="to"> The Contact phone number to start a Studio Flow Engagement, available as variable `{{contact.channel.address}}`. </param>
        /// <param name="from"> The Twilio phone number to send messages or initiate calls from during the Flow Engagement. Available as variable `{{flow.channel.address}}` </param>
        /// <param name="parameters"> A JSON string we will add to your flow's context and that you can access as variables inside your flow. For example, if you pass in `Parameters={'name':'Zeke'}` then inside a widget you can reference the variable `{{flow.data.name}}` which will return the string 'Zeke'. Note: the JSON value must explicitly be passed as a string, not as a hash object. Depending on your particular HTTP library, you may need to add quotes or URL encode your JSON string. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Engagement </returns>
        public static EngagementResource Create(
                                          string pathFlowSid,
                                          Types.PhoneNumber to,
                                          Types.PhoneNumber from,
                                          object parameters = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateEngagementOptions(pathFlowSid, to, from){  Parameters = parameters };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Triggers a new Engagement for the Flow </summary>
        /// <param name="pathFlowSid"> The SID of the Flow. </param>
        /// <param name="to"> The Contact phone number to start a Studio Flow Engagement, available as variable `{{contact.channel.address}}`. </param>
        /// <param name="from"> The Twilio phone number to send messages or initiate calls from during the Flow Engagement. Available as variable `{{flow.channel.address}}` </param>
        /// <param name="parameters"> A JSON string we will add to your flow's context and that you can access as variables inside your flow. For example, if you pass in `Parameters={'name':'Zeke'}` then inside a widget you can reference the variable `{{flow.data.name}}` which will return the string 'Zeke'. Note: the JSON value must explicitly be passed as a string, not as a hash object. Depending on your particular HTTP library, you may need to add quotes or URL encode your JSON string. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Engagement </returns>
        public static async System.Threading.Tasks.Task<EngagementResource> CreateAsync(
                                                                                  string pathFlowSid,
                                                                                  Types.PhoneNumber to,
                                                                                  Types.PhoneNumber from,
                                                                                  object parameters = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateEngagementOptions(pathFlowSid, to, from){  Parameters = parameters };
            return await CreateAsync(options, client);
        }
        #endif
        
        /// <summary> Delete this Engagement and all Steps relating to it. </summary>
        /// <param name="options"> Delete Engagement parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Engagement </returns>
        private static Request BuildDeleteRequest(DeleteEngagementOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Flows/{FlowSid}/Engagements/{Sid}";

            string PathFlowSid = options.PathFlowSid;
            path = path.Replace("{"+"FlowSid"+"}", PathFlowSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Studio,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Delete this Engagement and all Steps relating to it. </summary>
        /// <param name="options"> Delete Engagement parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Engagement </returns>
        public static bool Delete(DeleteEngagementOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> Delete this Engagement and all Steps relating to it. </summary>
        /// <param name="options"> Delete Engagement parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Engagement </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteEngagementOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> Delete this Engagement and all Steps relating to it. </summary>
        /// <param name="pathFlowSid"> The SID of the Flow to delete Engagements from. </param>
        /// <param name="pathSid"> The SID of the Engagement resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Engagement </returns>
        public static bool Delete(string pathFlowSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteEngagementOptions(pathFlowSid, pathSid)        ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> Delete this Engagement and all Steps relating to it. </summary>
        /// <param name="pathFlowSid"> The SID of the Flow to delete Engagements from. </param>
        /// <param name="pathSid"> The SID of the Engagement resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Engagement </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathFlowSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteEngagementOptions(pathFlowSid, pathSid) ;
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchEngagementOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Flows/{FlowSid}/Engagements/{Sid}";

            string PathFlowSid = options.PathFlowSid;
            path = path.Replace("{"+"FlowSid"+"}", PathFlowSid);
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

        /// <summary> Retrieve an Engagement </summary>
        /// <param name="options"> Fetch Engagement parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Engagement </returns>
        public static EngagementResource Fetch(FetchEngagementOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Retrieve an Engagement </summary>
        /// <param name="options"> Fetch Engagement parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Engagement </returns>
        public static async System.Threading.Tasks.Task<EngagementResource> FetchAsync(FetchEngagementOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Retrieve an Engagement </summary>
        /// <param name="pathFlowSid"> The SID of the Flow. </param>
        /// <param name="pathSid"> The SID of the Engagement resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Engagement </returns>
        public static EngagementResource Fetch(
                                         string pathFlowSid, 
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchEngagementOptions(pathFlowSid, pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Retrieve an Engagement </summary>
        /// <param name="pathFlowSid"> The SID of the Flow. </param>
        /// <param name="pathSid"> The SID of the Engagement resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Engagement </returns>
        public static async System.Threading.Tasks.Task<EngagementResource> FetchAsync(string pathFlowSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchEngagementOptions(pathFlowSid, pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadEngagementOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Flows/{FlowSid}/Engagements";

            string PathFlowSid = options.PathFlowSid;
            path = path.Replace("{"+"FlowSid"+"}", PathFlowSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Studio,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of all Engagements for the Flow. </summary>
        /// <param name="options"> Read Engagement parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Engagement </returns>
        public static ResourceSet<EngagementResource> Read(ReadEngagementOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<EngagementResource>.FromJson("engagements", response.Content);
            return new ResourceSet<EngagementResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Engagements for the Flow. </summary>
        /// <param name="options"> Read Engagement parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Engagement </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<EngagementResource>> ReadAsync(ReadEngagementOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<EngagementResource>.FromJson("engagements", response.Content);
            return new ResourceSet<EngagementResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of all Engagements for the Flow. </summary>
        /// <param name="pathFlowSid"> The SID of the Flow to read Engagements from. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Engagement </returns>
        public static ResourceSet<EngagementResource> Read(
                                                     string pathFlowSid,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadEngagementOptions(pathFlowSid){ PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of all Engagements for the Flow. </summary>
        /// <param name="pathFlowSid"> The SID of the Flow to read Engagements from. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Engagement </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<EngagementResource>> ReadAsync(
                                                                                             string pathFlowSid,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadEngagementOptions(pathFlowSid){ PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<EngagementResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<EngagementResource>.FromJson("engagements", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<EngagementResource> NextPage(Page<EngagementResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<EngagementResource>.FromJson("engagements", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<EngagementResource> PreviousPage(Page<EngagementResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<EngagementResource>.FromJson("engagements", response.Content);
        }

    
        /// <summary>
        /// Converts a JSON string into a EngagementResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> EngagementResource object represented by the provided JSON </returns>
        public static EngagementResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<EngagementResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The unique string that we created to identify the Engagement resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Engagement resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The SID of the Flow. </summary> 
        [JsonProperty("flow_sid")]
        public string FlowSid { get; private set; }

        ///<summary> The SID of the Contact. </summary> 
        [JsonProperty("contact_sid")]
        public string ContactSid { get; private set; }

        ///<summary> The phone number, SIP address or Client identifier that triggered this Engagement. Phone numbers are in E.164 format (+16175551212). SIP addresses are formatted as `name@company.com`. Client identifiers are formatted `client:name`. </summary> 
        [JsonProperty("contact_channel_address")]
        public string ContactChannelAddress { get; private set; }

        ///<summary> The current state of the execution flow. As your flow executes, we save the state in a flow context. Your widgets can access the data in the flow context as variables, either in configuration fields or in text areas as variable substitution. </summary> 
        [JsonProperty("context")]
        public object Context { get; private set; }

        
        [JsonProperty("status")]
        public EngagementResource.StatusEnum Status { get; private set; }

        ///<summary> The date and time in GMT when the Engagement was created in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT when the Engagement was updated in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The absolute URL of the resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The URLs of the Engagement's nested resources. </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }



        private EngagementResource() {

        }
    }
}
