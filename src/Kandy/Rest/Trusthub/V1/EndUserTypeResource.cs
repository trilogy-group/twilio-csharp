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
    public class EndUserTypeResource : Resource
    {



        private static Request BuildFetchRequest(FetchEndUserTypeOptions options, IKandyRestClient client)
        {

            string path = "/v1/EndUserTypes/{Sid}";

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

        /// <summary> Fetch a specific End-User Type Instance. </summary>
        /// <param name="options"> Fetch EndUserType parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of EndUserType </returns>
        public static EndUserTypeResource Fetch(FetchEndUserTypeOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> Fetch a specific End-User Type Instance. </summary>
        /// <param name="options"> Fetch EndUserType parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of EndUserType </returns>
        public static async System.Threading.Tasks.Task<EndUserTypeResource> FetchAsync(FetchEndUserTypeOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
#endif
        /// <summary> Fetch a specific End-User Type Instance. </summary>
        /// <param name="pathSid"> The unique string that identifies the End-User Type resource. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of EndUserType </returns>
        public static EndUserTypeResource Fetch(
                                         string pathSid,
                                         IKandyRestClient client = null)
        {
            var options = new FetchEndUserTypeOptions(pathSid) { };
            return Fetch(options, client);
        }

#if !NET35
        /// <summary> Fetch a specific End-User Type Instance. </summary>
        /// <param name="pathSid"> The unique string that identifies the End-User Type resource. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of EndUserType </returns>
        public static async System.Threading.Tasks.Task<EndUserTypeResource> FetchAsync(string pathSid, IKandyRestClient client = null)
        {
            var options = new FetchEndUserTypeOptions(pathSid) { };
            return await FetchAsync(options, client);
        }
#endif

        private static Request BuildReadRequest(ReadEndUserTypeOptions options, IKandyRestClient client)
        {

            string path = "/v1/EndUserTypes";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Trusthub,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of all End-User Types. </summary>
        /// <param name="options"> Read EndUserType parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of EndUserType </returns>
        public static ResourceSet<EndUserTypeResource> Read(ReadEndUserTypeOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<EndUserTypeResource>.FromJson("end_user_types", response.Content);
            return new ResourceSet<EndUserTypeResource>(page, options, client);
        }

#if !NET35
        /// <summary> Retrieve a list of all End-User Types. </summary>
        /// <param name="options"> Read EndUserType parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of EndUserType </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<EndUserTypeResource>> ReadAsync(ReadEndUserTypeOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<EndUserTypeResource>.FromJson("end_user_types", response.Content);
            return new ResourceSet<EndUserTypeResource>(page, options, client);
        }
#endif
        /// <summary> Retrieve a list of all End-User Types. </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of EndUserType </returns>
        public static ResourceSet<EndUserTypeResource> Read(
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     IKandyRestClient client = null)
        {
            var options = new ReadEndUserTypeOptions() { PageSize = pageSize, Limit = limit };
            return Read(options, client);
        }

#if !NET35
        /// <summary> Retrieve a list of all End-User Types. </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of EndUserType </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<EndUserTypeResource>> ReadAsync(
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             IKandyRestClient client = null)
        {
            var options = new ReadEndUserTypeOptions() { PageSize = pageSize, Limit = limit };
            return await ReadAsync(options, client);
        }
#endif


        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The target page of records </returns>
        public static Page<EndUserTypeResource> GetPage(string targetUrl, IKandyRestClient client)
        {
            client = client ?? KandyClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<EndUserTypeResource>.FromJson("end_user_types", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The next page of records </returns>
        public static Page<EndUserTypeResource> NextPage(Page<EndUserTypeResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<EndUserTypeResource>.FromJson("end_user_types", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The previous page of records </returns>
        public static Page<EndUserTypeResource> PreviousPage(Page<EndUserTypeResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<EndUserTypeResource>.FromJson("end_user_types", response.Content);
        }


        /// <summary>
        /// Converts a JSON string into a EndUserTypeResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> EndUserTypeResource object represented by the provided JSON </returns>
        public static EndUserTypeResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<EndUserTypeResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> The unique string that identifies the End-User Type resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> A human-readable description that is assigned to describe the End-User Type resource. Examples can include first name, last name, email, business name, etc </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> A machine-readable description of the End-User Type resource. Examples can include first_name, last_name, email, business_name, etc. </summary> 
        [JsonProperty("machine_name")]
        public string MachineName { get; private set; }

        ///<summary> The required information for creating an End-User. The required fields will change as regulatory needs change and will differ for businesses and individuals. </summary> 
        [JsonProperty("fields")]
        public List<object> Fields { get; private set; }

        ///<summary> The absolute URL of the End-User Type resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private EndUserTypeResource()
        {

        }
    }
}
