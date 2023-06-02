/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Ip_messaging
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



namespace Kandy.Rest.IpMessaging.V2
{
    public class ServiceResource : Resource
    {



        private static Request BuildCreateRequest(CreateServiceOptions options, IKandyRestClient client)
        {

            string path = "/v2/Services";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.IpMessaging,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> create </summary>
        /// <param name="options"> Create Service parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Service </returns>
        public static ServiceResource Create(CreateServiceOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> create </summary>
        /// <param name="options"> Create Service parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Service </returns>
        public static async System.Threading.Tasks.Task<ServiceResource> CreateAsync(CreateServiceOptions options,
        IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> create </summary>
        /// <param name="friendlyName">  </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Service </returns>
        public static ServiceResource Create(
                                          string friendlyName,
                                          IKandyRestClient client = null)
        {
            var options = new CreateServiceOptions(friendlyName) { };
            return Create(options, client);
        }

#if !NET35
        /// <summary> create </summary>
        /// <param name="friendlyName">  </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Service </returns>
        public static async System.Threading.Tasks.Task<ServiceResource> CreateAsync(
                                                                                  string friendlyName,
                                                                                  IKandyRestClient client = null)
        {
            var options = new CreateServiceOptions(friendlyName) { };
            return await CreateAsync(options, client);
        }
#endif

        /// <summary> delete </summary>
        /// <param name="options"> Delete Service parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Service </returns>
        private static Request BuildDeleteRequest(DeleteServiceOptions options, IKandyRestClient client)
        {

            string path = "/v2/Services/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.IpMessaging,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> delete </summary>
        /// <param name="options"> Delete Service parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Service </returns>
        public static bool Delete(DeleteServiceOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

#if !NET35
        /// <summary> delete </summary>
        /// <param name="options"> Delete Service parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Service </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteServiceOptions options,
                                                                          IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
#endif

        /// <summary> delete </summary>
        /// <param name="pathSid">  </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Service </returns>
        public static bool Delete(string pathSid, IKandyRestClient client = null)
        {
            var options = new DeleteServiceOptions(pathSid);
            return Delete(options, client);
        }

#if !NET35
        /// <summary> delete </summary>
        /// <param name="pathSid">  </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Service </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, IKandyRestClient client = null)
        {
            var options = new DeleteServiceOptions(pathSid);
            return await DeleteAsync(options, client);
        }
#endif

        private static Request BuildFetchRequest(FetchServiceOptions options, IKandyRestClient client)
        {

            string path = "/v2/Services/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.IpMessaging,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Service parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Service </returns>
        public static ServiceResource Fetch(FetchServiceOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Service parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Service </returns>
        public static async System.Threading.Tasks.Task<ServiceResource> FetchAsync(FetchServiceOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
#endif
        /// <summary> fetch </summary>
        /// <param name="pathSid">  </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Service </returns>
        public static ServiceResource Fetch(
                                         string pathSid,
                                         IKandyRestClient client = null)
        {
            var options = new FetchServiceOptions(pathSid) { };
            return Fetch(options, client);
        }

#if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathSid">  </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Service </returns>
        public static async System.Threading.Tasks.Task<ServiceResource> FetchAsync(string pathSid, IKandyRestClient client = null)
        {
            var options = new FetchServiceOptions(pathSid) { };
            return await FetchAsync(options, client);
        }
#endif

        private static Request BuildReadRequest(ReadServiceOptions options, IKandyRestClient client)
        {

            string path = "/v2/Services";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.IpMessaging,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> read </summary>
        /// <param name="options"> Read Service parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Service </returns>
        public static ResourceSet<ServiceResource> Read(ReadServiceOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<ServiceResource>.FromJson("services", response.Content);
            return new ResourceSet<ServiceResource>(page, options, client);
        }

#if !NET35
        /// <summary> read </summary>
        /// <param name="options"> Read Service parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Service </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<ServiceResource>> ReadAsync(ReadServiceOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<ServiceResource>.FromJson("services", response.Content);
            return new ResourceSet<ServiceResource>(page, options, client);
        }
#endif
        /// <summary> read </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Service </returns>
        public static ResourceSet<ServiceResource> Read(
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     IKandyRestClient client = null)
        {
            var options = new ReadServiceOptions() { PageSize = pageSize, Limit = limit };
            return Read(options, client);
        }

#if !NET35
        /// <summary> read </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Service </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<ServiceResource>> ReadAsync(
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             IKandyRestClient client = null)
        {
            var options = new ReadServiceOptions() { PageSize = pageSize, Limit = limit };
            return await ReadAsync(options, client);
        }
#endif


        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The target page of records </returns>
        public static Page<ServiceResource> GetPage(string targetUrl, IKandyRestClient client)
        {
            client = client ?? KandyClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<ServiceResource>.FromJson("services", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The next page of records </returns>
        public static Page<ServiceResource> NextPage(Page<ServiceResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<ServiceResource>.FromJson("services", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The previous page of records </returns>
        public static Page<ServiceResource> PreviousPage(Page<ServiceResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<ServiceResource>.FromJson("services", response.Content);
        }


        private static Request BuildUpdateRequest(UpdateServiceOptions options, IKandyRestClient client)
        {

            string path = "/v2/Services/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.IpMessaging,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> update </summary>
        /// <param name="options"> Update Service parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Service </returns>
        public static ServiceResource Update(UpdateServiceOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> update </summary>
        /// <param name="options"> Update Service parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Service </returns>
#if !NET35
        public static async System.Threading.Tasks.Task<ServiceResource> UpdateAsync(UpdateServiceOptions options,
                                                                                                          IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> update </summary>
        /// <param name="pathSid">  </param>
        /// <param name="friendlyName">  </param>
        /// <param name="defaultServiceRoleSid">  </param>
        /// <param name="defaultChannelRoleSid">  </param>
        /// <param name="defaultChannelCreatorRoleSid">  </param>
        /// <param name="readStatusEnabled">  </param>
        /// <param name="reachabilityEnabled">  </param>
        /// <param name="typingIndicatorTimeout">  </param>
        /// <param name="consumptionReportInterval">  </param>
        /// <param name="notificationsNewMessageEnabled">  </param>
        /// <param name="notificationsNewMessageTemplate">  </param>
        /// <param name="notificationsNewMessageSound">  </param>
        /// <param name="notificationsNewMessageBadgeCountEnabled">  </param>
        /// <param name="notificationsAddedToChannelEnabled">  </param>
        /// <param name="notificationsAddedToChannelTemplate">  </param>
        /// <param name="notificationsAddedToChannelSound">  </param>
        /// <param name="notificationsRemovedFromChannelEnabled">  </param>
        /// <param name="notificationsRemovedFromChannelTemplate">  </param>
        /// <param name="notificationsRemovedFromChannelSound">  </param>
        /// <param name="notificationsInvitedToChannelEnabled">  </param>
        /// <param name="notificationsInvitedToChannelTemplate">  </param>
        /// <param name="notificationsInvitedToChannelSound">  </param>
        /// <param name="preWebhookUrl">  </param>
        /// <param name="postWebhookUrl">  </param>
        /// <param name="webhookMethod">  </param>
        /// <param name="webhookFilters">  </param>
        /// <param name="limitsChannelMembers">  </param>
        /// <param name="limitsUserChannels">  </param>
        /// <param name="mediaCompatibilityMessage">  </param>
        /// <param name="preWebhookRetryCount">  </param>
        /// <param name="postWebhookRetryCount">  </param>
        /// <param name="notificationsLogEnabled">  </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Service </returns>
        public static ServiceResource Update(
                                          string pathSid,
                                          string friendlyName = null,
                                          string defaultServiceRoleSid = null,
                                          string defaultChannelRoleSid = null,
                                          string defaultChannelCreatorRoleSid = null,
                                          bool? readStatusEnabled = null,
                                          bool? reachabilityEnabled = null,
                                          int? typingIndicatorTimeout = null,
                                          int? consumptionReportInterval = null,
                                          bool? notificationsNewMessageEnabled = null,
                                          string notificationsNewMessageTemplate = null,
                                          string notificationsNewMessageSound = null,
                                          bool? notificationsNewMessageBadgeCountEnabled = null,
                                          bool? notificationsAddedToChannelEnabled = null,
                                          string notificationsAddedToChannelTemplate = null,
                                          string notificationsAddedToChannelSound = null,
                                          bool? notificationsRemovedFromChannelEnabled = null,
                                          string notificationsRemovedFromChannelTemplate = null,
                                          string notificationsRemovedFromChannelSound = null,
                                          bool? notificationsInvitedToChannelEnabled = null,
                                          string notificationsInvitedToChannelTemplate = null,
                                          string notificationsInvitedToChannelSound = null,
                                          Uri preWebhookUrl = null,
                                          Uri postWebhookUrl = null,
                                          Kandy.Http.HttpMethod webhookMethod = null,
                                          List<string> webhookFilters = null,
                                          int? limitsChannelMembers = null,
                                          int? limitsUserChannels = null,
                                          string mediaCompatibilityMessage = null,
                                          int? preWebhookRetryCount = null,
                                          int? postWebhookRetryCount = null,
                                          bool? notificationsLogEnabled = null,
                                          IKandyRestClient client = null)
        {
            var options = new UpdateServiceOptions(pathSid) { FriendlyName = friendlyName, DefaultServiceRoleSid = defaultServiceRoleSid, DefaultChannelRoleSid = defaultChannelRoleSid, DefaultChannelCreatorRoleSid = defaultChannelCreatorRoleSid, ReadStatusEnabled = readStatusEnabled, ReachabilityEnabled = reachabilityEnabled, TypingIndicatorTimeout = typingIndicatorTimeout, ConsumptionReportInterval = consumptionReportInterval, NotificationsNewMessageEnabled = notificationsNewMessageEnabled, NotificationsNewMessageTemplate = notificationsNewMessageTemplate, NotificationsNewMessageSound = notificationsNewMessageSound, NotificationsNewMessageBadgeCountEnabled = notificationsNewMessageBadgeCountEnabled, NotificationsAddedToChannelEnabled = notificationsAddedToChannelEnabled, NotificationsAddedToChannelTemplate = notificationsAddedToChannelTemplate, NotificationsAddedToChannelSound = notificationsAddedToChannelSound, NotificationsRemovedFromChannelEnabled = notificationsRemovedFromChannelEnabled, NotificationsRemovedFromChannelTemplate = notificationsRemovedFromChannelTemplate, NotificationsRemovedFromChannelSound = notificationsRemovedFromChannelSound, NotificationsInvitedToChannelEnabled = notificationsInvitedToChannelEnabled, NotificationsInvitedToChannelTemplate = notificationsInvitedToChannelTemplate, NotificationsInvitedToChannelSound = notificationsInvitedToChannelSound, PreWebhookUrl = preWebhookUrl, PostWebhookUrl = postWebhookUrl, WebhookMethod = webhookMethod, WebhookFilters = webhookFilters, LimitsChannelMembers = limitsChannelMembers, LimitsUserChannels = limitsUserChannels, MediaCompatibilityMessage = mediaCompatibilityMessage, PreWebhookRetryCount = preWebhookRetryCount, PostWebhookRetryCount = postWebhookRetryCount, NotificationsLogEnabled = notificationsLogEnabled };
            return Update(options, client);
        }

#if !NET35
        /// <summary> update </summary>
        /// <param name="pathSid">  </param>
        /// <param name="friendlyName">  </param>
        /// <param name="defaultServiceRoleSid">  </param>
        /// <param name="defaultChannelRoleSid">  </param>
        /// <param name="defaultChannelCreatorRoleSid">  </param>
        /// <param name="readStatusEnabled">  </param>
        /// <param name="reachabilityEnabled">  </param>
        /// <param name="typingIndicatorTimeout">  </param>
        /// <param name="consumptionReportInterval">  </param>
        /// <param name="notificationsNewMessageEnabled">  </param>
        /// <param name="notificationsNewMessageTemplate">  </param>
        /// <param name="notificationsNewMessageSound">  </param>
        /// <param name="notificationsNewMessageBadgeCountEnabled">  </param>
        /// <param name="notificationsAddedToChannelEnabled">  </param>
        /// <param name="notificationsAddedToChannelTemplate">  </param>
        /// <param name="notificationsAddedToChannelSound">  </param>
        /// <param name="notificationsRemovedFromChannelEnabled">  </param>
        /// <param name="notificationsRemovedFromChannelTemplate">  </param>
        /// <param name="notificationsRemovedFromChannelSound">  </param>
        /// <param name="notificationsInvitedToChannelEnabled">  </param>
        /// <param name="notificationsInvitedToChannelTemplate">  </param>
        /// <param name="notificationsInvitedToChannelSound">  </param>
        /// <param name="preWebhookUrl">  </param>
        /// <param name="postWebhookUrl">  </param>
        /// <param name="webhookMethod">  </param>
        /// <param name="webhookFilters">  </param>
        /// <param name="limitsChannelMembers">  </param>
        /// <param name="limitsUserChannels">  </param>
        /// <param name="mediaCompatibilityMessage">  </param>
        /// <param name="preWebhookRetryCount">  </param>
        /// <param name="postWebhookRetryCount">  </param>
        /// <param name="notificationsLogEnabled">  </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Service </returns>
        public static async System.Threading.Tasks.Task<ServiceResource> UpdateAsync(
                                                                              string pathSid,
                                                                              string friendlyName = null,
                                                                              string defaultServiceRoleSid = null,
                                                                              string defaultChannelRoleSid = null,
                                                                              string defaultChannelCreatorRoleSid = null,
                                                                              bool? readStatusEnabled = null,
                                                                              bool? reachabilityEnabled = null,
                                                                              int? typingIndicatorTimeout = null,
                                                                              int? consumptionReportInterval = null,
                                                                              bool? notificationsNewMessageEnabled = null,
                                                                              string notificationsNewMessageTemplate = null,
                                                                              string notificationsNewMessageSound = null,
                                                                              bool? notificationsNewMessageBadgeCountEnabled = null,
                                                                              bool? notificationsAddedToChannelEnabled = null,
                                                                              string notificationsAddedToChannelTemplate = null,
                                                                              string notificationsAddedToChannelSound = null,
                                                                              bool? notificationsRemovedFromChannelEnabled = null,
                                                                              string notificationsRemovedFromChannelTemplate = null,
                                                                              string notificationsRemovedFromChannelSound = null,
                                                                              bool? notificationsInvitedToChannelEnabled = null,
                                                                              string notificationsInvitedToChannelTemplate = null,
                                                                              string notificationsInvitedToChannelSound = null,
                                                                              Uri preWebhookUrl = null,
                                                                              Uri postWebhookUrl = null,
                                                                              Kandy.Http.HttpMethod webhookMethod = null,
                                                                              List<string> webhookFilters = null,
                                                                              int? limitsChannelMembers = null,
                                                                              int? limitsUserChannels = null,
                                                                              string mediaCompatibilityMessage = null,
                                                                              int? preWebhookRetryCount = null,
                                                                              int? postWebhookRetryCount = null,
                                                                              bool? notificationsLogEnabled = null,
                                                                              IKandyRestClient client = null)
        {
            var options = new UpdateServiceOptions(pathSid) { FriendlyName = friendlyName, DefaultServiceRoleSid = defaultServiceRoleSid, DefaultChannelRoleSid = defaultChannelRoleSid, DefaultChannelCreatorRoleSid = defaultChannelCreatorRoleSid, ReadStatusEnabled = readStatusEnabled, ReachabilityEnabled = reachabilityEnabled, TypingIndicatorTimeout = typingIndicatorTimeout, ConsumptionReportInterval = consumptionReportInterval, NotificationsNewMessageEnabled = notificationsNewMessageEnabled, NotificationsNewMessageTemplate = notificationsNewMessageTemplate, NotificationsNewMessageSound = notificationsNewMessageSound, NotificationsNewMessageBadgeCountEnabled = notificationsNewMessageBadgeCountEnabled, NotificationsAddedToChannelEnabled = notificationsAddedToChannelEnabled, NotificationsAddedToChannelTemplate = notificationsAddedToChannelTemplate, NotificationsAddedToChannelSound = notificationsAddedToChannelSound, NotificationsRemovedFromChannelEnabled = notificationsRemovedFromChannelEnabled, NotificationsRemovedFromChannelTemplate = notificationsRemovedFromChannelTemplate, NotificationsRemovedFromChannelSound = notificationsRemovedFromChannelSound, NotificationsInvitedToChannelEnabled = notificationsInvitedToChannelEnabled, NotificationsInvitedToChannelTemplate = notificationsInvitedToChannelTemplate, NotificationsInvitedToChannelSound = notificationsInvitedToChannelSound, PreWebhookUrl = preWebhookUrl, PostWebhookUrl = postWebhookUrl, WebhookMethod = webhookMethod, WebhookFilters = webhookFilters, LimitsChannelMembers = limitsChannelMembers, LimitsUserChannels = limitsUserChannels, MediaCompatibilityMessage = mediaCompatibilityMessage, PreWebhookRetryCount = preWebhookRetryCount, PostWebhookRetryCount = postWebhookRetryCount, NotificationsLogEnabled = notificationsLogEnabled };
            return await UpdateAsync(options, client);
        }
#endif

        /// <summary>
        /// Converts a JSON string into a ServiceResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ServiceResource object represented by the provided JSON </returns>
        public static ServiceResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<ServiceResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> The sid </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The account_sid </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The friendly_name </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> The date_created </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date_updated </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The default_service_role_sid </summary> 
        [JsonProperty("default_service_role_sid")]
        public string DefaultServiceRoleSid { get; private set; }

        ///<summary> The default_channel_role_sid </summary> 
        [JsonProperty("default_channel_role_sid")]
        public string DefaultChannelRoleSid { get; private set; }

        ///<summary> The default_channel_creator_role_sid </summary> 
        [JsonProperty("default_channel_creator_role_sid")]
        public string DefaultChannelCreatorRoleSid { get; private set; }

        ///<summary> The read_status_enabled </summary> 
        [JsonProperty("read_status_enabled")]
        public bool? ReadStatusEnabled { get; private set; }

        ///<summary> The reachability_enabled </summary> 
        [JsonProperty("reachability_enabled")]
        public bool? ReachabilityEnabled { get; private set; }

        ///<summary> The typing_indicator_timeout </summary> 
        [JsonProperty("typing_indicator_timeout")]
        public int? TypingIndicatorTimeout { get; private set; }

        ///<summary> The consumption_report_interval </summary> 
        [JsonProperty("consumption_report_interval")]
        public int? ConsumptionReportInterval { get; private set; }

        ///<summary> The limits </summary> 
        [JsonProperty("limits")]
        public object Limits { get; private set; }

        ///<summary> The pre_webhook_url </summary> 
        [JsonProperty("pre_webhook_url")]
        public string PreWebhookUrl { get; private set; }

        ///<summary> The post_webhook_url </summary> 
        [JsonProperty("post_webhook_url")]
        public string PostWebhookUrl { get; private set; }

        ///<summary> The webhook_method </summary> 
        [JsonProperty("webhook_method")]
        public string WebhookMethod { get; private set; }

        ///<summary> The webhook_filters </summary> 
        [JsonProperty("webhook_filters")]
        public List<string> WebhookFilters { get; private set; }

        ///<summary> The pre_webhook_retry_count </summary> 
        [JsonProperty("pre_webhook_retry_count")]
        public int? PreWebhookRetryCount { get; private set; }

        ///<summary> The post_webhook_retry_count </summary> 
        [JsonProperty("post_webhook_retry_count")]
        public int? PostWebhookRetryCount { get; private set; }

        ///<summary> The notifications </summary> 
        [JsonProperty("notifications")]
        public object Notifications { get; private set; }

        ///<summary> The media </summary> 
        [JsonProperty("media")]
        public object Media { get; private set; }

        ///<summary> The url </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The links </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }



        private ServiceResource()
        {

        }
    }
}
