/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Preview
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



namespace Kandy.Rest.Preview.Understand.Assistant.Task
{
    public class TaskStatisticsResource : Resource
    {



        private static Request BuildFetchRequest(FetchTaskStatisticsOptions options, IKandyRestClient client)
        {

            string path = "/understand/Assistants/{AssistantSid}/Tasks/{TaskSid}/Statistics";

            string PathAssistantSid = options.PathAssistantSid;
            path = path.Replace("{" + "AssistantSid" + "}", PathAssistantSid);
            string PathTaskSid = options.PathTaskSid;
            path = path.Replace("{" + "TaskSid" + "}", PathTaskSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch TaskStatistics parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of TaskStatistics </returns>
        public static TaskStatisticsResource Fetch(FetchTaskStatisticsOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch TaskStatistics parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of TaskStatistics </returns>
        public static async System.Threading.Tasks.Task<TaskStatisticsResource> FetchAsync(FetchTaskStatisticsOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
#endif
        /// <summary> fetch </summary>
        /// <param name="pathAssistantSid"> The unique ID of the parent Assistant. </param>
        /// <param name="pathTaskSid"> The unique ID of the Task associated with this Field. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of TaskStatistics </returns>
        public static TaskStatisticsResource Fetch(
                                         string pathAssistantSid,
                                         string pathTaskSid,
                                         IKandyRestClient client = null)
        {
            var options = new FetchTaskStatisticsOptions(pathAssistantSid, pathTaskSid) { };
            return Fetch(options, client);
        }

#if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathAssistantSid"> The unique ID of the parent Assistant. </param>
        /// <param name="pathTaskSid"> The unique ID of the Task associated with this Field. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of TaskStatistics </returns>
        public static async System.Threading.Tasks.Task<TaskStatisticsResource> FetchAsync(string pathAssistantSid, string pathTaskSid, IKandyRestClient client = null)
        {
            var options = new FetchTaskStatisticsOptions(pathAssistantSid, pathTaskSid) { };
            return await FetchAsync(options, client);
        }
#endif

        /// <summary>
        /// Converts a JSON string into a TaskStatisticsResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> TaskStatisticsResource object represented by the provided JSON </returns>
        public static TaskStatisticsResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<TaskStatisticsResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> The unique ID of the Account that created this Field. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The unique ID of the parent Assistant. </summary> 
        [JsonProperty("assistant_sid")]
        public string AssistantSid { get; private set; }

        ///<summary> The unique ID of the Task associated with this Field. </summary> 
        [JsonProperty("task_sid")]
        public string TaskSid { get; private set; }

        ///<summary> The total number of Samples associated with this Task. </summary> 
        [JsonProperty("samples_count")]
        public int? SamplesCount { get; private set; }

        ///<summary> The total number of Fields associated with this Task. </summary> 
        [JsonProperty("fields_count")]
        public int? FieldsCount { get; private set; }

        ///<summary> The url </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private TaskStatisticsResource()
        {

        }
    }
}
