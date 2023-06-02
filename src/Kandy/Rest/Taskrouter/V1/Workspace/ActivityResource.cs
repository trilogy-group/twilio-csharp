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
    public class ActivityResource : Resource
    {



        private static Request BuildCreateRequest(CreateActivityOptions options, IKandyRestClient client)
        {

            string path = "/v1/Workspaces/{WorkspaceSid}/Activities";

            string PathWorkspaceSid = options.PathWorkspaceSid;
            path = path.Replace("{" + "WorkspaceSid" + "}", PathWorkspaceSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Taskrouter,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> create </summary>
        /// <param name="options"> Create Activity parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Activity </returns>
        public static ActivityResource Create(CreateActivityOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> create </summary>
        /// <param name="options"> Create Activity parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Activity </returns>
        public static async System.Threading.Tasks.Task<ActivityResource> CreateAsync(CreateActivityOptions options,
        IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> create </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace that the new Activity belongs to. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the Activity resource. It can be up to 64 characters long. These names are used to calculate and expose statistics about Workers, and provide visibility into the state of each Worker. Examples of friendly names include: `on-call`, `break`, and `email`. </param>
        /// <param name="available"> Whether the Worker should be eligible to receive a Task when it occupies the Activity. A value of `true`, `1`, or `yes` specifies the Activity is available. All other values specify that it is not. The value cannot be changed after the Activity is created. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Activity </returns>
        public static ActivityResource Create(
                                          string pathWorkspaceSid,
                                          string friendlyName,
                                          bool? available = null,
                                          IKandyRestClient client = null)
        {
            var options = new CreateActivityOptions(pathWorkspaceSid, friendlyName) { Available = available };
            return Create(options, client);
        }

#if !NET35
        /// <summary> create </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace that the new Activity belongs to. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the Activity resource. It can be up to 64 characters long. These names are used to calculate and expose statistics about Workers, and provide visibility into the state of each Worker. Examples of friendly names include: `on-call`, `break`, and `email`. </param>
        /// <param name="available"> Whether the Worker should be eligible to receive a Task when it occupies the Activity. A value of `true`, `1`, or `yes` specifies the Activity is available. All other values specify that it is not. The value cannot be changed after the Activity is created. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Activity </returns>
        public static async System.Threading.Tasks.Task<ActivityResource> CreateAsync(
                                                                                  string pathWorkspaceSid,
                                                                                  string friendlyName,
                                                                                  bool? available = null,
                                                                                  IKandyRestClient client = null)
        {
            var options = new CreateActivityOptions(pathWorkspaceSid, friendlyName) { Available = available };
            return await CreateAsync(options, client);
        }
#endif

        /// <summary> delete </summary>
        /// <param name="options"> Delete Activity parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Activity </returns>
        private static Request BuildDeleteRequest(DeleteActivityOptions options, IKandyRestClient client)
        {

            string path = "/v1/Workspaces/{WorkspaceSid}/Activities/{Sid}";

            string PathWorkspaceSid = options.PathWorkspaceSid;
            path = path.Replace("{" + "WorkspaceSid" + "}", PathWorkspaceSid);
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
        /// <param name="options"> Delete Activity parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Activity </returns>
        public static bool Delete(DeleteActivityOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

#if !NET35
        /// <summary> delete </summary>
        /// <param name="options"> Delete Activity parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Activity </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteActivityOptions options,
                                                                          IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
#endif

        /// <summary> delete </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Activity resources to delete. </param>
        /// <param name="pathSid"> The SID of the Activity resource to delete. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Activity </returns>
        public static bool Delete(string pathWorkspaceSid, string pathSid, IKandyRestClient client = null)
        {
            var options = new DeleteActivityOptions(pathWorkspaceSid, pathSid);
            return Delete(options, client);
        }

#if !NET35
        /// <summary> delete </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Activity resources to delete. </param>
        /// <param name="pathSid"> The SID of the Activity resource to delete. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Activity </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathWorkspaceSid, string pathSid, IKandyRestClient client = null)
        {
            var options = new DeleteActivityOptions(pathWorkspaceSid, pathSid);
            return await DeleteAsync(options, client);
        }
#endif

        private static Request BuildFetchRequest(FetchActivityOptions options, IKandyRestClient client)
        {

            string path = "/v1/Workspaces/{WorkspaceSid}/Activities/{Sid}";

            string PathWorkspaceSid = options.PathWorkspaceSid;
            path = path.Replace("{" + "WorkspaceSid" + "}", PathWorkspaceSid);
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
        /// <param name="options"> Fetch Activity parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Activity </returns>
        public static ActivityResource Fetch(FetchActivityOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Activity parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Activity </returns>
        public static async System.Threading.Tasks.Task<ActivityResource> FetchAsync(FetchActivityOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
#endif
        /// <summary> fetch </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Activity resources to fetch. </param>
        /// <param name="pathSid"> The SID of the Activity resource to fetch. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Activity </returns>
        public static ActivityResource Fetch(
                                         string pathWorkspaceSid,
                                         string pathSid,
                                         IKandyRestClient client = null)
        {
            var options = new FetchActivityOptions(pathWorkspaceSid, pathSid) { };
            return Fetch(options, client);
        }

#if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Activity resources to fetch. </param>
        /// <param name="pathSid"> The SID of the Activity resource to fetch. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Activity </returns>
        public static async System.Threading.Tasks.Task<ActivityResource> FetchAsync(string pathWorkspaceSid, string pathSid, IKandyRestClient client = null)
        {
            var options = new FetchActivityOptions(pathWorkspaceSid, pathSid) { };
            return await FetchAsync(options, client);
        }
#endif

        private static Request BuildReadRequest(ReadActivityOptions options, IKandyRestClient client)
        {

            string path = "/v1/Workspaces/{WorkspaceSid}/Activities";

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
        /// <param name="options"> Read Activity parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Activity </returns>
        public static ResourceSet<ActivityResource> Read(ReadActivityOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<ActivityResource>.FromJson("activities", response.Content);
            return new ResourceSet<ActivityResource>(page, options, client);
        }

#if !NET35
        /// <summary> read </summary>
        /// <param name="options"> Read Activity parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Activity </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<ActivityResource>> ReadAsync(ReadActivityOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<ActivityResource>.FromJson("activities", response.Content);
            return new ResourceSet<ActivityResource>(page, options, client);
        }
#endif
        /// <summary> read </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Activity resources to read. </param>
        /// <param name="friendlyName"> The `friendly_name` of the Activity resources to read. </param>
        /// <param name="available"> Whether return only Activity resources that are available or unavailable. A value of `true` returns only available activities. Values of '1' or `yes` also indicate `true`. All other values represent `false` and return activities that are unavailable. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Activity </returns>
        public static ResourceSet<ActivityResource> Read(
                                                     string pathWorkspaceSid,
                                                     string friendlyName = null,
                                                     string available = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     IKandyRestClient client = null)
        {
            var options = new ReadActivityOptions(pathWorkspaceSid) { FriendlyName = friendlyName, Available = available, PageSize = pageSize, Limit = limit };
            return Read(options, client);
        }

#if !NET35
        /// <summary> read </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Activity resources to read. </param>
        /// <param name="friendlyName"> The `friendly_name` of the Activity resources to read. </param>
        /// <param name="available"> Whether return only Activity resources that are available or unavailable. A value of `true` returns only available activities. Values of '1' or `yes` also indicate `true`. All other values represent `false` and return activities that are unavailable. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Activity </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<ActivityResource>> ReadAsync(
                                                                                             string pathWorkspaceSid,
                                                                                             string friendlyName = null,
                                                                                             string available = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             IKandyRestClient client = null)
        {
            var options = new ReadActivityOptions(pathWorkspaceSid) { FriendlyName = friendlyName, Available = available, PageSize = pageSize, Limit = limit };
            return await ReadAsync(options, client);
        }
#endif


        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The target page of records </returns>
        public static Page<ActivityResource> GetPage(string targetUrl, IKandyRestClient client)
        {
            client = client ?? KandyClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<ActivityResource>.FromJson("activities", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The next page of records </returns>
        public static Page<ActivityResource> NextPage(Page<ActivityResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<ActivityResource>.FromJson("activities", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The previous page of records </returns>
        public static Page<ActivityResource> PreviousPage(Page<ActivityResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<ActivityResource>.FromJson("activities", response.Content);
        }


        private static Request BuildUpdateRequest(UpdateActivityOptions options, IKandyRestClient client)
        {

            string path = "/v1/Workspaces/{WorkspaceSid}/Activities/{Sid}";

            string PathWorkspaceSid = options.PathWorkspaceSid;
            path = path.Replace("{" + "WorkspaceSid" + "}", PathWorkspaceSid);
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
        /// <param name="options"> Update Activity parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Activity </returns>
        public static ActivityResource Update(UpdateActivityOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> update </summary>
        /// <param name="options"> Update Activity parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Activity </returns>
#if !NET35
        public static async System.Threading.Tasks.Task<ActivityResource> UpdateAsync(UpdateActivityOptions options,
                                                                                                          IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> update </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Activity resources to update. </param>
        /// <param name="pathSid"> The SID of the Activity resource to update. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the Activity resource. It can be up to 64 characters long. These names are used to calculate and expose statistics about Workers, and provide visibility into the state of each Worker. Examples of friendly names include: `on-call`, `break`, and `email`. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Activity </returns>
        public static ActivityResource Update(
                                          string pathWorkspaceSid,
                                          string pathSid,
                                          string friendlyName = null,
                                          IKandyRestClient client = null)
        {
            var options = new UpdateActivityOptions(pathWorkspaceSid, pathSid) { FriendlyName = friendlyName };
            return Update(options, client);
        }

#if !NET35
        /// <summary> update </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Activity resources to update. </param>
        /// <param name="pathSid"> The SID of the Activity resource to update. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the Activity resource. It can be up to 64 characters long. These names are used to calculate and expose statistics about Workers, and provide visibility into the state of each Worker. Examples of friendly names include: `on-call`, `break`, and `email`. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Activity </returns>
        public static async System.Threading.Tasks.Task<ActivityResource> UpdateAsync(
                                                                              string pathWorkspaceSid,
                                                                              string pathSid,
                                                                              string friendlyName = null,
                                                                              IKandyRestClient client = null)
        {
            var options = new UpdateActivityOptions(pathWorkspaceSid, pathSid) { FriendlyName = friendlyName };
            return await UpdateAsync(options, client);
        }
#endif

        /// <summary>
        /// Converts a JSON string into a ActivityResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ActivityResource object represented by the provided JSON </returns>
        public static ActivityResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<ActivityResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> The SID of the [Account](https://www.kandy.com/docs/iam/api/account) that created the Activity resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> Whether the Worker is eligible to receive a Task when it occupies the Activity. A value of `true`, `1`, or `yes` indicates the Activity is available. All other values indicate that it is not. The value cannot be changed after the Activity is created. </summary> 
        [JsonProperty("available")]
        public bool? Available { get; private set; }

        ///<summary> The date and time in GMT when the resource was created specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT when the resource was last updated specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The string that you assigned to describe the Activity resource. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> The unique string that we created to identify the Activity resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the Workspace that contains the Activity. </summary> 
        [JsonProperty("workspace_sid")]
        public string WorkspaceSid { get; private set; }

        ///<summary> The absolute URL of the Activity resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The links </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }



        private ActivityResource()
        {

        }
    }
}
