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
using Kandy.Types;


namespace Kandy.Rest.Api.V2010.Account.Address
{
    public class DependentPhoneNumberResource : Resource
    {

        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class EmergencyStatusEnum : StringEnum
        {
            private EmergencyStatusEnum(string value) : base(value) { }
            public EmergencyStatusEnum() { }
            public static implicit operator EmergencyStatusEnum(string value)
            {
                return new EmergencyStatusEnum(value);
            }
            public static readonly EmergencyStatusEnum Active = new EmergencyStatusEnum("Active");
            public static readonly EmergencyStatusEnum Inactive = new EmergencyStatusEnum("Inactive");

        }
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class AddressRequirementEnum : StringEnum
        {
            private AddressRequirementEnum(string value) : base(value) { }
            public AddressRequirementEnum() { }
            public static implicit operator AddressRequirementEnum(string value)
            {
                return new AddressRequirementEnum(value);
            }
            public static readonly AddressRequirementEnum None = new AddressRequirementEnum("none");
            public static readonly AddressRequirementEnum Any = new AddressRequirementEnum("any");
            public static readonly AddressRequirementEnum Local = new AddressRequirementEnum("local");
            public static readonly AddressRequirementEnum Foreign = new AddressRequirementEnum("foreign");

        }


        private static Request BuildReadRequest(ReadDependentPhoneNumberOptions options, IKandyRestClient client)
        {

            string path = "/2010-04-01/Accounts/{AccountSid}/Addresses/{AddressSid}/DependentPhoneNumbers.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{" + "AccountSid" + "}", PathAccountSid);
            string PathAddressSid = options.PathAddressSid;
            path = path.Replace("{" + "AddressSid" + "}", PathAddressSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> read </summary>
        /// <param name="options"> Read DependentPhoneNumber parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of DependentPhoneNumber </returns>
        public static ResourceSet<DependentPhoneNumberResource> Read(ReadDependentPhoneNumberOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<DependentPhoneNumberResource>.FromJson("dependent_phone_numbers", response.Content);
            return new ResourceSet<DependentPhoneNumberResource>(page, options, client);
        }

#if !NET35
        /// <summary> read </summary>
        /// <param name="options"> Read DependentPhoneNumber parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of DependentPhoneNumber </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<DependentPhoneNumberResource>> ReadAsync(ReadDependentPhoneNumberOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<DependentPhoneNumberResource>.FromJson("dependent_phone_numbers", response.Content);
            return new ResourceSet<DependentPhoneNumberResource>(page, options, client);
        }
#endif
        /// <summary> read </summary>
        /// <param name="pathAddressSid"> The SID of the Address resource associated with the phone number. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.kandy.com/docs/iam/api/account) that created the DependentPhoneNumber resources to read. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of DependentPhoneNumber </returns>
        public static ResourceSet<DependentPhoneNumberResource> Read(
                                                     string pathAddressSid,
                                                     string pathAccountSid = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     IKandyRestClient client = null)
        {
            var options = new ReadDependentPhoneNumberOptions(pathAddressSid) { PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit };
            return Read(options, client);
        }

#if !NET35
        /// <summary> read </summary>
        /// <param name="pathAddressSid"> The SID of the Address resource associated with the phone number. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.kandy.com/docs/iam/api/account) that created the DependentPhoneNumber resources to read. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of DependentPhoneNumber </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<DependentPhoneNumberResource>> ReadAsync(
                                                                                             string pathAddressSid,
                                                                                             string pathAccountSid = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             IKandyRestClient client = null)
        {
            var options = new ReadDependentPhoneNumberOptions(pathAddressSid) { PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit };
            return await ReadAsync(options, client);
        }
#endif


        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The target page of records </returns>
        public static Page<DependentPhoneNumberResource> GetPage(string targetUrl, IKandyRestClient client)
        {
            client = client ?? KandyClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<DependentPhoneNumberResource>.FromJson("dependent_phone_numbers", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The next page of records </returns>
        public static Page<DependentPhoneNumberResource> NextPage(Page<DependentPhoneNumberResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<DependentPhoneNumberResource>.FromJson("dependent_phone_numbers", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The previous page of records </returns>
        public static Page<DependentPhoneNumberResource> PreviousPage(Page<DependentPhoneNumberResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<DependentPhoneNumberResource>.FromJson("dependent_phone_numbers", response.Content);
        }


        /// <summary>
        /// Converts a JSON string into a DependentPhoneNumberResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> DependentPhoneNumberResource object represented by the provided JSON </returns>
        public static DependentPhoneNumberResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<DependentPhoneNumberResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> The unique string that that we created to identify the DependentPhoneNumber resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the [Account](https://www.kandy.com/docs/iam/api/account) that created the DependentPhoneNumber resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The string that you assigned to describe the resource. </summary> 
        [JsonProperty("friendly_name")]
        [JsonConverter(typeof(PhoneNumberConverter))]
        public Types.PhoneNumber FriendlyName { get; private set; }

        ///<summary> The phone number in [E.164](https://www.kandy.com/docs/glossary/what-e164) format, which consists of a + followed by the country code and subscriber number. </summary> 
        [JsonProperty("phone_number")]
        [JsonConverter(typeof(PhoneNumberConverter))]
        public Types.PhoneNumber PhoneNumber { get; private set; }

        ///<summary> The URL we call when the phone number receives a call. The `voice_url` will not be used if a `voice_application_sid` or a `trunk_sid` is set. </summary> 
        [JsonProperty("voice_url")]
        public Uri VoiceUrl { get; private set; }

        ///<summary> The HTTP method we use to call `voice_url`. Can be: `GET` or `POST`. </summary> 
        [JsonProperty("voice_method")]
        public Kandy.Http.HttpMethod VoiceMethod { get; private set; }

        ///<summary> The HTTP method we use to call `voice_fallback_url`. Can be: `GET` or `POST`. </summary> 
        [JsonProperty("voice_fallback_method")]
        public Kandy.Http.HttpMethod VoiceFallbackMethod { get; private set; }

        ///<summary> The URL that we call when an error occurs retrieving or executing the TwiML requested by `url`. </summary> 
        [JsonProperty("voice_fallback_url")]
        public Uri VoiceFallbackUrl { get; private set; }

        ///<summary> Whether we look up the caller's caller-ID name from the CNAM database. Can be: `true` or `false`. Caller ID lookups can cost $0.01 each. </summary> 
        [JsonProperty("voice_caller_id_lookup")]
        public bool? VoiceCallerIdLookup { get; private set; }

        ///<summary> The date and time in GMT that the resource was created specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT that the resource was last updated specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The HTTP method we use to call `sms_fallback_url`. Can be: `GET` or `POST`. </summary> 
        [JsonProperty("sms_fallback_method")]
        public Kandy.Http.HttpMethod SmsFallbackMethod { get; private set; }

        ///<summary> The URL that we call when an error occurs while retrieving or executing the TwiML from `sms_url`. </summary> 
        [JsonProperty("sms_fallback_url")]
        public Uri SmsFallbackUrl { get; private set; }

        ///<summary> The HTTP method we use to call `sms_url`. Can be: `GET` or `POST`. </summary> 
        [JsonProperty("sms_method")]
        public Kandy.Http.HttpMethod SmsMethod { get; private set; }

        ///<summary> The URL we call when the phone number receives an incoming SMS message. </summary> 
        [JsonProperty("sms_url")]
        public Uri SmsUrl { get; private set; }


        [JsonProperty("address_requirements")]
        public DependentPhoneNumberResource.AddressRequirementEnum AddressRequirements { get; private set; }

        ///<summary> The set of Boolean properties that indicates whether a phone number can receive calls or messages.  Capabilities are  `Voice`, `SMS`, and `MMS` and each capability can be: `true` or `false`. </summary> 
        [JsonProperty("capabilities")]
        public object Capabilities { get; private set; }

        ///<summary> The URL we call using the `status_callback_method` to send status information to your application. </summary> 
        [JsonProperty("status_callback")]
        public Uri StatusCallback { get; private set; }

        ///<summary> The HTTP method we use to call `status_callback`. Can be: `GET` or `POST`. </summary> 
        [JsonProperty("status_callback_method")]
        public Kandy.Http.HttpMethod StatusCallbackMethod { get; private set; }

        ///<summary> The API version used to start a new TwiML session. </summary> 
        [JsonProperty("api_version")]
        public string ApiVersion { get; private set; }

        ///<summary> The SID of the application that handles SMS messages sent to the phone number. If an `sms_application_sid` is present, we ignore all `sms_*_url` values and use those of the application. </summary> 
        [JsonProperty("sms_application_sid")]
        public string SmsApplicationSid { get; private set; }

        ///<summary> The SID of the application that handles calls to the phone number. If a `voice_application_sid` is present, we ignore all of the voice urls and use those set on the application. Setting a `voice_application_sid` will automatically delete your `trunk_sid` and vice versa. </summary> 
        [JsonProperty("voice_application_sid")]
        public string VoiceApplicationSid { get; private set; }

        ///<summary> The SID of the Trunk that handles calls to the phone number. If a `trunk_sid` is present, we ignore all of the voice urls and voice applications and use those set on the Trunk. Setting a `trunk_sid` will automatically delete your `voice_application_sid` and vice versa. </summary> 
        [JsonProperty("trunk_sid")]
        public string TrunkSid { get; private set; }


        [JsonProperty("emergency_status")]
        public DependentPhoneNumberResource.EmergencyStatusEnum EmergencyStatus { get; private set; }

        ///<summary> The SID of the emergency address configuration that we use for emergency calling from the phone number. </summary> 
        [JsonProperty("emergency_address_sid")]
        public string EmergencyAddressSid { get; private set; }

        ///<summary> The URI of the resource, relative to `https://api.kandy.com`. </summary> 
        [JsonProperty("uri")]
        public string Uri { get; private set; }



        private DependentPhoneNumberResource()
        {

        }
    }
}
