/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Preview
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



namespace Kandy.Rest.Preview.Understand.Assistant.Task
{
    public class TaskActionsResource : Resource
    {



        private static Request BuildFetchRequest(FetchTaskActionsOptions options, IKandyRestClient client)
        {

            string path = "/understand/Assistants/{AssistantSid}/Tasks/{TaskSid}/Actions";

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

        /// <summary> Returns JSON actions for this Task. </summary>
        /// <param name="options"> Fetch TaskActions parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TaskActions </returns>
        public static TaskActionsResource Fetch(FetchTaskActionsOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> Returns JSON actions for this Task. </summary>
        /// <param name="options"> Fetch TaskActions parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TaskActions </returns>
        public static async System.Threading.Tasks.Task<TaskActionsResource> FetchAsync(FetchTaskActionsOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
#endif
        /// <summary> Returns JSON actions for this Task. </summary>
        /// <param name="pathAssistantSid"> The unique ID of the parent Assistant. </param>
        /// <param name="pathTaskSid"> The unique ID of the Task. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TaskActions </returns>
        public static TaskActionsResource Fetch(
                                         string pathAssistantSid,
                                         string pathTaskSid,
                                         IKandyRestClient client = null)
        {
            var options = new FetchTaskActionsOptions(pathAssistantSid, pathTaskSid) { };
            return Fetch(options, client);
        }

#if !NET35
        /// <summary> Returns JSON actions for this Task. </summary>
        /// <param name="pathAssistantSid"> The unique ID of the parent Assistant. </param>
        /// <param name="pathTaskSid"> The unique ID of the Task. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TaskActions </returns>
        public static async System.Threading.Tasks.Task<TaskActionsResource> FetchAsync(string pathAssistantSid, string pathTaskSid, IKandyRestClient client = null)
        {
            var options = new FetchTaskActionsOptions(pathAssistantSid, pathTaskSid) { };
            return await FetchAsync(options, client);
        }
#endif

        private static Request BuildUpdateRequest(UpdateTaskActionsOptions options, IKandyRestClient client)
        {

            string path = "/understand/Assistants/{AssistantSid}/Tasks/{TaskSid}/Actions";

            string PathAssistantSid = options.PathAssistantSid;
            path = path.Replace("{" + "AssistantSid" + "}", PathAssistantSid);
            string PathTaskSid = options.PathTaskSid;
            path = path.Replace("{" + "TaskSid" + "}", PathTaskSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Preview,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Updates the actions of an Task identified by {TaskSid} or {TaskUniqueName}. </summary>
        /// <param name="options"> Update TaskActions parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TaskActions </returns>
        public static TaskActionsResource Update(UpdateTaskActionsOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Updates the actions of an Task identified by {TaskSid} or {TaskUniqueName}. </summary>
        /// <param name="options"> Update TaskActions parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TaskActions </returns>
#if !NET35
        public static async System.Threading.Tasks.Task<TaskActionsResource> UpdateAsync(UpdateTaskActionsOptions options,
                                                                                                          IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> Updates the actions of an Task identified by {TaskSid} or {TaskUniqueName}. </summary>
        /// <param name="pathAssistantSid"> The unique ID of the parent Assistant. </param>
        /// <param name="pathTaskSid"> The unique ID of the Task. </param>
        /// <param name="actions"> The JSON actions that instruct the Assistant how to perform this task. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TaskActions </returns>
        public static TaskActionsResource Update(
                                          string pathAssistantSid,
                                          string pathTaskSid,
                                          object actions = null,
                                          IKandyRestClient client = null)
        {
            var options = new UpdateTaskActionsOptions(pathAssistantSid, pathTaskSid) { Actions = actions };
            return Update(options, client);
        }

#if !NET35
        /// <summary> Updates the actions of an Task identified by {TaskSid} or {TaskUniqueName}. </summary>
        /// <param name="pathAssistantSid"> The unique ID of the parent Assistant. </param>
        /// <param name="pathTaskSid"> The unique ID of the Task. </param>
        /// <param name="actions"> The JSON actions that instruct the Assistant how to perform this task. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TaskActions </returns>
        public static async System.Threading.Tasks.Task<TaskActionsResource> UpdateAsync(
                                                                              string pathAssistantSid,
                                                                              string pathTaskSid,
                                                                              object actions = null,
                                                                              IKandyRestClient client = null)
        {
            var options = new UpdateTaskActionsOptions(pathAssistantSid, pathTaskSid) { Actions = actions };
            return await UpdateAsync(options, client);
        }
#endif

        /// <summary>
        /// Converts a JSON string into a TaskActionsResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> TaskActionsResource object represented by the provided JSON </returns>
        public static TaskActionsResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<TaskActionsResource>(json);
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

        ///<summary> The unique ID of the Task. </summary> 
        [JsonProperty("task_sid")]
        public string TaskSid { get; private set; }

        ///<summary> The url </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The data </summary> 
        [JsonProperty("data")]
        public object Data { get; private set; }



        private TaskActionsResource()
        {

        }
    }
}
