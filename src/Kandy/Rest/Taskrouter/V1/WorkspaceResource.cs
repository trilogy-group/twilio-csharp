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
using Kandy.Types;


namespace Kandy.Rest.Taskrouter.V1
{
    public class WorkspaceResource : Resource
    {

        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class QueueOrderEnum : StringEnum
        {
            private QueueOrderEnum(string value) : base(value) { }
            public QueueOrderEnum() { }
            public static implicit operator QueueOrderEnum(string value)
            {
                return new QueueOrderEnum(value);
            }
            public static readonly QueueOrderEnum Fifo = new QueueOrderEnum("FIFO");
            public static readonly QueueOrderEnum Lifo = new QueueOrderEnum("LIFO");

        }


        private static Request BuildCreateRequest(CreateWorkspaceOptions options, IKandyRestClient client)
        {

            string path = "/v1/Workspaces";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Taskrouter,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> create </summary>
        /// <param name="options"> Create Workspace parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Workspace </returns>
        public static WorkspaceResource Create(CreateWorkspaceOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> create </summary>
        /// <param name="options"> Create Workspace parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Workspace </returns>
        public static async System.Threading.Tasks.Task<WorkspaceResource> CreateAsync(CreateWorkspaceOptions options,
        IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> create </summary>
        /// <param name="friendlyName"> A descriptive string that you create to describe the Workspace resource. It can be up to 64 characters long. For example: `Customer Support` or `2014 Election Campaign`. </param>
        /// <param name="eventCallbackUrl"> The URL we should call when an event occurs. If provided, the Workspace will publish events to this URL, for example, to collect data for reporting. See [Workspace Events](https://www.kandy.com/docs/taskrouter/api/event) for more information. This parameter supports Kandy's [Webhooks (HTTP callbacks) Connection Overrides](https://www.kandy.com/docs/usage/webhooks/webhooks-connection-overrides). </param>
        /// <param name="eventsFilter"> The list of Workspace events for which to call event_callback_url. For example, if `EventsFilter=task.created, task.canceled, worker.activity.update`, then TaskRouter will call event_callback_url only when a task is created, canceled, or a Worker activity is updated. </param>
        /// <param name="multiTaskEnabled"> Whether to enable multi-tasking. Can be: `true` to enable multi-tasking, or `false` to disable it. However, all workspaces should be created as multi-tasking. The default is `true`. Multi-tasking allows Workers to handle multiple Tasks simultaneously. When enabled (`true`), each Worker can receive parallel reservations up to the per-channel maximums defined in the Workers section. In single-tasking mode (legacy mode), each Worker will only receive a new reservation when the previous task is completed. Learn more at [Multitasking](https://www.kandy.com/docs/taskrouter/multitasking). </param>
        /// <param name="template"> An available template name. Can be: `NONE` or `FIFO` and the default is `NONE`. Pre-configures the Workspace with the Workflow and Activities specified in the template. `NONE` will create a Workspace with only a set of default activities. `FIFO` will configure TaskRouter with a set of default activities and a single TaskQueue for first-in, first-out distribution, which can be useful when you are getting started with TaskRouter. </param>
        /// <param name="prioritizeQueueOrder">  </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Workspace </returns>
        public static WorkspaceResource Create(
                                          string friendlyName,
                                          Uri eventCallbackUrl = null,
                                          string eventsFilter = null,
                                          bool? multiTaskEnabled = null,
                                          string template = null,
                                          WorkspaceResource.QueueOrderEnum prioritizeQueueOrder = null,
                                          IKandyRestClient client = null)
        {
            var options = new CreateWorkspaceOptions(friendlyName) { EventCallbackUrl = eventCallbackUrl, EventsFilter = eventsFilter, MultiTaskEnabled = multiTaskEnabled, Template = template, PrioritizeQueueOrder = prioritizeQueueOrder };
            return Create(options, client);
        }

#if !NET35
        /// <summary> create </summary>
        /// <param name="friendlyName"> A descriptive string that you create to describe the Workspace resource. It can be up to 64 characters long. For example: `Customer Support` or `2014 Election Campaign`. </param>
        /// <param name="eventCallbackUrl"> The URL we should call when an event occurs. If provided, the Workspace will publish events to this URL, for example, to collect data for reporting. See [Workspace Events](https://www.kandy.com/docs/taskrouter/api/event) for more information. This parameter supports Kandy's [Webhooks (HTTP callbacks) Connection Overrides](https://www.kandy.com/docs/usage/webhooks/webhooks-connection-overrides). </param>
        /// <param name="eventsFilter"> The list of Workspace events for which to call event_callback_url. For example, if `EventsFilter=task.created, task.canceled, worker.activity.update`, then TaskRouter will call event_callback_url only when a task is created, canceled, or a Worker activity is updated. </param>
        /// <param name="multiTaskEnabled"> Whether to enable multi-tasking. Can be: `true` to enable multi-tasking, or `false` to disable it. However, all workspaces should be created as multi-tasking. The default is `true`. Multi-tasking allows Workers to handle multiple Tasks simultaneously. When enabled (`true`), each Worker can receive parallel reservations up to the per-channel maximums defined in the Workers section. In single-tasking mode (legacy mode), each Worker will only receive a new reservation when the previous task is completed. Learn more at [Multitasking](https://www.kandy.com/docs/taskrouter/multitasking). </param>
        /// <param name="template"> An available template name. Can be: `NONE` or `FIFO` and the default is `NONE`. Pre-configures the Workspace with the Workflow and Activities specified in the template. `NONE` will create a Workspace with only a set of default activities. `FIFO` will configure TaskRouter with a set of default activities and a single TaskQueue for first-in, first-out distribution, which can be useful when you are getting started with TaskRouter. </param>
        /// <param name="prioritizeQueueOrder">  </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Workspace </returns>
        public static async System.Threading.Tasks.Task<WorkspaceResource> CreateAsync(
                                                                                  string friendlyName,
                                                                                  Uri eventCallbackUrl = null,
                                                                                  string eventsFilter = null,
                                                                                  bool? multiTaskEnabled = null,
                                                                                  string template = null,
                                                                                  WorkspaceResource.QueueOrderEnum prioritizeQueueOrder = null,
                                                                                  IKandyRestClient client = null)
        {
            var options = new CreateWorkspaceOptions(friendlyName) { EventCallbackUrl = eventCallbackUrl, EventsFilter = eventsFilter, MultiTaskEnabled = multiTaskEnabled, Template = template, PrioritizeQueueOrder = prioritizeQueueOrder };
            return await CreateAsync(options, client);
        }
#endif

        /// <summary> delete </summary>
        /// <param name="options"> Delete Workspace parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Workspace </returns>
        private static Request BuildDeleteRequest(DeleteWorkspaceOptions options, IKandyRestClient client)
        {

            string path = "/v1/Workspaces/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Taskrouter,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> delete </summary>
        /// <param name="options"> Delete Workspace parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Workspace </returns>
        public static bool Delete(DeleteWorkspaceOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

#if !NET35
        /// <summary> delete </summary>
        /// <param name="options"> Delete Workspace parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Workspace </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteWorkspaceOptions options,
                                                                          IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
#endif

        /// <summary> delete </summary>
        /// <param name="pathSid"> The SID of the Workspace resource to delete. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Workspace </returns>
        public static bool Delete(string pathSid, IKandyRestClient client = null)
        {
            var options = new DeleteWorkspaceOptions(pathSid);
            return Delete(options, client);
        }

#if !NET35
        /// <summary> delete </summary>
        /// <param name="pathSid"> The SID of the Workspace resource to delete. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Workspace </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, IKandyRestClient client = null)
        {
            var options = new DeleteWorkspaceOptions(pathSid);
            return await DeleteAsync(options, client);
        }
#endif

        private static Request BuildFetchRequest(FetchWorkspaceOptions options, IKandyRestClient client)
        {

            string path = "/v1/Workspaces/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Taskrouter,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Workspace parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Workspace </returns>
        public static WorkspaceResource Fetch(FetchWorkspaceOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Workspace parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Workspace </returns>
        public static async System.Threading.Tasks.Task<WorkspaceResource> FetchAsync(FetchWorkspaceOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
#endif
        /// <summary> fetch </summary>
        /// <param name="pathSid"> The SID of the Workspace resource to fetch. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Workspace </returns>
        public static WorkspaceResource Fetch(
                                         string pathSid,
                                         IKandyRestClient client = null)
        {
            var options = new FetchWorkspaceOptions(pathSid) { };
            return Fetch(options, client);
        }

#if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathSid"> The SID of the Workspace resource to fetch. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Workspace </returns>
        public static async System.Threading.Tasks.Task<WorkspaceResource> FetchAsync(string pathSid, IKandyRestClient client = null)
        {
            var options = new FetchWorkspaceOptions(pathSid) { };
            return await FetchAsync(options, client);
        }
#endif

        private static Request BuildReadRequest(ReadWorkspaceOptions options, IKandyRestClient client)
        {

            string path = "/v1/Workspaces";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Taskrouter,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> read </summary>
        /// <param name="options"> Read Workspace parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Workspace </returns>
        public static ResourceSet<WorkspaceResource> Read(ReadWorkspaceOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<WorkspaceResource>.FromJson("workspaces", response.Content);
            return new ResourceSet<WorkspaceResource>(page, options, client);
        }

#if !NET35
        /// <summary> read </summary>
        /// <param name="options"> Read Workspace parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Workspace </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<WorkspaceResource>> ReadAsync(ReadWorkspaceOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<WorkspaceResource>.FromJson("workspaces", response.Content);
            return new ResourceSet<WorkspaceResource>(page, options, client);
        }
#endif
        /// <summary> read </summary>
        /// <param name="friendlyName"> The `friendly_name` of the Workspace resources to read. For example `Customer Support` or `2014 Election Campaign`. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Workspace </returns>
        public static ResourceSet<WorkspaceResource> Read(
                                                     string friendlyName = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     IKandyRestClient client = null)
        {
            var options = new ReadWorkspaceOptions() { FriendlyName = friendlyName, PageSize = pageSize, Limit = limit };
            return Read(options, client);
        }

#if !NET35
        /// <summary> read </summary>
        /// <param name="friendlyName"> The `friendly_name` of the Workspace resources to read. For example `Customer Support` or `2014 Election Campaign`. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Workspace </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<WorkspaceResource>> ReadAsync(
                                                                                             string friendlyName = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             IKandyRestClient client = null)
        {
            var options = new ReadWorkspaceOptions() { FriendlyName = friendlyName, PageSize = pageSize, Limit = limit };
            return await ReadAsync(options, client);
        }
#endif


        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The target page of records </returns>
        public static Page<WorkspaceResource> GetPage(string targetUrl, IKandyRestClient client)
        {
            client = client ?? KandyClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<WorkspaceResource>.FromJson("workspaces", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The next page of records </returns>
        public static Page<WorkspaceResource> NextPage(Page<WorkspaceResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<WorkspaceResource>.FromJson("workspaces", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The previous page of records </returns>
        public static Page<WorkspaceResource> PreviousPage(Page<WorkspaceResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<WorkspaceResource>.FromJson("workspaces", response.Content);
        }


        private static Request BuildUpdateRequest(UpdateWorkspaceOptions options, IKandyRestClient client)
        {

            string path = "/v1/Workspaces/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Taskrouter,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> update </summary>
        /// <param name="options"> Update Workspace parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Workspace </returns>
        public static WorkspaceResource Update(UpdateWorkspaceOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> update </summary>
        /// <param name="options"> Update Workspace parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Workspace </returns>
#if !NET35
        public static async System.Threading.Tasks.Task<WorkspaceResource> UpdateAsync(UpdateWorkspaceOptions options,
                                                                                                          IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> update </summary>
        /// <param name="pathSid"> The SID of the Workspace resource to update. </param>
        /// <param name="defaultActivitySid"> The SID of the Activity that will be used when new Workers are created in the Workspace. </param>
        /// <param name="eventCallbackUrl"> The URL we should call when an event occurs. See [Workspace Events](https://www.kandy.com/docs/taskrouter/api/event) for more information. This parameter supports Kandy's [Webhooks (HTTP callbacks) Connection Overrides](https://www.kandy.com/docs/usage/webhooks/webhooks-connection-overrides). </param>
        /// <param name="eventsFilter"> The list of Workspace events for which to call event_callback_url. For example if `EventsFilter=task.created,task.canceled,worker.activity.update`, then TaskRouter will call event_callback_url only when a task is created, canceled, or a Worker activity is updated. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the Workspace resource. For example: `Sales Call Center` or `Customer Support Team`. </param>
        /// <param name="multiTaskEnabled"> Whether to enable multi-tasking. Can be: `true` to enable multi-tasking, or `false` to disable it. However, all workspaces should be maintained as multi-tasking. There is no default when omitting this parameter. A multi-tasking Workspace can't be updated to single-tasking unless it is not a Flex Project and another (legacy) single-tasking Workspace exists. Multi-tasking allows Workers to handle multiple Tasks simultaneously. In multi-tasking mode, each Worker can receive parallel reservations up to the per-channel maximums defined in the Workers section. In single-tasking mode (legacy mode), each Worker will only receive a new reservation when the previous task is completed. Learn more at [Multitasking](https://www.kandy.com/docs/taskrouter/multitasking). </param>
        /// <param name="timeoutActivitySid"> The SID of the Activity that will be assigned to a Worker when a Task reservation times out without a response. </param>
        /// <param name="prioritizeQueueOrder">  </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Workspace </returns>
        public static WorkspaceResource Update(
                                          string pathSid,
                                          string defaultActivitySid = null,
                                          Uri eventCallbackUrl = null,
                                          string eventsFilter = null,
                                          string friendlyName = null,
                                          bool? multiTaskEnabled = null,
                                          string timeoutActivitySid = null,
                                          WorkspaceResource.QueueOrderEnum prioritizeQueueOrder = null,
                                          IKandyRestClient client = null)
        {
            var options = new UpdateWorkspaceOptions(pathSid) { DefaultActivitySid = defaultActivitySid, EventCallbackUrl = eventCallbackUrl, EventsFilter = eventsFilter, FriendlyName = friendlyName, MultiTaskEnabled = multiTaskEnabled, TimeoutActivitySid = timeoutActivitySid, PrioritizeQueueOrder = prioritizeQueueOrder };
            return Update(options, client);
        }

#if !NET35
        /// <summary> update </summary>
        /// <param name="pathSid"> The SID of the Workspace resource to update. </param>
        /// <param name="defaultActivitySid"> The SID of the Activity that will be used when new Workers are created in the Workspace. </param>
        /// <param name="eventCallbackUrl"> The URL we should call when an event occurs. See [Workspace Events](https://www.kandy.com/docs/taskrouter/api/event) for more information. This parameter supports Kandy's [Webhooks (HTTP callbacks) Connection Overrides](https://www.kandy.com/docs/usage/webhooks/webhooks-connection-overrides). </param>
        /// <param name="eventsFilter"> The list of Workspace events for which to call event_callback_url. For example if `EventsFilter=task.created,task.canceled,worker.activity.update`, then TaskRouter will call event_callback_url only when a task is created, canceled, or a Worker activity is updated. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the Workspace resource. For example: `Sales Call Center` or `Customer Support Team`. </param>
        /// <param name="multiTaskEnabled"> Whether to enable multi-tasking. Can be: `true` to enable multi-tasking, or `false` to disable it. However, all workspaces should be maintained as multi-tasking. There is no default when omitting this parameter. A multi-tasking Workspace can't be updated to single-tasking unless it is not a Flex Project and another (legacy) single-tasking Workspace exists. Multi-tasking allows Workers to handle multiple Tasks simultaneously. In multi-tasking mode, each Worker can receive parallel reservations up to the per-channel maximums defined in the Workers section. In single-tasking mode (legacy mode), each Worker will only receive a new reservation when the previous task is completed. Learn more at [Multitasking](https://www.kandy.com/docs/taskrouter/multitasking). </param>
        /// <param name="timeoutActivitySid"> The SID of the Activity that will be assigned to a Worker when a Task reservation times out without a response. </param>
        /// <param name="prioritizeQueueOrder">  </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Workspace </returns>
        public static async System.Threading.Tasks.Task<WorkspaceResource> UpdateAsync(
                                                                              string pathSid,
                                                                              string defaultActivitySid = null,
                                                                              Uri eventCallbackUrl = null,
                                                                              string eventsFilter = null,
                                                                              string friendlyName = null,
                                                                              bool? multiTaskEnabled = null,
                                                                              string timeoutActivitySid = null,
                                                                              WorkspaceResource.QueueOrderEnum prioritizeQueueOrder = null,
                                                                              IKandyRestClient client = null)
        {
            var options = new UpdateWorkspaceOptions(pathSid) { DefaultActivitySid = defaultActivitySid, EventCallbackUrl = eventCallbackUrl, EventsFilter = eventsFilter, FriendlyName = friendlyName, MultiTaskEnabled = multiTaskEnabled, TimeoutActivitySid = timeoutActivitySid, PrioritizeQueueOrder = prioritizeQueueOrder };
            return await UpdateAsync(options, client);
        }
#endif

        /// <summary>
        /// Converts a JSON string into a WorkspaceResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> WorkspaceResource object represented by the provided JSON </returns>
        public static WorkspaceResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<WorkspaceResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> The SID of the [Account](https://www.kandy.com/docs/iam/api/account) that created the Workspace resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The date and time in GMT when the resource was created specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT when the resource was last updated specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The name of the default activity. </summary> 
        [JsonProperty("default_activity_name")]
        public string DefaultActivityName { get; private set; }

        ///<summary> The SID of the Activity that will be used when new Workers are created in the Workspace. </summary> 
        [JsonProperty("default_activity_sid")]
        public string DefaultActivitySid { get; private set; }

        ///<summary> The URL we call when an event occurs. If provided, the Workspace will publish events to this URL, for example, to collect data for reporting. See [Workspace Events](https://www.kandy.com/docs/taskrouter/api/event) for more information. This parameter supports Kandy's [Webhooks (HTTP callbacks) Connection Overrides](https://www.kandy.com/docs/usage/webhooks/webhooks-connection-overrides). </summary> 
        [JsonProperty("event_callback_url")]
        public Uri EventCallbackUrl { get; private set; }

        ///<summary> The list of Workspace events for which to call `event_callback_url`. For example, if `EventsFilter=task.created, task.canceled, worker.activity.update`, then TaskRouter will call event_callback_url only when a task is created, canceled, or a Worker activity is updated. </summary> 
        [JsonProperty("events_filter")]
        public string EventsFilter { get; private set; }

        ///<summary> The string that you assigned to describe the Workspace resource. For example `Customer Support` or `2014 Election Campaign`. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> Whether multi-tasking is enabled. The default is `true`, which enables multi-tasking. Multi-tasking allows Workers to handle multiple Tasks simultaneously. When enabled (`true`), each Worker can receive parallel reservations up to the per-channel maximums defined in the Workers section. In single-tasking each Worker would only receive a new reservation when the previous task is completed. Learn more at [Multitasking](https://www.kandy.com/docs/taskrouter/multitasking). </summary> 
        [JsonProperty("multi_task_enabled")]
        public bool? MultiTaskEnabled { get; private set; }

        ///<summary> The unique string that we created to identify the Workspace resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The name of the timeout activity. </summary> 
        [JsonProperty("timeout_activity_name")]
        public string TimeoutActivityName { get; private set; }

        ///<summary> The SID of the Activity that will be assigned to a Worker when a Task reservation times out without a response. </summary> 
        [JsonProperty("timeout_activity_sid")]
        public string TimeoutActivitySid { get; private set; }


        [JsonProperty("prioritize_queue_order")]
        public WorkspaceResource.QueueOrderEnum PrioritizeQueueOrder { get; private set; }

        ///<summary> The absolute URL of the Workspace resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The URLs of related resources. </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }



        private WorkspaceResource()
        {

        }
    }
}
