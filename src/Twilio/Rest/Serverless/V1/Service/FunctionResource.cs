/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Serverless
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



namespace Kandy.Rest.Serverless.V1.Service
{
    public class FunctionResource : Resource
    {



        private static Request BuildCreateRequest(CreateFunctionOptions options, IKandyRestClient client)
        {

            string path = "/v1/Services/{ServiceSid}/Functions";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{" + "ServiceSid" + "}", PathServiceSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Serverless,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Create a new Function resource. </summary>
        /// <param name="options"> Create Function parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Function </returns>
        public static FunctionResource Create(CreateFunctionOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> Create a new Function resource. </summary>
        /// <param name="options"> Create Function parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Function </returns>
        public static async System.Threading.Tasks.Task<FunctionResource> CreateAsync(CreateFunctionOptions options,
        IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> Create a new Function resource. </summary>
        /// <param name="pathServiceSid"> The SID of the Service to create the Function resource under. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the Function resource. It can be a maximum of 255 characters. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Function </returns>
        public static FunctionResource Create(
                                          string pathServiceSid,
                                          string friendlyName,
                                          IKandyRestClient client = null)
        {
            var options = new CreateFunctionOptions(pathServiceSid, friendlyName) { };
            return Create(options, client);
        }

#if !NET35
        /// <summary> Create a new Function resource. </summary>
        /// <param name="pathServiceSid"> The SID of the Service to create the Function resource under. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the Function resource. It can be a maximum of 255 characters. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Function </returns>
        public static async System.Threading.Tasks.Task<FunctionResource> CreateAsync(
                                                                                  string pathServiceSid,
                                                                                  string friendlyName,
                                                                                  IKandyRestClient client = null)
        {
            var options = new CreateFunctionOptions(pathServiceSid, friendlyName) { };
            return await CreateAsync(options, client);
        }
#endif

        /// <summary> Delete a Function resource. </summary>
        /// <param name="options"> Delete Function parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Function </returns>
        private static Request BuildDeleteRequest(DeleteFunctionOptions options, IKandyRestClient client)
        {

            string path = "/v1/Services/{ServiceSid}/Functions/{Sid}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{" + "ServiceSid" + "}", PathServiceSid);
            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Serverless,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Delete a Function resource. </summary>
        /// <param name="options"> Delete Function parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Function </returns>
        public static bool Delete(DeleteFunctionOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

#if !NET35
        /// <summary> Delete a Function resource. </summary>
        /// <param name="options"> Delete Function parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Function </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteFunctionOptions options,
                                                                          IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
#endif

        /// <summary> Delete a Function resource. </summary>
        /// <param name="pathServiceSid"> The SID of the Service to delete the Function resource from. </param>
        /// <param name="pathSid"> The SID of the Function resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Function </returns>
        public static bool Delete(string pathServiceSid, string pathSid, IKandyRestClient client = null)
        {
            var options = new DeleteFunctionOptions(pathServiceSid, pathSid);
            return Delete(options, client);
        }

#if !NET35
        /// <summary> Delete a Function resource. </summary>
        /// <param name="pathServiceSid"> The SID of the Service to delete the Function resource from. </param>
        /// <param name="pathSid"> The SID of the Function resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Function </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathServiceSid, string pathSid, IKandyRestClient client = null)
        {
            var options = new DeleteFunctionOptions(pathServiceSid, pathSid);
            return await DeleteAsync(options, client);
        }
#endif

        private static Request BuildFetchRequest(FetchFunctionOptions options, IKandyRestClient client)
        {

            string path = "/v1/Services/{ServiceSid}/Functions/{Sid}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{" + "ServiceSid" + "}", PathServiceSid);
            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Serverless,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Retrieve a specific Function resource. </summary>
        /// <param name="options"> Fetch Function parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Function </returns>
        public static FunctionResource Fetch(FetchFunctionOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> Retrieve a specific Function resource. </summary>
        /// <param name="options"> Fetch Function parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Function </returns>
        public static async System.Threading.Tasks.Task<FunctionResource> FetchAsync(FetchFunctionOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
#endif
        /// <summary> Retrieve a specific Function resource. </summary>
        /// <param name="pathServiceSid"> The SID of the Service to fetch the Function resource from. </param>
        /// <param name="pathSid"> The SID of the Function resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Function </returns>
        public static FunctionResource Fetch(
                                         string pathServiceSid,
                                         string pathSid,
                                         IKandyRestClient client = null)
        {
            var options = new FetchFunctionOptions(pathServiceSid, pathSid) { };
            return Fetch(options, client);
        }

#if !NET35
        /// <summary> Retrieve a specific Function resource. </summary>
        /// <param name="pathServiceSid"> The SID of the Service to fetch the Function resource from. </param>
        /// <param name="pathSid"> The SID of the Function resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Function </returns>
        public static async System.Threading.Tasks.Task<FunctionResource> FetchAsync(string pathServiceSid, string pathSid, IKandyRestClient client = null)
        {
            var options = new FetchFunctionOptions(pathServiceSid, pathSid) { };
            return await FetchAsync(options, client);
        }
#endif

        private static Request BuildReadRequest(ReadFunctionOptions options, IKandyRestClient client)
        {

            string path = "/v1/Services/{ServiceSid}/Functions";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{" + "ServiceSid" + "}", PathServiceSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Serverless,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of all Functions. </summary>
        /// <param name="options"> Read Function parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Function </returns>
        public static ResourceSet<FunctionResource> Read(ReadFunctionOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<FunctionResource>.FromJson("functions", response.Content);
            return new ResourceSet<FunctionResource>(page, options, client);
        }

#if !NET35
        /// <summary> Retrieve a list of all Functions. </summary>
        /// <param name="options"> Read Function parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Function </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<FunctionResource>> ReadAsync(ReadFunctionOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<FunctionResource>.FromJson("functions", response.Content);
            return new ResourceSet<FunctionResource>(page, options, client);
        }
#endif
        /// <summary> Retrieve a list of all Functions. </summary>
        /// <param name="pathServiceSid"> The SID of the Service to read the Function resources from. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Function </returns>
        public static ResourceSet<FunctionResource> Read(
                                                     string pathServiceSid,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     IKandyRestClient client = null)
        {
            var options = new ReadFunctionOptions(pathServiceSid) { PageSize = pageSize, Limit = limit };
            return Read(options, client);
        }

#if !NET35
        /// <summary> Retrieve a list of all Functions. </summary>
        /// <param name="pathServiceSid"> The SID of the Service to read the Function resources from. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Function </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<FunctionResource>> ReadAsync(
                                                                                             string pathServiceSid,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             IKandyRestClient client = null)
        {
            var options = new ReadFunctionOptions(pathServiceSid) { PageSize = pageSize, Limit = limit };
            return await ReadAsync(options, client);
        }
#endif


        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<FunctionResource> GetPage(string targetUrl, IKandyRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<FunctionResource>.FromJson("functions", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<FunctionResource> NextPage(Page<FunctionResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<FunctionResource>.FromJson("functions", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<FunctionResource> PreviousPage(Page<FunctionResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<FunctionResource>.FromJson("functions", response.Content);
        }


        private static Request BuildUpdateRequest(UpdateFunctionOptions options, IKandyRestClient client)
        {

            string path = "/v1/Services/{ServiceSid}/Functions/{Sid}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{" + "ServiceSid" + "}", PathServiceSid);
            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Serverless,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Update a specific Function resource. </summary>
        /// <param name="options"> Update Function parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Function </returns>
        public static FunctionResource Update(UpdateFunctionOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Update a specific Function resource. </summary>
        /// <param name="options"> Update Function parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Function </returns>
#if !NET35
        public static async System.Threading.Tasks.Task<FunctionResource> UpdateAsync(UpdateFunctionOptions options,
                                                                                                          IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> Update a specific Function resource. </summary>
        /// <param name="pathServiceSid"> The SID of the Service to update the Function resource from. </param>
        /// <param name="pathSid"> The SID of the Function resource to update. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the Function resource. It can be a maximum of 255 characters. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Function </returns>
        public static FunctionResource Update(
                                          string pathServiceSid,
                                          string pathSid,
                                          string friendlyName,
                                          IKandyRestClient client = null)
        {
            var options = new UpdateFunctionOptions(pathServiceSid, pathSid, friendlyName) { };
            return Update(options, client);
        }

#if !NET35
        /// <summary> Update a specific Function resource. </summary>
        /// <param name="pathServiceSid"> The SID of the Service to update the Function resource from. </param>
        /// <param name="pathSid"> The SID of the Function resource to update. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the Function resource. It can be a maximum of 255 characters. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Function </returns>
        public static async System.Threading.Tasks.Task<FunctionResource> UpdateAsync(
                                                                              string pathServiceSid,
                                                                              string pathSid,
                                                                              string friendlyName,
                                                                              IKandyRestClient client = null)
        {
            var options = new UpdateFunctionOptions(pathServiceSid, pathSid, friendlyName) { };
            return await UpdateAsync(options, client);
        }
#endif

        /// <summary>
        /// Converts a JSON string into a FunctionResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> FunctionResource object represented by the provided JSON </returns>
        public static FunctionResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<FunctionResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> The unique string that we created to identify the Function resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Function resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The SID of the Service that the Function resource is associated with. </summary> 
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }

        ///<summary> The string that you assigned to describe the Function resource. It can be a maximum of 255 characters. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> The date and time in GMT when the Function resource was created specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT when the Function resource was last updated specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The absolute URL of the Function resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The URLs of nested resources of the Function resource. </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }



        private FunctionResource()
        {

        }
    }
}
