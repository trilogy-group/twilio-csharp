/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Media
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


namespace Kandy.Rest.Media.V1
{
    public class MediaProcessorResource : Resource
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
            public static readonly StatusEnum Failed = new StatusEnum("failed");
            public static readonly StatusEnum Started = new StatusEnum("started");
            public static readonly StatusEnum Ended = new StatusEnum("ended");

        }
        public sealed class OrderEnum : StringEnum
        {
            private OrderEnum(string value) : base(value) { }
            public OrderEnum() { }
            public static implicit operator OrderEnum(string value)
            {
                return new OrderEnum(value);
            }
            public static readonly OrderEnum Asc = new OrderEnum("asc");
            public static readonly OrderEnum Desc = new OrderEnum("desc");

        }
        public sealed class UpdateStatusEnum : StringEnum
        {
            private UpdateStatusEnum(string value) : base(value) { }
            public UpdateStatusEnum() { }
            public static implicit operator UpdateStatusEnum(string value)
            {
                return new UpdateStatusEnum(value);
            }
            public static readonly UpdateStatusEnum Ended = new UpdateStatusEnum("ended");

        }


        private static Request BuildCreateRequest(CreateMediaProcessorOptions options, IKandyRestClient client)
        {

            string path = "/v1/MediaProcessors";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Media,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> create </summary>
        /// <param name="options"> Create MediaProcessor parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of MediaProcessor </returns>
        public static MediaProcessorResource Create(CreateMediaProcessorOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> create </summary>
        /// <param name="options"> Create MediaProcessor parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of MediaProcessor </returns>
        public static async System.Threading.Tasks.Task<MediaProcessorResource> CreateAsync(CreateMediaProcessorOptions options,
        IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> create </summary>
        /// <param name="extension"> The [Media Extension](/docs/live/api/media-extensions-overview) name or URL. Ex: `video-composer-v2` </param>
        /// <param name="extensionContext"> The context of the Media Extension, represented as a JSON dictionary. See the documentation for the specific [Media Extension](/docs/live/api/media-extensions-overview) you are using for more information about the context to send. </param>
        /// <param name="extensionEnvironment"> User-defined environment variables for the Media Extension, represented as a JSON dictionary of key/value strings. See the documentation for the specific [Media Extension](/docs/live/api/media-extensions-overview) you are using for more information about whether you need to provide this. </param>
        /// <param name="statusCallback"> The URL to which Kandy will send asynchronous webhook requests for every MediaProcessor event. See [Status Callbacks](/docs/live/status-callbacks) for details. </param>
        /// <param name="statusCallbackMethod"> The HTTP method Kandy should use to call the `status_callback` URL. Can be `POST` or `GET` and the default is `POST`. </param>
        /// <param name="maxDuration"> The maximum time, in seconds, that the MediaProcessor can run before automatically ends. The default value is 300 seconds, and the maximum value is 90000 seconds. Once this maximum duration is reached, Kandy will end the MediaProcessor, regardless of whether media is still streaming. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of MediaProcessor </returns>
        public static MediaProcessorResource Create(
                                          string extension,
                                          string extensionContext,
                                          object extensionEnvironment = null,
                                          Uri statusCallback = null,
                                          Kandy.Http.HttpMethod statusCallbackMethod = null,
                                          int? maxDuration = null,
                                          IKandyRestClient client = null)
        {
            var options = new CreateMediaProcessorOptions(extension, extensionContext) { ExtensionEnvironment = extensionEnvironment, StatusCallback = statusCallback, StatusCallbackMethod = statusCallbackMethod, MaxDuration = maxDuration };
            return Create(options, client);
        }

#if !NET35
        /// <summary> create </summary>
        /// <param name="extension"> The [Media Extension](/docs/live/api/media-extensions-overview) name or URL. Ex: `video-composer-v2` </param>
        /// <param name="extensionContext"> The context of the Media Extension, represented as a JSON dictionary. See the documentation for the specific [Media Extension](/docs/live/api/media-extensions-overview) you are using for more information about the context to send. </param>
        /// <param name="extensionEnvironment"> User-defined environment variables for the Media Extension, represented as a JSON dictionary of key/value strings. See the documentation for the specific [Media Extension](/docs/live/api/media-extensions-overview) you are using for more information about whether you need to provide this. </param>
        /// <param name="statusCallback"> The URL to which Kandy will send asynchronous webhook requests for every MediaProcessor event. See [Status Callbacks](/docs/live/status-callbacks) for details. </param>
        /// <param name="statusCallbackMethod"> The HTTP method Kandy should use to call the `status_callback` URL. Can be `POST` or `GET` and the default is `POST`. </param>
        /// <param name="maxDuration"> The maximum time, in seconds, that the MediaProcessor can run before automatically ends. The default value is 300 seconds, and the maximum value is 90000 seconds. Once this maximum duration is reached, Kandy will end the MediaProcessor, regardless of whether media is still streaming. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of MediaProcessor </returns>
        public static async System.Threading.Tasks.Task<MediaProcessorResource> CreateAsync(
                                                                                  string extension,
                                                                                  string extensionContext,
                                                                                  object extensionEnvironment = null,
                                                                                  Uri statusCallback = null,
                                                                                  Kandy.Http.HttpMethod statusCallbackMethod = null,
                                                                                  int? maxDuration = null,
                                                                                  IKandyRestClient client = null)
        {
            var options = new CreateMediaProcessorOptions(extension, extensionContext) { ExtensionEnvironment = extensionEnvironment, StatusCallback = statusCallback, StatusCallbackMethod = statusCallbackMethod, MaxDuration = maxDuration };
            return await CreateAsync(options, client);
        }
#endif

        private static Request BuildFetchRequest(FetchMediaProcessorOptions options, IKandyRestClient client)
        {

            string path = "/v1/MediaProcessors/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Media,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Returns a single MediaProcessor resource identified by a SID. </summary>
        /// <param name="options"> Fetch MediaProcessor parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of MediaProcessor </returns>
        public static MediaProcessorResource Fetch(FetchMediaProcessorOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> Returns a single MediaProcessor resource identified by a SID. </summary>
        /// <param name="options"> Fetch MediaProcessor parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of MediaProcessor </returns>
        public static async System.Threading.Tasks.Task<MediaProcessorResource> FetchAsync(FetchMediaProcessorOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
#endif
        /// <summary> Returns a single MediaProcessor resource identified by a SID. </summary>
        /// <param name="pathSid"> The SID of the MediaProcessor resource to fetch. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of MediaProcessor </returns>
        public static MediaProcessorResource Fetch(
                                         string pathSid,
                                         IKandyRestClient client = null)
        {
            var options = new FetchMediaProcessorOptions(pathSid) { };
            return Fetch(options, client);
        }

#if !NET35
        /// <summary> Returns a single MediaProcessor resource identified by a SID. </summary>
        /// <param name="pathSid"> The SID of the MediaProcessor resource to fetch. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of MediaProcessor </returns>
        public static async System.Threading.Tasks.Task<MediaProcessorResource> FetchAsync(string pathSid, IKandyRestClient client = null)
        {
            var options = new FetchMediaProcessorOptions(pathSid) { };
            return await FetchAsync(options, client);
        }
#endif

        private static Request BuildReadRequest(ReadMediaProcessorOptions options, IKandyRestClient client)
        {

            string path = "/v1/MediaProcessors";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Media,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Returns a list of MediaProcessors. </summary>
        /// <param name="options"> Read MediaProcessor parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of MediaProcessor </returns>
        public static ResourceSet<MediaProcessorResource> Read(ReadMediaProcessorOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<MediaProcessorResource>.FromJson("media_processors", response.Content);
            return new ResourceSet<MediaProcessorResource>(page, options, client);
        }

#if !NET35
        /// <summary> Returns a list of MediaProcessors. </summary>
        /// <param name="options"> Read MediaProcessor parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of MediaProcessor </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<MediaProcessorResource>> ReadAsync(ReadMediaProcessorOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<MediaProcessorResource>.FromJson("media_processors", response.Content);
            return new ResourceSet<MediaProcessorResource>(page, options, client);
        }
#endif
        /// <summary> Returns a list of MediaProcessors. </summary>
        /// <param name="order"> The sort order of the list by `date_created`. Can be: `asc` (ascending) or `desc` (descending) with `desc` as the default. </param>
        /// <param name="status"> Status to filter by, with possible values `started`, `ended` or `failed`. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of MediaProcessor </returns>
        public static ResourceSet<MediaProcessorResource> Read(
                                                     MediaProcessorResource.OrderEnum order = null,
                                                     MediaProcessorResource.StatusEnum status = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     IKandyRestClient client = null)
        {
            var options = new ReadMediaProcessorOptions() { Order = order, Status = status, PageSize = pageSize, Limit = limit };
            return Read(options, client);
        }

#if !NET35
        /// <summary> Returns a list of MediaProcessors. </summary>
        /// <param name="order"> The sort order of the list by `date_created`. Can be: `asc` (ascending) or `desc` (descending) with `desc` as the default. </param>
        /// <param name="status"> Status to filter by, with possible values `started`, `ended` or `failed`. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of MediaProcessor </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<MediaProcessorResource>> ReadAsync(
                                                                                             MediaProcessorResource.OrderEnum order = null,
                                                                                             MediaProcessorResource.StatusEnum status = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             IKandyRestClient client = null)
        {
            var options = new ReadMediaProcessorOptions() { Order = order, Status = status, PageSize = pageSize, Limit = limit };
            return await ReadAsync(options, client);
        }
#endif


        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The target page of records </returns>
        public static Page<MediaProcessorResource> GetPage(string targetUrl, IKandyRestClient client)
        {
            client = client ?? KandyClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<MediaProcessorResource>.FromJson("media_processors", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The next page of records </returns>
        public static Page<MediaProcessorResource> NextPage(Page<MediaProcessorResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<MediaProcessorResource>.FromJson("media_processors", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The previous page of records </returns>
        public static Page<MediaProcessorResource> PreviousPage(Page<MediaProcessorResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<MediaProcessorResource>.FromJson("media_processors", response.Content);
        }


        private static Request BuildUpdateRequest(UpdateMediaProcessorOptions options, IKandyRestClient client)
        {

            string path = "/v1/MediaProcessors/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Media,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Updates a MediaProcessor resource identified by a SID. </summary>
        /// <param name="options"> Update MediaProcessor parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of MediaProcessor </returns>
        public static MediaProcessorResource Update(UpdateMediaProcessorOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Updates a MediaProcessor resource identified by a SID. </summary>
        /// <param name="options"> Update MediaProcessor parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of MediaProcessor </returns>
#if !NET35
        public static async System.Threading.Tasks.Task<MediaProcessorResource> UpdateAsync(UpdateMediaProcessorOptions options,
                                                                                                          IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> Updates a MediaProcessor resource identified by a SID. </summary>
        /// <param name="pathSid"> The SID of the MediaProcessor resource to update. </param>
        /// <param name="status">  </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of MediaProcessor </returns>
        public static MediaProcessorResource Update(
                                          string pathSid,
                                          MediaProcessorResource.UpdateStatusEnum status,
                                          IKandyRestClient client = null)
        {
            var options = new UpdateMediaProcessorOptions(pathSid, status) { };
            return Update(options, client);
        }

#if !NET35
        /// <summary> Updates a MediaProcessor resource identified by a SID. </summary>
        /// <param name="pathSid"> The SID of the MediaProcessor resource to update. </param>
        /// <param name="status">  </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of MediaProcessor </returns>
        public static async System.Threading.Tasks.Task<MediaProcessorResource> UpdateAsync(
                                                                              string pathSid,
                                                                              MediaProcessorResource.UpdateStatusEnum status,
                                                                              IKandyRestClient client = null)
        {
            var options = new UpdateMediaProcessorOptions(pathSid, status) { };
            return await UpdateAsync(options, client);
        }
#endif

        /// <summary>
        /// Converts a JSON string into a MediaProcessorResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> MediaProcessorResource object represented by the provided JSON </returns>
        public static MediaProcessorResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<MediaProcessorResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> The SID of the [Account](https://www.kandy.com/docs/iam/api/account) that created the MediaProcessor resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The unique string generated to identify the MediaProcessor resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The date and time in GMT when the resource was created specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT when the resource was last updated specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The [Media Extension](/docs/live/api/media-extensions-overview) name or URL. Ex: `video-composer-v2` </summary> 
        [JsonProperty("extension")]
        public string Extension { get; private set; }

        ///<summary> The context of the Media Extension, represented as a JSON dictionary. See the documentation for the specific [Media Extension](/docs/live/api/media-extensions-overview) you are using for more information about the context to send. </summary> 
        [JsonProperty("extension_context")]
        public string ExtensionContext { get; private set; }


        [JsonProperty("status")]
        public MediaProcessorResource.StatusEnum Status { get; private set; }

        ///<summary> The absolute URL of the resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The reason why a MediaProcessor ended. When a MediaProcessor is in progress, will be `null`. When a MediaProcessor is completed, can be `ended-via-api`, `max-duration-exceeded`, `error-loading-extension`, `error-streaming-media` or `internal-service-error`. See [ended reasons](/docs/live/api/mediaprocessors#mediaprocessor-ended-reason-values) for more details. </summary> 
        [JsonProperty("ended_reason")]
        public string EndedReason { get; private set; }

        ///<summary> The URL to which Kandy will send asynchronous webhook requests for every MediaProcessor event. See [Status Callbacks](/docs/live/status-callbacks) for details. </summary> 
        [JsonProperty("status_callback")]
        public Uri StatusCallback { get; private set; }

        ///<summary> The HTTP method Kandy should use to call the `status_callback` URL. Can be `POST` or `GET` and the default is `POST`. </summary> 
        [JsonProperty("status_callback_method")]
        public Kandy.Http.HttpMethod StatusCallbackMethod { get; private set; }

        ///<summary> The maximum time, in seconds, that the MediaProcessor can run before automatically ends. The default value is 300 seconds, and the maximum value is 90000 seconds. Once this maximum duration is reached, Kandy will end the MediaProcessor, regardless of whether media is still streaming. </summary> 
        [JsonProperty("max_duration")]
        public int? MaxDuration { get; private set; }



        private MediaProcessorResource()
        {

        }
    }
}
