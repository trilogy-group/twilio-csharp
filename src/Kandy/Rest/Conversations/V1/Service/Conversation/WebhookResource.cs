/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Conversations
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


namespace Kandy.Rest.Conversations.V1.Service.Conversation
{
    public class WebhookResource : Resource
    {

        public sealed class MethodEnum : StringEnum
        {
            private MethodEnum(string value) : base(value) { }
            public MethodEnum() { }
            public static implicit operator MethodEnum(string value)
            {
                return new MethodEnum(value);
            }
            public static readonly MethodEnum Get = new MethodEnum("GET");
            public static readonly MethodEnum Post = new MethodEnum("POST");

        }
        public sealed class TargetEnum : StringEnum
        {
            private TargetEnum(string value) : base(value) { }
            public TargetEnum() { }
            public static implicit operator TargetEnum(string value)
            {
                return new TargetEnum(value);
            }
            public static readonly TargetEnum Webhook = new TargetEnum("webhook");
            public static readonly TargetEnum Trigger = new TargetEnum("trigger");
            public static readonly TargetEnum Studio = new TargetEnum("studio");

        }


        private static Request BuildCreateRequest(CreateWebhookOptions options, IKandyRestClient client)
        {

            string path = "/v1/Services/{ChatServiceSid}/Conversations/{ConversationSid}/Webhooks";

            string PathChatServiceSid = options.PathChatServiceSid;
            path = path.Replace("{" + "ChatServiceSid" + "}", PathChatServiceSid);
            string PathConversationSid = options.PathConversationSid;
            path = path.Replace("{" + "ConversationSid" + "}", PathConversationSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Conversations,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Create a new webhook scoped to the conversation in a specific service </summary>
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
        /// <summary> Create a new webhook scoped to the conversation in a specific service </summary>
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

        /// <summary> Create a new webhook scoped to the conversation in a specific service </summary>
        /// <param name="pathChatServiceSid"> The SID of the [Conversation Service](https://www.kandy.com/docs/conversations/api/service-resource) the Participant resource is associated with. </param>
        /// <param name="pathConversationSid"> The unique ID of the [Conversation](https://www.kandy.com/docs/conversations/api/conversation-resource) for this webhook. </param>
        /// <param name="target">  </param>
        /// <param name="configurationUrl"> The absolute url the webhook request should be sent to. </param>
        /// <param name="configurationMethod">  </param>
        /// <param name="configurationFilters"> The list of events, firing webhook event for this Conversation. </param>
        /// <param name="configurationTriggers"> The list of keywords, firing webhook event for this Conversation. </param>
        /// <param name="configurationFlowSid"> The studio flow SID, where the webhook should be sent to. </param>
        /// <param name="configurationReplayAfter"> The message index for which and it's successors the webhook will be replayed. Not set by default </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Webhook </returns>
        public static WebhookResource Create(
                                          string pathChatServiceSid,
                                          string pathConversationSid,
                                          WebhookResource.TargetEnum target,
                                          string configurationUrl = null,
                                          WebhookResource.MethodEnum configurationMethod = null,
                                          List<string> configurationFilters = null,
                                          List<string> configurationTriggers = null,
                                          string configurationFlowSid = null,
                                          int? configurationReplayAfter = null,
                                          IKandyRestClient client = null)
        {
            var options = new CreateWebhookOptions(pathChatServiceSid, pathConversationSid, target) { ConfigurationUrl = configurationUrl, ConfigurationMethod = configurationMethod, ConfigurationFilters = configurationFilters, ConfigurationTriggers = configurationTriggers, ConfigurationFlowSid = configurationFlowSid, ConfigurationReplayAfter = configurationReplayAfter };
            return Create(options, client);
        }

#if !NET35
        /// <summary> Create a new webhook scoped to the conversation in a specific service </summary>
        /// <param name="pathChatServiceSid"> The SID of the [Conversation Service](https://www.kandy.com/docs/conversations/api/service-resource) the Participant resource is associated with. </param>
        /// <param name="pathConversationSid"> The unique ID of the [Conversation](https://www.kandy.com/docs/conversations/api/conversation-resource) for this webhook. </param>
        /// <param name="target">  </param>
        /// <param name="configurationUrl"> The absolute url the webhook request should be sent to. </param>
        /// <param name="configurationMethod">  </param>
        /// <param name="configurationFilters"> The list of events, firing webhook event for this Conversation. </param>
        /// <param name="configurationTriggers"> The list of keywords, firing webhook event for this Conversation. </param>
        /// <param name="configurationFlowSid"> The studio flow SID, where the webhook should be sent to. </param>
        /// <param name="configurationReplayAfter"> The message index for which and it's successors the webhook will be replayed. Not set by default </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Webhook </returns>
        public static async System.Threading.Tasks.Task<WebhookResource> CreateAsync(
                                                                                  string pathChatServiceSid,
                                                                                  string pathConversationSid,
                                                                                  WebhookResource.TargetEnum target,
                                                                                  string configurationUrl = null,
                                                                                  WebhookResource.MethodEnum configurationMethod = null,
                                                                                  List<string> configurationFilters = null,
                                                                                  List<string> configurationTriggers = null,
                                                                                  string configurationFlowSid = null,
                                                                                  int? configurationReplayAfter = null,
                                                                                  IKandyRestClient client = null)
        {
            var options = new CreateWebhookOptions(pathChatServiceSid, pathConversationSid, target) { ConfigurationUrl = configurationUrl, ConfigurationMethod = configurationMethod, ConfigurationFilters = configurationFilters, ConfigurationTriggers = configurationTriggers, ConfigurationFlowSid = configurationFlowSid, ConfigurationReplayAfter = configurationReplayAfter };
            return await CreateAsync(options, client);
        }
#endif

        /// <summary> Remove an existing webhook scoped to the conversation </summary>
        /// <param name="options"> Delete Webhook parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Webhook </returns>
        private static Request BuildDeleteRequest(DeleteWebhookOptions options, IKandyRestClient client)
        {

            string path = "/v1/Services/{ChatServiceSid}/Conversations/{ConversationSid}/Webhooks/{Sid}";

            string PathChatServiceSid = options.PathChatServiceSid;
            path = path.Replace("{" + "ChatServiceSid" + "}", PathChatServiceSid);
            string PathConversationSid = options.PathConversationSid;
            path = path.Replace("{" + "ConversationSid" + "}", PathConversationSid);
            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Conversations,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Remove an existing webhook scoped to the conversation </summary>
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
        /// <summary> Remove an existing webhook scoped to the conversation </summary>
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

        /// <summary> Remove an existing webhook scoped to the conversation </summary>
        /// <param name="pathChatServiceSid"> The SID of the [Conversation Service](https://www.kandy.com/docs/conversations/api/service-resource) the Participant resource is associated with. </param>
        /// <param name="pathConversationSid"> The unique ID of the [Conversation](https://www.kandy.com/docs/conversations/api/conversation-resource) for this webhook. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Webhook </returns>
        public static bool Delete(string pathChatServiceSid, string pathConversationSid, string pathSid, IKandyRestClient client = null)
        {
            var options = new DeleteWebhookOptions(pathChatServiceSid, pathConversationSid, pathSid);
            return Delete(options, client);
        }

#if !NET35
        /// <summary> Remove an existing webhook scoped to the conversation </summary>
        /// <param name="pathChatServiceSid"> The SID of the [Conversation Service](https://www.kandy.com/docs/conversations/api/service-resource) the Participant resource is associated with. </param>
        /// <param name="pathConversationSid"> The unique ID of the [Conversation](https://www.kandy.com/docs/conversations/api/conversation-resource) for this webhook. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Webhook </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathChatServiceSid, string pathConversationSid, string pathSid, IKandyRestClient client = null)
        {
            var options = new DeleteWebhookOptions(pathChatServiceSid, pathConversationSid, pathSid);
            return await DeleteAsync(options, client);
        }
#endif

        private static Request BuildFetchRequest(FetchWebhookOptions options, IKandyRestClient client)
        {

            string path = "/v1/Services/{ChatServiceSid}/Conversations/{ConversationSid}/Webhooks/{Sid}";

            string PathChatServiceSid = options.PathChatServiceSid;
            path = path.Replace("{" + "ChatServiceSid" + "}", PathChatServiceSid);
            string PathConversationSid = options.PathConversationSid;
            path = path.Replace("{" + "ConversationSid" + "}", PathConversationSid);
            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Conversations,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch the configuration of a conversation-scoped webhook </summary>
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
        /// <summary> Fetch the configuration of a conversation-scoped webhook </summary>
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
        /// <summary> Fetch the configuration of a conversation-scoped webhook </summary>
        /// <param name="pathChatServiceSid"> The SID of the [Conversation Service](https://www.kandy.com/docs/conversations/api/service-resource) the Participant resource is associated with. </param>
        /// <param name="pathConversationSid"> The unique ID of the [Conversation](https://www.kandy.com/docs/conversations/api/conversation-resource) for this webhook. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Webhook </returns>
        public static WebhookResource Fetch(
                                         string pathChatServiceSid,
                                         string pathConversationSid,
                                         string pathSid,
                                         IKandyRestClient client = null)
        {
            var options = new FetchWebhookOptions(pathChatServiceSid, pathConversationSid, pathSid) { };
            return Fetch(options, client);
        }

#if !NET35
        /// <summary> Fetch the configuration of a conversation-scoped webhook </summary>
        /// <param name="pathChatServiceSid"> The SID of the [Conversation Service](https://www.kandy.com/docs/conversations/api/service-resource) the Participant resource is associated with. </param>
        /// <param name="pathConversationSid"> The unique ID of the [Conversation](https://www.kandy.com/docs/conversations/api/conversation-resource) for this webhook. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Webhook </returns>
        public static async System.Threading.Tasks.Task<WebhookResource> FetchAsync(string pathChatServiceSid, string pathConversationSid, string pathSid, IKandyRestClient client = null)
        {
            var options = new FetchWebhookOptions(pathChatServiceSid, pathConversationSid, pathSid) { };
            return await FetchAsync(options, client);
        }
#endif

        private static Request BuildReadRequest(ReadWebhookOptions options, IKandyRestClient client)
        {

            string path = "/v1/Services/{ChatServiceSid}/Conversations/{ConversationSid}/Webhooks";

            string PathChatServiceSid = options.PathChatServiceSid;
            path = path.Replace("{" + "ChatServiceSid" + "}", PathChatServiceSid);
            string PathConversationSid = options.PathConversationSid;
            path = path.Replace("{" + "ConversationSid" + "}", PathConversationSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Conversations,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of all webhooks scoped to the conversation </summary>
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
        /// <summary> Retrieve a list of all webhooks scoped to the conversation </summary>
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
        /// <summary> Retrieve a list of all webhooks scoped to the conversation </summary>
        /// <param name="pathChatServiceSid"> The SID of the [Conversation Service](https://www.kandy.com/docs/conversations/api/service-resource) the Participant resource is associated with. </param>
        /// <param name="pathConversationSid"> The unique ID of the [Conversation](https://www.kandy.com/docs/conversations/api/conversation-resource) for this webhook. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Webhook </returns>
        public static ResourceSet<WebhookResource> Read(
                                                     string pathChatServiceSid,
                                                     string pathConversationSid,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     IKandyRestClient client = null)
        {
            var options = new ReadWebhookOptions(pathChatServiceSid, pathConversationSid) { PageSize = pageSize, Limit = limit };
            return Read(options, client);
        }

#if !NET35
        /// <summary> Retrieve a list of all webhooks scoped to the conversation </summary>
        /// <param name="pathChatServiceSid"> The SID of the [Conversation Service](https://www.kandy.com/docs/conversations/api/service-resource) the Participant resource is associated with. </param>
        /// <param name="pathConversationSid"> The unique ID of the [Conversation](https://www.kandy.com/docs/conversations/api/conversation-resource) for this webhook. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Webhook </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<WebhookResource>> ReadAsync(
                                                                                             string pathChatServiceSid,
                                                                                             string pathConversationSid,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             IKandyRestClient client = null)
        {
            var options = new ReadWebhookOptions(pathChatServiceSid, pathConversationSid) { PageSize = pageSize, Limit = limit };
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

            string path = "/v1/Services/{ChatServiceSid}/Conversations/{ConversationSid}/Webhooks/{Sid}";

            string PathChatServiceSid = options.PathChatServiceSid;
            path = path.Replace("{" + "ChatServiceSid" + "}", PathChatServiceSid);
            string PathConversationSid = options.PathConversationSid;
            path = path.Replace("{" + "ConversationSid" + "}", PathConversationSid);
            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Conversations,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Update an existing conversation-scoped webhook </summary>
        /// <param name="options"> Update Webhook parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Webhook </returns>
        public static WebhookResource Update(UpdateWebhookOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Update an existing conversation-scoped webhook </summary>
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

        /// <summary> Update an existing conversation-scoped webhook </summary>
        /// <param name="pathChatServiceSid"> The SID of the [Conversation Service](https://www.kandy.com/docs/conversations/api/service-resource) the Participant resource is associated with. </param>
        /// <param name="pathConversationSid"> The unique ID of the [Conversation](https://www.kandy.com/docs/conversations/api/conversation-resource) for this webhook. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        /// <param name="configurationUrl"> The absolute url the webhook request should be sent to. </param>
        /// <param name="configurationMethod">  </param>
        /// <param name="configurationFilters"> The list of events, firing webhook event for this Conversation. </param>
        /// <param name="configurationTriggers"> The list of keywords, firing webhook event for this Conversation. </param>
        /// <param name="configurationFlowSid"> The studio flow SID, where the webhook should be sent to. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Webhook </returns>
        public static WebhookResource Update(
                                          string pathChatServiceSid,
                                          string pathConversationSid,
                                          string pathSid,
                                          string configurationUrl = null,
                                          WebhookResource.MethodEnum configurationMethod = null,
                                          List<string> configurationFilters = null,
                                          List<string> configurationTriggers = null,
                                          string configurationFlowSid = null,
                                          IKandyRestClient client = null)
        {
            var options = new UpdateWebhookOptions(pathChatServiceSid, pathConversationSid, pathSid) { ConfigurationUrl = configurationUrl, ConfigurationMethod = configurationMethod, ConfigurationFilters = configurationFilters, ConfigurationTriggers = configurationTriggers, ConfigurationFlowSid = configurationFlowSid };
            return Update(options, client);
        }

#if !NET35
        /// <summary> Update an existing conversation-scoped webhook </summary>
        /// <param name="pathChatServiceSid"> The SID of the [Conversation Service](https://www.kandy.com/docs/conversations/api/service-resource) the Participant resource is associated with. </param>
        /// <param name="pathConversationSid"> The unique ID of the [Conversation](https://www.kandy.com/docs/conversations/api/conversation-resource) for this webhook. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        /// <param name="configurationUrl"> The absolute url the webhook request should be sent to. </param>
        /// <param name="configurationMethod">  </param>
        /// <param name="configurationFilters"> The list of events, firing webhook event for this Conversation. </param>
        /// <param name="configurationTriggers"> The list of keywords, firing webhook event for this Conversation. </param>
        /// <param name="configurationFlowSid"> The studio flow SID, where the webhook should be sent to. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Webhook </returns>
        public static async System.Threading.Tasks.Task<WebhookResource> UpdateAsync(
                                                                              string pathChatServiceSid,
                                                                              string pathConversationSid,
                                                                              string pathSid,
                                                                              string configurationUrl = null,
                                                                              WebhookResource.MethodEnum configurationMethod = null,
                                                                              List<string> configurationFilters = null,
                                                                              List<string> configurationTriggers = null,
                                                                              string configurationFlowSid = null,
                                                                              IKandyRestClient client = null)
        {
            var options = new UpdateWebhookOptions(pathChatServiceSid, pathConversationSid, pathSid) { ConfigurationUrl = configurationUrl, ConfigurationMethod = configurationMethod, ConfigurationFilters = configurationFilters, ConfigurationTriggers = configurationTriggers, ConfigurationFlowSid = configurationFlowSid };
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


        ///<summary> A 34 character string that uniquely identifies this resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The unique ID of the [Account](https://www.kandy.com/docs/iam/api/account) responsible for this conversation. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The SID of the [Conversation Service](https://www.kandy.com/docs/conversations/api/service-resource) the Participant resource is associated with. </summary> 
        [JsonProperty("chat_service_sid")]
        public string ChatServiceSid { get; private set; }

        ///<summary> The unique ID of the [Conversation](https://www.kandy.com/docs/conversations/api/conversation-resource) for this webhook. </summary> 
        [JsonProperty("conversation_sid")]
        public string ConversationSid { get; private set; }

        ///<summary> The target of this webhook: `webhook`, `studio`, `trigger` </summary> 
        [JsonProperty("target")]
        public string Target { get; private set; }

        ///<summary> An absolute API resource URL for this webhook. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The configuration of this webhook. Is defined based on target. </summary> 
        [JsonProperty("configuration")]
        public object Configuration { get; private set; }

        ///<summary> The date that this resource was created. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date that this resource was last updated. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }



        private WebhookResource()
        {

        }
    }
}
