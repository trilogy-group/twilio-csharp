/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Content
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



namespace Kandy.Rest.Content.V1
{
    public class ContentResource : Resource
    {



        /// <summary> Deletes a Content resource </summary>
        /// <param name="options"> Delete Content parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Content </returns>
        private static Request BuildDeleteRequest(DeleteContentOptions options, IKandyRestClient client)
        {

            string path = "/v1/Content/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Content,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Deletes a Content resource </summary>
        /// <param name="options"> Delete Content parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Content </returns>
        public static bool Delete(DeleteContentOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

#if !NET35
        /// <summary> Deletes a Content resource </summary>
        /// <param name="options"> Delete Content parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Content </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteContentOptions options,
                                                                          IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
#endif

        /// <summary> Deletes a Content resource </summary>
        /// <param name="pathSid"> The Kandy-provided string that uniquely identifies the Content resource to fetch. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Content </returns>
        public static bool Delete(string pathSid, IKandyRestClient client = null)
        {
            var options = new DeleteContentOptions(pathSid);
            return Delete(options, client);
        }

#if !NET35
        /// <summary> Deletes a Content resource </summary>
        /// <param name="pathSid"> The Kandy-provided string that uniquely identifies the Content resource to fetch. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Content </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, IKandyRestClient client = null)
        {
            var options = new DeleteContentOptions(pathSid);
            return await DeleteAsync(options, client);
        }
#endif

        private static Request BuildFetchRequest(FetchContentOptions options, IKandyRestClient client)
        {

            string path = "/v1/Content/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Content,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch a Content resource by its unique Content Sid </summary>
        /// <param name="options"> Fetch Content parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Content </returns>
        public static ContentResource Fetch(FetchContentOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> Fetch a Content resource by its unique Content Sid </summary>
        /// <param name="options"> Fetch Content parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Content </returns>
        public static async System.Threading.Tasks.Task<ContentResource> FetchAsync(FetchContentOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
#endif
        /// <summary> Fetch a Content resource by its unique Content Sid </summary>
        /// <param name="pathSid"> The Kandy-provided string that uniquely identifies the Content resource to fetch. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Content </returns>
        public static ContentResource Fetch(
                                         string pathSid,
                                         IKandyRestClient client = null)
        {
            var options = new FetchContentOptions(pathSid) { };
            return Fetch(options, client);
        }

#if !NET35
        /// <summary> Fetch a Content resource by its unique Content Sid </summary>
        /// <param name="pathSid"> The Kandy-provided string that uniquely identifies the Content resource to fetch. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Content </returns>
        public static async System.Threading.Tasks.Task<ContentResource> FetchAsync(string pathSid, IKandyRestClient client = null)
        {
            var options = new FetchContentOptions(pathSid) { };
            return await FetchAsync(options, client);
        }
#endif

        private static Request BuildReadRequest(ReadContentOptions options, IKandyRestClient client)
        {

            string path = "/v1/Content";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Content,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of Contents belonging to the account used to make the request </summary>
        /// <param name="options"> Read Content parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Content </returns>
        public static ResourceSet<ContentResource> Read(ReadContentOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<ContentResource>.FromJson("contents", response.Content);
            return new ResourceSet<ContentResource>(page, options, client);
        }

#if !NET35
        /// <summary> Retrieve a list of Contents belonging to the account used to make the request </summary>
        /// <param name="options"> Read Content parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Content </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<ContentResource>> ReadAsync(ReadContentOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<ContentResource>.FromJson("contents", response.Content);
            return new ResourceSet<ContentResource>(page, options, client);
        }
#endif
        /// <summary> Retrieve a list of Contents belonging to the account used to make the request </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Content </returns>
        public static ResourceSet<ContentResource> Read(
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     IKandyRestClient client = null)
        {
            var options = new ReadContentOptions() { PageSize = pageSize, Limit = limit };
            return Read(options, client);
        }

#if !NET35
        /// <summary> Retrieve a list of Contents belonging to the account used to make the request </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Content </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<ContentResource>> ReadAsync(
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             IKandyRestClient client = null)
        {
            var options = new ReadContentOptions() { PageSize = pageSize, Limit = limit };
            return await ReadAsync(options, client);
        }
#endif


        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The target page of records </returns>
        public static Page<ContentResource> GetPage(string targetUrl, IKandyRestClient client)
        {
            client = client ?? KandyClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<ContentResource>.FromJson("contents", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The next page of records </returns>
        public static Page<ContentResource> NextPage(Page<ContentResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<ContentResource>.FromJson("contents", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The previous page of records </returns>
        public static Page<ContentResource> PreviousPage(Page<ContentResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<ContentResource>.FromJson("contents", response.Content);
        }


        /// <summary>
        /// Converts a JSON string into a ContentResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ContentResource object represented by the provided JSON </returns>
        public static ContentResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<ContentResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> The date and time in GMT that the resource was created specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT that the resource was last updated specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The unique string that that we created to identify the Content resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the [Account](https://www.kandy.com/docs/usage/api/account) that created Content resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> A string name used to describe the Content resource. Not visible to the end recipient. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> Two-letter (ISO 639-1) language code (e.g., en) identifying the language the Content resource is in. </summary> 
        [JsonProperty("language")]
        public string Language { get; private set; }

        ///<summary> Defines the default placeholder values for variables included in the Content resource. e.g. {\"1\": \"Customer_Name\"}. </summary> 
        [JsonProperty("variables")]
        public object Variables { get; private set; }

        ///<summary> The [Content types](https://www.kandy.com/docs/content-api/content-types-overview) (e.g. kandy/text) for this Content resource. </summary> 
        [JsonProperty("types")]
        public object Types { get; private set; }

        ///<summary> The URL of the resource, relative to `https://content.kandy.com`. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> A list of links related to the Content resource, such as approval_fetch and approval_create </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }



        private ContentResource()
        {

        }
    }
}
