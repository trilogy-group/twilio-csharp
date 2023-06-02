/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Supersim
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



namespace Kandy.Rest.Supersim.V1
{
    public class NetworkAccessProfileResource : Resource
    {
    

        
        private static Request BuildCreateRequest(CreateNetworkAccessProfileOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/NetworkAccessProfiles";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Supersim,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Create a new Network Access Profile </summary>
        /// <param name="options"> Create NetworkAccessProfile parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of NetworkAccessProfile </returns>
        public static NetworkAccessProfileResource Create(CreateNetworkAccessProfileOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Create a new Network Access Profile </summary>
        /// <param name="options"> Create NetworkAccessProfile parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of NetworkAccessProfile </returns>
        public static async System.Threading.Tasks.Task<NetworkAccessProfileResource> CreateAsync(CreateNetworkAccessProfileOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Create a new Network Access Profile </summary>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the resource. It can be used in place of the resource's `sid` in the URL to address the resource. </param>
        /// <param name="networks"> List of Network SIDs that this Network Access Profile will allow connections to. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of NetworkAccessProfile </returns>
        public static NetworkAccessProfileResource Create(
                                          string uniqueName = null,
                                          List<string> networks = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateNetworkAccessProfileOptions(){  UniqueName = uniqueName, Networks = networks };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Create a new Network Access Profile </summary>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the resource. It can be used in place of the resource's `sid` in the URL to address the resource. </param>
        /// <param name="networks"> List of Network SIDs that this Network Access Profile will allow connections to. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of NetworkAccessProfile </returns>
        public static async System.Threading.Tasks.Task<NetworkAccessProfileResource> CreateAsync(
                                                                                  string uniqueName = null,
                                                                                  List<string> networks = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateNetworkAccessProfileOptions(){  UniqueName = uniqueName, Networks = networks };
            return await CreateAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchNetworkAccessProfileOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/NetworkAccessProfiles/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Supersim,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch a Network Access Profile instance from your account. </summary>
        /// <param name="options"> Fetch NetworkAccessProfile parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of NetworkAccessProfile </returns>
        public static NetworkAccessProfileResource Fetch(FetchNetworkAccessProfileOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Fetch a Network Access Profile instance from your account. </summary>
        /// <param name="options"> Fetch NetworkAccessProfile parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of NetworkAccessProfile </returns>
        public static async System.Threading.Tasks.Task<NetworkAccessProfileResource> FetchAsync(FetchNetworkAccessProfileOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> Fetch a Network Access Profile instance from your account. </summary>
        /// <param name="pathSid"> The SID of the Network Access Profile resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of NetworkAccessProfile </returns>
        public static NetworkAccessProfileResource Fetch(
                                         string pathSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchNetworkAccessProfileOptions(pathSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> Fetch a Network Access Profile instance from your account. </summary>
        /// <param name="pathSid"> The SID of the Network Access Profile resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of NetworkAccessProfile </returns>
        public static async System.Threading.Tasks.Task<NetworkAccessProfileResource> FetchAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchNetworkAccessProfileOptions(pathSid){  };
            return await FetchAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadNetworkAccessProfileOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/NetworkAccessProfiles";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Supersim,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of Network Access Profiles from your account. </summary>
        /// <param name="options"> Read NetworkAccessProfile parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of NetworkAccessProfile </returns>
        public static ResourceSet<NetworkAccessProfileResource> Read(ReadNetworkAccessProfileOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<NetworkAccessProfileResource>.FromJson("network_access_profiles", response.Content);
            return new ResourceSet<NetworkAccessProfileResource>(page, options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of Network Access Profiles from your account. </summary>
        /// <param name="options"> Read NetworkAccessProfile parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of NetworkAccessProfile </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<NetworkAccessProfileResource>> ReadAsync(ReadNetworkAccessProfileOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<NetworkAccessProfileResource>.FromJson("network_access_profiles", response.Content);
            return new ResourceSet<NetworkAccessProfileResource>(page, options, client);
        }
        #endif
        /// <summary> Retrieve a list of Network Access Profiles from your account. </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of NetworkAccessProfile </returns>
        public static ResourceSet<NetworkAccessProfileResource> Read(
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadNetworkAccessProfileOptions(){ PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> Retrieve a list of Network Access Profiles from your account. </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of NetworkAccessProfile </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<NetworkAccessProfileResource>> ReadAsync(
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadNetworkAccessProfileOptions(){ PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<NetworkAccessProfileResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<NetworkAccessProfileResource>.FromJson("network_access_profiles", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<NetworkAccessProfileResource> NextPage(Page<NetworkAccessProfileResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<NetworkAccessProfileResource>.FromJson("network_access_profiles", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<NetworkAccessProfileResource> PreviousPage(Page<NetworkAccessProfileResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<NetworkAccessProfileResource>.FromJson("network_access_profiles", response.Content);
        }

        
        private static Request BuildUpdateRequest(UpdateNetworkAccessProfileOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/NetworkAccessProfiles/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{"+"Sid"+"}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Supersim,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Updates the given properties of a Network Access Profile in your account. </summary>
        /// <param name="options"> Update NetworkAccessProfile parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of NetworkAccessProfile </returns>
        public static NetworkAccessProfileResource Update(UpdateNetworkAccessProfileOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Updates the given properties of a Network Access Profile in your account. </summary>
        /// <param name="options"> Update NetworkAccessProfile parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of NetworkAccessProfile </returns>
        #if !NET35
        public static async System.Threading.Tasks.Task<NetworkAccessProfileResource> UpdateAsync(UpdateNetworkAccessProfileOptions options,
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Updates the given properties of a Network Access Profile in your account. </summary>
        /// <param name="pathSid"> The SID of the Network Access Profile to update. </param>
        /// <param name="uniqueName"> The new unique name of the Network Access Profile. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of NetworkAccessProfile </returns>
        public static NetworkAccessProfileResource Update(
                                          string pathSid,
                                          string uniqueName = null,
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateNetworkAccessProfileOptions(pathSid){ UniqueName = uniqueName };
            return Update(options, client);
        }

        #if !NET35
        /// <summary> Updates the given properties of a Network Access Profile in your account. </summary>
        /// <param name="pathSid"> The SID of the Network Access Profile to update. </param>
        /// <param name="uniqueName"> The new unique name of the Network Access Profile. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of NetworkAccessProfile </returns>
        public static async System.Threading.Tasks.Task<NetworkAccessProfileResource> UpdateAsync(
                                                                              string pathSid,
                                                                              string uniqueName = null,
                                                                              ITwilioRestClient client = null)
        {
            var options = new UpdateNetworkAccessProfileOptions(pathSid){ UniqueName = uniqueName };
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a NetworkAccessProfileResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> NetworkAccessProfileResource object represented by the provided JSON </returns>
        public static NetworkAccessProfileResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<NetworkAccessProfileResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The unique string that identifies the Network Access Profile resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> An application-defined string that uniquely identifies the resource. It can be used in place of the resource's `sid` in the URL to address the resource. </summary> 
        [JsonProperty("unique_name")]
        public string UniqueName { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that the Network Access Profile belongs to. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The date and time in GMT when the resource was created specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT when the resource was last updated specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The absolute URL of the Network Access Profile resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The links </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }



        private NetworkAccessProfileResource() {

        }
    }
}
