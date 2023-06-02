/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Api
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



namespace Kandy.Rest.Api.V2010.Account
{
    public class AddressResource : Resource
    {



        private static Request BuildCreateRequest(CreateAddressOptions options, IKandyRestClient client)
        {

            string path = "/2010-04-01/Accounts/{AccountSid}/Addresses.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{" + "AccountSid" + "}", PathAccountSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> create </summary>
        /// <param name="options"> Create Address parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Address </returns>
        public static AddressResource Create(CreateAddressOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> create </summary>
        /// <param name="options"> Create Address parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Address </returns>
        public static async System.Threading.Tasks.Task<AddressResource> CreateAsync(CreateAddressOptions options,
        IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> create </summary>
        /// <param name="customerName"> The name to associate with the new address. </param>
        /// <param name="street"> The number and street address of the new address. </param>
        /// <param name="city"> The city of the new address. </param>
        /// <param name="region"> The state or region of the new address. </param>
        /// <param name="postalCode"> The postal code of the new address. </param>
        /// <param name="isoCountry"> The ISO country code of the new address. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that will be responsible for the new Address resource. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the new address. It can be up to 64 characters long. </param>
        /// <param name="emergencyEnabled"> Whether to enable emergency calling on the new address. Can be: `true` or `false`. </param>
        /// <param name="autoCorrectAddress"> Whether we should automatically correct the address. Can be: `true` or `false` and the default is `true`. If empty or `true`, we will correct the address you provide if necessary. If `false`, we won't alter the address you provide. </param>
        /// <param name="streetSecondary"> The additional number and street address of the address. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Address </returns>
        public static AddressResource Create(
                                          string customerName,
                                          string street,
                                          string city,
                                          string region,
                                          string postalCode,
                                          string isoCountry,
                                          string pathAccountSid = null,
                                          string friendlyName = null,
                                          bool? emergencyEnabled = null,
                                          bool? autoCorrectAddress = null,
                                          string streetSecondary = null,
                                          IKandyRestClient client = null)
        {
            var options = new CreateAddressOptions(customerName, street, city, region, postalCode, isoCountry) { PathAccountSid = pathAccountSid, FriendlyName = friendlyName, EmergencyEnabled = emergencyEnabled, AutoCorrectAddress = autoCorrectAddress, StreetSecondary = streetSecondary };
            return Create(options, client);
        }

#if !NET35
        /// <summary> create </summary>
        /// <param name="customerName"> The name to associate with the new address. </param>
        /// <param name="street"> The number and street address of the new address. </param>
        /// <param name="city"> The city of the new address. </param>
        /// <param name="region"> The state or region of the new address. </param>
        /// <param name="postalCode"> The postal code of the new address. </param>
        /// <param name="isoCountry"> The ISO country code of the new address. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that will be responsible for the new Address resource. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the new address. It can be up to 64 characters long. </param>
        /// <param name="emergencyEnabled"> Whether to enable emergency calling on the new address. Can be: `true` or `false`. </param>
        /// <param name="autoCorrectAddress"> Whether we should automatically correct the address. Can be: `true` or `false` and the default is `true`. If empty or `true`, we will correct the address you provide if necessary. If `false`, we won't alter the address you provide. </param>
        /// <param name="streetSecondary"> The additional number and street address of the address. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Address </returns>
        public static async System.Threading.Tasks.Task<AddressResource> CreateAsync(
                                                                                  string customerName,
                                                                                  string street,
                                                                                  string city,
                                                                                  string region,
                                                                                  string postalCode,
                                                                                  string isoCountry,
                                                                                  string pathAccountSid = null,
                                                                                  string friendlyName = null,
                                                                                  bool? emergencyEnabled = null,
                                                                                  bool? autoCorrectAddress = null,
                                                                                  string streetSecondary = null,
                                                                                  IKandyRestClient client = null)
        {
            var options = new CreateAddressOptions(customerName, street, city, region, postalCode, isoCountry) { PathAccountSid = pathAccountSid, FriendlyName = friendlyName, EmergencyEnabled = emergencyEnabled, AutoCorrectAddress = autoCorrectAddress, StreetSecondary = streetSecondary };
            return await CreateAsync(options, client);
        }
#endif

        /// <summary> delete </summary>
        /// <param name="options"> Delete Address parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Address </returns>
        private static Request BuildDeleteRequest(DeleteAddressOptions options, IKandyRestClient client)
        {

            string path = "/2010-04-01/Accounts/{AccountSid}/Addresses/{Sid}.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{" + "AccountSid" + "}", PathAccountSid);
            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Api,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> delete </summary>
        /// <param name="options"> Delete Address parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Address </returns>
        public static bool Delete(DeleteAddressOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

#if !NET35
        /// <summary> delete </summary>
        /// <param name="options"> Delete Address parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Address </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteAddressOptions options,
                                                                          IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
#endif

        /// <summary> delete </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Address resource to delete. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that is responsible for the Address resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Address </returns>
        public static bool Delete(string pathSid, string pathAccountSid = null, IKandyRestClient client = null)
        {
            var options = new DeleteAddressOptions(pathSid) { PathAccountSid = pathAccountSid };
            return Delete(options, client);
        }

#if !NET35
        /// <summary> delete </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Address resource to delete. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that is responsible for the Address resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Address </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, string pathAccountSid = null, IKandyRestClient client = null)
        {
            var options = new DeleteAddressOptions(pathSid) { PathAccountSid = pathAccountSid };
            return await DeleteAsync(options, client);
        }
#endif

        private static Request BuildFetchRequest(FetchAddressOptions options, IKandyRestClient client)
        {

            string path = "/2010-04-01/Accounts/{AccountSid}/Addresses/{Sid}.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{" + "AccountSid" + "}", PathAccountSid);
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

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Address parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Address </returns>
        public static AddressResource Fetch(FetchAddressOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Address parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Address </returns>
        public static async System.Threading.Tasks.Task<AddressResource> FetchAsync(FetchAddressOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
#endif
        /// <summary> fetch </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Address resource to fetch. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that is responsible for the Address resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Address </returns>
        public static AddressResource Fetch(
                                         string pathSid,
                                         string pathAccountSid = null,
                                         IKandyRestClient client = null)
        {
            var options = new FetchAddressOptions(pathSid) { PathAccountSid = pathAccountSid };
            return Fetch(options, client);
        }

#if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Address resource to fetch. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that is responsible for the Address resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Address </returns>
        public static async System.Threading.Tasks.Task<AddressResource> FetchAsync(string pathSid, string pathAccountSid = null, IKandyRestClient client = null)
        {
            var options = new FetchAddressOptions(pathSid) { PathAccountSid = pathAccountSid };
            return await FetchAsync(options, client);
        }
#endif

        private static Request BuildReadRequest(ReadAddressOptions options, IKandyRestClient client)
        {

            string path = "/2010-04-01/Accounts/{AccountSid}/Addresses.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{" + "AccountSid" + "}", PathAccountSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> read </summary>
        /// <param name="options"> Read Address parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Address </returns>
        public static ResourceSet<AddressResource> Read(ReadAddressOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<AddressResource>.FromJson("addresses", response.Content);
            return new ResourceSet<AddressResource>(page, options, client);
        }

#if !NET35
        /// <summary> read </summary>
        /// <param name="options"> Read Address parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Address </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<AddressResource>> ReadAsync(ReadAddressOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<AddressResource>.FromJson("addresses", response.Content);
            return new ResourceSet<AddressResource>(page, options, client);
        }
#endif
        /// <summary> read </summary>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that is responsible for the Address resource to read. </param>
        /// <param name="customerName"> The `customer_name` of the Address resources to read. </param>
        /// <param name="friendlyName"> The string that identifies the Address resources to read. </param>
        /// <param name="isoCountry"> The ISO country code of the Address resources to read. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Address </returns>
        public static ResourceSet<AddressResource> Read(
                                                     string pathAccountSid = null,
                                                     string customerName = null,
                                                     string friendlyName = null,
                                                     string isoCountry = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     IKandyRestClient client = null)
        {
            var options = new ReadAddressOptions() { PathAccountSid = pathAccountSid, CustomerName = customerName, FriendlyName = friendlyName, IsoCountry = isoCountry, PageSize = pageSize, Limit = limit };
            return Read(options, client);
        }

#if !NET35
        /// <summary> read </summary>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that is responsible for the Address resource to read. </param>
        /// <param name="customerName"> The `customer_name` of the Address resources to read. </param>
        /// <param name="friendlyName"> The string that identifies the Address resources to read. </param>
        /// <param name="isoCountry"> The ISO country code of the Address resources to read. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Address </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<AddressResource>> ReadAsync(
                                                                                             string pathAccountSid = null,
                                                                                             string customerName = null,
                                                                                             string friendlyName = null,
                                                                                             string isoCountry = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             IKandyRestClient client = null)
        {
            var options = new ReadAddressOptions() { PathAccountSid = pathAccountSid, CustomerName = customerName, FriendlyName = friendlyName, IsoCountry = isoCountry, PageSize = pageSize, Limit = limit };
            return await ReadAsync(options, client);
        }
#endif


        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<AddressResource> GetPage(string targetUrl, IKandyRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<AddressResource>.FromJson("addresses", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<AddressResource> NextPage(Page<AddressResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<AddressResource>.FromJson("addresses", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<AddressResource> PreviousPage(Page<AddressResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<AddressResource>.FromJson("addresses", response.Content);
        }


        private static Request BuildUpdateRequest(UpdateAddressOptions options, IKandyRestClient client)
        {

            string path = "/2010-04-01/Accounts/{AccountSid}/Addresses/{Sid}.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{" + "AccountSid" + "}", PathAccountSid);
            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> update </summary>
        /// <param name="options"> Update Address parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Address </returns>
        public static AddressResource Update(UpdateAddressOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> update </summary>
        /// <param name="options"> Update Address parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Address </returns>
#if !NET35
        public static async System.Threading.Tasks.Task<AddressResource> UpdateAsync(UpdateAddressOptions options,
                                                                                                          IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> update </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Address resource to update. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that is responsible for the Address resource to update. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the address. It can be up to 64 characters long. </param>
        /// <param name="customerName"> The name to associate with the address. </param>
        /// <param name="street"> The number and street address of the address. </param>
        /// <param name="city"> The city of the address. </param>
        /// <param name="region"> The state or region of the address. </param>
        /// <param name="postalCode"> The postal code of the address. </param>
        /// <param name="emergencyEnabled"> Whether to enable emergency calling on the address. Can be: `true` or `false`. </param>
        /// <param name="autoCorrectAddress"> Whether we should automatically correct the address. Can be: `true` or `false` and the default is `true`. If empty or `true`, we will correct the address you provide if necessary. If `false`, we won't alter the address you provide. </param>
        /// <param name="streetSecondary"> The additional number and street address of the address. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Address </returns>
        public static AddressResource Update(
                                          string pathSid,
                                          string pathAccountSid = null,
                                          string friendlyName = null,
                                          string customerName = null,
                                          string street = null,
                                          string city = null,
                                          string region = null,
                                          string postalCode = null,
                                          bool? emergencyEnabled = null,
                                          bool? autoCorrectAddress = null,
                                          string streetSecondary = null,
                                          IKandyRestClient client = null)
        {
            var options = new UpdateAddressOptions(pathSid) { PathAccountSid = pathAccountSid, FriendlyName = friendlyName, CustomerName = customerName, Street = street, City = city, Region = region, PostalCode = postalCode, EmergencyEnabled = emergencyEnabled, AutoCorrectAddress = autoCorrectAddress, StreetSecondary = streetSecondary };
            return Update(options, client);
        }

#if !NET35
        /// <summary> update </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Address resource to update. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that is responsible for the Address resource to update. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the address. It can be up to 64 characters long. </param>
        /// <param name="customerName"> The name to associate with the address. </param>
        /// <param name="street"> The number and street address of the address. </param>
        /// <param name="city"> The city of the address. </param>
        /// <param name="region"> The state or region of the address. </param>
        /// <param name="postalCode"> The postal code of the address. </param>
        /// <param name="emergencyEnabled"> Whether to enable emergency calling on the address. Can be: `true` or `false`. </param>
        /// <param name="autoCorrectAddress"> Whether we should automatically correct the address. Can be: `true` or `false` and the default is `true`. If empty or `true`, we will correct the address you provide if necessary. If `false`, we won't alter the address you provide. </param>
        /// <param name="streetSecondary"> The additional number and street address of the address. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Address </returns>
        public static async System.Threading.Tasks.Task<AddressResource> UpdateAsync(
                                                                              string pathSid,
                                                                              string pathAccountSid = null,
                                                                              string friendlyName = null,
                                                                              string customerName = null,
                                                                              string street = null,
                                                                              string city = null,
                                                                              string region = null,
                                                                              string postalCode = null,
                                                                              bool? emergencyEnabled = null,
                                                                              bool? autoCorrectAddress = null,
                                                                              string streetSecondary = null,
                                                                              IKandyRestClient client = null)
        {
            var options = new UpdateAddressOptions(pathSid) { PathAccountSid = pathAccountSid, FriendlyName = friendlyName, CustomerName = customerName, Street = street, City = city, Region = region, PostalCode = postalCode, EmergencyEnabled = emergencyEnabled, AutoCorrectAddress = autoCorrectAddress, StreetSecondary = streetSecondary };
            return await UpdateAsync(options, client);
        }
#endif

        /// <summary>
        /// Converts a JSON string into a AddressResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> AddressResource object represented by the provided JSON </returns>
        public static AddressResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<AddressResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that is responsible for the Address resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The city in which the address is located. </summary> 
        [JsonProperty("city")]
        public string City { get; private set; }

        ///<summary> The name associated with the address.This property has a maximum length of 16 4-byte characters, or 21 3-byte characters. </summary> 
        [JsonProperty("customer_name")]
        public string CustomerName { get; private set; }

        ///<summary> The date and time in GMT that the resource was created specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT that the resource was last updated specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The string that you assigned to describe the resource. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> The ISO country code of the address. </summary> 
        [JsonProperty("iso_country")]
        public string IsoCountry { get; private set; }

        ///<summary> The postal code of the address. </summary> 
        [JsonProperty("postal_code")]
        public string PostalCode { get; private set; }

        ///<summary> The state or region of the address. </summary> 
        [JsonProperty("region")]
        public string Region { get; private set; }

        ///<summary> The unique string that that we created to identify the Address resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The number and street address of the address. </summary> 
        [JsonProperty("street")]
        public string Street { get; private set; }

        ///<summary> The URI of the resource, relative to `https://api.twilio.com`. </summary> 
        [JsonProperty("uri")]
        public string Uri { get; private set; }

        ///<summary> Whether emergency calling has been enabled on this number. </summary> 
        [JsonProperty("emergency_enabled")]
        public bool? EmergencyEnabled { get; private set; }

        ///<summary> Whether the address has been validated to comply with local regulation. In countries that require valid addresses, an invalid address will not be accepted. `true` indicates the Address has been validated. `false` indicate the country doesn't require validation or the Address is not valid. </summary> 
        [JsonProperty("validated")]
        public bool? Validated { get; private set; }

        ///<summary> Whether the address has been verified to comply with regulation. In countries that require valid addresses, an invalid address will not be accepted. `true` indicates the Address has been verified. `false` indicate the country doesn't require verified or the Address is not valid. </summary> 
        [JsonProperty("verified")]
        public bool? Verified { get; private set; }

        ///<summary> The additional number and street address of the address. </summary> 
        [JsonProperty("street_secondary")]
        public string StreetSecondary { get; private set; }



        private AddressResource()
        {

        }
    }
}
