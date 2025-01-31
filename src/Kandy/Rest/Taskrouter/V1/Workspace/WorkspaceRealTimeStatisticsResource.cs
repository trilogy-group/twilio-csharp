/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Taskrouter
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



namespace Kandy.Rest.Taskrouter.V1.Workspace
{
    public class WorkspaceRealTimeStatisticsResource : Resource
    {



        private static Request BuildFetchRequest(FetchWorkspaceRealTimeStatisticsOptions options, IKandyRestClient client)
        {

            string path = "/v1/Workspaces/{WorkspaceSid}/RealTimeStatistics";

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

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch WorkspaceRealTimeStatistics parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of WorkspaceRealTimeStatistics </returns>
        public static WorkspaceRealTimeStatisticsResource Fetch(FetchWorkspaceRealTimeStatisticsOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch WorkspaceRealTimeStatistics parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of WorkspaceRealTimeStatistics </returns>
        public static async System.Threading.Tasks.Task<WorkspaceRealTimeStatisticsResource> FetchAsync(FetchWorkspaceRealTimeStatisticsOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
#endif
        /// <summary> fetch </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace to fetch. </param>
        /// <param name="taskChannel"> Only calculate real-time statistics on this TaskChannel. Can be the TaskChannel's SID or its `unique_name`, such as `voice`, `sms`, or `default`. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of WorkspaceRealTimeStatistics </returns>
        public static WorkspaceRealTimeStatisticsResource Fetch(
                                         string pathWorkspaceSid,
                                         string taskChannel = null,
                                         IKandyRestClient client = null)
        {
            var options = new FetchWorkspaceRealTimeStatisticsOptions(pathWorkspaceSid) { TaskChannel = taskChannel };
            return Fetch(options, client);
        }

#if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace to fetch. </param>
        /// <param name="taskChannel"> Only calculate real-time statistics on this TaskChannel. Can be the TaskChannel's SID or its `unique_name`, such as `voice`, `sms`, or `default`. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of WorkspaceRealTimeStatistics </returns>
        public static async System.Threading.Tasks.Task<WorkspaceRealTimeStatisticsResource> FetchAsync(string pathWorkspaceSid, string taskChannel = null, IKandyRestClient client = null)
        {
            var options = new FetchWorkspaceRealTimeStatisticsOptions(pathWorkspaceSid) { TaskChannel = taskChannel };
            return await FetchAsync(options, client);
        }
#endif

        /// <summary>
        /// Converts a JSON string into a WorkspaceRealTimeStatisticsResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> WorkspaceRealTimeStatisticsResource object represented by the provided JSON </returns>
        public static WorkspaceRealTimeStatisticsResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<WorkspaceRealTimeStatisticsResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> The SID of the [Account](https://www.kandy.com/docs/iam/api/account) that created the Workspace resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The number of current Workers by Activity. </summary> 
        [JsonProperty("activity_statistics")]
        public List<object> ActivityStatistics { get; private set; }

        ///<summary> The age of the longest waiting Task. </summary> 
        [JsonProperty("longest_task_waiting_age")]
        public int? LongestTaskWaitingAge { get; private set; }

        ///<summary> The SID of the longest waiting Task. </summary> 
        [JsonProperty("longest_task_waiting_sid")]
        public string LongestTaskWaitingSid { get; private set; }

        ///<summary> The number of Tasks by priority. For example: `{\"0\": \"10\", \"99\": \"5\"}` shows 10 Tasks at priority 0 and 5 at priority 99. </summary> 
        [JsonProperty("tasks_by_priority")]
        public object TasksByPriority { get; private set; }

        ///<summary> The number of Tasks by their current status. For example: `{\"pending\": \"1\", \"reserved\": \"3\", \"assigned\": \"2\", \"completed\": \"5\"}`. </summary> 
        [JsonProperty("tasks_by_status")]
        public object TasksByStatus { get; private set; }

        ///<summary> The total number of Tasks. </summary> 
        [JsonProperty("total_tasks")]
        public int? TotalTasks { get; private set; }

        ///<summary> The total number of Workers in the Workspace. </summary> 
        [JsonProperty("total_workers")]
        public int? TotalWorkers { get; private set; }

        ///<summary> The SID of the Workspace. </summary> 
        [JsonProperty("workspace_sid")]
        public string WorkspaceSid { get; private set; }

        ///<summary> The absolute URL of the Workspace statistics resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private WorkspaceRealTimeStatisticsResource()
        {

        }
    }
}
