/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Flex
 * This is the public Kandy REST API.
 *
 * NOTE: This class is auto generated by OpenAPI Generator.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Kandy.Base;
using Kandy.Clients;
using Kandy.Converters;
using Kandy.Exceptions;
using Kandy.Http;



namespace Kandy.Rest.FlexApi.V1
{
    public class InsightsAssessmentsCommentResource : Resource
    {



        private static Request BuildCreateRequest(CreateInsightsAssessmentsCommentOptions options, IKandyRestClient client)
        {

            string path = "/v1/Insights/QualityManagement/Assessments/Comments";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.FlexApi,
                path,
                postParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }

        /// <summary> To create a comment assessment for a conversation </summary>
        /// <param name="options"> Create InsightsAssessmentsComment parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of InsightsAssessmentsComment </returns>
        public static InsightsAssessmentsCommentResource Create(CreateInsightsAssessmentsCommentOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> To create a comment assessment for a conversation </summary>
        /// <param name="options"> Create InsightsAssessmentsComment parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of InsightsAssessmentsComment </returns>
        public static async System.Threading.Tasks.Task<InsightsAssessmentsCommentResource> CreateAsync(CreateInsightsAssessmentsCommentOptions options,
        IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> To create a comment assessment for a conversation </summary>
        /// <param name="categoryId"> The ID of the category </param>
        /// <param name="categoryName"> The name of the category </param>
        /// <param name="comment"> The Assessment comment. </param>
        /// <param name="segmentId"> The id of the segment. </param>
        /// <param name="agentId"> The id of the agent. </param>
        /// <param name="offset"> The offset </param>
        /// <param name="authorization"> The Authorization HTTP request header </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of InsightsAssessmentsComment </returns>
        public static InsightsAssessmentsCommentResource Create(
                                          string categoryId,
                                          string categoryName,
                                          string comment,
                                          string segmentId,
                                          string agentId,
                                          decimal? offset,
                                          string authorization = null,
                                          IKandyRestClient client = null)
        {
            var options = new CreateInsightsAssessmentsCommentOptions(categoryId, categoryName, comment, segmentId, agentId, offset) { Authorization = authorization };
            return Create(options, client);
        }

#if !NET35
        /// <summary> To create a comment assessment for a conversation </summary>
        /// <param name="categoryId"> The ID of the category </param>
        /// <param name="categoryName"> The name of the category </param>
        /// <param name="comment"> The Assessment comment. </param>
        /// <param name="segmentId"> The id of the segment. </param>
        /// <param name="agentId"> The id of the agent. </param>
        /// <param name="offset"> The offset </param>
        /// <param name="authorization"> The Authorization HTTP request header </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of InsightsAssessmentsComment </returns>
        public static async System.Threading.Tasks.Task<InsightsAssessmentsCommentResource> CreateAsync(
                                                                                  string categoryId,
                                                                                  string categoryName,
                                                                                  string comment,
                                                                                  string segmentId,
                                                                                  string agentId,
                                                                                  decimal? offset,
                                                                                  string authorization = null,
                                                                                  IKandyRestClient client = null)
        {
            var options = new CreateInsightsAssessmentsCommentOptions(categoryId, categoryName, comment, segmentId, agentId, offset) { Authorization = authorization };
            return await CreateAsync(options, client);
        }
#endif

        private static Request BuildReadRequest(ReadInsightsAssessmentsCommentOptions options, IKandyRestClient client)
        {

            string path = "/v1/Insights/QualityManagement/Assessments/Comments";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.FlexApi,
                path,
                queryParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }
        /// <summary> To create a comment assessment for a conversation </summary>
        /// <param name="options"> Read InsightsAssessmentsComment parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of InsightsAssessmentsComment </returns>
        public static ResourceSet<InsightsAssessmentsCommentResource> Read(ReadInsightsAssessmentsCommentOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<InsightsAssessmentsCommentResource>.FromJson("comments", response.Content);
            return new ResourceSet<InsightsAssessmentsCommentResource>(page, options, client);
        }

#if !NET35
        /// <summary> To create a comment assessment for a conversation </summary>
        /// <param name="options"> Read InsightsAssessmentsComment parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of InsightsAssessmentsComment </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<InsightsAssessmentsCommentResource>> ReadAsync(ReadInsightsAssessmentsCommentOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<InsightsAssessmentsCommentResource>.FromJson("comments", response.Content);
            return new ResourceSet<InsightsAssessmentsCommentResource>(page, options, client);
        }
#endif
        /// <summary> To create a comment assessment for a conversation </summary>
        /// <param name="authorization"> The Authorization HTTP request header </param>
        /// <param name="segmentId"> The id of the segment. </param>
        /// <param name="agentId"> The id of the agent. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of InsightsAssessmentsComment </returns>
        public static ResourceSet<InsightsAssessmentsCommentResource> Read(
                                                     string authorization = null,
                                                     string segmentId = null,
                                                     string agentId = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     IKandyRestClient client = null)
        {
            var options = new ReadInsightsAssessmentsCommentOptions() { Authorization = authorization, SegmentId = segmentId, AgentId = agentId, PageSize = pageSize, Limit = limit };
            return Read(options, client);
        }

#if !NET35
        /// <summary> To create a comment assessment for a conversation </summary>
        /// <param name="authorization"> The Authorization HTTP request header </param>
        /// <param name="segmentId"> The id of the segment. </param>
        /// <param name="agentId"> The id of the agent. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of InsightsAssessmentsComment </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<InsightsAssessmentsCommentResource>> ReadAsync(
                                                                                             string authorization = null,
                                                                                             string segmentId = null,
                                                                                             string agentId = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             IKandyRestClient client = null)
        {
            var options = new ReadInsightsAssessmentsCommentOptions() { Authorization = authorization, SegmentId = segmentId, AgentId = agentId, PageSize = pageSize, Limit = limit };
            return await ReadAsync(options, client);
        }
#endif


        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The target page of records </returns>
        public static Page<InsightsAssessmentsCommentResource> GetPage(string targetUrl, IKandyRestClient client)
        {
            client = client ?? KandyClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<InsightsAssessmentsCommentResource>.FromJson("comments", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The next page of records </returns>
        public static Page<InsightsAssessmentsCommentResource> NextPage(Page<InsightsAssessmentsCommentResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<InsightsAssessmentsCommentResource>.FromJson("comments", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The previous page of records </returns>
        public static Page<InsightsAssessmentsCommentResource> PreviousPage(Page<InsightsAssessmentsCommentResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<InsightsAssessmentsCommentResource>.FromJson("comments", response.Content);
        }


        /// <summary>
        /// Converts a JSON string into a InsightsAssessmentsCommentResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> InsightsAssessmentsCommentResource object represented by the provided JSON </returns>
        public static InsightsAssessmentsCommentResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<InsightsAssessmentsCommentResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> The SID of the [Account](https://www.kandy.com/docs/iam/api/account) that created the Flex Insights resource and owns this resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The SID of the assessment. </summary> 
        [JsonProperty("assessment_sid")]
        public string AssessmentSid { get; private set; }

        ///<summary> The comment added for assessment. </summary> 
        [JsonProperty("comment")]
        public object Comment { get; private set; }

        ///<summary> The offset </summary> 
        [JsonProperty("offset")]
        public decimal? Offset { get; private set; }

        ///<summary> The flag indicating if this assessment is part of report  </summary> 
        [JsonProperty("report")]
        public bool? Report { get; private set; }

        ///<summary> The weightage given to this comment </summary> 
        [JsonProperty("weight")]
        public decimal? Weight { get; private set; }

        ///<summary> The id of the agent. </summary> 
        [JsonProperty("agent_id")]
        public string AgentId { get; private set; }

        ///<summary> The id of the segment. </summary> 
        [JsonProperty("segment_id")]
        public string SegmentId { get; private set; }

        ///<summary> The name of the user. </summary> 
        [JsonProperty("user_name")]
        public string UserName { get; private set; }

        ///<summary> The email id of the user. </summary> 
        [JsonProperty("user_email")]
        public string UserEmail { get; private set; }

        ///<summary> The timestamp when the record is inserted </summary> 
        [JsonProperty("timestamp")]
        public decimal? Timestamp { get; private set; }

        ///<summary> The url </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private InsightsAssessmentsCommentResource()
        {

        }
    }
}
