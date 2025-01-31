/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Microvisor
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



namespace Kandy.Rest.Microvisor.V1.Device
{
    public class DeviceConfigResource : Resource
    {



        private static Request BuildCreateRequest(CreateDeviceConfigOptions options, IKandyRestClient client)
        {

            string path = "/v1/Devices/{DeviceSid}/Configs";

            string PathDeviceSid = options.PathDeviceSid;
            path = path.Replace("{" + "DeviceSid" + "}", PathDeviceSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Microvisor,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Create a config for a Microvisor Device. </summary>
        /// <param name="options"> Create DeviceConfig parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of DeviceConfig </returns>
        public static DeviceConfigResource Create(CreateDeviceConfigOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> Create a config for a Microvisor Device. </summary>
        /// <param name="options"> Create DeviceConfig parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of DeviceConfig </returns>
        public static async System.Threading.Tasks.Task<DeviceConfigResource> CreateAsync(CreateDeviceConfigOptions options,
        IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> Create a config for a Microvisor Device. </summary>
        /// <param name="pathDeviceSid"> A 34-character string that uniquely identifies the Device. </param>
        /// <param name="key"> The config key; up to 100 characters. </param>
        /// <param name="value"> The config value; up to 4096 characters. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of DeviceConfig </returns>
        public static DeviceConfigResource Create(
                                          string pathDeviceSid,
                                          string key,
                                          string value,
                                          IKandyRestClient client = null)
        {
            var options = new CreateDeviceConfigOptions(pathDeviceSid, key, value) { };
            return Create(options, client);
        }

#if !NET35
        /// <summary> Create a config for a Microvisor Device. </summary>
        /// <param name="pathDeviceSid"> A 34-character string that uniquely identifies the Device. </param>
        /// <param name="key"> The config key; up to 100 characters. </param>
        /// <param name="value"> The config value; up to 4096 characters. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of DeviceConfig </returns>
        public static async System.Threading.Tasks.Task<DeviceConfigResource> CreateAsync(
                                                                                  string pathDeviceSid,
                                                                                  string key,
                                                                                  string value,
                                                                                  IKandyRestClient client = null)
        {
            var options = new CreateDeviceConfigOptions(pathDeviceSid, key, value) { };
            return await CreateAsync(options, client);
        }
#endif

        /// <summary> Delete a config for a Microvisor Device. </summary>
        /// <param name="options"> Delete DeviceConfig parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of DeviceConfig </returns>
        private static Request BuildDeleteRequest(DeleteDeviceConfigOptions options, IKandyRestClient client)
        {

            string path = "/v1/Devices/{DeviceSid}/Configs/{Key}";

            string PathDeviceSid = options.PathDeviceSid;
            path = path.Replace("{" + "DeviceSid" + "}", PathDeviceSid);
            string PathKey = options.PathKey;
            path = path.Replace("{" + "Key" + "}", PathKey);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Microvisor,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Delete a config for a Microvisor Device. </summary>
        /// <param name="options"> Delete DeviceConfig parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of DeviceConfig </returns>
        public static bool Delete(DeleteDeviceConfigOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

#if !NET35
        /// <summary> Delete a config for a Microvisor Device. </summary>
        /// <param name="options"> Delete DeviceConfig parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of DeviceConfig </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteDeviceConfigOptions options,
                                                                          IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
#endif

        /// <summary> Delete a config for a Microvisor Device. </summary>
        /// <param name="pathDeviceSid"> A 34-character string that uniquely identifies the Device. </param>
        /// <param name="pathKey"> The config key; up to 100 characters. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of DeviceConfig </returns>
        public static bool Delete(string pathDeviceSid, string pathKey, IKandyRestClient client = null)
        {
            var options = new DeleteDeviceConfigOptions(pathDeviceSid, pathKey);
            return Delete(options, client);
        }

#if !NET35
        /// <summary> Delete a config for a Microvisor Device. </summary>
        /// <param name="pathDeviceSid"> A 34-character string that uniquely identifies the Device. </param>
        /// <param name="pathKey"> The config key; up to 100 characters. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of DeviceConfig </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathDeviceSid, string pathKey, IKandyRestClient client = null)
        {
            var options = new DeleteDeviceConfigOptions(pathDeviceSid, pathKey);
            return await DeleteAsync(options, client);
        }
#endif

        private static Request BuildFetchRequest(FetchDeviceConfigOptions options, IKandyRestClient client)
        {

            string path = "/v1/Devices/{DeviceSid}/Configs/{Key}";

            string PathDeviceSid = options.PathDeviceSid;
            path = path.Replace("{" + "DeviceSid" + "}", PathDeviceSid);
            string PathKey = options.PathKey;
            path = path.Replace("{" + "Key" + "}", PathKey);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Microvisor,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Retrieve a Config for a Device. </summary>
        /// <param name="options"> Fetch DeviceConfig parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of DeviceConfig </returns>
        public static DeviceConfigResource Fetch(FetchDeviceConfigOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> Retrieve a Config for a Device. </summary>
        /// <param name="options"> Fetch DeviceConfig parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of DeviceConfig </returns>
        public static async System.Threading.Tasks.Task<DeviceConfigResource> FetchAsync(FetchDeviceConfigOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
#endif
        /// <summary> Retrieve a Config for a Device. </summary>
        /// <param name="pathDeviceSid"> A 34-character string that uniquely identifies the Device. </param>
        /// <param name="pathKey"> The config key; up to 100 characters. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of DeviceConfig </returns>
        public static DeviceConfigResource Fetch(
                                         string pathDeviceSid,
                                         string pathKey,
                                         IKandyRestClient client = null)
        {
            var options = new FetchDeviceConfigOptions(pathDeviceSid, pathKey) { };
            return Fetch(options, client);
        }

#if !NET35
        /// <summary> Retrieve a Config for a Device. </summary>
        /// <param name="pathDeviceSid"> A 34-character string that uniquely identifies the Device. </param>
        /// <param name="pathKey"> The config key; up to 100 characters. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of DeviceConfig </returns>
        public static async System.Threading.Tasks.Task<DeviceConfigResource> FetchAsync(string pathDeviceSid, string pathKey, IKandyRestClient client = null)
        {
            var options = new FetchDeviceConfigOptions(pathDeviceSid, pathKey) { };
            return await FetchAsync(options, client);
        }
#endif

        private static Request BuildReadRequest(ReadDeviceConfigOptions options, IKandyRestClient client)
        {

            string path = "/v1/Devices/{DeviceSid}/Configs";

            string PathDeviceSid = options.PathDeviceSid;
            path = path.Replace("{" + "DeviceSid" + "}", PathDeviceSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Microvisor,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of all Configs for a Device. </summary>
        /// <param name="options"> Read DeviceConfig parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of DeviceConfig </returns>
        public static ResourceSet<DeviceConfigResource> Read(ReadDeviceConfigOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<DeviceConfigResource>.FromJson("configs", response.Content);
            return new ResourceSet<DeviceConfigResource>(page, options, client);
        }

#if !NET35
        /// <summary> Retrieve a list of all Configs for a Device. </summary>
        /// <param name="options"> Read DeviceConfig parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of DeviceConfig </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<DeviceConfigResource>> ReadAsync(ReadDeviceConfigOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<DeviceConfigResource>.FromJson("configs", response.Content);
            return new ResourceSet<DeviceConfigResource>(page, options, client);
        }
#endif
        /// <summary> Retrieve a list of all Configs for a Device. </summary>
        /// <param name="pathDeviceSid"> A 34-character string that uniquely identifies the Device. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of DeviceConfig </returns>
        public static ResourceSet<DeviceConfigResource> Read(
                                                     string pathDeviceSid,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     IKandyRestClient client = null)
        {
            var options = new ReadDeviceConfigOptions(pathDeviceSid) { PageSize = pageSize, Limit = limit };
            return Read(options, client);
        }

#if !NET35
        /// <summary> Retrieve a list of all Configs for a Device. </summary>
        /// <param name="pathDeviceSid"> A 34-character string that uniquely identifies the Device. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of DeviceConfig </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<DeviceConfigResource>> ReadAsync(
                                                                                             string pathDeviceSid,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             IKandyRestClient client = null)
        {
            var options = new ReadDeviceConfigOptions(pathDeviceSid) { PageSize = pageSize, Limit = limit };
            return await ReadAsync(options, client);
        }
#endif


        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The target page of records </returns>
        public static Page<DeviceConfigResource> GetPage(string targetUrl, IKandyRestClient client)
        {
            client = client ?? KandyClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<DeviceConfigResource>.FromJson("configs", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The next page of records </returns>
        public static Page<DeviceConfigResource> NextPage(Page<DeviceConfigResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<DeviceConfigResource>.FromJson("configs", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The previous page of records </returns>
        public static Page<DeviceConfigResource> PreviousPage(Page<DeviceConfigResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<DeviceConfigResource>.FromJson("configs", response.Content);
        }


        private static Request BuildUpdateRequest(UpdateDeviceConfigOptions options, IKandyRestClient client)
        {

            string path = "/v1/Devices/{DeviceSid}/Configs/{Key}";

            string PathDeviceSid = options.PathDeviceSid;
            path = path.Replace("{" + "DeviceSid" + "}", PathDeviceSid);
            string PathKey = options.PathKey;
            path = path.Replace("{" + "Key" + "}", PathKey);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Microvisor,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Update a config for a Microvisor Device. </summary>
        /// <param name="options"> Update DeviceConfig parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of DeviceConfig </returns>
        public static DeviceConfigResource Update(UpdateDeviceConfigOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Update a config for a Microvisor Device. </summary>
        /// <param name="options"> Update DeviceConfig parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of DeviceConfig </returns>
#if !NET35
        public static async System.Threading.Tasks.Task<DeviceConfigResource> UpdateAsync(UpdateDeviceConfigOptions options,
                                                                                                          IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> Update a config for a Microvisor Device. </summary>
        /// <param name="pathDeviceSid"> A 34-character string that uniquely identifies the Device. </param>
        /// <param name="pathKey"> The config key; up to 100 characters. </param>
        /// <param name="value"> The config value; up to 4096 characters. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of DeviceConfig </returns>
        public static DeviceConfigResource Update(
                                          string pathDeviceSid,
                                          string pathKey,
                                          string value,
                                          IKandyRestClient client = null)
        {
            var options = new UpdateDeviceConfigOptions(pathDeviceSid, pathKey, value) { };
            return Update(options, client);
        }

#if !NET35
        /// <summary> Update a config for a Microvisor Device. </summary>
        /// <param name="pathDeviceSid"> A 34-character string that uniquely identifies the Device. </param>
        /// <param name="pathKey"> The config key; up to 100 characters. </param>
        /// <param name="value"> The config value; up to 4096 characters. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of DeviceConfig </returns>
        public static async System.Threading.Tasks.Task<DeviceConfigResource> UpdateAsync(
                                                                              string pathDeviceSid,
                                                                              string pathKey,
                                                                              string value,
                                                                              IKandyRestClient client = null)
        {
            var options = new UpdateDeviceConfigOptions(pathDeviceSid, pathKey, value) { };
            return await UpdateAsync(options, client);
        }
#endif

        /// <summary>
        /// Converts a JSON string into a DeviceConfigResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> DeviceConfigResource object represented by the provided JSON </returns>
        public static DeviceConfigResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<DeviceConfigResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> A 34-character string that uniquely identifies the parent Device. </summary> 
        [JsonProperty("device_sid")]
        public string DeviceSid { get; private set; }

        ///<summary> The config key; up to 100 characters. </summary> 
        [JsonProperty("key")]
        public string Key { get; private set; }

        ///<summary> The config value; up to 4096 characters. </summary> 
        [JsonProperty("value")]
        public string Value { get; private set; }

        ///<summary> The date_updated </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The absolute URL of the Config. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private DeviceConfigResource()
        {

        }
    }
}
