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



namespace Kandy.Rest.Preview.Sync
{
    public class ServiceResource : Resource
    {



        private static Request BuildCreateRequest(CreateServiceOptions options, IKandyRestClient client)
        {

            string path = "/Sync/Services";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Preview,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> create </summary>
        /// <param name="options"> Create Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns>
        public static ServiceResource Create(CreateServiceOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> create </summary>
        /// <param name="options"> Create Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns>
        public static async System.Threading.Tasks.Task<ServiceResource> CreateAsync(CreateServiceOptions options,
        IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> create </summary>
        /// <param name="friendlyName">  </param>
        /// <param name="webhookUrl">  </param>
        /// <param name="reachabilityWebhooksEnabled">  </param>
        /// <param name="aclEnabled">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns>
        public static ServiceResource Create(
                                          string friendlyName = null,
                                          Uri webhookUrl = null,
                                          bool? reachabilityWebhooksEnabled = null,
                                          bool? aclEnabled = null,
                                          IKandyRestClient client = null)
        {
            var options = new CreateServiceOptions() { FriendlyName = friendlyName, WebhookUrl = webhookUrl, ReachabilityWebhooksEnabled = reachabilityWebhooksEnabled, AclEnabled = aclEnabled };
            return Create(options, client);
        }

#if !NET35
        /// <summary> create </summary>
        /// <param name="friendlyName">  </param>
        /// <param name="webhookUrl">  </param>
        /// <param name="reachabilityWebhooksEnabled">  </param>
        /// <param name="aclEnabled">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns>
        public static async System.Threading.Tasks.Task<ServiceResource> CreateAsync(
                                                                                  string friendlyName = null,
                                                                                  Uri webhookUrl = null,
                                                                                  bool? reachabilityWebhooksEnabled = null,
                                                                                  bool? aclEnabled = null,
                                                                                  IKandyRestClient client = null)
        {
            var options = new CreateServiceOptions() { FriendlyName = friendlyName, WebhookUrl = webhookUrl, ReachabilityWebhooksEnabled = reachabilityWebhooksEnabled, AclEnabled = aclEnabled };
            return await CreateAsync(options, client);
        }
#endif

        /// <summary> delete </summary>
        /// <param name="options"> Delete Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns>
        private static Request BuildDeleteRequest(DeleteServiceOptions options, IKandyRestClient client)
        {

            string path = "/Sync/Services/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Preview,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> delete </summary>
        /// <param name="options"> Delete Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns>
        public static bool Delete(DeleteServiceOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

#if !NET35
        /// <summary> delete </summary>
        /// <param name="options"> Delete Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteServiceOptions options,
                                                                          IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
#endif

        /// <summary> delete </summary>
        /// <param name="pathSid">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns>
        public static bool Delete(string pathSid, IKandyRestClient client = null)
        {
            var options = new DeleteServiceOptions(pathSid);
            return Delete(options, client);
        }

#if !NET35
        /// <summary> delete </summary>
        /// <param name="pathSid">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, IKandyRestClient client = null)
        {
            var options = new DeleteServiceOptions(pathSid);
            return await DeleteAsync(options, client);
        }
#endif

        private static Request BuildFetchRequest(FetchServiceOptions options, IKandyRestClient client)
        {

            string path = "/Sync/Services/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns>
        public static ServiceResource Fetch(FetchServiceOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns>
        public static async System.Threading.Tasks.Task<ServiceResource> FetchAsync(FetchServiceOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
#endif
        /// <summary> fetch </summary>
        /// <param name="pathSid">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
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
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns>
        public static async System.Threading.Tasks.Task<ServiceResource> FetchAsync(string pathSid, IKandyRestClient client = null)
        {
            var options = new FetchServiceOptions(pathSid) { };
            return await FetchAsync(options, client);
        }
#endif

        private static Request BuildReadRequest(ReadServiceOptions options, IKandyRestClient client)
        {

            string path = "/Sync/Services";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> read </summary>
        /// <param name="options"> Read Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns>
        public static ResourceSet<ServiceResource> Read(ReadServiceOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<ServiceResource>.FromJson("services", response.Content);
            return new ResourceSet<ServiceResource>(page, options, client);
        }

#if !NET35
        /// <summary> read </summary>
        /// <param name="options"> Read Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<ServiceResource>> ReadAsync(ReadServiceOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<ServiceResource>.FromJson("services", response.Content);
            return new ResourceSet<ServiceResource>(page, options, client);
        }
#endif
        /// <summary> read </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
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
        /// <param name="client"> Client to make requests to Twilio </param>
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
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<ServiceResource> GetPage(string targetUrl, IKandyRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<ServiceResource>.FromJson("services", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
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
        /// <param name="client"> Client to make requests to Twilio </param>
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

            string path = "/Sync/Services/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Preview,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> update </summary>
        /// <param name="options"> Update Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns>
        public static ServiceResource Update(UpdateServiceOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> update </summary>
        /// <param name="options"> Update Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns>
#if !NET35
        public static async System.Threading.Tasks.Task<ServiceResource> UpdateAsync(UpdateServiceOptions options,
                                                                                                          IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> update </summary>
        /// <param name="pathSid">  </param>
        /// <param name="webhookUrl">  </param>
        /// <param name="friendlyName">  </param>
        /// <param name="reachabilityWebhooksEnabled">  </param>
        /// <param name="aclEnabled">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns>
        public static ServiceResource Update(
                                          string pathSid,
                                          Uri webhookUrl = null,
                                          string friendlyName = null,
                                          bool? reachabilityWebhooksEnabled = null,
                                          bool? aclEnabled = null,
                                          IKandyRestClient client = null)
        {
            var options = new UpdateServiceOptions(pathSid) { WebhookUrl = webhookUrl, FriendlyName = friendlyName, ReachabilityWebhooksEnabled = reachabilityWebhooksEnabled, AclEnabled = aclEnabled };
            return Update(options, client);
        }

#if !NET35
        /// <summary> update </summary>
        /// <param name="pathSid">  </param>
        /// <param name="webhookUrl">  </param>
        /// <param name="friendlyName">  </param>
        /// <param name="reachabilityWebhooksEnabled">  </param>
        /// <param name="aclEnabled">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns>
        public static async System.Threading.Tasks.Task<ServiceResource> UpdateAsync(
                                                                              string pathSid,
                                                                              Uri webhookUrl = null,
                                                                              string friendlyName = null,
                                                                              bool? reachabilityWebhooksEnabled = null,
                                                                              bool? aclEnabled = null,
                                                                              IKandyRestClient client = null)
        {
            var options = new UpdateServiceOptions(pathSid) { WebhookUrl = webhookUrl, FriendlyName = friendlyName, ReachabilityWebhooksEnabled = reachabilityWebhooksEnabled, AclEnabled = aclEnabled };
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

        ///<summary> The url </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The webhook_url </summary> 
        [JsonProperty("webhook_url")]
        public Uri WebhookUrl { get; private set; }

        ///<summary> The reachability_webhooks_enabled </summary> 
        [JsonProperty("reachability_webhooks_enabled")]
        public bool? ReachabilityWebhooksEnabled { get; private set; }

        ///<summary> The acl_enabled </summary> 
        [JsonProperty("acl_enabled")]
        public bool? AclEnabled { get; private set; }

        ///<summary> The links </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }



        private ServiceResource()
        {

        }
    }
}
