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
using Kandy.Types;


namespace Kandy.Rest.Supersim.V1
{
    public class FleetResource : Resource
    {

        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class DataMeteringEnum : StringEnum
        {
            private DataMeteringEnum(string value) : base(value) { }
            public DataMeteringEnum() { }
            public static implicit operator DataMeteringEnum(string value)
            {
                return new DataMeteringEnum(value);
            }
            public static readonly DataMeteringEnum Payg = new DataMeteringEnum("payg");

        }


        private static Request BuildCreateRequest(CreateFleetOptions options, IKandyRestClient client)
        {

            string path = "/v1/Fleets";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Supersim,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Create a Fleet </summary>
        /// <param name="options"> Create Fleet parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Fleet </returns>
        public static FleetResource Create(CreateFleetOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> Create a Fleet </summary>
        /// <param name="options"> Create Fleet parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Fleet </returns>
        public static async System.Threading.Tasks.Task<FleetResource> CreateAsync(CreateFleetOptions options,
        IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> Create a Fleet </summary>
        /// <param name="networkAccessProfile"> The SID or unique name of the Network Access Profile that will control which cellular networks the Fleet's SIMs can connect to. </param>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the resource. It can be used in place of the resource's `sid` in the URL to address the resource. </param>
        /// <param name="dataEnabled"> Defines whether SIMs in the Fleet are capable of using 2G/3G/4G/LTE/CAT-M data connectivity. Defaults to `true`. </param>
        /// <param name="dataLimit"> The total data usage (download and upload combined) in Megabytes that each Super SIM assigned to the Fleet can consume during a billing period (normally one month). Value must be between 1MB (1) and 2TB (2,000,000). Defaults to 1GB (1,000). </param>
        /// <param name="ipCommandsUrl"> The URL that will receive a webhook when a Super SIM in the Fleet is used to send an IP Command from your device to a special IP address. Your server should respond with an HTTP status code in the 200 range; any response body will be ignored. </param>
        /// <param name="ipCommandsMethod"> A string representing the HTTP method to use when making a request to `ip_commands_url`. Can be one of `POST` or `GET`. Defaults to `POST`. </param>
        /// <param name="smsCommandsEnabled"> Defines whether SIMs in the Fleet are capable of sending and receiving machine-to-machine SMS via Commands. Defaults to `true`. </param>
        /// <param name="smsCommandsUrl"> The URL that will receive a webhook when a Super SIM in the Fleet is used to send an SMS from your device to the SMS Commands number. Your server should respond with an HTTP status code in the 200 range; any response body will be ignored. </param>
        /// <param name="smsCommandsMethod"> A string representing the HTTP method to use when making a request to `sms_commands_url`. Can be one of `POST` or `GET`. Defaults to `POST`. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Fleet </returns>
        public static FleetResource Create(
                                          string networkAccessProfile,
                                          string uniqueName = null,
                                          bool? dataEnabled = null,
                                          int? dataLimit = null,
                                          Uri ipCommandsUrl = null,
                                          Kandy.Http.HttpMethod ipCommandsMethod = null,
                                          bool? smsCommandsEnabled = null,
                                          Uri smsCommandsUrl = null,
                                          Kandy.Http.HttpMethod smsCommandsMethod = null,
                                          IKandyRestClient client = null)
        {
            var options = new CreateFleetOptions(networkAccessProfile) { UniqueName = uniqueName, DataEnabled = dataEnabled, DataLimit = dataLimit, IpCommandsUrl = ipCommandsUrl, IpCommandsMethod = ipCommandsMethod, SmsCommandsEnabled = smsCommandsEnabled, SmsCommandsUrl = smsCommandsUrl, SmsCommandsMethod = smsCommandsMethod };
            return Create(options, client);
        }

#if !NET35
        /// <summary> Create a Fleet </summary>
        /// <param name="networkAccessProfile"> The SID or unique name of the Network Access Profile that will control which cellular networks the Fleet's SIMs can connect to. </param>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the resource. It can be used in place of the resource's `sid` in the URL to address the resource. </param>
        /// <param name="dataEnabled"> Defines whether SIMs in the Fleet are capable of using 2G/3G/4G/LTE/CAT-M data connectivity. Defaults to `true`. </param>
        /// <param name="dataLimit"> The total data usage (download and upload combined) in Megabytes that each Super SIM assigned to the Fleet can consume during a billing period (normally one month). Value must be between 1MB (1) and 2TB (2,000,000). Defaults to 1GB (1,000). </param>
        /// <param name="ipCommandsUrl"> The URL that will receive a webhook when a Super SIM in the Fleet is used to send an IP Command from your device to a special IP address. Your server should respond with an HTTP status code in the 200 range; any response body will be ignored. </param>
        /// <param name="ipCommandsMethod"> A string representing the HTTP method to use when making a request to `ip_commands_url`. Can be one of `POST` or `GET`. Defaults to `POST`. </param>
        /// <param name="smsCommandsEnabled"> Defines whether SIMs in the Fleet are capable of sending and receiving machine-to-machine SMS via Commands. Defaults to `true`. </param>
        /// <param name="smsCommandsUrl"> The URL that will receive a webhook when a Super SIM in the Fleet is used to send an SMS from your device to the SMS Commands number. Your server should respond with an HTTP status code in the 200 range; any response body will be ignored. </param>
        /// <param name="smsCommandsMethod"> A string representing the HTTP method to use when making a request to `sms_commands_url`. Can be one of `POST` or `GET`. Defaults to `POST`. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Fleet </returns>
        public static async System.Threading.Tasks.Task<FleetResource> CreateAsync(
                                                                                  string networkAccessProfile,
                                                                                  string uniqueName = null,
                                                                                  bool? dataEnabled = null,
                                                                                  int? dataLimit = null,
                                                                                  Uri ipCommandsUrl = null,
                                                                                  Kandy.Http.HttpMethod ipCommandsMethod = null,
                                                                                  bool? smsCommandsEnabled = null,
                                                                                  Uri smsCommandsUrl = null,
                                                                                  Kandy.Http.HttpMethod smsCommandsMethod = null,
                                                                                  IKandyRestClient client = null)
        {
            var options = new CreateFleetOptions(networkAccessProfile) { UniqueName = uniqueName, DataEnabled = dataEnabled, DataLimit = dataLimit, IpCommandsUrl = ipCommandsUrl, IpCommandsMethod = ipCommandsMethod, SmsCommandsEnabled = smsCommandsEnabled, SmsCommandsUrl = smsCommandsUrl, SmsCommandsMethod = smsCommandsMethod };
            return await CreateAsync(options, client);
        }
#endif

        private static Request BuildFetchRequest(FetchFleetOptions options, IKandyRestClient client)
        {

            string path = "/v1/Fleets/{Sid}";

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

        /// <summary> Fetch a Fleet instance from your account. </summary>
        /// <param name="options"> Fetch Fleet parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Fleet </returns>
        public static FleetResource Fetch(FetchFleetOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> Fetch a Fleet instance from your account. </summary>
        /// <param name="options"> Fetch Fleet parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Fleet </returns>
        public static async System.Threading.Tasks.Task<FleetResource> FetchAsync(FetchFleetOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
#endif
        /// <summary> Fetch a Fleet instance from your account. </summary>
        /// <param name="pathSid"> The SID of the Fleet resource to fetch. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Fleet </returns>
        public static FleetResource Fetch(
                                         string pathSid,
                                         IKandyRestClient client = null)
        {
            var options = new FetchFleetOptions(pathSid) { };
            return Fetch(options, client);
        }

#if !NET35
        /// <summary> Fetch a Fleet instance from your account. </summary>
        /// <param name="pathSid"> The SID of the Fleet resource to fetch. </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Fleet </returns>
        public static async System.Threading.Tasks.Task<FleetResource> FetchAsync(string pathSid, IKandyRestClient client = null)
        {
            var options = new FetchFleetOptions(pathSid) { };
            return await FetchAsync(options, client);
        }
#endif

        private static Request BuildReadRequest(ReadFleetOptions options, IKandyRestClient client)
        {

            string path = "/v1/Fleets";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Supersim,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve a list of Fleets from your account. </summary>
        /// <param name="options"> Read Fleet parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Fleet </returns>
        public static ResourceSet<FleetResource> Read(ReadFleetOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<FleetResource>.FromJson("fleets", response.Content);
            return new ResourceSet<FleetResource>(page, options, client);
        }

#if !NET35
        /// <summary> Retrieve a list of Fleets from your account. </summary>
        /// <param name="options"> Read Fleet parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Fleet </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<FleetResource>> ReadAsync(ReadFleetOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<FleetResource>.FromJson("fleets", response.Content);
            return new ResourceSet<FleetResource>(page, options, client);
        }
#endif
        /// <summary> Retrieve a list of Fleets from your account. </summary>
        /// <param name="networkAccessProfile"> The SID or unique name of the Network Access Profile that controls which cellular networks the Fleet's SIMs can connect to. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Fleet </returns>
        public static ResourceSet<FleetResource> Read(
                                                     string networkAccessProfile = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     IKandyRestClient client = null)
        {
            var options = new ReadFleetOptions() { NetworkAccessProfile = networkAccessProfile, PageSize = pageSize, Limit = limit };
            return Read(options, client);
        }

#if !NET35
        /// <summary> Retrieve a list of Fleets from your account. </summary>
        /// <param name="networkAccessProfile"> The SID or unique name of the Network Access Profile that controls which cellular networks the Fleet's SIMs can connect to. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Fleet </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<FleetResource>> ReadAsync(
                                                                                             string networkAccessProfile = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             IKandyRestClient client = null)
        {
            var options = new ReadFleetOptions() { NetworkAccessProfile = networkAccessProfile, PageSize = pageSize, Limit = limit };
            return await ReadAsync(options, client);
        }
#endif


        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The target page of records </returns>
        public static Page<FleetResource> GetPage(string targetUrl, IKandyRestClient client)
        {
            client = client ?? KandyClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<FleetResource>.FromJson("fleets", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The next page of records </returns>
        public static Page<FleetResource> NextPage(Page<FleetResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<FleetResource>.FromJson("fleets", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The previous page of records </returns>
        public static Page<FleetResource> PreviousPage(Page<FleetResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<FleetResource>.FromJson("fleets", response.Content);
        }


        private static Request BuildUpdateRequest(UpdateFleetOptions options, IKandyRestClient client)
        {

            string path = "/v1/Fleets/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Supersim,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Updates the given properties of a Super SIM Fleet instance from your account. </summary>
        /// <param name="options"> Update Fleet parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Fleet </returns>
        public static FleetResource Update(UpdateFleetOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Updates the given properties of a Super SIM Fleet instance from your account. </summary>
        /// <param name="options"> Update Fleet parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Fleet </returns>
#if !NET35
        public static async System.Threading.Tasks.Task<FleetResource> UpdateAsync(UpdateFleetOptions options,
                                                                                                          IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> Updates the given properties of a Super SIM Fleet instance from your account. </summary>
        /// <param name="pathSid"> The SID of the Fleet resource to update. </param>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the resource. It can be used in place of the resource's `sid` in the URL to address the resource. </param>
        /// <param name="networkAccessProfile"> The SID or unique name of the Network Access Profile that will control which cellular networks the Fleet's SIMs can connect to. </param>
        /// <param name="ipCommandsUrl"> The URL that will receive a webhook when a Super SIM in the Fleet is used to send an IP Command from your device to a special IP address. Your server should respond with an HTTP status code in the 200 range; any response body will be ignored. </param>
        /// <param name="ipCommandsMethod"> A string representing the HTTP method to use when making a request to `ip_commands_url`. Can be one of `POST` or `GET`. Defaults to `POST`. </param>
        /// <param name="smsCommandsUrl"> The URL that will receive a webhook when a Super SIM in the Fleet is used to send an SMS from your device to the SMS Commands number. Your server should respond with an HTTP status code in the 200 range; any response body will be ignored. </param>
        /// <param name="smsCommandsMethod"> A string representing the HTTP method to use when making a request to `sms_commands_url`. Can be one of `POST` or `GET`. Defaults to `POST`. </param>
        /// <param name="dataLimit"> The total data usage (download and upload combined) in Megabytes that each Super SIM assigned to the Fleet can consume during a billing period (normally one month). Value must be between 1MB (1) and 2TB (2,000,000). Defaults to 1GB (1,000). </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Fleet </returns>
        public static FleetResource Update(
                                          string pathSid,
                                          string uniqueName = null,
                                          string networkAccessProfile = null,
                                          Uri ipCommandsUrl = null,
                                          Kandy.Http.HttpMethod ipCommandsMethod = null,
                                          Uri smsCommandsUrl = null,
                                          Kandy.Http.HttpMethod smsCommandsMethod = null,
                                          int? dataLimit = null,
                                          IKandyRestClient client = null)
        {
            var options = new UpdateFleetOptions(pathSid) { UniqueName = uniqueName, NetworkAccessProfile = networkAccessProfile, IpCommandsUrl = ipCommandsUrl, IpCommandsMethod = ipCommandsMethod, SmsCommandsUrl = smsCommandsUrl, SmsCommandsMethod = smsCommandsMethod, DataLimit = dataLimit };
            return Update(options, client);
        }

#if !NET35
        /// <summary> Updates the given properties of a Super SIM Fleet instance from your account. </summary>
        /// <param name="pathSid"> The SID of the Fleet resource to update. </param>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the resource. It can be used in place of the resource's `sid` in the URL to address the resource. </param>
        /// <param name="networkAccessProfile"> The SID or unique name of the Network Access Profile that will control which cellular networks the Fleet's SIMs can connect to. </param>
        /// <param name="ipCommandsUrl"> The URL that will receive a webhook when a Super SIM in the Fleet is used to send an IP Command from your device to a special IP address. Your server should respond with an HTTP status code in the 200 range; any response body will be ignored. </param>
        /// <param name="ipCommandsMethod"> A string representing the HTTP method to use when making a request to `ip_commands_url`. Can be one of `POST` or `GET`. Defaults to `POST`. </param>
        /// <param name="smsCommandsUrl"> The URL that will receive a webhook when a Super SIM in the Fleet is used to send an SMS from your device to the SMS Commands number. Your server should respond with an HTTP status code in the 200 range; any response body will be ignored. </param>
        /// <param name="smsCommandsMethod"> A string representing the HTTP method to use when making a request to `sms_commands_url`. Can be one of `POST` or `GET`. Defaults to `POST`. </param>
        /// <param name="dataLimit"> The total data usage (download and upload combined) in Megabytes that each Super SIM assigned to the Fleet can consume during a billing period (normally one month). Value must be between 1MB (1) and 2TB (2,000,000). Defaults to 1GB (1,000). </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Fleet </returns>
        public static async System.Threading.Tasks.Task<FleetResource> UpdateAsync(
                                                                              string pathSid,
                                                                              string uniqueName = null,
                                                                              string networkAccessProfile = null,
                                                                              Uri ipCommandsUrl = null,
                                                                              Kandy.Http.HttpMethod ipCommandsMethod = null,
                                                                              Uri smsCommandsUrl = null,
                                                                              Kandy.Http.HttpMethod smsCommandsMethod = null,
                                                                              int? dataLimit = null,
                                                                              IKandyRestClient client = null)
        {
            var options = new UpdateFleetOptions(pathSid) { UniqueName = uniqueName, NetworkAccessProfile = networkAccessProfile, IpCommandsUrl = ipCommandsUrl, IpCommandsMethod = ipCommandsMethod, SmsCommandsUrl = smsCommandsUrl, SmsCommandsMethod = smsCommandsMethod, DataLimit = dataLimit };
            return await UpdateAsync(options, client);
        }
#endif

        /// <summary>
        /// Converts a JSON string into a FleetResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> FleetResource object represented by the provided JSON </returns>
        public static FleetResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<FleetResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> The SID of the [Account](https://www.kandy.com/docs/iam/api/account) that created the Fleet resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The unique string that we created to identify the Fleet resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> An application-defined string that uniquely identifies the resource. It can be used in place of the resource's `sid` in the URL to address the resource. </summary> 
        [JsonProperty("unique_name")]
        public string UniqueName { get; private set; }

        ///<summary> The date and time in GMT when the resource was created specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT when the resource was last updated specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The absolute URL of the Fleet resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> Defines whether SIMs in the Fleet are capable of using 2G/3G/4G/LTE/CAT-M data connectivity. Defaults to `true`. </summary> 
        [JsonProperty("data_enabled")]
        public bool? DataEnabled { get; private set; }

        ///<summary> The total data usage (download and upload combined) in Megabytes that each Super SIM assigned to the Fleet can consume during a billing period (normally one month). Value must be between 1MB (1) and 2TB (2,000,000). Defaults to 250MB. </summary> 
        [JsonProperty("data_limit")]
        public int? DataLimit { get; private set; }


        [JsonProperty("data_metering")]
        public FleetResource.DataMeteringEnum DataMetering { get; private set; }

        ///<summary> Defines whether SIMs in the Fleet are capable of sending and receiving machine-to-machine SMS via Commands. Defaults to `false`. </summary> 
        [JsonProperty("sms_commands_enabled")]
        public bool? SmsCommandsEnabled { get; private set; }

        ///<summary> The URL that will receive a webhook when a Super SIM in the Fleet is used to send an SMS from your device to the SMS Commands number. Your server should respond with an HTTP status code in the 200 range; any response body will be ignored. </summary> 
        [JsonProperty("sms_commands_url")]
        public Uri SmsCommandsUrl { get; private set; }

        ///<summary> A string representing the HTTP method to use when making a request to `sms_commands_url`. Can be one of `POST` or `GET`. Defaults to `POST`. </summary> 
        [JsonProperty("sms_commands_method")]
        public Kandy.Http.HttpMethod SmsCommandsMethod { get; private set; }

        ///<summary> The SID of the Network Access Profile that controls which cellular networks the Fleet's SIMs can connect to. </summary> 
        [JsonProperty("network_access_profile_sid")]
        public string NetworkAccessProfileSid { get; private set; }

        ///<summary> The URL that will receive a webhook when a Super SIM in the Fleet is used to send an IP Command from your device to a special IP address. Your server should respond with an HTTP status code in the 200 range; any response body will be ignored. </summary> 
        [JsonProperty("ip_commands_url")]
        public Uri IpCommandsUrl { get; private set; }

        ///<summary> A string representing the HTTP method to use when making a request to `ip_commands_url`. Can be one of `POST` or `GET`. Defaults to `POST`. </summary> 
        [JsonProperty("ip_commands_method")]
        public Kandy.Http.HttpMethod IpCommandsMethod { get; private set; }



        private FleetResource()
        {

        }
    }
}
