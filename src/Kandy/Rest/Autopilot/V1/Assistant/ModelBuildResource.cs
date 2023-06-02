/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Autopilot
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


namespace Kandy.Rest.Autopilot.V1.Assistant
{
    public class ModelBuildResource : Resource
    {

        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class StatusEnum : StringEnum
        {
            private StatusEnum(string value) : base(value) { }
            public StatusEnum() { }
            public static implicit operator StatusEnum(string value)
            {
                return new StatusEnum(value);
            }
            public static readonly StatusEnum Enqueued = new StatusEnum("enqueued");
            public static readonly StatusEnum Building = new StatusEnum("building");
            public static readonly StatusEnum Completed = new StatusEnum("completed");
            public static readonly StatusEnum Failed = new StatusEnum("failed");
            public static readonly StatusEnum Canceled = new StatusEnum("canceled");

        }


        private static Request BuildCreateRequest(CreateModelBuildOptions options, IKandyRestClient client)
        {

            string path = "/v1/Assistants/{AssistantSid}/ModelBuilds";

            string PathAssistantSid = options.PathAssistantSid;
            path = path.Replace("{" + "AssistantSid" + "}", PathAssistantSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Autopilot,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> create </summary>
        /// <param name="options"> Create ModelBuild parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of ModelBuild </returns>
        public static ModelBuildResource Create(CreateModelBuildOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> create </summary>
        /// <param name="options"> Create ModelBuild parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of ModelBuild </returns>
        public static async System.Threading.Tasks.Task<ModelBuildResource> CreateAsync(CreateModelBuildOptions options,
        IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> create </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.kandy.com/docs/autopilot/api/assistant) that is the parent of the new resource. </param>
        /// <param name="statusCallback"> The URL we should call using a POST method to send status information to your application. </param>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the new resource. This value must be a unique string of no more than 64 characters. It can be used as an alternative to the `sid` in the URL path to address the resource. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of ModelBuild </returns>
        public static ModelBuildResource Create(
                                          string pathAssistantSid,
                                          Uri statusCallback = null,
                                          string uniqueName = null,
                                          IKandyRestClient client = null)
        {
            var options = new CreateModelBuildOptions(pathAssistantSid) { StatusCallback = statusCallback, UniqueName = uniqueName };
            return Create(options, client);
        }

#if !NET35
        /// <summary> create </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.kandy.com/docs/autopilot/api/assistant) that is the parent of the new resource. </param>
        /// <param name="statusCallback"> The URL we should call using a POST method to send status information to your application. </param>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the new resource. This value must be a unique string of no more than 64 characters. It can be used as an alternative to the `sid` in the URL path to address the resource. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of ModelBuild </returns>
        public static async System.Threading.Tasks.Task<ModelBuildResource> CreateAsync(
                                                                                  string pathAssistantSid,
                                                                                  Uri statusCallback = null,
                                                                                  string uniqueName = null,
                                                                                  IKandyRestClient client = null)
        {
            var options = new CreateModelBuildOptions(pathAssistantSid) { StatusCallback = statusCallback, UniqueName = uniqueName };
            return await CreateAsync(options, client);
        }
#endif

        /// <summary> delete </summary>
        /// <param name="options"> Delete ModelBuild parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of ModelBuild </returns>
        private static Request BuildDeleteRequest(DeleteModelBuildOptions options, IKandyRestClient client)
        {

            string path = "/v1/Assistants/{AssistantSid}/ModelBuilds/{Sid}";

            string PathAssistantSid = options.PathAssistantSid;
            path = path.Replace("{" + "AssistantSid" + "}", PathAssistantSid);
            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Autopilot,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> delete </summary>
        /// <param name="options"> Delete ModelBuild parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of ModelBuild </returns>
        public static bool Delete(DeleteModelBuildOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

#if !NET35
        /// <summary> delete </summary>
        /// <param name="options"> Delete ModelBuild parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of ModelBuild </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteModelBuildOptions options,
                                                                          IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
#endif

        /// <summary> delete </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.kandy.com/docs/autopilot/api/assistant) that is the parent of the resources to delete. </param>
        /// <param name="pathSid"> The Kandy-provided string that uniquely identifies the ModelBuild resource to delete. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of ModelBuild </returns>
        public static bool Delete(string pathAssistantSid, string pathSid, IKandyRestClient client = null)
        {
            var options = new DeleteModelBuildOptions(pathAssistantSid, pathSid);
            return Delete(options, client);
        }

#if !NET35
        /// <summary> delete </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.kandy.com/docs/autopilot/api/assistant) that is the parent of the resources to delete. </param>
        /// <param name="pathSid"> The Kandy-provided string that uniquely identifies the ModelBuild resource to delete. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of ModelBuild </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathAssistantSid, string pathSid, IKandyRestClient client = null)
        {
            var options = new DeleteModelBuildOptions(pathAssistantSid, pathSid);
            return await DeleteAsync(options, client);
        }
#endif

        private static Request BuildFetchRequest(FetchModelBuildOptions options, IKandyRestClient client)
        {

            string path = "/v1/Assistants/{AssistantSid}/ModelBuilds/{Sid}";

            string PathAssistantSid = options.PathAssistantSid;
            path = path.Replace("{" + "AssistantSid" + "}", PathAssistantSid);
            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Autopilot,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch ModelBuild parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of ModelBuild </returns>
        public static ModelBuildResource Fetch(FetchModelBuildOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch ModelBuild parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of ModelBuild </returns>
        public static async System.Threading.Tasks.Task<ModelBuildResource> FetchAsync(FetchModelBuildOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
#endif
        /// <summary> fetch </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.kandy.com/docs/autopilot/api/assistant) that is the parent of the resource to fetch. </param>
        /// <param name="pathSid"> The Kandy-provided string that uniquely identifies the ModelBuild resource to fetch. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of ModelBuild </returns>
        public static ModelBuildResource Fetch(
                                         string pathAssistantSid,
                                         string pathSid,
                                         IKandyRestClient client = null)
        {
            var options = new FetchModelBuildOptions(pathAssistantSid, pathSid) { };
            return Fetch(options, client);
        }

#if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.kandy.com/docs/autopilot/api/assistant) that is the parent of the resource to fetch. </param>
        /// <param name="pathSid"> The Kandy-provided string that uniquely identifies the ModelBuild resource to fetch. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of ModelBuild </returns>
        public static async System.Threading.Tasks.Task<ModelBuildResource> FetchAsync(string pathAssistantSid, string pathSid, IKandyRestClient client = null)
        {
            var options = new FetchModelBuildOptions(pathAssistantSid, pathSid) { };
            return await FetchAsync(options, client);
        }
#endif

        private static Request BuildReadRequest(ReadModelBuildOptions options, IKandyRestClient client)
        {

            string path = "/v1/Assistants/{AssistantSid}/ModelBuilds";

            string PathAssistantSid = options.PathAssistantSid;
            path = path.Replace("{" + "AssistantSid" + "}", PathAssistantSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Autopilot,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> read </summary>
        /// <param name="options"> Read ModelBuild parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of ModelBuild </returns>
        public static ResourceSet<ModelBuildResource> Read(ReadModelBuildOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<ModelBuildResource>.FromJson("model_builds", response.Content);
            return new ResourceSet<ModelBuildResource>(page, options, client);
        }

#if !NET35
        /// <summary> read </summary>
        /// <param name="options"> Read ModelBuild parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of ModelBuild </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<ModelBuildResource>> ReadAsync(ReadModelBuildOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<ModelBuildResource>.FromJson("model_builds", response.Content);
            return new ResourceSet<ModelBuildResource>(page, options, client);
        }
#endif
        /// <summary> read </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.kandy.com/docs/autopilot/api/assistant) that is the parent of the resources to read. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of ModelBuild </returns>
        public static ResourceSet<ModelBuildResource> Read(
                                                     string pathAssistantSid,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     IKandyRestClient client = null)
        {
            var options = new ReadModelBuildOptions(pathAssistantSid) { PageSize = pageSize, Limit = limit };
            return Read(options, client);
        }

#if !NET35
        /// <summary> read </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.kandy.com/docs/autopilot/api/assistant) that is the parent of the resources to read. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of ModelBuild </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<ModelBuildResource>> ReadAsync(
                                                                                             string pathAssistantSid,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             IKandyRestClient client = null)
        {
            var options = new ReadModelBuildOptions(pathAssistantSid) { PageSize = pageSize, Limit = limit };
            return await ReadAsync(options, client);
        }
#endif


        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The target page of records </returns>
        public static Page<ModelBuildResource> GetPage(string targetUrl, IKandyRestClient client)
        {
            client = client ?? KandyClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<ModelBuildResource>.FromJson("model_builds", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The next page of records </returns>
        public static Page<ModelBuildResource> NextPage(Page<ModelBuildResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<ModelBuildResource>.FromJson("model_builds", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The previous page of records </returns>
        public static Page<ModelBuildResource> PreviousPage(Page<ModelBuildResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<ModelBuildResource>.FromJson("model_builds", response.Content);
        }


        private static Request BuildUpdateRequest(UpdateModelBuildOptions options, IKandyRestClient client)
        {

            string path = "/v1/Assistants/{AssistantSid}/ModelBuilds/{Sid}";

            string PathAssistantSid = options.PathAssistantSid;
            path = path.Replace("{" + "AssistantSid" + "}", PathAssistantSid);
            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Autopilot,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> update </summary>
        /// <param name="options"> Update ModelBuild parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of ModelBuild </returns>
        public static ModelBuildResource Update(UpdateModelBuildOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> update </summary>
        /// <param name="options"> Update ModelBuild parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of ModelBuild </returns>
#if !NET35
        public static async System.Threading.Tasks.Task<ModelBuildResource> UpdateAsync(UpdateModelBuildOptions options,
                                                                                                          IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> update </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.kandy.com/docs/autopilot/api/assistant) that is the parent of the resource to update. </param>
        /// <param name="pathSid"> The Kandy-provided string that uniquely identifies the ModelBuild resource to update. </param>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the resource. This value must be a unique string of no more than 64 characters. It can be used as an alternative to the `sid` in the URL path to address the resource. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of ModelBuild </returns>
        public static ModelBuildResource Update(
                                          string pathAssistantSid,
                                          string pathSid,
                                          string uniqueName = null,
                                          IKandyRestClient client = null)
        {
            var options = new UpdateModelBuildOptions(pathAssistantSid, pathSid) { UniqueName = uniqueName };
            return Update(options, client);
        }

#if !NET35
        /// <summary> update </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.kandy.com/docs/autopilot/api/assistant) that is the parent of the resource to update. </param>
        /// <param name="pathSid"> The Kandy-provided string that uniquely identifies the ModelBuild resource to update. </param>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the resource. This value must be a unique string of no more than 64 characters. It can be used as an alternative to the `sid` in the URL path to address the resource. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of ModelBuild </returns>
        public static async System.Threading.Tasks.Task<ModelBuildResource> UpdateAsync(
                                                                              string pathAssistantSid,
                                                                              string pathSid,
                                                                              string uniqueName = null,
                                                                              IKandyRestClient client = null)
        {
            var options = new UpdateModelBuildOptions(pathAssistantSid, pathSid) { UniqueName = uniqueName };
            return await UpdateAsync(options, client);
        }
#endif

        /// <summary>
        /// Converts a JSON string into a ModelBuildResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ModelBuildResource object represented by the provided JSON </returns>
        public static ModelBuildResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<ModelBuildResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> The SID of the [Account](https://www.kandy.com/docs/iam/api/account) that created the ModelBuild resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The date and time in GMT when the resource was created specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT when the resource was last updated specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The SID of the [Assistant](https://www.kandy.com/docs/autopilot/api/assistant) that is the parent of the resource. </summary> 
        [JsonProperty("assistant_sid")]
        public string AssistantSid { get; private set; }

        ///<summary> The unique string that we created to identify the ModelBuild resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }


        [JsonProperty("status")]
        public ModelBuildResource.StatusEnum Status { get; private set; }

        ///<summary> An application-defined string that uniquely identifies the resource. It can be used as an alternative to the `sid` in the URL path to address the resource. </summary> 
        [JsonProperty("unique_name")]
        public string UniqueName { get; private set; }

        ///<summary> The absolute URL of the ModelBuild resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The time in seconds it took to build the model. </summary> 
        [JsonProperty("build_duration")]
        public int? BuildDuration { get; private set; }

        ///<summary> If the `status` for the model build is `failed`, this value is a code to more information about the failure. This value will be null for all other statuses. See [error code dictionary](https://www.kandy.com/docs/api/errors) for a description of the error. </summary> 
        [JsonProperty("error_code")]
        public int? ErrorCode { get; private set; }



        private ModelBuildResource()
        {

        }
    }
}
