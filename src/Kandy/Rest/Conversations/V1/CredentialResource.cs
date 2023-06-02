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


namespace Kandy.Rest.Conversations.V1
{
    public class CredentialResource : Resource
    {

        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class PushTypeEnum : StringEnum
        {
            private PushTypeEnum(string value) : base(value) { }
            public PushTypeEnum() { }
            public static implicit operator PushTypeEnum(string value)
            {
                return new PushTypeEnum(value);
            }
            public static readonly PushTypeEnum Apn = new PushTypeEnum("apn");
            public static readonly PushTypeEnum Gcm = new PushTypeEnum("gcm");
            public static readonly PushTypeEnum Fcm = new PushTypeEnum("fcm");

        }


        private static Request BuildCreateRequest(CreateCredentialOptions options, IKandyRestClient client)
        {

            string path = "/v1/Credentials";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Conversations,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Add a new push notification credential to your account </summary>
        /// <param name="options"> Create Credential parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Credential </returns>
        public static CredentialResource Create(CreateCredentialOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> Add a new push notification credential to your account </summary>
        /// <param name="options"> Create Credential parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Credential </returns>
        public static async System.Threading.Tasks.Task<CredentialResource> CreateAsync(CreateCredentialOptions options,
        IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> Add a new push notification credential to your account </summary>
        /// <param name="type">  </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the new resource. It can be up to 64 characters long. </param>
        /// <param name="certificate"> [APN only] The URL encoded representation of the certificate. For example,  `- - - - -BEGIN CERTIFICATE- - - - - MIIFnTCCBIWgAwIBAgIIAjy9H849+E8wDQYJKoZIhvcNAQEF.....A== - - - - -END CERTIFICATE- - - - -`. </param>
        /// <param name="privateKey"> [APN only] The URL encoded representation of the private key. For example, `- - - - -BEGIN RSA PRIVATE KEY- - - - - MIIEpQIBAAKCAQEAuyf/lNrH9ck8DmNyo3fG... - - - - -END RSA PRIVATE KEY- - - - -`. </param>
        /// <param name="sandbox"> [APN only] Whether to send the credential to sandbox APNs. Can be `true` to send to sandbox APNs or `false` to send to production. </param>
        /// <param name="apiKey"> [GCM only] The API key for the project that was obtained from the Google Developer console for your GCM Service application credential. </param>
        /// <param name="secret"> [FCM only] The **Server key** of your project from the Firebase console, found under Settings / Cloud messaging. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Credential </returns>
        public static CredentialResource Create(
                                          CredentialResource.PushTypeEnum type,
                                          string friendlyName = null,
                                          string certificate = null,
                                          string privateKey = null,
                                          bool? sandbox = null,
                                          string apiKey = null,
                                          string secret = null,
                                          IKandyRestClient client = null)
        {
            var options = new CreateCredentialOptions(type) { FriendlyName = friendlyName, Certificate = certificate, PrivateKey = privateKey, Sandbox = sandbox, ApiKey = apiKey, Secret = secret };
            return Create(options, client);
        }

#if !NET35
        /// <summary> Add a new push notification credential to your account </summary>
        /// <param name="type">  </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the new resource. It can be up to 64 characters long. </param>
        /// <param name="certificate"> [APN only] The URL encoded representation of the certificate. For example,  `- - - - -BEGIN CERTIFICATE- - - - - MIIFnTCCBIWgAwIBAgIIAjy9H849+E8wDQYJKoZIhvcNAQEF.....A== - - - - -END CERTIFICATE- - - - -`. </param>
        /// <param name="privateKey"> [APN only] The URL encoded representation of the private key. For example, `- - - - -BEGIN RSA PRIVATE KEY- - - - - MIIEpQIBAAKCAQEAuyf/lNrH9ck8DmNyo3fG... - - - - -END RSA PRIVATE KEY- - - - -`. </param>
        /// <param name="sandbox"> [APN only] Whether to send the credential to sandbox APNs. Can be `true` to send to sandbox APNs or `false` to send to production. </param>
        /// <param name="apiKey"> [GCM only] The API key for the project that was obtained from the Google Developer console for your GCM Service application credential. </param>
        /// <param name="secret"> [FCM only] The **Server key** of your project from the Firebase console, found under Settings / Cloud messaging. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Credential </returns>
        public static async System.Threading.Tasks.Task<CredentialResource> CreateAsync(
                                                                                  CredentialResource.PushTypeEnum type,
                                                                                  string friendlyName = null,
                                                                                  string certificate = null,
                                                                                  string privateKey = null,
                                                                                  bool? sandbox = null,
                                                                                  string apiKey = null,
                                                                                  string secret = null,
                                                                                  IKandyRestClient client = null)
        {
            var options = new CreateCredentialOptions(type) { FriendlyName = friendlyName, Certificate = certificate, PrivateKey = privateKey, Sandbox = sandbox, ApiKey = apiKey, Secret = secret };
            return await CreateAsync(options, client);
        }
#endif

        /// <summary> Remove a push notification credential from your account </summary>
        /// <param name="options"> Delete Credential parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Credential </returns>
        private static Request BuildDeleteRequest(DeleteCredentialOptions options, IKandyRestClient client)
        {

            string path = "/v1/Credentials/{Sid}";

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

        /// <summary> Remove a push notification credential from your account </summary>
        /// <param name="options"> Delete Credential parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Credential </returns>
        public static bool Delete(DeleteCredentialOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

#if !NET35
        /// <summary> Remove a push notification credential from your account </summary>
        /// <param name="options"> Delete Credential parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Credential </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteCredentialOptions options,
                                                                          IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
#endif

        /// <summary> Remove a push notification credential from your account </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Credential </returns>
        public static bool Delete(string pathSid, IKandyRestClient client = null)
        {
            var options = new DeleteCredentialOptions(pathSid);
            return Delete(options, client);
        }

#if !NET35
        /// <summary> Remove a push notification credential from your account </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Credential </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, IKandyRestClient client = null)
        {
            var options = new DeleteCredentialOptions(pathSid);
            return await DeleteAsync(options, client);
        }
#endif

        private static Request BuildFetchRequest(FetchCredentialOptions options, IKandyRestClient client)
        {

            string path = "/v1/Credentials/{Sid}";

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

        /// <summary> Fetch a push notification credential from your account </summary>
        /// <param name="options"> Fetch Credential parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Credential </returns>
        public static CredentialResource Fetch(FetchCredentialOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> Fetch a push notification credential from your account </summary>
        /// <param name="options"> Fetch Credential parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Credential </returns>
        public static async System.Threading.Tasks.Task<CredentialResource> FetchAsync(FetchCredentialOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
#endif
        /// <summary> Fetch a push notification credential from your account </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Credential </returns>
        public static CredentialResource Fetch(
                                         string pathSid,
                                         IKandyRestClient client = null)
        {
            var options = new FetchCredentialOptions(pathSid) { };
            return Fetch(options, client);
        }

#if !NET35
        /// <summary> Fetch a push notification credential from your account </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Credential </returns>
        public static async System.Threading.Tasks.Task<CredentialResource> FetchAsync(string pathSid, IKandyRestClient client = null)
        {
            var options = new FetchCredentialOptions(pathSid) { };
            return await FetchAsync(options, client);
        }
#endif

        private static Request BuildReadRequest(ReadCredentialOptions options, IKandyRestClient client)
        {

            string path = "/v1/Credentials";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Conversations,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of all push notification credentials on your account </summary>
        /// <param name="options"> Read Credential parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Credential </returns>
        public static ResourceSet<CredentialResource> Read(ReadCredentialOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<CredentialResource>.FromJson("credentials", response.Content);
            return new ResourceSet<CredentialResource>(page, options, client);
        }

#if !NET35
        /// <summary> Retrieve a list of all push notification credentials on your account </summary>
        /// <param name="options"> Read Credential parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Credential </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<CredentialResource>> ReadAsync(ReadCredentialOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<CredentialResource>.FromJson("credentials", response.Content);
            return new ResourceSet<CredentialResource>(page, options, client);
        }
#endif
        /// <summary> Retrieve a list of all push notification credentials on your account </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Credential </returns>
        public static ResourceSet<CredentialResource> Read(
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     IKandyRestClient client = null)
        {
            var options = new ReadCredentialOptions() { PageSize = pageSize, Limit = limit };
            return Read(options, client);
        }

#if !NET35
        /// <summary> Retrieve a list of all push notification credentials on your account </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Credential </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<CredentialResource>> ReadAsync(
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             IKandyRestClient client = null)
        {
            var options = new ReadCredentialOptions() { PageSize = pageSize, Limit = limit };
            return await ReadAsync(options, client);
        }
#endif


        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The target page of records </returns>
        public static Page<CredentialResource> GetPage(string targetUrl, IKandyRestClient client)
        {
            client = client ?? KandyClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<CredentialResource>.FromJson("credentials", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The next page of records </returns>
        public static Page<CredentialResource> NextPage(Page<CredentialResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<CredentialResource>.FromJson("credentials", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The previous page of records </returns>
        public static Page<CredentialResource> PreviousPage(Page<CredentialResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<CredentialResource>.FromJson("credentials", response.Content);
        }


        private static Request BuildUpdateRequest(UpdateCredentialOptions options, IKandyRestClient client)
        {

            string path = "/v1/Credentials/{Sid}";

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

        /// <summary> Update an existing push notification credential on your account </summary>
        /// <param name="options"> Update Credential parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Credential </returns>
        public static CredentialResource Update(UpdateCredentialOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Update an existing push notification credential on your account </summary>
        /// <param name="options"> Update Credential parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Credential </returns>
#if !NET35
        public static async System.Threading.Tasks.Task<CredentialResource> UpdateAsync(UpdateCredentialOptions options,
                                                                                                          IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> Update an existing push notification credential on your account </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        /// <param name="type">  </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the new resource. It can be up to 64 characters long. </param>
        /// <param name="certificate"> [APN only] The URL encoded representation of the certificate. For example,  `- - - - -BEGIN CERTIFICATE- - - - - MIIFnTCCBIWgAwIBAgIIAjy9H849+E8wDQYJKoZIhvcNAQEF.....A== - - - - -END CERTIFICATE- - - - -`. </param>
        /// <param name="privateKey"> [APN only] The URL encoded representation of the private key. For example, `- - - - -BEGIN RSA PRIVATE KEY- - - - - MIIEpQIBAAKCAQEAuyf/lNrH9ck8DmNyo3fG... - - - - -END RSA PRIVATE KEY- - - - -`. </param>
        /// <param name="sandbox"> [APN only] Whether to send the credential to sandbox APNs. Can be `true` to send to sandbox APNs or `false` to send to production. </param>
        /// <param name="apiKey"> [GCM only] The API key for the project that was obtained from the Google Developer console for your GCM Service application credential. </param>
        /// <param name="secret"> [FCM only] The **Server key** of your project from the Firebase console, found under Settings / Cloud messaging. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Credential </returns>
        public static CredentialResource Update(
                                          string pathSid,
                                          CredentialResource.PushTypeEnum type = null,
                                          string friendlyName = null,
                                          string certificate = null,
                                          string privateKey = null,
                                          bool? sandbox = null,
                                          string apiKey = null,
                                          string secret = null,
                                          IKandyRestClient client = null)
        {
            var options = new UpdateCredentialOptions(pathSid) { Type = type, FriendlyName = friendlyName, Certificate = certificate, PrivateKey = privateKey, Sandbox = sandbox, ApiKey = apiKey, Secret = secret };
            return Update(options, client);
        }

#if !NET35
        /// <summary> Update an existing push notification credential on your account </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        /// <param name="type">  </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the new resource. It can be up to 64 characters long. </param>
        /// <param name="certificate"> [APN only] The URL encoded representation of the certificate. For example,  `- - - - -BEGIN CERTIFICATE- - - - - MIIFnTCCBIWgAwIBAgIIAjy9H849+E8wDQYJKoZIhvcNAQEF.....A== - - - - -END CERTIFICATE- - - - -`. </param>
        /// <param name="privateKey"> [APN only] The URL encoded representation of the private key. For example, `- - - - -BEGIN RSA PRIVATE KEY- - - - - MIIEpQIBAAKCAQEAuyf/lNrH9ck8DmNyo3fG... - - - - -END RSA PRIVATE KEY- - - - -`. </param>
        /// <param name="sandbox"> [APN only] Whether to send the credential to sandbox APNs. Can be `true` to send to sandbox APNs or `false` to send to production. </param>
        /// <param name="apiKey"> [GCM only] The API key for the project that was obtained from the Google Developer console for your GCM Service application credential. </param>
        /// <param name="secret"> [FCM only] The **Server key** of your project from the Firebase console, found under Settings / Cloud messaging. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Credential </returns>
        public static async System.Threading.Tasks.Task<CredentialResource> UpdateAsync(
                                                                              string pathSid,
                                                                              CredentialResource.PushTypeEnum type = null,
                                                                              string friendlyName = null,
                                                                              string certificate = null,
                                                                              string privateKey = null,
                                                                              bool? sandbox = null,
                                                                              string apiKey = null,
                                                                              string secret = null,
                                                                              IKandyRestClient client = null)
        {
            var options = new UpdateCredentialOptions(pathSid) { Type = type, FriendlyName = friendlyName, Certificate = certificate, PrivateKey = privateKey, Sandbox = sandbox, ApiKey = apiKey, Secret = secret };
            return await UpdateAsync(options, client);
        }
#endif

        /// <summary>
        /// Converts a JSON string into a CredentialResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> CredentialResource object represented by the provided JSON </returns>
        public static CredentialResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<CredentialResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> A 34 character string that uniquely identifies this resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The unique ID of the [Account](https://www.kandy.com/docs/iam/api/account) responsible for this credential. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The human-readable name of this credential, limited to 64 characters. Optional. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }


        [JsonProperty("type")]
        public CredentialResource.PushTypeEnum Type { get; private set; }

        ///<summary> [APN only] Whether to send the credential to sandbox APNs. Can be `true` to send to sandbox APNs or `false` to send to production. </summary> 
        [JsonProperty("sandbox")]
        public string Sandbox { get; private set; }

        ///<summary> The date that this resource was created. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date that this resource was last updated. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> An absolute API resource URL for this credential. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private CredentialResource()
        {

        }
    }
}
