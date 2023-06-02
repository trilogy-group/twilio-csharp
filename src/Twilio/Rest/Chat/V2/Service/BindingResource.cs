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


namespace Kandy.Rest.Chat.V2.Service
{
    public class BindingResource : Resource
    {

        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class BindingTypeEnum : StringEnum
        {
            private BindingTypeEnum(string value) : base(value) { }
            public BindingTypeEnum() { }
            public static implicit operator BindingTypeEnum(string value)
            {
                return new BindingTypeEnum(value);
            }
            public static readonly BindingTypeEnum Gcm = new BindingTypeEnum("gcm");
            public static readonly BindingTypeEnum Apn = new BindingTypeEnum("apn");
            public static readonly BindingTypeEnum Fcm = new BindingTypeEnum("fcm");

        }


        /// <summary> delete </summary>
        /// <param name="options"> Delete Binding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Binding </returns>
        private static Request BuildDeleteRequest(DeleteBindingOptions options, IKandyRestClient client)
        {

            string path = "/v2/Services/{ServiceSid}/Bindings/{Sid}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{" + "ServiceSid" + "}", PathServiceSid);
            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Chat,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> delete </summary>
        /// <param name="options"> Delete Binding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Binding </returns>
        public static bool Delete(DeleteBindingOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

#if !NET35
        /// <summary> delete </summary>
        /// <param name="options"> Delete Binding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Binding </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteBindingOptions options,
                                                                          IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
#endif

        /// <summary> delete </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to delete the Binding resource from. </param>
        /// <param name="pathSid"> The SID of the Binding resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Binding </returns>
        public static bool Delete(string pathServiceSid, string pathSid, IKandyRestClient client = null)
        {
            var options = new DeleteBindingOptions(pathServiceSid, pathSid);
            return Delete(options, client);
        }

#if !NET35
        /// <summary> delete </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to delete the Binding resource from. </param>
        /// <param name="pathSid"> The SID of the Binding resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Binding </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathServiceSid, string pathSid, IKandyRestClient client = null)
        {
            var options = new DeleteBindingOptions(pathServiceSid, pathSid);
            return await DeleteAsync(options, client);
        }
#endif

        private static Request BuildFetchRequest(FetchBindingOptions options, IKandyRestClient client)
        {

            string path = "/v2/Services/{ServiceSid}/Bindings/{Sid}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{" + "ServiceSid" + "}", PathServiceSid);
            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Chat,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Binding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Binding </returns>
        public static BindingResource Fetch(FetchBindingOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Binding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Binding </returns>
        public static async System.Threading.Tasks.Task<BindingResource> FetchAsync(FetchBindingOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
#endif
        /// <summary> fetch </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to fetch the Binding resource from. </param>
        /// <param name="pathSid"> The SID of the Binding resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Binding </returns>
        public static BindingResource Fetch(
                                         string pathServiceSid,
                                         string pathSid,
                                         IKandyRestClient client = null)
        {
            var options = new FetchBindingOptions(pathServiceSid, pathSid) { };
            return Fetch(options, client);
        }

#if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to fetch the Binding resource from. </param>
        /// <param name="pathSid"> The SID of the Binding resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Binding </returns>
        public static async System.Threading.Tasks.Task<BindingResource> FetchAsync(string pathServiceSid, string pathSid, IKandyRestClient client = null)
        {
            var options = new FetchBindingOptions(pathServiceSid, pathSid) { };
            return await FetchAsync(options, client);
        }
#endif

        private static Request BuildReadRequest(ReadBindingOptions options, IKandyRestClient client)
        {

            string path = "/v2/Services/{ServiceSid}/Bindings";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{" + "ServiceSid" + "}", PathServiceSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Chat,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> read </summary>
        /// <param name="options"> Read Binding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Binding </returns>
        public static ResourceSet<BindingResource> Read(ReadBindingOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<BindingResource>.FromJson("bindings", response.Content);
            return new ResourceSet<BindingResource>(page, options, client);
        }

#if !NET35
        /// <summary> read </summary>
        /// <param name="options"> Read Binding parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Binding </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<BindingResource>> ReadAsync(ReadBindingOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<BindingResource>.FromJson("bindings", response.Content);
            return new ResourceSet<BindingResource>(page, options, client);
        }
#endif
        /// <summary> read </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to read the Binding resources from. </param>
        /// <param name="bindingType"> The push technology used by the Binding resources to read.  Can be: `apn`, `gcm`, or `fcm`.  See [push notification configuration](https://www.twilio.com/docs/chat/push-notification-configuration) for more info. </param>
        /// <param name="identity"> The [User](https://www.twilio.com/docs/chat/rest/user-resource)'s `identity` value of the resources to read. See [access tokens](https://www.twilio.com/docs/chat/create-tokens) for more details. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Binding </returns>
        public static ResourceSet<BindingResource> Read(
                                                     string pathServiceSid,
                                                     List<BindingResource.BindingTypeEnum> bindingType = null,
                                                     List<string> identity = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     IKandyRestClient client = null)
        {
            var options = new ReadBindingOptions(pathServiceSid) { BindingType = bindingType, Identity = identity, PageSize = pageSize, Limit = limit };
            return Read(options, client);
        }

#if !NET35
        /// <summary> read </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to read the Binding resources from. </param>
        /// <param name="bindingType"> The push technology used by the Binding resources to read.  Can be: `apn`, `gcm`, or `fcm`.  See [push notification configuration](https://www.twilio.com/docs/chat/push-notification-configuration) for more info. </param>
        /// <param name="identity"> The [User](https://www.twilio.com/docs/chat/rest/user-resource)'s `identity` value of the resources to read. See [access tokens](https://www.twilio.com/docs/chat/create-tokens) for more details. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Binding </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<BindingResource>> ReadAsync(
                                                                                             string pathServiceSid,
                                                                                             List<BindingResource.BindingTypeEnum> bindingType = null,
                                                                                             List<string> identity = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             IKandyRestClient client = null)
        {
            var options = new ReadBindingOptions(pathServiceSid) { BindingType = bindingType, Identity = identity, PageSize = pageSize, Limit = limit };
            return await ReadAsync(options, client);
        }
#endif


        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<BindingResource> GetPage(string targetUrl, IKandyRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<BindingResource>.FromJson("bindings", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<BindingResource> NextPage(Page<BindingResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<BindingResource>.FromJson("bindings", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<BindingResource> PreviousPage(Page<BindingResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<BindingResource>.FromJson("bindings", response.Content);
        }


        /// <summary>
        /// Converts a JSON string into a BindingResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> BindingResource object represented by the provided JSON </returns>
        public static BindingResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<BindingResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> The unique string that we created to identify the Binding resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Binding resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) the Binding resource is associated with. </summary> 
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }

        ///<summary> The date and time in GMT when the resource was created specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT when the resource was last updated specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The unique endpoint identifier for the Binding. The format of this value depends on the `binding_type`. </summary> 
        [JsonProperty("endpoint")]
        public string Endpoint { get; private set; }

        ///<summary> The application-defined string that uniquely identifies the resource's [User](https://www.twilio.com/docs/chat/rest/user-resource) within the [Service](https://www.twilio.com/docs/chat/rest/service-resource). See [access tokens](https://www.twilio.com/docs/chat/create-tokens) for more info. </summary> 
        [JsonProperty("identity")]
        public string Identity { get; private set; }

        ///<summary> The SID of the [Credential](https://www.twilio.com/docs/chat/rest/credential-resource) for the binding. See [push notification configuration](https://www.twilio.com/docs/chat/push-notification-configuration) for more info. </summary> 
        [JsonProperty("credential_sid")]
        public string CredentialSid { get; private set; }


        [JsonProperty("binding_type")]
        public BindingResource.BindingTypeEnum BindingType { get; private set; }

        ///<summary> The [Programmable Chat message types](https://www.twilio.com/docs/chat/push-notification-configuration#push-types) the binding is subscribed to. </summary> 
        [JsonProperty("message_types")]
        public List<string> MessageTypes { get; private set; }

        ///<summary> The absolute URL of the Binding resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The absolute URLs of the Binding's [User](https://www.twilio.com/docs/chat/rest/user-resource). </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }



        private BindingResource()
        {

        }
    }
}
