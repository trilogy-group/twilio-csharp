/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Taskrouter
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



namespace Kandy.Rest.Taskrouter.V1.Workspace.TaskQueue
{
    public class TaskQueueStatisticsResource : Resource
    {



        private static Request BuildFetchRequest(FetchTaskQueueStatisticsOptions options, IKandyRestClient client)
        {

            string path = "/v1/Workspaces/{WorkspaceSid}/TaskQueues/{TaskQueueSid}/Statistics";

            string PathWorkspaceSid = options.PathWorkspaceSid;
            path = path.Replace("{" + "WorkspaceSid" + "}", PathWorkspaceSid);
            string PathTaskQueueSid = options.PathTaskQueueSid;
            path = path.Replace("{" + "TaskQueueSid" + "}", PathTaskQueueSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Taskrouter,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch TaskQueueStatistics parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TaskQueueStatistics </returns>
        public static TaskQueueStatisticsResource Fetch(FetchTaskQueueStatisticsOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch TaskQueueStatistics parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TaskQueueStatistics </returns>
        public static async System.Threading.Tasks.Task<TaskQueueStatisticsResource> FetchAsync(FetchTaskQueueStatisticsOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
#endif
        /// <summary> fetch </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the TaskQueue to fetch. </param>
        /// <param name="pathTaskQueueSid"> The SID of the TaskQueue for which to fetch statistics. </param>
        /// <param name="endDate"> Only calculate statistics from this date and time and earlier, specified in GMT as an [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) date-time. </param>
        /// <param name="minutes"> Only calculate statistics since this many minutes in the past. The default is 15 minutes. </param>
        /// <param name="startDate"> Only calculate statistics from this date and time and later, specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </param>
        /// <param name="taskChannel"> Only calculate real-time and cumulative statistics for the specified TaskChannel. Can be the TaskChannel's SID or its `unique_name`, such as `voice`, `sms`, or `default`. </param>
        /// <param name="splitByWaitTime"> A comma separated list of values that describes the thresholds, in seconds, to calculate statistics on. For each threshold specified, the number of Tasks canceled and reservations accepted above and below the specified thresholds in seconds are computed. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TaskQueueStatistics </returns>
        public static TaskQueueStatisticsResource Fetch(
                                         string pathWorkspaceSid,
                                         string pathTaskQueueSid,
                                         DateTime? endDate = null,
                                         int? minutes = null,
                                         DateTime? startDate = null,
                                         string taskChannel = null,
                                         string splitByWaitTime = null,
                                         IKandyRestClient client = null)
        {
            var options = new FetchTaskQueueStatisticsOptions(pathWorkspaceSid, pathTaskQueueSid) { EndDate = endDate, Minutes = minutes, StartDate = startDate, TaskChannel = taskChannel, SplitByWaitTime = splitByWaitTime };
            return Fetch(options, client);
        }

#if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the TaskQueue to fetch. </param>
        /// <param name="pathTaskQueueSid"> The SID of the TaskQueue for which to fetch statistics. </param>
        /// <param name="endDate"> Only calculate statistics from this date and time and earlier, specified in GMT as an [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) date-time. </param>
        /// <param name="minutes"> Only calculate statistics since this many minutes in the past. The default is 15 minutes. </param>
        /// <param name="startDate"> Only calculate statistics from this date and time and later, specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </param>
        /// <param name="taskChannel"> Only calculate real-time and cumulative statistics for the specified TaskChannel. Can be the TaskChannel's SID or its `unique_name`, such as `voice`, `sms`, or `default`. </param>
        /// <param name="splitByWaitTime"> A comma separated list of values that describes the thresholds, in seconds, to calculate statistics on. For each threshold specified, the number of Tasks canceled and reservations accepted above and below the specified thresholds in seconds are computed. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TaskQueueStatistics </returns>
        public static async System.Threading.Tasks.Task<TaskQueueStatisticsResource> FetchAsync(string pathWorkspaceSid, string pathTaskQueueSid, DateTime? endDate = null, int? minutes = null, DateTime? startDate = null, string taskChannel = null, string splitByWaitTime = null, IKandyRestClient client = null)
        {
            var options = new FetchTaskQueueStatisticsOptions(pathWorkspaceSid, pathTaskQueueSid) { EndDate = endDate, Minutes = minutes, StartDate = startDate, TaskChannel = taskChannel, SplitByWaitTime = splitByWaitTime };
            return await FetchAsync(options, client);
        }
#endif

        /// <summary>
        /// Converts a JSON string into a TaskQueueStatisticsResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> TaskQueueStatisticsResource object represented by the provided JSON </returns>
        public static TaskQueueStatisticsResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<TaskQueueStatisticsResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the TaskQueue resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> An object that contains the cumulative statistics for the TaskQueue. </summary> 
        [JsonProperty("cumulative")]
        public object Cumulative { get; private set; }

        ///<summary> An object that contains the real-time statistics for the TaskQueue. </summary> 
        [JsonProperty("realtime")]
        public object Realtime { get; private set; }

        ///<summary> The SID of the TaskQueue from which these statistics were calculated. </summary> 
        [JsonProperty("task_queue_sid")]
        public string TaskQueueSid { get; private set; }

        ///<summary> The SID of the Workspace that contains the TaskQueue. </summary> 
        [JsonProperty("workspace_sid")]
        public string WorkspaceSid { get; private set; }

        ///<summary> The absolute URL of the TaskQueue statistics resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private TaskQueueStatisticsResource()
        {

        }
    }
}
