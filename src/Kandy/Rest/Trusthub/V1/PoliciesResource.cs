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



namespace Kandy.Rest.Trusthub.V1
{
    public class PoliciesResource : Resource
    {



        private static Request BuildFetchRequest(FetchPoliciesOptions options, IKandyRestClient client)
        {

            string path = "/v1/Policies/{Sid}";

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

        /// <summary> Fetch specific Policy Instance. </summary>
        /// <param name="options"> Fetch Policies parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Policies </returns>
        public static PoliciesResource Fetch(FetchPoliciesOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> Fetch specific Policy Instance. </summary>
        /// <param name="options"> Fetch Policies parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Policies </returns>
        public static async System.Threading.Tasks.Task<PoliciesResource> FetchAsync(FetchPoliciesOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
#endif
        /// <summary> Fetch specific Policy Instance. </summary>
        /// <param name="pathSid"> The unique string that identifies the Policy resource. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Policies </returns>
        public static PoliciesResource Fetch(
                                         string pathSid,
                                         IKandyRestClient client = null)
        {
            var options = new FetchPoliciesOptions(pathSid) { };
            return Fetch(options, client);
        }

#if !NET35
        /// <summary> Fetch specific Policy Instance. </summary>
        /// <param name="pathSid"> The unique string that identifies the Policy resource. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Policies </returns>
        public static async System.Threading.Tasks.Task<PoliciesResource> FetchAsync(string pathSid, IKandyRestClient client = null)
        {
            var options = new FetchPoliciesOptions(pathSid) { };
            return await FetchAsync(options, client);
        }
#endif

        private static Request BuildReadRequest(ReadPoliciesOptions options, IKandyRestClient client)
        {

            string path = "/v1/Policies";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Trusthub,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of all Policys. </summary>
        /// <param name="options"> Read Policies parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Policies </returns>
        public static ResourceSet<PoliciesResource> Read(ReadPoliciesOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<PoliciesResource>.FromJson("results", response.Content);
            return new ResourceSet<PoliciesResource>(page, options, client);
        }

#if !NET35
        /// <summary> Retrieve a list of all Policys. </summary>
        /// <param name="options"> Read Policies parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Policies </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<PoliciesResource>> ReadAsync(ReadPoliciesOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<PoliciesResource>.FromJson("results", response.Content);
            return new ResourceSet<PoliciesResource>(page, options, client);
        }
#endif
        /// <summary> Retrieve a list of all Policys. </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Policies </returns>
        public static ResourceSet<PoliciesResource> Read(
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     IKandyRestClient client = null)
        {
            var options = new ReadPoliciesOptions() { PageSize = pageSize, Limit = limit };
            return Read(options, client);
        }

#if !NET35
        /// <summary> Retrieve a list of all Policys. </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Policies </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<PoliciesResource>> ReadAsync(
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             IKandyRestClient client = null)
        {
            var options = new ReadPoliciesOptions() { PageSize = pageSize, Limit = limit };
            return await ReadAsync(options, client);
        }
#endif


        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The target page of records </returns>
        public static Page<PoliciesResource> GetPage(string targetUrl, IKandyRestClient client)
        {
            client = client ?? KandyClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<PoliciesResource>.FromJson("results", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The next page of records </returns>
        public static Page<PoliciesResource> NextPage(Page<PoliciesResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<PoliciesResource>.FromJson("results", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The previous page of records </returns>
        public static Page<PoliciesResource> PreviousPage(Page<PoliciesResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<PoliciesResource>.FromJson("results", response.Content);
        }


        /// <summary>
        /// Converts a JSON string into a PoliciesResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> PoliciesResource object represented by the provided JSON </returns>
        public static PoliciesResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<PoliciesResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> The unique string that identifies the Policy resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> A human-readable description that is assigned to describe the Policy resource. Examples can include Primary Customer profile policy </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> The SID of an object that holds the policy information </summary> 
        [JsonProperty("requirements")]
        public object Requirements { get; private set; }

        ///<summary> The absolute URL of the Policy resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private PoliciesResource()
        {

        }
    }
}
