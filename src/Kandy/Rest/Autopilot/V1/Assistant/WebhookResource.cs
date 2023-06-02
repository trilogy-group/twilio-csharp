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



namespace Kandy.Rest.Autopilot.V1.Assistant
{
    public class WebhookResource : Resource
    {



        private static Request BuildCreateRequest(CreateWebhookOptions options, IKandyRestClient client)
        {

            string path = "/v1/Assistants/{AssistantSid}/Webhooks";

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
        /// <param name="options"> Create Webhook parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Webhook </returns>
        public static WebhookResource Create(CreateWebhookOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> create </summary>
        /// <param name="options"> Create Webhook parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Webhook </returns>
        public static async System.Threading.Tasks.Task<WebhookResource> CreateAsync(CreateWebhookOptions options,
        IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> create </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.kandy.com/docs/autopilot/api/assistant) that is the parent of the new resource. </param>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the new resource. It can be used as an alternative to the `sid` in the URL path to address the resource. This value must be unique and 64 characters or less in length. </param>
        /// <param name="events"> The list of space-separated events that this Webhook will subscribe to. </param>
        /// <param name="webhookUrl"> The URL associated with this Webhook. </param>
        /// <param name="webhookMethod"> The method to be used when calling the webhook's URL. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Webhook </returns>
        public static WebhookResource Create(
                                          string pathAssistantSid,
                                          string uniqueName,
                                          string events,
                                          Uri webhookUrl,
                                          string webhookMethod = null,
                                          IKandyRestClient client = null)
        {
            var options = new CreateWebhookOptions(pathAssistantSid, uniqueName, events, webhookUrl) { WebhookMethod = webhookMethod };
            return Create(options, client);
        }

#if !NET35
        /// <summary> create </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.kandy.com/docs/autopilot/api/assistant) that is the parent of the new resource. </param>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the new resource. It can be used as an alternative to the `sid` in the URL path to address the resource. This value must be unique and 64 characters or less in length. </param>
        /// <param name="events"> The list of space-separated events that this Webhook will subscribe to. </param>
        /// <param name="webhookUrl"> The URL associated with this Webhook. </param>
        /// <param name="webhookMethod"> The method to be used when calling the webhook's URL. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Webhook </returns>
        public static async System.Threading.Tasks.Task<WebhookResource> CreateAsync(
                                                                                  string pathAssistantSid,
                                                                                  string uniqueName,
                                                                                  string events,
                                                                                  Uri webhookUrl,
                                                                                  string webhookMethod = null,
                                                                                  IKandyRestClient client = null)
        {
            var options = new CreateWebhookOptions(pathAssistantSid, uniqueName, events, webhookUrl) { WebhookMethod = webhookMethod };
            return await CreateAsync(options, client);
        }
#endif

        /// <summary> delete </summary>
        /// <param name="options"> Delete Webhook parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Webhook </returns>
        private static Request BuildDeleteRequest(DeleteWebhookOptions options, IKandyRestClient client)
        {

            string path = "/v1/Assistants/{AssistantSid}/Webhooks/{Sid}";

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
        /// <param name="options"> Delete Webhook parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Webhook </returns>
        public static bool Delete(DeleteWebhookOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

#if !NET35
        /// <summary> delete </summary>
        /// <param name="options"> Delete Webhook parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Webhook </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteWebhookOptions options,
                                                                          IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
#endif

        /// <summary> delete </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.kandy.com/docs/autopilot/api/assistant) that is the parent of the resources to delete. </param>
        /// <param name="pathSid"> The Kandy-provided string that uniquely identifies the Webhook resource to delete. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Webhook </returns>
        public static bool Delete(string pathAssistantSid, string pathSid, IKandyRestClient client = null)
        {
            var options = new DeleteWebhookOptions(pathAssistantSid, pathSid);
            return Delete(options, client);
        }

#if !NET35
        /// <summary> delete </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.kandy.com/docs/autopilot/api/assistant) that is the parent of the resources to delete. </param>
        /// <param name="pathSid"> The Kandy-provided string that uniquely identifies the Webhook resource to delete. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Webhook </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathAssistantSid, string pathSid, IKandyRestClient client = null)
        {
            var options = new DeleteWebhookOptions(pathAssistantSid, pathSid);
            return await DeleteAsync(options, client);
        }
#endif

        private static Request BuildFetchRequest(FetchWebhookOptions options, IKandyRestClient client)
        {

            string path = "/v1/Assistants/{AssistantSid}/Webhooks/{Sid}";

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
        /// <param name="options"> Fetch Webhook parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Webhook </returns>
        public static WebhookResource Fetch(FetchWebhookOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Webhook parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Webhook </returns>
        public static async System.Threading.Tasks.Task<WebhookResource> FetchAsync(FetchWebhookOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
#endif
        /// <summary> fetch </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.kandy.com/docs/autopilot/api/assistant) that is the parent of the resource to fetch. </param>
        /// <param name="pathSid"> The Kandy-provided string that uniquely identifies the Webhook resource to fetch. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Webhook </returns>
        public static WebhookResource Fetch(
                                         string pathAssistantSid,
                                         string pathSid,
                                         IKandyRestClient client = null)
        {
            var options = new FetchWebhookOptions(pathAssistantSid, pathSid) { };
            return Fetch(options, client);
        }

#if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.kandy.com/docs/autopilot/api/assistant) that is the parent of the resource to fetch. </param>
        /// <param name="pathSid"> The Kandy-provided string that uniquely identifies the Webhook resource to fetch. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Webhook </returns>
        public static async System.Threading.Tasks.Task<WebhookResource> FetchAsync(string pathAssistantSid, string pathSid, IKandyRestClient client = null)
        {
            var options = new FetchWebhookOptions(pathAssistantSid, pathSid) { };
            return await FetchAsync(options, client);
        }
#endif

        private static Request BuildReadRequest(ReadWebhookOptions options, IKandyRestClient client)
        {

            string path = "/v1/Assistants/{AssistantSid}/Webhooks";

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
        /// <param name="options"> Read Webhook parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Webhook </returns>
        public static ResourceSet<WebhookResource> Read(ReadWebhookOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<WebhookResource>.FromJson("webhooks", response.Content);
            return new ResourceSet<WebhookResource>(page, options, client);
        }

#if !NET35
        /// <summary> read </summary>
        /// <param name="options"> Read Webhook parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Webhook </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<WebhookResource>> ReadAsync(ReadWebhookOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<WebhookResource>.FromJson("webhooks", response.Content);
            return new ResourceSet<WebhookResource>(page, options, client);
        }
#endif
        /// <summary> read </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.kandy.com/docs/autopilot/api/assistant) that is the parent of the resources to read. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Webhook </returns>
        public static ResourceSet<WebhookResource> Read(
                                                     string pathAssistantSid,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     IKandyRestClient client = null)
        {
            var options = new ReadWebhookOptions(pathAssistantSid) { PageSize = pageSize, Limit = limit };
            return Read(options, client);
        }

#if !NET35
        /// <summary> read </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.kandy.com/docs/autopilot/api/assistant) that is the parent of the resources to read. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Webhook </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<WebhookResource>> ReadAsync(
                                                                                             string pathAssistantSid,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             IKandyRestClient client = null)
        {
            var options = new ReadWebhookOptions(pathAssistantSid) { PageSize = pageSize, Limit = limit };
            return await ReadAsync(options, client);
        }
#endif


        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The target page of records </returns>
        public static Page<WebhookResource> GetPage(string targetUrl, IKandyRestClient client)
        {
            client = client ?? KandyClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<WebhookResource>.FromJson("webhooks", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The next page of records </returns>
        public static Page<WebhookResource> NextPage(Page<WebhookResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<WebhookResource>.FromJson("webhooks", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The previous page of records </returns>
        public static Page<WebhookResource> PreviousPage(Page<WebhookResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<WebhookResource>.FromJson("webhooks", response.Content);
        }


        private static Request BuildUpdateRequest(UpdateWebhookOptions options, IKandyRestClient client)
        {

            string path = "/v1/Assistants/{AssistantSid}/Webhooks/{Sid}";

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
        /// <param name="options"> Update Webhook parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Webhook </returns>
        public static WebhookResource Update(UpdateWebhookOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> update </summary>
        /// <param name="options"> Update Webhook parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Webhook </returns>
#if !NET35
        public static async System.Threading.Tasks.Task<WebhookResource> UpdateAsync(UpdateWebhookOptions options,
                                                                                                          IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> update </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.kandy.com/docs/autopilot/api/assistant) that is the parent of the resource to update. </param>
        /// <param name="pathSid"> The Kandy-provided string that uniquely identifies the Webhook resource to update. </param>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the new resource. It can be used as an alternative to the `sid` in the URL path to address the resource. This value must be unique and 64 characters or less in length. </param>
        /// <param name="events"> The list of space-separated events that this Webhook will subscribe to. </param>
        /// <param name="webhookUrl"> The URL associated with this Webhook. </param>
        /// <param name="webhookMethod"> The method to be used when calling the webhook's URL. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Webhook </returns>
        public static WebhookResource Update(
                                          string pathAssistantSid,
                                          string pathSid,
                                          string uniqueName = null,
                                          string events = null,
                                          Uri webhookUrl = null,
                                          string webhookMethod = null,
                                          IKandyRestClient client = null)
        {
            var options = new UpdateWebhookOptions(pathAssistantSid, pathSid) { UniqueName = uniqueName, Events = events, WebhookUrl = webhookUrl, WebhookMethod = webhookMethod };
            return Update(options, client);
        }

#if !NET35
        /// <summary> update </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.kandy.com/docs/autopilot/api/assistant) that is the parent of the resource to update. </param>
        /// <param name="pathSid"> The Kandy-provided string that uniquely identifies the Webhook resource to update. </param>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the new resource. It can be used as an alternative to the `sid` in the URL path to address the resource. This value must be unique and 64 characters or less in length. </param>
        /// <param name="events"> The list of space-separated events that this Webhook will subscribe to. </param>
        /// <param name="webhookUrl"> The URL associated with this Webhook. </param>
        /// <param name="webhookMethod"> The method to be used when calling the webhook's URL. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Webhook </returns>
        public static async System.Threading.Tasks.Task<WebhookResource> UpdateAsync(
                                                                              string pathAssistantSid,
                                                                              string pathSid,
                                                                              string uniqueName = null,
                                                                              string events = null,
                                                                              Uri webhookUrl = null,
                                                                              string webhookMethod = null,
                                                                              IKandyRestClient client = null)
        {
            var options = new UpdateWebhookOptions(pathAssistantSid, pathSid) { UniqueName = uniqueName, Events = events, WebhookUrl = webhookUrl, WebhookMethod = webhookMethod };
            return await UpdateAsync(options, client);
        }
#endif

        /// <summary>
        /// Converts a JSON string into a WebhookResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> WebhookResource object represented by the provided JSON </returns>
        public static WebhookResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<WebhookResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> The absolute URL of the Webhook resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The SID of the [Account](https://www.kandy.com/docs/iam/api/account) that created the Webhook resource. </summary> 
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

        ///<summary> The unique string that we created to identify the Webhook resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> An application-defined string that uniquely identifies the resource. It can be used in place of the resource's `sid` in the URL to address the resource. </summary> 
        [JsonProperty("unique_name")]
        public string UniqueName { get; private set; }

        ///<summary> The list of space-separated events that this Webhook is subscribed to. </summary> 
        [JsonProperty("events")]
        public string Events { get; private set; }

        ///<summary> The URL associated with this Webhook. </summary> 
        [JsonProperty("webhook_url")]
        public Uri WebhookUrl { get; private set; }

        ///<summary> The method used when calling the webhook's URL. </summary> 
        [JsonProperty("webhook_method")]
        public string WebhookMethod { get; private set; }



        private WebhookResource()
        {

        }
    }
}
