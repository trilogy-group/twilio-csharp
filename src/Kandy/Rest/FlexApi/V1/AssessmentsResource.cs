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
    public class AssessmentsResource : Resource
    {



        private static Request BuildCreateRequest(CreateAssessmentsOptions options, IKandyRestClient client)
        {

            string path = "/v1/Insights/QualityManagement/Assessments";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.FlexApi,
                path,
                postParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }

        /// <summary> Add assessments against conversation to dynamo db. Used in assessments screen by user. Users can select the questionnaire and pick up answers for each and every question. </summary>
        /// <param name="options"> Create Assessments parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Assessments </returns>
        public static AssessmentsResource Create(CreateAssessmentsOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> Add assessments against conversation to dynamo db. Used in assessments screen by user. Users can select the questionnaire and pick up answers for each and every question. </summary>
        /// <param name="options"> Create Assessments parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Assessments </returns>
        public static async System.Threading.Tasks.Task<AssessmentsResource> CreateAsync(CreateAssessmentsOptions options,
        IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> Add assessments against conversation to dynamo db. Used in assessments screen by user. Users can select the questionnaire and pick up answers for each and every question. </summary>
        /// <param name="categorySid"> The SID of the category  </param>
        /// <param name="categoryName"> The name of the category </param>
        /// <param name="segmentId"> Segment Id of the conversation </param>
        /// <param name="agentId"> The id of the Agent </param>
        /// <param name="offset"> The offset of the conversation. </param>
        /// <param name="metricId"> The question SID selected for assessment </param>
        /// <param name="metricName"> The question name of the assessment </param>
        /// <param name="answerText"> The answer text selected by user </param>
        /// <param name="answerId"> The id of the answer selected by user </param>
        /// <param name="questionnaireSid"> Questionnaire SID of the associated question </param>
        /// <param name="authorization"> The Authorization HTTP request header </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Assessments </returns>
        public static AssessmentsResource Create(
                                          string categorySid,
                                          string categoryName,
                                          string segmentId,
                                          string agentId,
                                          decimal? offset,
                                          string metricId,
                                          string metricName,
                                          string answerText,
                                          string answerId,
                                          string questionnaireSid,
                                          string authorization = null,
                                          IKandyRestClient client = null)
        {
            var options = new CreateAssessmentsOptions(categorySid, categoryName, segmentId, agentId, offset, metricId, metricName, answerText, answerId, questionnaireSid) { Authorization = authorization };
            return Create(options, client);
        }

#if !NET35
        /// <summary> Add assessments against conversation to dynamo db. Used in assessments screen by user. Users can select the questionnaire and pick up answers for each and every question. </summary>
        /// <param name="categorySid"> The SID of the category  </param>
        /// <param name="categoryName"> The name of the category </param>
        /// <param name="segmentId"> Segment Id of the conversation </param>
        /// <param name="agentId"> The id of the Agent </param>
        /// <param name="offset"> The offset of the conversation. </param>
        /// <param name="metricId"> The question SID selected for assessment </param>
        /// <param name="metricName"> The question name of the assessment </param>
        /// <param name="answerText"> The answer text selected by user </param>
        /// <param name="answerId"> The id of the answer selected by user </param>
        /// <param name="questionnaireSid"> Questionnaire SID of the associated question </param>
        /// <param name="authorization"> The Authorization HTTP request header </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Assessments </returns>
        public static async System.Threading.Tasks.Task<AssessmentsResource> CreateAsync(
                                                                                  string categorySid,
                                                                                  string categoryName,
                                                                                  string segmentId,
                                                                                  string agentId,
                                                                                  decimal? offset,
                                                                                  string metricId,
                                                                                  string metricName,
                                                                                  string answerText,
                                                                                  string answerId,
                                                                                  string questionnaireSid,
                                                                                  string authorization = null,
                                                                                  IKandyRestClient client = null)
        {
            var options = new CreateAssessmentsOptions(categorySid, categoryName, segmentId, agentId, offset, metricId, metricName, answerText, answerId, questionnaireSid) { Authorization = authorization };
            return await CreateAsync(options, client);
        }
#endif

        private static Request BuildReadRequest(ReadAssessmentsOptions options, IKandyRestClient client)
        {

            string path = "/v1/Insights/QualityManagement/Assessments";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.FlexApi,
                path,
                queryParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }
        /// <summary> Get assessments done for a conversation by logged in user </summary>
        /// <param name="options"> Read Assessments parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Assessments </returns>
        public static ResourceSet<AssessmentsResource> Read(ReadAssessmentsOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<AssessmentsResource>.FromJson("assessments", response.Content);
            return new ResourceSet<AssessmentsResource>(page, options, client);
        }

#if !NET35
        /// <summary> Get assessments done for a conversation by logged in user </summary>
        /// <param name="options"> Read Assessments parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Assessments </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<AssessmentsResource>> ReadAsync(ReadAssessmentsOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<AssessmentsResource>.FromJson("assessments", response.Content);
            return new ResourceSet<AssessmentsResource>(page, options, client);
        }
#endif
        /// <summary> Get assessments done for a conversation by logged in user </summary>
        /// <param name="authorization"> The Authorization HTTP request header </param>
        /// <param name="segmentId"> The id of the segment. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Assessments </returns>
        public static ResourceSet<AssessmentsResource> Read(
                                                     string authorization = null,
                                                     string segmentId = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     IKandyRestClient client = null)
        {
            var options = new ReadAssessmentsOptions() { Authorization = authorization, SegmentId = segmentId, PageSize = pageSize, Limit = limit };
            return Read(options, client);
        }

#if !NET35
        /// <summary> Get assessments done for a conversation by logged in user </summary>
        /// <param name="authorization"> The Authorization HTTP request header </param>
        /// <param name="segmentId"> The id of the segment. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Assessments </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<AssessmentsResource>> ReadAsync(
                                                                                             string authorization = null,
                                                                                             string segmentId = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             IKandyRestClient client = null)
        {
            var options = new ReadAssessmentsOptions() { Authorization = authorization, SegmentId = segmentId, PageSize = pageSize, Limit = limit };
            return await ReadAsync(options, client);
        }
#endif


        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The target page of records </returns>
        public static Page<AssessmentsResource> GetPage(string targetUrl, IKandyRestClient client)
        {
            client = client ?? KandyClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<AssessmentsResource>.FromJson("assessments", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The next page of records </returns>
        public static Page<AssessmentsResource> NextPage(Page<AssessmentsResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<AssessmentsResource>.FromJson("assessments", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The previous page of records </returns>
        public static Page<AssessmentsResource> PreviousPage(Page<AssessmentsResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<AssessmentsResource>.FromJson("assessments", response.Content);
        }


        private static Request BuildUpdateRequest(UpdateAssessmentsOptions options, IKandyRestClient client)
        {

            string path = "/v1/Insights/QualityManagement/Assessments/{AssessmentSid}";

            string PathAssessmentSid = options.PathAssessmentSid;
            path = path.Replace("{" + "AssessmentSid" + "}", PathAssessmentSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.FlexApi,
                path,
                postParams: options.GetParams(),
                headerParams: options.GetHeaderParams()
            );
        }

        /// <summary> Update a specific Assessment assessed earlier </summary>
        /// <param name="options"> Update Assessments parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Assessments </returns>
        public static AssessmentsResource Update(UpdateAssessmentsOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Update a specific Assessment assessed earlier </summary>
        /// <param name="options"> Update Assessments parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Assessments </returns>
#if !NET35
        public static async System.Threading.Tasks.Task<AssessmentsResource> UpdateAsync(UpdateAssessmentsOptions options,
                                                                                                          IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> Update a specific Assessment assessed earlier </summary>
        /// <param name="pathAssessmentSid"> The SID of the assessment to be modified </param>
        /// <param name="offset"> The offset of the conversation </param>
        /// <param name="answerText"> The answer text selected by user </param>
        /// <param name="answerId"> The id of the answer selected by user </param>
        /// <param name="authorization"> The Authorization HTTP request header </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Assessments </returns>
        public static AssessmentsResource Update(
                                          string pathAssessmentSid,
                                          decimal? offset,
                                          string answerText,
                                          string answerId,
                                          string authorization = null,
                                          IKandyRestClient client = null)
        {
            var options = new UpdateAssessmentsOptions(pathAssessmentSid, offset, answerText, answerId) { Authorization = authorization };
            return Update(options, client);
        }

#if !NET35
        /// <summary> Update a specific Assessment assessed earlier </summary>
        /// <param name="pathAssessmentSid"> The SID of the assessment to be modified </param>
        /// <param name="offset"> The offset of the conversation </param>
        /// <param name="answerText"> The answer text selected by user </param>
        /// <param name="answerId"> The id of the answer selected by user </param>
        /// <param name="authorization"> The Authorization HTTP request header </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Assessments </returns>
        public static async System.Threading.Tasks.Task<AssessmentsResource> UpdateAsync(
                                                                              string pathAssessmentSid,
                                                                              decimal? offset,
                                                                              string answerText,
                                                                              string answerId,
                                                                              string authorization = null,
                                                                              IKandyRestClient client = null)
        {
            var options = new UpdateAssessmentsOptions(pathAssessmentSid, offset, answerText, answerId) { Authorization = authorization };
            return await UpdateAsync(options, client);
        }
#endif

        /// <summary>
        /// Converts a JSON string into a AssessmentsResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> AssessmentsResource object represented by the provided JSON </returns>
        public static AssessmentsResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<AssessmentsResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> The unique SID identifier of the Account. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The SID of the assessment </summary> 
        [JsonProperty("assessment_sid")]
        public string AssessmentSid { get; private set; }

        ///<summary> Offset of the conversation </summary> 
        [JsonProperty("offset")]
        public decimal? Offset { get; private set; }

        ///<summary> The flag indicating if this assessment is part of report  </summary> 
        [JsonProperty("report")]
        public bool? Report { get; private set; }

        ///<summary> The weightage given to this comment </summary> 
        [JsonProperty("weight")]
        public decimal? Weight { get; private set; }

        ///<summary> The id of the Agent </summary> 
        [JsonProperty("agent_id")]
        public string AgentId { get; private set; }

        ///<summary> Segment Id of conversation </summary> 
        [JsonProperty("segment_id")]
        public string SegmentId { get; private set; }

        ///<summary> The name of the user. </summary> 
        [JsonProperty("user_name")]
        public string UserName { get; private set; }

        ///<summary> The email id of the user. </summary> 
        [JsonProperty("user_email")]
        public string UserEmail { get; private set; }

        ///<summary> The answer text selected by user </summary> 
        [JsonProperty("answer_text")]
        public string AnswerText { get; private set; }

        ///<summary> The id of the answer selected by user </summary> 
        [JsonProperty("answer_id")]
        public string AnswerId { get; private set; }

        ///<summary> Assessment Details associated with an assessment </summary> 
        [JsonProperty("assessment")]
        public object Assessment { get; private set; }

        ///<summary> The timestamp </summary> 
        [JsonProperty("timestamp")]
        public decimal? Timestamp { get; private set; }

        ///<summary> The url </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private AssessmentsResource()
        {

        }
    }
}
