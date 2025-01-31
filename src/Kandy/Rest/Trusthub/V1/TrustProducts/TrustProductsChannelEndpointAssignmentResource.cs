/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Trusthub
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



namespace Kandy.Rest.Trusthub.V1.TrustProducts
{
    public class TrustProductsChannelEndpointAssignmentResource : Resource
    {



        private static Request BuildCreateRequest(CreateTrustProductsChannelEndpointAssignmentOptions options, IKandyRestClient client)
        {

            string path = "/v1/TrustProducts/{TrustProductSid}/ChannelEndpointAssignments";

            string PathTrustProductSid = options.PathTrustProductSid;
            path = path.Replace("{" + "TrustProductSid" + "}", PathTrustProductSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Trusthub,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Create a new Assigned Item. </summary>
        /// <param name="options"> Create TrustProductsChannelEndpointAssignment parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of TrustProductsChannelEndpointAssignment </returns>
        public static TrustProductsChannelEndpointAssignmentResource Create(CreateTrustProductsChannelEndpointAssignmentOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> Create a new Assigned Item. </summary>
        /// <param name="options"> Create TrustProductsChannelEndpointAssignment parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of TrustProductsChannelEndpointAssignment </returns>
        public static async System.Threading.Tasks.Task<TrustProductsChannelEndpointAssignmentResource> CreateAsync(CreateTrustProductsChannelEndpointAssignmentOptions options,
        IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> Create a new Assigned Item. </summary>
        /// <param name="pathTrustProductSid"> The unique string that we created to identify the CustomerProfile resource. </param>
        /// <param name="channelEndpointType"> The type of channel endpoint. eg: phone-number </param>
        /// <param name="channelEndpointSid"> The SID of an channel endpoint </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of TrustProductsChannelEndpointAssignment </returns>
        public static TrustProductsChannelEndpointAssignmentResource Create(
                                          string pathTrustProductSid,
                                          string channelEndpointType,
                                          string channelEndpointSid,
                                          IKandyRestClient client = null)
        {
            var options = new CreateTrustProductsChannelEndpointAssignmentOptions(pathTrustProductSid, channelEndpointType, channelEndpointSid) { };
            return Create(options, client);
        }

#if !NET35
        /// <summary> Create a new Assigned Item. </summary>
        /// <param name="pathTrustProductSid"> The unique string that we created to identify the CustomerProfile resource. </param>
        /// <param name="channelEndpointType"> The type of channel endpoint. eg: phone-number </param>
        /// <param name="channelEndpointSid"> The SID of an channel endpoint </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of TrustProductsChannelEndpointAssignment </returns>
        public static async System.Threading.Tasks.Task<TrustProductsChannelEndpointAssignmentResource> CreateAsync(
                                                                                  string pathTrustProductSid,
                                                                                  string channelEndpointType,
                                                                                  string channelEndpointSid,
                                                                                  IKandyRestClient client = null)
        {
            var options = new CreateTrustProductsChannelEndpointAssignmentOptions(pathTrustProductSid, channelEndpointType, channelEndpointSid) { };
            return await CreateAsync(options, client);
        }
#endif

        /// <summary> Remove an Assignment Item Instance. </summary>
        /// <param name="options"> Delete TrustProductsChannelEndpointAssignment parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of TrustProductsChannelEndpointAssignment </returns>
        private static Request BuildDeleteRequest(DeleteTrustProductsChannelEndpointAssignmentOptions options, IKandyRestClient client)
        {

            string path = "/v1/TrustProducts/{TrustProductSid}/ChannelEndpointAssignments/{Sid}";

            string PathTrustProductSid = options.PathTrustProductSid;
            path = path.Replace("{" + "TrustProductSid" + "}", PathTrustProductSid);
            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Trusthub,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Remove an Assignment Item Instance. </summary>
        /// <param name="options"> Delete TrustProductsChannelEndpointAssignment parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of TrustProductsChannelEndpointAssignment </returns>
        public static bool Delete(DeleteTrustProductsChannelEndpointAssignmentOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

#if !NET35
        /// <summary> Remove an Assignment Item Instance. </summary>
        /// <param name="options"> Delete TrustProductsChannelEndpointAssignment parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of TrustProductsChannelEndpointAssignment </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteTrustProductsChannelEndpointAssignmentOptions options,
                                                                          IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
#endif

        /// <summary> Remove an Assignment Item Instance. </summary>
        /// <param name="pathTrustProductSid"> The unique string that we created to identify the CustomerProfile resource. </param>
        /// <param name="pathSid"> The unique string that we created to identify the resource. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of TrustProductsChannelEndpointAssignment </returns>
        public static bool Delete(string pathTrustProductSid, string pathSid, IKandyRestClient client = null)
        {
            var options = new DeleteTrustProductsChannelEndpointAssignmentOptions(pathTrustProductSid, pathSid);
            return Delete(options, client);
        }

#if !NET35
        /// <summary> Remove an Assignment Item Instance. </summary>
        /// <param name="pathTrustProductSid"> The unique string that we created to identify the CustomerProfile resource. </param>
        /// <param name="pathSid"> The unique string that we created to identify the resource. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of TrustProductsChannelEndpointAssignment </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathTrustProductSid, string pathSid, IKandyRestClient client = null)
        {
            var options = new DeleteTrustProductsChannelEndpointAssignmentOptions(pathTrustProductSid, pathSid);
            return await DeleteAsync(options, client);
        }
#endif

        private static Request BuildFetchRequest(FetchTrustProductsChannelEndpointAssignmentOptions options, IKandyRestClient client)
        {

            string path = "/v1/TrustProducts/{TrustProductSid}/ChannelEndpointAssignments/{Sid}";

            string PathTrustProductSid = options.PathTrustProductSid;
            path = path.Replace("{" + "TrustProductSid" + "}", PathTrustProductSid);
            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Trusthub,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch specific Assigned Item Instance. </summary>
        /// <param name="options"> Fetch TrustProductsChannelEndpointAssignment parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of TrustProductsChannelEndpointAssignment </returns>
        public static TrustProductsChannelEndpointAssignmentResource Fetch(FetchTrustProductsChannelEndpointAssignmentOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> Fetch specific Assigned Item Instance. </summary>
        /// <param name="options"> Fetch TrustProductsChannelEndpointAssignment parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of TrustProductsChannelEndpointAssignment </returns>
        public static async System.Threading.Tasks.Task<TrustProductsChannelEndpointAssignmentResource> FetchAsync(FetchTrustProductsChannelEndpointAssignmentOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
#endif
        /// <summary> Fetch specific Assigned Item Instance. </summary>
        /// <param name="pathTrustProductSid"> The unique string that we created to identify the CustomerProfile resource. </param>
        /// <param name="pathSid"> The unique string that we created to identify the resource. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of TrustProductsChannelEndpointAssignment </returns>
        public static TrustProductsChannelEndpointAssignmentResource Fetch(
                                         string pathTrustProductSid,
                                         string pathSid,
                                         IKandyRestClient client = null)
        {
            var options = new FetchTrustProductsChannelEndpointAssignmentOptions(pathTrustProductSid, pathSid) { };
            return Fetch(options, client);
        }

#if !NET35
        /// <summary> Fetch specific Assigned Item Instance. </summary>
        /// <param name="pathTrustProductSid"> The unique string that we created to identify the CustomerProfile resource. </param>
        /// <param name="pathSid"> The unique string that we created to identify the resource. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of TrustProductsChannelEndpointAssignment </returns>
        public static async System.Threading.Tasks.Task<TrustProductsChannelEndpointAssignmentResource> FetchAsync(string pathTrustProductSid, string pathSid, IKandyRestClient client = null)
        {
            var options = new FetchTrustProductsChannelEndpointAssignmentOptions(pathTrustProductSid, pathSid) { };
            return await FetchAsync(options, client);
        }
#endif

        private static Request BuildReadRequest(ReadTrustProductsChannelEndpointAssignmentOptions options, IKandyRestClient client)
        {

            string path = "/v1/TrustProducts/{TrustProductSid}/ChannelEndpointAssignments";

            string PathTrustProductSid = options.PathTrustProductSid;
            path = path.Replace("{" + "TrustProductSid" + "}", PathTrustProductSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Trusthub,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of all Assigned Items for an account. </summary>
        /// <param name="options"> Read TrustProductsChannelEndpointAssignment parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of TrustProductsChannelEndpointAssignment </returns>
        public static ResourceSet<TrustProductsChannelEndpointAssignmentResource> Read(ReadTrustProductsChannelEndpointAssignmentOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<TrustProductsChannelEndpointAssignmentResource>.FromJson("results", response.Content);
            return new ResourceSet<TrustProductsChannelEndpointAssignmentResource>(page, options, client);
        }

#if !NET35
        /// <summary> Retrieve a list of all Assigned Items for an account. </summary>
        /// <param name="options"> Read TrustProductsChannelEndpointAssignment parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of TrustProductsChannelEndpointAssignment </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<TrustProductsChannelEndpointAssignmentResource>> ReadAsync(ReadTrustProductsChannelEndpointAssignmentOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<TrustProductsChannelEndpointAssignmentResource>.FromJson("results", response.Content);
            return new ResourceSet<TrustProductsChannelEndpointAssignmentResource>(page, options, client);
        }
#endif
        /// <summary> Retrieve a list of all Assigned Items for an account. </summary>
        /// <param name="pathTrustProductSid"> The unique string that we created to identify the CustomerProfile resource. </param>
        /// <param name="channelEndpointSid"> The SID of an channel endpoint </param>
        /// <param name="channelEndpointSids"> comma separated list of channel endpoint sids </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of TrustProductsChannelEndpointAssignment </returns>
        public static ResourceSet<TrustProductsChannelEndpointAssignmentResource> Read(
                                                     string pathTrustProductSid,
                                                     string channelEndpointSid = null,
                                                     string channelEndpointSids = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     IKandyRestClient client = null)
        {
            var options = new ReadTrustProductsChannelEndpointAssignmentOptions(pathTrustProductSid) { ChannelEndpointSid = channelEndpointSid, ChannelEndpointSids = channelEndpointSids, PageSize = pageSize, Limit = limit };
            return Read(options, client);
        }

#if !NET35
        /// <summary> Retrieve a list of all Assigned Items for an account. </summary>
        /// <param name="pathTrustProductSid"> The unique string that we created to identify the CustomerProfile resource. </param>
        /// <param name="channelEndpointSid"> The SID of an channel endpoint </param>
        /// <param name="channelEndpointSids"> comma separated list of channel endpoint sids </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of TrustProductsChannelEndpointAssignment </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<TrustProductsChannelEndpointAssignmentResource>> ReadAsync(
                                                                                             string pathTrustProductSid,
                                                                                             string channelEndpointSid = null,
                                                                                             string channelEndpointSids = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             IKandyRestClient client = null)
        {
            var options = new ReadTrustProductsChannelEndpointAssignmentOptions(pathTrustProductSid) { ChannelEndpointSid = channelEndpointSid, ChannelEndpointSids = channelEndpointSids, PageSize = pageSize, Limit = limit };
            return await ReadAsync(options, client);
        }
#endif


        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The target page of records </returns>
        public static Page<TrustProductsChannelEndpointAssignmentResource> GetPage(string targetUrl, IKandyRestClient client)
        {
            client = client ?? KandyClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<TrustProductsChannelEndpointAssignmentResource>.FromJson("results", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The next page of records </returns>
        public static Page<TrustProductsChannelEndpointAssignmentResource> NextPage(Page<TrustProductsChannelEndpointAssignmentResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<TrustProductsChannelEndpointAssignmentResource>.FromJson("results", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The previous page of records </returns>
        public static Page<TrustProductsChannelEndpointAssignmentResource> PreviousPage(Page<TrustProductsChannelEndpointAssignmentResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<TrustProductsChannelEndpointAssignmentResource>.FromJson("results", response.Content);
        }


        /// <summary>
        /// Converts a JSON string into a TrustProductsChannelEndpointAssignmentResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> TrustProductsChannelEndpointAssignmentResource object represented by the provided JSON </returns>
        public static TrustProductsChannelEndpointAssignmentResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<TrustProductsChannelEndpointAssignmentResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> The unique string that we created to identify the Item Assignment resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The unique string that we created to identify the CustomerProfile resource. </summary> 
        [JsonProperty("trust_product_sid")]
        public string TrustProductSid { get; private set; }

        ///<summary> The SID of the [Account](https://www.kandy.com/docs/iam/api/account) that created the Item Assignment resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The type of channel endpoint. eg: phone-number </summary> 
        [JsonProperty("channel_endpoint_type")]
        public string ChannelEndpointType { get; private set; }

        ///<summary> The SID of an channel endpoint </summary> 
        [JsonProperty("channel_endpoint_sid")]
        public string ChannelEndpointSid { get; private set; }

        ///<summary> The date and time in GMT when the resource was created specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The absolute URL of the Identity resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private TrustProductsChannelEndpointAssignmentResource()
        {

        }
    }
}
