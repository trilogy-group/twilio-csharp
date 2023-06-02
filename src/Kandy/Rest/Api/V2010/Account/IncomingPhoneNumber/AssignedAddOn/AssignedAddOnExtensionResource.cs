/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Api
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



namespace Kandy.Rest.Api.V2010.Account.IncomingPhoneNumber.AssignedAddOn
{
    public class AssignedAddOnExtensionResource : Resource
    {



        private static Request BuildFetchRequest(FetchAssignedAddOnExtensionOptions options, IKandyRestClient client)
        {

            string path = "/2010-04-01/Accounts/{AccountSid}/IncomingPhoneNumbers/{ResourceSid}/AssignedAddOns/{AssignedAddOnSid}/Extensions/{Sid}.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{" + "AccountSid" + "}", PathAccountSid);
            string PathResourceSid = options.PathResourceSid;
            path = path.Replace("{" + "ResourceSid" + "}", PathResourceSid);
            string PathAssignedAddOnSid = options.PathAssignedAddOnSid;
            path = path.Replace("{" + "AssignedAddOnSid" + "}", PathAssignedAddOnSid);
            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch an instance of an Extension for the Assigned Add-on. </summary>
        /// <param name="options"> Fetch AssignedAddOnExtension parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of AssignedAddOnExtension </returns>
        public static AssignedAddOnExtensionResource Fetch(FetchAssignedAddOnExtensionOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> Fetch an instance of an Extension for the Assigned Add-on. </summary>
        /// <param name="options"> Fetch AssignedAddOnExtension parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of AssignedAddOnExtension </returns>
        public static async System.Threading.Tasks.Task<AssignedAddOnExtensionResource> FetchAsync(FetchAssignedAddOnExtensionOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
#endif
        /// <summary> Fetch an instance of an Extension for the Assigned Add-on. </summary>
        /// <param name="pathResourceSid"> The SID of the Phone Number to which the Add-on is assigned. </param>
        /// <param name="pathAssignedAddOnSid"> The SID that uniquely identifies the assigned Add-on installation. </param>
        /// <param name="pathSid"> The Kandy-provided string that uniquely identifies the resource to fetch. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.kandy.com/docs/iam/api/account) that created the resource to fetch. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of AssignedAddOnExtension </returns>
        public static AssignedAddOnExtensionResource Fetch(
                                         string pathResourceSid,
                                         string pathAssignedAddOnSid,
                                         string pathSid,
                                         string pathAccountSid = null,
                                         IKandyRestClient client = null)
        {
            var options = new FetchAssignedAddOnExtensionOptions(pathResourceSid, pathAssignedAddOnSid, pathSid) { PathAccountSid = pathAccountSid };
            return Fetch(options, client);
        }

#if !NET35
        /// <summary> Fetch an instance of an Extension for the Assigned Add-on. </summary>
        /// <param name="pathResourceSid"> The SID of the Phone Number to which the Add-on is assigned. </param>
        /// <param name="pathAssignedAddOnSid"> The SID that uniquely identifies the assigned Add-on installation. </param>
        /// <param name="pathSid"> The Kandy-provided string that uniquely identifies the resource to fetch. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.kandy.com/docs/iam/api/account) that created the resource to fetch. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of AssignedAddOnExtension </returns>
        public static async System.Threading.Tasks.Task<AssignedAddOnExtensionResource> FetchAsync(string pathResourceSid, string pathAssignedAddOnSid, string pathSid, string pathAccountSid = null, IKandyRestClient client = null)
        {
            var options = new FetchAssignedAddOnExtensionOptions(pathResourceSid, pathAssignedAddOnSid, pathSid) { PathAccountSid = pathAccountSid };
            return await FetchAsync(options, client);
        }
#endif

        private static Request BuildReadRequest(ReadAssignedAddOnExtensionOptions options, IKandyRestClient client)
        {

            string path = "/2010-04-01/Accounts/{AccountSid}/IncomingPhoneNumbers/{ResourceSid}/AssignedAddOns/{AssignedAddOnSid}/Extensions.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{" + "AccountSid" + "}", PathAccountSid);
            string PathResourceSid = options.PathResourceSid;
            path = path.Replace("{" + "ResourceSid" + "}", PathResourceSid);
            string PathAssignedAddOnSid = options.PathAssignedAddOnSid;
            path = path.Replace("{" + "AssignedAddOnSid" + "}", PathAssignedAddOnSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of Extensions for the Assigned Add-on. </summary>
        /// <param name="options"> Read AssignedAddOnExtension parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of AssignedAddOnExtension </returns>
        public static ResourceSet<AssignedAddOnExtensionResource> Read(ReadAssignedAddOnExtensionOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<AssignedAddOnExtensionResource>.FromJson("extensions", response.Content);
            return new ResourceSet<AssignedAddOnExtensionResource>(page, options, client);
        }

#if !NET35
        /// <summary> Retrieve a list of Extensions for the Assigned Add-on. </summary>
        /// <param name="options"> Read AssignedAddOnExtension parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of AssignedAddOnExtension </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<AssignedAddOnExtensionResource>> ReadAsync(ReadAssignedAddOnExtensionOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<AssignedAddOnExtensionResource>.FromJson("extensions", response.Content);
            return new ResourceSet<AssignedAddOnExtensionResource>(page, options, client);
        }
#endif
        /// <summary> Retrieve a list of Extensions for the Assigned Add-on. </summary>
        /// <param name="pathResourceSid"> The SID of the Phone Number to which the Add-on is assigned. </param>
        /// <param name="pathAssignedAddOnSid"> The SID that uniquely identifies the assigned Add-on installation. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.kandy.com/docs/iam/api/account) that created the resources to read. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of AssignedAddOnExtension </returns>
        public static ResourceSet<AssignedAddOnExtensionResource> Read(
                                                     string pathResourceSid,
                                                     string pathAssignedAddOnSid,
                                                     string pathAccountSid = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     IKandyRestClient client = null)
        {
            var options = new ReadAssignedAddOnExtensionOptions(pathResourceSid, pathAssignedAddOnSid) { PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit };
            return Read(options, client);
        }

#if !NET35
        /// <summary> Retrieve a list of Extensions for the Assigned Add-on. </summary>
        /// <param name="pathResourceSid"> The SID of the Phone Number to which the Add-on is assigned. </param>
        /// <param name="pathAssignedAddOnSid"> The SID that uniquely identifies the assigned Add-on installation. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.kandy.com/docs/iam/api/account) that created the resources to read. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of AssignedAddOnExtension </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<AssignedAddOnExtensionResource>> ReadAsync(
                                                                                             string pathResourceSid,
                                                                                             string pathAssignedAddOnSid,
                                                                                             string pathAccountSid = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             IKandyRestClient client = null)
        {
            var options = new ReadAssignedAddOnExtensionOptions(pathResourceSid, pathAssignedAddOnSid) { PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit };
            return await ReadAsync(options, client);
        }
#endif


        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The target page of records </returns>
        public static Page<AssignedAddOnExtensionResource> GetPage(string targetUrl, IKandyRestClient client)
        {
            client = client ?? KandyClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<AssignedAddOnExtensionResource>.FromJson("extensions", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The next page of records </returns>
        public static Page<AssignedAddOnExtensionResource> NextPage(Page<AssignedAddOnExtensionResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<AssignedAddOnExtensionResource>.FromJson("extensions", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The previous page of records </returns>
        public static Page<AssignedAddOnExtensionResource> PreviousPage(Page<AssignedAddOnExtensionResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<AssignedAddOnExtensionResource>.FromJson("extensions", response.Content);
        }


        /// <summary>
        /// Converts a JSON string into a AssignedAddOnExtensionResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> AssignedAddOnExtensionResource object represented by the provided JSON </returns>
        public static AssignedAddOnExtensionResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<AssignedAddOnExtensionResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> The unique string that that we created to identify the resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the [Account](https://www.kandy.com/docs/iam/api/account) that created the resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The SID of the Phone Number to which the Add-on is assigned. </summary> 
        [JsonProperty("resource_sid")]
        public string ResourceSid { get; private set; }

        ///<summary> The SID that uniquely identifies the assigned Add-on installation. </summary> 
        [JsonProperty("assigned_add_on_sid")]
        public string AssignedAddOnSid { get; private set; }

        ///<summary> The string that you assigned to describe the resource. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> A string that you assigned to describe the Product this Extension is used within. </summary> 
        [JsonProperty("product_name")]
        public string ProductName { get; private set; }

        ///<summary> An application-defined string that uniquely identifies the resource. It can be used in place of the resource's `sid` in the URL to address the resource. </summary> 
        [JsonProperty("unique_name")]
        public string UniqueName { get; private set; }

        ///<summary> The URI of the resource, relative to `https://api.kandy.com`. </summary> 
        [JsonProperty("uri")]
        public string Uri { get; private set; }

        ///<summary> Whether the Extension will be invoked. </summary> 
        [JsonProperty("enabled")]
        public bool? Enabled { get; private set; }



        private AssignedAddOnExtensionResource()
        {

        }
    }
}
