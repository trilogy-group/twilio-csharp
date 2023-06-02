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
    public class TaskQueuesStatisticsResource : Resource
    {



        private static Request BuildReadRequest(ReadTaskQueuesStatisticsOptions options, IKandyRestClient client)
        {

            string path = "/v1/Workspaces/{WorkspaceSid}/TaskQueues/Statistics";

            string PathWorkspaceSid = options.PathWorkspaceSid;
            path = path.Replace("{" + "WorkspaceSid" + "}", PathWorkspaceSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Taskrouter,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> read </summary>
        /// <param name="options"> Read TaskQueuesStatistics parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TaskQueuesStatistics </returns>
        public static ResourceSet<TaskQueuesStatisticsResource> Read(ReadTaskQueuesStatisticsOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<TaskQueuesStatisticsResource>.FromJson("task_queues_statistics", response.Content);
            return new ResourceSet<TaskQueuesStatisticsResource>(page, options, client);
        }

#if !NET35
        /// <summary> read </summary>
        /// <param name="options"> Read TaskQueuesStatistics parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TaskQueuesStatistics </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<TaskQueuesStatisticsResource>> ReadAsync(ReadTaskQueuesStatisticsOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<TaskQueuesStatisticsResource>.FromJson("task_queues_statistics", response.Content);
            return new ResourceSet<TaskQueuesStatisticsResource>(page, options, client);
        }
#endif
        /// <summary> read </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the TaskQueues to read. </param>
        /// <param name="endDate"> Only calculate statistics from this date and time and earlier, specified in GMT as an [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) date-time. </param>
        /// <param name="friendlyName"> The `friendly_name` of the TaskQueue statistics to read. </param>
        /// <param name="minutes"> Only calculate statistics since this many minutes in the past. The default is 15 minutes. </param>
        /// <param name="startDate"> Only calculate statistics from this date and time and later, specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </param>
        /// <param name="taskChannel"> Only calculate statistics on this TaskChannel. Can be the TaskChannel's SID or its `unique_name`, such as `voice`, `sms`, or `default`. </param>
        /// <param name="splitByWaitTime"> A comma separated list of values that describes the thresholds, in seconds, to calculate statistics on. For each threshold specified, the number of Tasks canceled and reservations accepted above and below the specified thresholds in seconds are computed. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TaskQueuesStatistics </returns>
        public static ResourceSet<TaskQueuesStatisticsResource> Read(
                                                     string pathWorkspaceSid,
                                                     DateTime? endDate = null,
                                                     string friendlyName = null,
                                                     int? minutes = null,
                                                     DateTime? startDate = null,
                                                     string taskChannel = null,
                                                     string splitByWaitTime = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     IKandyRestClient client = null)
        {
            var options = new ReadTaskQueuesStatisticsOptions(pathWorkspaceSid) { EndDate = endDate, FriendlyName = friendlyName, Minutes = minutes, StartDate = startDate, TaskChannel = taskChannel, SplitByWaitTime = splitByWaitTime, PageSize = pageSize, Limit = limit };
            return Read(options, client);
        }

#if !NET35
        /// <summary> read </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the TaskQueues to read. </param>
        /// <param name="endDate"> Only calculate statistics from this date and time and earlier, specified in GMT as an [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) date-time. </param>
        /// <param name="friendlyName"> The `friendly_name` of the TaskQueue statistics to read. </param>
        /// <param name="minutes"> Only calculate statistics since this many minutes in the past. The default is 15 minutes. </param>
        /// <param name="startDate"> Only calculate statistics from this date and time and later, specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </param>
        /// <param name="taskChannel"> Only calculate statistics on this TaskChannel. Can be the TaskChannel's SID or its `unique_name`, such as `voice`, `sms`, or `default`. </param>
        /// <param name="splitByWaitTime"> A comma separated list of values that describes the thresholds, in seconds, to calculate statistics on. For each threshold specified, the number of Tasks canceled and reservations accepted above and below the specified thresholds in seconds are computed. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TaskQueuesStatistics </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<TaskQueuesStatisticsResource>> ReadAsync(
                                                                                             string pathWorkspaceSid,
                                                                                             DateTime? endDate = null,
                                                                                             string friendlyName = null,
                                                                                             int? minutes = null,
                                                                                             DateTime? startDate = null,
                                                                                             string taskChannel = null,
                                                                                             string splitByWaitTime = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             IKandyRestClient client = null)
        {
            var options = new ReadTaskQueuesStatisticsOptions(pathWorkspaceSid) { EndDate = endDate, FriendlyName = friendlyName, Minutes = minutes, StartDate = startDate, TaskChannel = taskChannel, SplitByWaitTime = splitByWaitTime, PageSize = pageSize, Limit = limit };
            return await ReadAsync(options, client);
        }
#endif


        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<TaskQueuesStatisticsResource> GetPage(string targetUrl, IKandyRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<TaskQueuesStatisticsResource>.FromJson("task_queues_statistics", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<TaskQueuesStatisticsResource> NextPage(Page<TaskQueuesStatisticsResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<TaskQueuesStatisticsResource>.FromJson("task_queues_statistics", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<TaskQueuesStatisticsResource> PreviousPage(Page<TaskQueuesStatisticsResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<TaskQueuesStatisticsResource>.FromJson("task_queues_statistics", response.Content);
        }


        /// <summary>
        /// Converts a JSON string into a TaskQueuesStatisticsResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> TaskQueuesStatisticsResource object represented by the provided JSON </returns>
        public static TaskQueuesStatisticsResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<TaskQueuesStatisticsResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the TaskQueue resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> An object that contains the cumulative statistics for the TaskQueues. </summary> 
        [JsonProperty("cumulative")]
        public object Cumulative { get; private set; }

        ///<summary> An object that contains the real-time statistics for the TaskQueues. </summary> 
        [JsonProperty("realtime")]
        public object Realtime { get; private set; }

        ///<summary> The SID of the TaskQueue from which these statistics were calculated. </summary> 
        [JsonProperty("task_queue_sid")]
        public string TaskQueueSid { get; private set; }

        ///<summary> The SID of the Workspace that contains the TaskQueues. </summary> 
        [JsonProperty("workspace_sid")]
        public string WorkspaceSid { get; private set; }



        private TaskQueuesStatisticsResource()
        {

        }
    }
}
