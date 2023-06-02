/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Content
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



namespace Kandy.Rest.Content.V1
{
    public class ContentAndApprovalsResource : Resource
    {
    

        
        private static Request BuildReadRequest(ReadContentAndApprovalsOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/ContentAndApprovals";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Content,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of Contents with approval statuses belonging to the account used to make the request </summary>
        /// <param name="options"> Read ContentAndApprovals parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ContentAndApprovals </returns>
        public static ResourceSet<ContentAndApprovalsResource> Read(ReadContentAndApprovalsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<ContentAndApprovalsResource>.FromJson("contents", response.Content);
            return new ResourceSet<ContentAndApprovalsResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of Contents with approval statuses belonging to the account used to make the request </summary>
        /// <param name="options"> Read ContentAndApprovals parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ContentAndApprovals </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<ContentAndApprovalsResource>> ReadAsync(ReadContentAndApprovalsOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<ContentAndApprovalsResource>.FromJson("contents", response.Content);
            return new ResourceSet<ContentAndApprovalsResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of Contents with approval statuses belonging to the account used to make the request </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ContentAndApprovals </returns>
        public static ResourceSet<ContentAndApprovalsResource> Read(
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadContentAndApprovalsOptions(){ PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of Contents with approval statuses belonging to the account used to make the request </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ContentAndApprovals </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<ContentAndApprovalsResource>> ReadAsync(
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadContentAndApprovalsOptions(){ PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<ContentAndApprovalsResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<ContentAndApprovalsResource>.FromJson("contents", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<ContentAndApprovalsResource> NextPage(Page<ContentAndApprovalsResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<ContentAndApprovalsResource>.FromJson("contents", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<ContentAndApprovalsResource> PreviousPage(Page<ContentAndApprovalsResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<ContentAndApprovalsResource>.FromJson("contents", response.Content);
        }

    
        /// <summary>
        /// Converts a JSON string into a ContentAndApprovalsResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ContentAndApprovalsResource object represented by the provided JSON </returns>
        public static ContentAndApprovalsResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<ContentAndApprovalsResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The date and time in GMT that the resource was created specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT that the resource was last updated specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The unique string that that we created to identify the Content resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/usage/api/account) that created Content resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> A string name used to describe the Content resource. Not visible to the end recipient. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> Two-letter (ISO 639-1) language code (e.g., en) identifying the language the Content resource is in. </summary> 
        [JsonProperty("language")]
        public string Language { get; private set; }

        ///<summary> Defines the default placeholder values for variables included in the Content resource. e.g. {\"1\": \"Customer_Name\"}. </summary> 
        [JsonProperty("variables")]
        public object Variables { get; private set; }

        ///<summary> The [Content types](https://www.twilio.com/docs/content-api/content-types-overview) (e.g. twilio/text) for this Content resource. </summary> 
        [JsonProperty("types")]
        public object Types { get; private set; }

        ///<summary> The submitted information and approval request status of the Content resource. </summary> 
        [JsonProperty("approval_requests")]
        public object ApprovalRequests { get; private set; }



        private ContentAndApprovalsResource() {

        }
    }
}
