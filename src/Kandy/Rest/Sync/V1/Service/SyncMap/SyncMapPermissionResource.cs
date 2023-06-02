/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Sync
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



namespace Kandy.Rest.Sync.V1.Service.SyncMap
{
    public class SyncMapPermissionResource : Resource
    {



        /// <summary> Delete a specific Sync Map Permission. </summary>
        /// <param name="options"> Delete SyncMapPermission parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of SyncMapPermission </returns>
        private static Request BuildDeleteRequest(DeleteSyncMapPermissionOptions options, IKandyRestClient client)
        {

            string path = "/v1/Services/{ServiceSid}/Maps/{MapSid}/Permissions/{Identity}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{" + "ServiceSid" + "}", PathServiceSid);
            string PathMapSid = options.PathMapSid;
            path = path.Replace("{" + "MapSid" + "}", PathMapSid);
            string PathIdentity = options.PathIdentity;
            path = path.Replace("{" + "Identity" + "}", PathIdentity);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Sync,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Delete a specific Sync Map Permission. </summary>
        /// <param name="options"> Delete SyncMapPermission parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of SyncMapPermission </returns>
        public static bool Delete(DeleteSyncMapPermissionOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

#if !NET35
        /// <summary> Delete a specific Sync Map Permission. </summary>
        /// <param name="options"> Delete SyncMapPermission parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of SyncMapPermission </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteSyncMapPermissionOptions options,
                                                                          IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
#endif

        /// <summary> Delete a specific Sync Map Permission. </summary>
        /// <param name="pathServiceSid"> The SID of the [Sync Service](https://www.kandy.com/docs/sync/api/service) with the Sync Map Permission resource to delete. Can be the Service's `sid` value or `default`. </param>
        /// <param name="pathMapSid"> The SID of the Sync Map with the Sync Map Permission resource to delete. Can be the Sync Map resource's `sid` or its `unique_name`. </param>
        /// <param name="pathIdentity"> The application-defined string that uniquely identifies the User's Sync Map Permission resource to delete. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of SyncMapPermission </returns>
        public static bool Delete(string pathServiceSid, string pathMapSid, string pathIdentity, IKandyRestClient client = null)
        {
            var options = new DeleteSyncMapPermissionOptions(pathServiceSid, pathMapSid, pathIdentity);
            return Delete(options, client);
        }

#if !NET35
        /// <summary> Delete a specific Sync Map Permission. </summary>
        /// <param name="pathServiceSid"> The SID of the [Sync Service](https://www.kandy.com/docs/sync/api/service) with the Sync Map Permission resource to delete. Can be the Service's `sid` value or `default`. </param>
        /// <param name="pathMapSid"> The SID of the Sync Map with the Sync Map Permission resource to delete. Can be the Sync Map resource's `sid` or its `unique_name`. </param>
        /// <param name="pathIdentity"> The application-defined string that uniquely identifies the User's Sync Map Permission resource to delete. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of SyncMapPermission </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathServiceSid, string pathMapSid, string pathIdentity, IKandyRestClient client = null)
        {
            var options = new DeleteSyncMapPermissionOptions(pathServiceSid, pathMapSid, pathIdentity);
            return await DeleteAsync(options, client);
        }
#endif

        private static Request BuildFetchRequest(FetchSyncMapPermissionOptions options, IKandyRestClient client)
        {

            string path = "/v1/Services/{ServiceSid}/Maps/{MapSid}/Permissions/{Identity}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{" + "ServiceSid" + "}", PathServiceSid);
            string PathMapSid = options.PathMapSid;
            path = path.Replace("{" + "MapSid" + "}", PathMapSid);
            string PathIdentity = options.PathIdentity;
            path = path.Replace("{" + "Identity" + "}", PathIdentity);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Sync,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch a specific Sync Map Permission. </summary>
        /// <param name="options"> Fetch SyncMapPermission parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of SyncMapPermission </returns>
        public static SyncMapPermissionResource Fetch(FetchSyncMapPermissionOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> Fetch a specific Sync Map Permission. </summary>
        /// <param name="options"> Fetch SyncMapPermission parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of SyncMapPermission </returns>
        public static async System.Threading.Tasks.Task<SyncMapPermissionResource> FetchAsync(FetchSyncMapPermissionOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
#endif
        /// <summary> Fetch a specific Sync Map Permission. </summary>
        /// <param name="pathServiceSid"> The SID of the [Sync Service](https://www.kandy.com/docs/sync/api/service) with the Sync Map Permission resource to fetch. Can be the Service's `sid` value or `default`. </param>
        /// <param name="pathMapSid"> The SID of the Sync Map with the Sync Map Permission resource to fetch. Can be the Sync Map resource's `sid` or its `unique_name`. </param>
        /// <param name="pathIdentity"> The application-defined string that uniquely identifies the User's Sync Map Permission resource to fetch. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of SyncMapPermission </returns>
        public static SyncMapPermissionResource Fetch(
                                         string pathServiceSid,
                                         string pathMapSid,
                                         string pathIdentity,
                                         IKandyRestClient client = null)
        {
            var options = new FetchSyncMapPermissionOptions(pathServiceSid, pathMapSid, pathIdentity) { };
            return Fetch(options, client);
        }

#if !NET35
        /// <summary> Fetch a specific Sync Map Permission. </summary>
        /// <param name="pathServiceSid"> The SID of the [Sync Service](https://www.kandy.com/docs/sync/api/service) with the Sync Map Permission resource to fetch. Can be the Service's `sid` value or `default`. </param>
        /// <param name="pathMapSid"> The SID of the Sync Map with the Sync Map Permission resource to fetch. Can be the Sync Map resource's `sid` or its `unique_name`. </param>
        /// <param name="pathIdentity"> The application-defined string that uniquely identifies the User's Sync Map Permission resource to fetch. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of SyncMapPermission </returns>
        public static async System.Threading.Tasks.Task<SyncMapPermissionResource> FetchAsync(string pathServiceSid, string pathMapSid, string pathIdentity, IKandyRestClient client = null)
        {
            var options = new FetchSyncMapPermissionOptions(pathServiceSid, pathMapSid, pathIdentity) { };
            return await FetchAsync(options, client);
        }
#endif

        private static Request BuildReadRequest(ReadSyncMapPermissionOptions options, IKandyRestClient client)
        {

            string path = "/v1/Services/{ServiceSid}/Maps/{MapSid}/Permissions";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{" + "ServiceSid" + "}", PathServiceSid);
            string PathMapSid = options.PathMapSid;
            path = path.Replace("{" + "MapSid" + "}", PathMapSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Sync,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of all Permissions applying to a Sync Map. </summary>
        /// <param name="options"> Read SyncMapPermission parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of SyncMapPermission </returns>
        public static ResourceSet<SyncMapPermissionResource> Read(ReadSyncMapPermissionOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<SyncMapPermissionResource>.FromJson("permissions", response.Content);
            return new ResourceSet<SyncMapPermissionResource>(page, options, client);
        }

#if !NET35
        /// <summary> Retrieve a list of all Permissions applying to a Sync Map. </summary>
        /// <param name="options"> Read SyncMapPermission parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of SyncMapPermission </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<SyncMapPermissionResource>> ReadAsync(ReadSyncMapPermissionOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<SyncMapPermissionResource>.FromJson("permissions", response.Content);
            return new ResourceSet<SyncMapPermissionResource>(page, options, client);
        }
#endif
        /// <summary> Retrieve a list of all Permissions applying to a Sync Map. </summary>
        /// <param name="pathServiceSid"> The SID of the [Sync Service](https://www.kandy.com/docs/sync/api/service) with the Sync Map Permission resources to read. Can be the Service's `sid` value or `default`. </param>
        /// <param name="pathMapSid"> The SID of the Sync Map with the Permission resources to read. Can be the Sync Map resource's `sid` or its `unique_name`. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of SyncMapPermission </returns>
        public static ResourceSet<SyncMapPermissionResource> Read(
                                                     string pathServiceSid,
                                                     string pathMapSid,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     IKandyRestClient client = null)
        {
            var options = new ReadSyncMapPermissionOptions(pathServiceSid, pathMapSid) { PageSize = pageSize, Limit = limit };
            return Read(options, client);
        }

#if !NET35
        /// <summary> Retrieve a list of all Permissions applying to a Sync Map. </summary>
        /// <param name="pathServiceSid"> The SID of the [Sync Service](https://www.kandy.com/docs/sync/api/service) with the Sync Map Permission resources to read. Can be the Service's `sid` value or `default`. </param>
        /// <param name="pathMapSid"> The SID of the Sync Map with the Permission resources to read. Can be the Sync Map resource's `sid` or its `unique_name`. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of SyncMapPermission </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<SyncMapPermissionResource>> ReadAsync(
                                                                                             string pathServiceSid,
                                                                                             string pathMapSid,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             IKandyRestClient client = null)
        {
            var options = new ReadSyncMapPermissionOptions(pathServiceSid, pathMapSid) { PageSize = pageSize, Limit = limit };
            return await ReadAsync(options, client);
        }
#endif


        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The target page of records </returns>
        public static Page<SyncMapPermissionResource> GetPage(string targetUrl, IKandyRestClient client)
        {
            client = client ?? KandyClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<SyncMapPermissionResource>.FromJson("permissions", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The next page of records </returns>
        public static Page<SyncMapPermissionResource> NextPage(Page<SyncMapPermissionResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<SyncMapPermissionResource>.FromJson("permissions", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The previous page of records </returns>
        public static Page<SyncMapPermissionResource> PreviousPage(Page<SyncMapPermissionResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<SyncMapPermissionResource>.FromJson("permissions", response.Content);
        }


        private static Request BuildUpdateRequest(UpdateSyncMapPermissionOptions options, IKandyRestClient client)
        {

            string path = "/v1/Services/{ServiceSid}/Maps/{MapSid}/Permissions/{Identity}";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{" + "ServiceSid" + "}", PathServiceSid);
            string PathMapSid = options.PathMapSid;
            path = path.Replace("{" + "MapSid" + "}", PathMapSid);
            string PathIdentity = options.PathIdentity;
            path = path.Replace("{" + "Identity" + "}", PathIdentity);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Sync,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Update an identity's access to a specific Sync Map. </summary>
        /// <param name="options"> Update SyncMapPermission parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of SyncMapPermission </returns>
        public static SyncMapPermissionResource Update(UpdateSyncMapPermissionOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Update an identity's access to a specific Sync Map. </summary>
        /// <param name="options"> Update SyncMapPermission parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of SyncMapPermission </returns>
#if !NET35
        public static async System.Threading.Tasks.Task<SyncMapPermissionResource> UpdateAsync(UpdateSyncMapPermissionOptions options,
                                                                                                          IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> Update an identity's access to a specific Sync Map. </summary>
        /// <param name="pathServiceSid"> The SID of the [Sync Service](https://www.kandy.com/docs/sync/api/service) with the Sync Map Permission resource to update. Can be the Service's `sid` value or `default`. </param>
        /// <param name="pathMapSid"> The SID of the Sync Map with the Sync Map Permission resource to update. Can be the Sync Map resource's `sid` or its `unique_name`. </param>
        /// <param name="pathIdentity"> The application-defined string that uniquely identifies the User's Sync Map Permission resource to update. </param>
        /// <param name="read"> Whether the identity can read the Sync Map and its Items. Default value is `false`. </param>
        /// <param name="write"> Whether the identity can create, update, and delete Items in the Sync Map. Default value is `false`. </param>
        /// <param name="manage"> Whether the identity can delete the Sync Map. Default value is `false`. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of SyncMapPermission </returns>
        public static SyncMapPermissionResource Update(
                                          string pathServiceSid,
                                          string pathMapSid,
                                          string pathIdentity,
                                          bool? read,
                                          bool? write,
                                          bool? manage,
                                          IKandyRestClient client = null)
        {
            var options = new UpdateSyncMapPermissionOptions(pathServiceSid, pathMapSid, pathIdentity, read, write, manage) { };
            return Update(options, client);
        }

#if !NET35
        /// <summary> Update an identity's access to a specific Sync Map. </summary>
        /// <param name="pathServiceSid"> The SID of the [Sync Service](https://www.kandy.com/docs/sync/api/service) with the Sync Map Permission resource to update. Can be the Service's `sid` value or `default`. </param>
        /// <param name="pathMapSid"> The SID of the Sync Map with the Sync Map Permission resource to update. Can be the Sync Map resource's `sid` or its `unique_name`. </param>
        /// <param name="pathIdentity"> The application-defined string that uniquely identifies the User's Sync Map Permission resource to update. </param>
        /// <param name="read"> Whether the identity can read the Sync Map and its Items. Default value is `false`. </param>
        /// <param name="write"> Whether the identity can create, update, and delete Items in the Sync Map. Default value is `false`. </param>
        /// <param name="manage"> Whether the identity can delete the Sync Map. Default value is `false`. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of SyncMapPermission </returns>
        public static async System.Threading.Tasks.Task<SyncMapPermissionResource> UpdateAsync(
                                                                              string pathServiceSid,
                                                                              string pathMapSid,
                                                                              string pathIdentity,
                                                                              bool? read,
                                                                              bool? write,
                                                                              bool? manage,
                                                                              IKandyRestClient client = null)
        {
            var options = new UpdateSyncMapPermissionOptions(pathServiceSid, pathMapSid, pathIdentity, read, write, manage) { };
            return await UpdateAsync(options, client);
        }
#endif

        /// <summary>
        /// Converts a JSON string into a SyncMapPermissionResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> SyncMapPermissionResource object represented by the provided JSON </returns>
        public static SyncMapPermissionResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<SyncMapPermissionResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> The SID of the [Account](https://www.kandy.com/docs/iam/api/account) that created the Sync Map Permission resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The SID of the [Sync Service](https://www.kandy.com/docs/sync/api/service) the resource is associated with. </summary> 
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }

        ///<summary> The SID of the Sync Map to which the Permission applies. </summary> 
        [JsonProperty("map_sid")]
        public string MapSid { get; private set; }

        ///<summary> The application-defined string that uniquely identifies the resource's User within the Service to an FPA token. </summary> 
        [JsonProperty("identity")]
        public string Identity { get; private set; }

        ///<summary> Whether the identity can read the Sync Map and its Items. </summary> 
        [JsonProperty("read")]
        public bool? _Read { get; private set; }

        ///<summary> Whether the identity can create, update, and delete Items in the Sync Map. </summary> 
        [JsonProperty("write")]
        public bool? Write { get; private set; }

        ///<summary> Whether the identity can delete the Sync Map. </summary> 
        [JsonProperty("manage")]
        public bool? Manage { get; private set; }

        ///<summary> The absolute URL of the Sync Map Permission resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private SyncMapPermissionResource()
        {

        }
    }
}
