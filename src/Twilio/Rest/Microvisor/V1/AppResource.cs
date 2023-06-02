/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Microvisor
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



namespace Kandy.Rest.Microvisor.V1
{
    public class AppResource : Resource
    {



        /// <summary> Delete a specific App. </summary>
        /// <param name="options"> Delete App parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of App </returns>
        private static Request BuildDeleteRequest(DeleteAppOptions options, IKandyRestClient client)
        {

            string path = "/v1/Apps/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Microvisor,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Delete a specific App. </summary>
        /// <param name="options"> Delete App parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of App </returns>
        public static bool Delete(DeleteAppOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

#if !NET35
        /// <summary> Delete a specific App. </summary>
        /// <param name="options"> Delete App parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of App </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteAppOptions options,
                                                                          IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
#endif

        /// <summary> Delete a specific App. </summary>
        /// <param name="pathSid"> A 34-character string that uniquely identifies this App. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of App </returns>
        public static bool Delete(string pathSid, IKandyRestClient client = null)
        {
            var options = new DeleteAppOptions(pathSid);
            return Delete(options, client);
        }

#if !NET35
        /// <summary> Delete a specific App. </summary>
        /// <param name="pathSid"> A 34-character string that uniquely identifies this App. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of App </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, IKandyRestClient client = null)
        {
            var options = new DeleteAppOptions(pathSid);
            return await DeleteAsync(options, client);
        }
#endif

        private static Request BuildFetchRequest(FetchAppOptions options, IKandyRestClient client)
        {

            string path = "/v1/Apps/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Microvisor,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch a specific App. </summary>
        /// <param name="options"> Fetch App parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of App </returns>
        public static AppResource Fetch(FetchAppOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> Fetch a specific App. </summary>
        /// <param name="options"> Fetch App parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of App </returns>
        public static async System.Threading.Tasks.Task<AppResource> FetchAsync(FetchAppOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
#endif
        /// <summary> Fetch a specific App. </summary>
        /// <param name="pathSid"> A 34-character string that uniquely identifies this App. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of App </returns>
        public static AppResource Fetch(
                                         string pathSid,
                                         IKandyRestClient client = null)
        {
            var options = new FetchAppOptions(pathSid) { };
            return Fetch(options, client);
        }

#if !NET35
        /// <summary> Fetch a specific App. </summary>
        /// <param name="pathSid"> A 34-character string that uniquely identifies this App. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of App </returns>
        public static async System.Threading.Tasks.Task<AppResource> FetchAsync(string pathSid, IKandyRestClient client = null)
        {
            var options = new FetchAppOptions(pathSid) { };
            return await FetchAsync(options, client);
        }
#endif

        private static Request BuildReadRequest(ReadAppOptions options, IKandyRestClient client)
        {

            string path = "/v1/Apps";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Microvisor,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of all Apps for an Account. </summary>
        /// <param name="options"> Read App parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of App </returns>
        public static ResourceSet<AppResource> Read(ReadAppOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<AppResource>.FromJson("apps", response.Content);
            return new ResourceSet<AppResource>(page, options, client);
        }

#if !NET35
        /// <summary> Retrieve a list of all Apps for an Account. </summary>
        /// <param name="options"> Read App parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of App </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<AppResource>> ReadAsync(ReadAppOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<AppResource>.FromJson("apps", response.Content);
            return new ResourceSet<AppResource>(page, options, client);
        }
#endif
        /// <summary> Retrieve a list of all Apps for an Account. </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of App </returns>
        public static ResourceSet<AppResource> Read(
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     IKandyRestClient client = null)
        {
            var options = new ReadAppOptions() { PageSize = pageSize, Limit = limit };
            return Read(options, client);
        }

#if !NET35
        /// <summary> Retrieve a list of all Apps for an Account. </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of App </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<AppResource>> ReadAsync(
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             IKandyRestClient client = null)
        {
            var options = new ReadAppOptions() { PageSize = pageSize, Limit = limit };
            return await ReadAsync(options, client);
        }
#endif


        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<AppResource> GetPage(string targetUrl, IKandyRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<AppResource>.FromJson("apps", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<AppResource> NextPage(Page<AppResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<AppResource>.FromJson("apps", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<AppResource> PreviousPage(Page<AppResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<AppResource>.FromJson("apps", response.Content);
        }


        /// <summary>
        /// Converts a JSON string into a AppResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> AppResource object represented by the provided JSON </returns>
        public static AppResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<AppResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> A 34-character string that uniquely identifies this App. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The unique SID identifier of the Account. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> App manifest hash represented as `hash_algorithm:hash_value`. </summary> 
        [JsonProperty("hash")]
        public string Hash { get; private set; }

        ///<summary> A developer-defined string that uniquely identifies the App. This value must be unique for all Apps on this Account. The `unique_name` value may be used as an alternative to the `sid` in the URL path to address the resource. </summary> 
        [JsonProperty("unique_name")]
        public string UniqueName { get; private set; }

        ///<summary> The date that this App was created, given in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date that this App was last updated, given in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The URL of this resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The links </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }



        private AppResource()
        {

        }
    }
}
