/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Chat
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
using Twilio.Types;


namespace Kandy.Rest.Chat.V2.Service.Channel
{
    public class WebhookResource : Resource
    {
    
        public sealed class MethodEnum : StringEnum
        {
            private MethodEnum(string value) : base(value) {}
            public MethodEnum() {}
            public static implicit operator MethodEnum(string value)
            {
                return new MethodEnum(value);
            }
            public static readonly MethodEnum Get = new MethodEnum("GET");
            public static readonly MethodEnum Post = new MethodEnum("POST");

        }
        public sealed class TypeEnum : StringEnum
        {
            private TypeEnum(string value) : base(value) {}
            public TypeEnum() {}
            public static implicit operator TypeEnum(string value)
            {
                return new TypeEnum(value);
            }
            public static readonly TypeEnum Webhook = new TypeEnum("webhook");
            public static readonly TypeEnum Trigger = new TypeEnum("trigger");
            public static readonly TypeEnum Studio = new TypeEnum("studio");

        }

        
        private static Request BuildCreateRequest(CreateWebhookOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Services/{ServiceSid}/Channels/{ChannelSid}/Webhooks";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathChannelSid = options.PathChannelSid;
            path = path.Replace("{"+"ChannelSid"+"}", PathChannelSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Chat,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> create </summary>
        /// <param name="options"> Create Webhook parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Webhook </returns>
        public static WebhookResource Create(CreateWebhookOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="options"> Create Webhook parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Webhook </returns>
        public static async System.Threading.Tasks.Task<WebhookResource> CreateAsync(CreateWebhookOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> create </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) with the Channel to create the Webhook resource under. </param>
        /// <param name="pathChannelSid"> The SID of the [Channel](https://www.twilio.com/docs/chat/channels) the new Channel Webhook resource belongs to. This value can be the Channel resource's `sid` or `unique_name`. </param>
        /// <param name="type">  </param>
        /// <param name="configurationUrl"> The URL of the webhook to call using the `configuration.method`. </param>
        /// <param name="configurationMethod">  </param>
        /// <param name="configurationFilters"> The events that cause us to call the Channel Webhook. Used when `type` is `webhook`. This parameter takes only one event. To specify more than one event, repeat this parameter for each event. For the list of possible events, see [Webhook Event Triggers](https://www.twilio.com/docs/chat/webhook-events#webhook-event-trigger). </param>
        /// <param name="configurationTriggers"> A string that will cause us to call the webhook when it is present in a message body. This parameter takes only one trigger string. To specify more than one, repeat this parameter for each trigger string up to a total of 5 trigger strings. Used only when `type` = `trigger`. </param>
        /// <param name="configurationFlowSid"> The SID of the Studio [Flow](https://www.twilio.com/docs/studio/rest-api/flow) to call when an event in `configuration.filters` occurs. Used only when `type` is `studio`. </param>
        /// <param name="configurationRetryCount"> The number of times to retry the webhook if the first attempt fails. Can be an integer between 0 and 3, inclusive, and the default is 0. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Webhook </returns>
        public static WebhookResource Create(
                                          string pathServiceSid,
                                          string pathChannelSid,
                                          WebhookResource.TypeEnum type,
                                          string configurationUrl = null,
                                          WebhookResource.MethodEnum configurationMethod = null,
                                          List<string> configurationFilters = null,
                                          List<string> configurationTriggers = null,
                                          string configurationFlowSid = null,
                                          int? configurationRetryCount = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateWebhookOptions(pathServiceSid, pathChannelSid, type){  ConfigurationUrl = configurationUrl, ConfigurationMethod = configurationMethod, ConfigurationFilters = configurationFilters, ConfigurationTriggers = configurationTriggers, ConfigurationFlowSid = configurationFlowSid, ConfigurationRetryCount = configurationRetryCount };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) with the Channel to create the Webhook resource under. </param>
        /// <param name="pathChannelSid"> The SID of the [Channel](https://www.twilio.com/docs/chat/channels) the new Channel Webhook resource belongs to. This value can be the Channel resource's `sid` or `unique_name`. </param>
        /// <param name="type">  </param>
        /// <param name="configurationUrl"> The URL of the webhook to call using the `configuration.method`. </param>
        /// <param name="configurationMethod">  </param>
        /// <param name="configurationFilters"> The events that cause us to call the Channel Webhook. Used when `type` is `webhook`. This parameter takes only one event. To specify more than one event, repeat this parameter for each event. For the list of possible events, see [Webhook Event Triggers](https://www.twilio.com/docs/chat/webhook-events#webhook-event-trigger). </param>
        /// <param name="configurationTriggers"> A string that will cause us to call the webhook when it is present in a message body. This parameter takes only one trigger string. To specify more than one, repeat this parameter for each trigger string up to a total of 5 trigger strings. Used only when `type` = `trigger`. </param>
        /// <param name="configurationFlowSid"> The SID of the Studio [Flow](https://www.twilio.com/docs/studio/rest-api/flow) to call when an event in `configuration.filters` occurs. Used only when `type` is `studio`. </param>
        /// <param name="configurationRetryCount"> The number of times to retry the webhook if the first attempt fails. Can be an integer between 0 and 3, inclusive, and the default is 0. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Webhook </returns>
        public static async System.Threading.Tasks.Task<WebhookResource> CreateAsync(
                                                                                  string pathServiceSid,
                                                                                  string pathChannelSid,
                                                                                  WebhookResource.TypeEnum type,
                                                                                  string configurationUrl = null,
                                                                                  WebhookResource.MethodEnum configurationMethod = null,
                                                                                  List<string> configurationFilters = null,
                                                                                  List<string> configurationTriggers = null,
                                                                                  string configurationFlowSid = null,
                                                                                  int? configurationRetryCount = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateWebhookOptions(pathServiceSid, pathChannelSid, type){  ConfigurationUrl = configurationUrl, ConfigurationMethod = configurationMethod, ConfigurationFilters = configurationFilters, ConfigurationTriggers = configurationTriggers, ConfigurationFlowSid = configurationFlowSid, ConfigurationRetryCount = configurationRetryCount };
            return await CreateAsync(options, client);
        }
        #endif
        
        /// <summary> delete </summary>
        /// <param name="options"> Delete Webhook parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Webhook </returns>
        private static Request BuildDeleteRequest(DeleteWebhookOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Services/{ServiceSid}/Channels/{ChannelSid}/Webhooks/{Sid}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathChannelSid = options.PathChannelSid;
            path = path.Replace("{"+"ChannelSid"+"}", PathChannelSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Chat,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> delete </summary>
        /// <param name="options"> Delete Webhook parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Webhook </returns>
        public static bool Delete(DeleteWebhookOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> delete </summary>
        /// <param name="options"> Delete Webhook parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Webhook </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteWebhookOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> delete </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) with the Channel to delete the Webhook resource from. </param>
        /// <param name="pathChannelSid"> The SID of the [Channel](https://www.twilio.com/docs/chat/channels) the Channel Webhook resource to delete belongs to. This value can be the Channel resource's `sid` or `unique_name`. </param>
        /// <param name="pathSid"> The SID of the Channel Webhook resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Webhook </returns>
        public static bool Delete(string pathServiceSid, string pathChannelSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteWebhookOptions(pathServiceSid, pathChannelSid, pathSid)           ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> delete </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) with the Channel to delete the Webhook resource from. </param>
        /// <param name="pathChannelSid"> The SID of the [Channel](https://www.twilio.com/docs/chat/channels) the Channel Webhook resource to delete belongs to. This value can be the Channel resource's `sid` or `unique_name`. </param>
        /// <param name="pathSid"> The SID of the Channel Webhook resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Webhook </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathServiceSid, string pathChannelSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteWebhookOptions(pathServiceSid, pathChannelSid, pathSid) ;
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchWebhookOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Services/{ServiceSid}/Channels/{ChannelSid}/Webhooks/{Sid}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathChannelSid = options.PathChannelSid;
            path = path.Replace("{"+"ChannelSid"+"}", PathChannelSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Chat,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Webhook parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Webhook </returns>
        public static WebhookResource Fetch(FetchWebhookOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Webhook parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Webhook </returns>
        public static async System.Threading.Tasks.Task<WebhookResource> FetchAsync(FetchWebhookOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> fetch </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) with the Channel to fetch the Webhook resource from. </param>
        /// <param name="pathChannelSid"> The SID of the [Channel](https://www.twilio.com/docs/chat/channels) the Channel Webhook resource to fetch belongs to. This value can be the Channel resource's `sid` or `unique_name`. </param>
        /// <param name="pathSid"> The SID of the Channel Webhook resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Webhook </returns>
        public static WebhookResource Fetch(
                                         string pathServiceSid, 
                                         string pathChannelSid, 
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchWebhookOptions(pathServiceSid, pathChannelSid, pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) with the Channel to fetch the Webhook resource from. </param>
        /// <param name="pathChannelSid"> The SID of the [Channel](https://www.twilio.com/docs/chat/channels) the Channel Webhook resource to fetch belongs to. This value can be the Channel resource's `sid` or `unique_name`. </param>
        /// <param name="pathSid"> The SID of the Channel Webhook resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Webhook </returns>
        public static async System.Threading.Tasks.Task<WebhookResource> FetchAsync(string pathServiceSid, string pathChannelSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchWebhookOptions(pathServiceSid, pathChannelSid, pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadWebhookOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Services/{ServiceSid}/Channels/{ChannelSid}/Webhooks";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathChannelSid = options.PathChannelSid;
            path = path.Replace("{"+"ChannelSid"+"}", PathChannelSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Chat,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> read </summary>
        /// <param name="options"> Read Webhook parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Webhook </returns>
        public static ResourceSet<WebhookResource> Read(ReadWebhookOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<WebhookResource>.FromJson("webhooks", response.Content);
            return new ResourceSet<WebhookResource>(page, options, client);
        }

        #if !NET35
        /// <summary> read </summary>
        /// <param name="options"> Read Webhook parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Webhook </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<WebhookResource>> ReadAsync(ReadWebhookOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<WebhookResource>.FromJson("webhooks", response.Content);
            return new ResourceSet<WebhookResource>(page, options, client);
        }
        #endif
        /// <summary> read </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) with the Channel to read the resources from. </param>
        /// <param name="pathChannelSid"> The SID of the [Channel](https://www.twilio.com/docs/chat/channels) the Channel Webhook resources to read belong to. This value can be the Channel resource's `sid` or `unique_name`. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Webhook </returns>
        public static ResourceSet<WebhookResource> Read(
                                                     string pathServiceSid,
                                                     string pathChannelSid,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadWebhookOptions(pathServiceSid, pathChannelSid){ PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> read </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) with the Channel to read the resources from. </param>
        /// <param name="pathChannelSid"> The SID of the [Channel](https://www.twilio.com/docs/chat/channels) the Channel Webhook resources to read belong to. This value can be the Channel resource's `sid` or `unique_name`. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Webhook </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<WebhookResource>> ReadAsync(
                                                                                             string pathServiceSid,
                                                                                             string pathChannelSid,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadWebhookOptions(pathServiceSid, pathChannelSid){ PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<WebhookResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<WebhookResource>.FromJson("webhooks", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<WebhookResource> NextPage(Page<WebhookResource> page, ITwilioRestClient client)
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
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<WebhookResource> PreviousPage(Page<WebhookResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<WebhookResource>.FromJson("webhooks", response.Content);
        }

        
        private static Request BuildUpdateRequest(UpdateWebhookOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Services/{ServiceSid}/Channels/{ChannelSid}/Webhooks/{Sid}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathChannelSid = options.PathChannelSid;
            path = path.Replace("{"+"ChannelSid"+"}", PathChannelSid);
            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Chat,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> update </summary>
        /// <param name="options"> Update Webhook parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Webhook </returns>
        public static WebhookResource Update(UpdateWebhookOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> update </summary>
        /// <param name="options"> Update Webhook parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Webhook </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<WebhookResource> UpdateAsync(UpdateWebhookOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> update </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) with the Channel that has the Webhook resource to update. </param>
        /// <param name="pathChannelSid"> The SID of the [Channel](https://www.twilio.com/docs/chat/channels) the Channel Webhook resource to update belongs to. This value can be the Channel resource's `sid` or `unique_name`. </param>
        /// <param name="pathSid"> The SID of the Channel Webhook resource to update. </param>
        /// <param name="configurationUrl"> The URL of the webhook to call using the `configuration.method`. </param>
        /// <param name="configurationMethod">  </param>
        /// <param name="configurationFilters"> The events that cause us to call the Channel Webhook. Used when `type` is `webhook`. This parameter takes only one event. To specify more than one event, repeat this parameter for each event. For the list of possible events, see [Webhook Event Triggers](https://www.twilio.com/docs/chat/webhook-events#webhook-event-trigger). </param>
        /// <param name="configurationTriggers"> A string that will cause us to call the webhook when it is present in a message body. This parameter takes only one trigger string. To specify more than one, repeat this parameter for each trigger string up to a total of 5 trigger strings. Used only when `type` = `trigger`. </param>
        /// <param name="configurationFlowSid"> The SID of the Studio [Flow](https://www.twilio.com/docs/studio/rest-api/flow) to call when an event in `configuration.filters` occurs. Used only when `type` = `studio`. </param>
        /// <param name="configurationRetryCount"> The number of times to retry the webhook if the first attempt fails. Can be an integer between 0 and 3, inclusive, and the default is 0. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Webhook </returns>
        public static WebhookResource Update(
                                          string pathServiceSid,
                                          string pathChannelSid,
                                          string pathSid,
                                          string configurationUrl = null,
                                          WebhookResource.MethodEnum configurationMethod = null,
                                          List<string> configurationFilters = null,
                                          List<string> configurationTriggers = null,
                                          string configurationFlowSid = null,
                                          int? configurationRetryCount = null,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateWebhookOptions(pathServiceSid, pathChannelSid, pathSid){ ConfigurationUrl = configurationUrl, ConfigurationMethod = configurationMethod, ConfigurationFilters = configurationFilters, ConfigurationTriggers = configurationTriggers, ConfigurationFlowSid = configurationFlowSid, ConfigurationRetryCount = configurationRetryCount };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> update </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) with the Channel that has the Webhook resource to update. </param>
        /// <param name="pathChannelSid"> The SID of the [Channel](https://www.twilio.com/docs/chat/channels) the Channel Webhook resource to update belongs to. This value can be the Channel resource's `sid` or `unique_name`. </param>
        /// <param name="pathSid"> The SID of the Channel Webhook resource to update. </param>
        /// <param name="configurationUrl"> The URL of the webhook to call using the `configuration.method`. </param>
        /// <param name="configurationMethod">  </param>
        /// <param name="configurationFilters"> The events that cause us to call the Channel Webhook. Used when `type` is `webhook`. This parameter takes only one event. To specify more than one event, repeat this parameter for each event. For the list of possible events, see [Webhook Event Triggers](https://www.twilio.com/docs/chat/webhook-events#webhook-event-trigger). </param>
        /// <param name="configurationTriggers"> A string that will cause us to call the webhook when it is present in a message body. This parameter takes only one trigger string. To specify more than one, repeat this parameter for each trigger string up to a total of 5 trigger strings. Used only when `type` = `trigger`. </param>
        /// <param name="configurationFlowSid"> The SID of the Studio [Flow](https://www.twilio.com/docs/studio/rest-api/flow) to call when an event in `configuration.filters` occurs. Used only when `type` = `studio`. </param>
        /// <param name="configurationRetryCount"> The number of times to retry the webhook if the first attempt fails. Can be an integer between 0 and 3, inclusive, and the default is 0. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Webhook </returns>
        public static async System.Threading.Tasks.Task<WebhookResource> UpdateAsync(
                                                                              string pathServiceSid,
                                                                              string pathChannelSid,
                                                                              string pathSid,
                                                                              string configurationUrl = null,
                                                                              WebhookResource.MethodEnum configurationMethod = null,
                                                                              List<string> configurationFilters = null,
                                                                              List<string> configurationTriggers = null,
                                                                              string configurationFlowSid = null,
                                                                              int? configurationRetryCount = null,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateWebhookOptions(pathServiceSid, pathChannelSid, pathSid){ ConfigurationUrl = configurationUrl, ConfigurationMethod = configurationMethod, ConfigurationFilters = configurationFilters, ConfigurationTriggers = configurationTriggers, ConfigurationFlowSid = configurationFlowSid, ConfigurationRetryCount = configurationRetryCount };
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

    
        ///<summary> The unique string that we created to identify the Channel Webhook resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Channel Webhook resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) the Channel Webhook resource is associated with. </summary> 
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }

        ///<summary> The SID of the [Channel](https://www.twilio.com/docs/chat/channels) the Channel Webhook resource belongs to. </summary> 
        [JsonProperty("channel_sid")]
        public string ChannelSid { get; private set; }

        ///<summary> The type of webhook. Can be: `webhook`, `studio`, or `trigger`. </summary> 
        [JsonProperty("type")]
        public string Type { get; private set; }

        ///<summary> The absolute URL of the Channel Webhook resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The JSON string that describes how the channel webhook is configured. The configuration object contains the `url`, `method`, `filters`, and `retry_count` values that are configured by the create and update actions. </summary> 
        [JsonProperty("configuration")]
        public object Configuration { get; private set; }

        ///<summary> The date and time in GMT when the resource was created specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT when the resource was last updated specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }



        private WebhookResource() {

        }
    }
}
