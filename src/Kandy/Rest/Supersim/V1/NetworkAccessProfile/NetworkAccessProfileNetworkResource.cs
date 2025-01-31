/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Supersim
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



namespace Kandy.Rest.Supersim.V1.NetworkAccessProfile
{
    public class NetworkAccessProfileNetworkResource : Resource
    {



        private static Request BuildCreateRequest(CreateNetworkAccessProfileNetworkOptions options, IKandyRestClient client)
        {

            string path = "/v1/NetworkAccessProfiles/{NetworkAccessProfileSid}/Networks";

            string PathNetworkAccessProfileSid = options.PathNetworkAccessProfileSid;
            path = path.Replace("{" + "NetworkAccessProfileSid" + "}", PathNetworkAccessProfileSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Supersim,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Add a Network resource to the Network Access Profile resource. </summary>
        /// <param name="options"> Create NetworkAccessProfileNetwork parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of NetworkAccessProfileNetwork </returns>
        public static NetworkAccessProfileNetworkResource Create(CreateNetworkAccessProfileNetworkOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> Add a Network resource to the Network Access Profile resource. </summary>
        /// <param name="options"> Create NetworkAccessProfileNetwork parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of NetworkAccessProfileNetwork </returns>
        public static async System.Threading.Tasks.Task<NetworkAccessProfileNetworkResource> CreateAsync(CreateNetworkAccessProfileNetworkOptions options,
        IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> Add a Network resource to the Network Access Profile resource. </summary>
        /// <param name="pathNetworkAccessProfileSid"> The unique string that identifies the Network Access Profile resource. </param>
        /// <param name="network"> The SID of the Network resource to be added to the Network Access Profile resource. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of NetworkAccessProfileNetwork </returns>
        public static NetworkAccessProfileNetworkResource Create(
                                          string pathNetworkAccessProfileSid,
                                          string network,
                                          IKandyRestClient client = null)
        {
            var options = new CreateNetworkAccessProfileNetworkOptions(pathNetworkAccessProfileSid, network) { };
            return Create(options, client);
        }

#if !NET35
        /// <summary> Add a Network resource to the Network Access Profile resource. </summary>
        /// <param name="pathNetworkAccessProfileSid"> The unique string that identifies the Network Access Profile resource. </param>
        /// <param name="network"> The SID of the Network resource to be added to the Network Access Profile resource. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of NetworkAccessProfileNetwork </returns>
        public static async System.Threading.Tasks.Task<NetworkAccessProfileNetworkResource> CreateAsync(
                                                                                  string pathNetworkAccessProfileSid,
                                                                                  string network,
                                                                                  IKandyRestClient client = null)
        {
            var options = new CreateNetworkAccessProfileNetworkOptions(pathNetworkAccessProfileSid, network) { };
            return await CreateAsync(options, client);
        }
#endif

        /// <summary> Remove a Network resource from the Network Access Profile resource's. </summary>
        /// <param name="options"> Delete NetworkAccessProfileNetwork parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of NetworkAccessProfileNetwork </returns>
        private static Request BuildDeleteRequest(DeleteNetworkAccessProfileNetworkOptions options, IKandyRestClient client)
        {

            string path = "/v1/NetworkAccessProfiles/{NetworkAccessProfileSid}/Networks/{Sid}";

            string PathNetworkAccessProfileSid = options.PathNetworkAccessProfileSid;
            path = path.Replace("{" + "NetworkAccessProfileSid" + "}", PathNetworkAccessProfileSid);
            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Supersim,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Remove a Network resource from the Network Access Profile resource's. </summary>
        /// <param name="options"> Delete NetworkAccessProfileNetwork parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of NetworkAccessProfileNetwork </returns>
        public static bool Delete(DeleteNetworkAccessProfileNetworkOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

#if !NET35
        /// <summary> Remove a Network resource from the Network Access Profile resource's. </summary>
        /// <param name="options"> Delete NetworkAccessProfileNetwork parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of NetworkAccessProfileNetwork </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteNetworkAccessProfileNetworkOptions options,
                                                                          IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
#endif

        /// <summary> Remove a Network resource from the Network Access Profile resource's. </summary>
        /// <param name="pathNetworkAccessProfileSid"> The unique string that identifies the Network Access Profile resource. </param>
        /// <param name="pathSid"> The SID of the Network resource to be removed from the Network Access Profile resource. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of NetworkAccessProfileNetwork </returns>
        public static bool Delete(string pathNetworkAccessProfileSid, string pathSid, IKandyRestClient client = null)
        {
            var options = new DeleteNetworkAccessProfileNetworkOptions(pathNetworkAccessProfileSid, pathSid);
            return Delete(options, client);
        }

#if !NET35
        /// <summary> Remove a Network resource from the Network Access Profile resource's. </summary>
        /// <param name="pathNetworkAccessProfileSid"> The unique string that identifies the Network Access Profile resource. </param>
        /// <param name="pathSid"> The SID of the Network resource to be removed from the Network Access Profile resource. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of NetworkAccessProfileNetwork </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathNetworkAccessProfileSid, string pathSid, IKandyRestClient client = null)
        {
            var options = new DeleteNetworkAccessProfileNetworkOptions(pathNetworkAccessProfileSid, pathSid);
            return await DeleteAsync(options, client);
        }
#endif

        private static Request BuildFetchRequest(FetchNetworkAccessProfileNetworkOptions options, IKandyRestClient client)
        {

            string path = "/v1/NetworkAccessProfiles/{NetworkAccessProfileSid}/Networks/{Sid}";

            string PathNetworkAccessProfileSid = options.PathNetworkAccessProfileSid;
            path = path.Replace("{" + "NetworkAccessProfileSid" + "}", PathNetworkAccessProfileSid);
            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Supersim,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch a Network Access Profile resource's Network resource. </summary>
        /// <param name="options"> Fetch NetworkAccessProfileNetwork parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of NetworkAccessProfileNetwork </returns>
        public static NetworkAccessProfileNetworkResource Fetch(FetchNetworkAccessProfileNetworkOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> Fetch a Network Access Profile resource's Network resource. </summary>
        /// <param name="options"> Fetch NetworkAccessProfileNetwork parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of NetworkAccessProfileNetwork </returns>
        public static async System.Threading.Tasks.Task<NetworkAccessProfileNetworkResource> FetchAsync(FetchNetworkAccessProfileNetworkOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
#endif
        /// <summary> Fetch a Network Access Profile resource's Network resource. </summary>
        /// <param name="pathNetworkAccessProfileSid"> The unique string that identifies the Network Access Profile resource. </param>
        /// <param name="pathSid"> The SID of the Network resource to fetch. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of NetworkAccessProfileNetwork </returns>
        public static NetworkAccessProfileNetworkResource Fetch(
                                         string pathNetworkAccessProfileSid,
                                         string pathSid,
                                         IKandyRestClient client = null)
        {
            var options = new FetchNetworkAccessProfileNetworkOptions(pathNetworkAccessProfileSid, pathSid) { };
            return Fetch(options, client);
        }

#if !NET35
        /// <summary> Fetch a Network Access Profile resource's Network resource. </summary>
        /// <param name="pathNetworkAccessProfileSid"> The unique string that identifies the Network Access Profile resource. </param>
        /// <param name="pathSid"> The SID of the Network resource to fetch. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of NetworkAccessProfileNetwork </returns>
        public static async System.Threading.Tasks.Task<NetworkAccessProfileNetworkResource> FetchAsync(string pathNetworkAccessProfileSid, string pathSid, IKandyRestClient client = null)
        {
            var options = new FetchNetworkAccessProfileNetworkOptions(pathNetworkAccessProfileSid, pathSid) { };
            return await FetchAsync(options, client);
        }
#endif

        private static Request BuildReadRequest(ReadNetworkAccessProfileNetworkOptions options, IKandyRestClient client)
        {

            string path = "/v1/NetworkAccessProfiles/{NetworkAccessProfileSid}/Networks";

            string PathNetworkAccessProfileSid = options.PathNetworkAccessProfileSid;
            path = path.Replace("{" + "NetworkAccessProfileSid" + "}", PathNetworkAccessProfileSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Supersim,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of Network Access Profile resource's Network resource. </summary>
        /// <param name="options"> Read NetworkAccessProfileNetwork parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of NetworkAccessProfileNetwork </returns>
        public static ResourceSet<NetworkAccessProfileNetworkResource> Read(ReadNetworkAccessProfileNetworkOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<NetworkAccessProfileNetworkResource>.FromJson("networks", response.Content);
            return new ResourceSet<NetworkAccessProfileNetworkResource>(page, options, client);
        }

#if !NET35
        /// <summary> Retrieve a list of Network Access Profile resource's Network resource. </summary>
        /// <param name="options"> Read NetworkAccessProfileNetwork parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of NetworkAccessProfileNetwork </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<NetworkAccessProfileNetworkResource>> ReadAsync(ReadNetworkAccessProfileNetworkOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<NetworkAccessProfileNetworkResource>.FromJson("networks", response.Content);
            return new ResourceSet<NetworkAccessProfileNetworkResource>(page, options, client);
        }
#endif
        /// <summary> Retrieve a list of Network Access Profile resource's Network resource. </summary>
        /// <param name="pathNetworkAccessProfileSid"> The unique string that identifies the Network Access Profile resource. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of NetworkAccessProfileNetwork </returns>
        public static ResourceSet<NetworkAccessProfileNetworkResource> Read(
                                                     string pathNetworkAccessProfileSid,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     IKandyRestClient client = null)
        {
            var options = new ReadNetworkAccessProfileNetworkOptions(pathNetworkAccessProfileSid) { PageSize = pageSize, Limit = limit };
            return Read(options, client);
        }

#if !NET35
        /// <summary> Retrieve a list of Network Access Profile resource's Network resource. </summary>
        /// <param name="pathNetworkAccessProfileSid"> The unique string that identifies the Network Access Profile resource. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of NetworkAccessProfileNetwork </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<NetworkAccessProfileNetworkResource>> ReadAsync(
                                                                                             string pathNetworkAccessProfileSid,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             IKandyRestClient client = null)
        {
            var options = new ReadNetworkAccessProfileNetworkOptions(pathNetworkAccessProfileSid) { PageSize = pageSize, Limit = limit };
            return await ReadAsync(options, client);
        }
#endif


        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The target page of records </returns>
        public static Page<NetworkAccessProfileNetworkResource> GetPage(string targetUrl, IKandyRestClient client)
        {
            client = client ?? KandyClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<NetworkAccessProfileNetworkResource>.FromJson("networks", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The next page of records </returns>
        public static Page<NetworkAccessProfileNetworkResource> NextPage(Page<NetworkAccessProfileNetworkResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<NetworkAccessProfileNetworkResource>.FromJson("networks", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The previous page of records </returns>
        public static Page<NetworkAccessProfileNetworkResource> PreviousPage(Page<NetworkAccessProfileNetworkResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<NetworkAccessProfileNetworkResource>.FromJson("networks", response.Content);
        }


        /// <summary>
        /// Converts a JSON string into a NetworkAccessProfileNetworkResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> NetworkAccessProfileNetworkResource object represented by the provided JSON </returns>
        public static NetworkAccessProfileNetworkResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<NetworkAccessProfileNetworkResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> The unique string that identifies the Network resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The unique string that identifies the Network resource's Network Access Profile resource. </summary> 
        [JsonProperty("network_access_profile_sid")]
        public string NetworkAccessProfileSid { get; private set; }

        ///<summary> A human readable identifier of the Network this resource refers to. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> The [ISO country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) of the Network resource. </summary> 
        [JsonProperty("iso_country")]
        public string IsoCountry { get; private set; }

        ///<summary> Array of objects identifying the [MCC-MNCs](https://en.wikipedia.org/wiki/Mobile_country_code) that are included in the Network resource. </summary> 
        [JsonProperty("identifiers")]
        public List<object> Identifiers { get; private set; }

        ///<summary> The absolute URL of the Network resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private NetworkAccessProfileNetworkResource()
        {

        }
    }
}
