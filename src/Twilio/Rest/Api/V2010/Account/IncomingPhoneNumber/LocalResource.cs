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
using Twilio.Types;


namespace Kandy.Rest.Api.V2010.Account.IncomingPhoneNumber
{
    public class LocalResource : Resource
    {
    
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class EmergencyStatusEnum : StringEnum
        {
            private EmergencyStatusEnum(string value) : base(value) {}
            public EmergencyStatusEnum() {}
            public static implicit operator EmergencyStatusEnum(string value)
            {
                return new EmergencyStatusEnum(value);
            }
            public static readonly EmergencyStatusEnum Active = new EmergencyStatusEnum("Active");
            public static readonly EmergencyStatusEnum Inactive = new EmergencyStatusEnum("Inactive");

        }
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class EmergencyAddressStatusEnum : StringEnum
        {
            private EmergencyAddressStatusEnum(string value) : base(value) {}
            public EmergencyAddressStatusEnum() {}
            public static implicit operator EmergencyAddressStatusEnum(string value)
            {
                return new EmergencyAddressStatusEnum(value);
            }
            public static readonly EmergencyAddressStatusEnum Registered = new EmergencyAddressStatusEnum("registered");
            public static readonly EmergencyAddressStatusEnum Unregistered = new EmergencyAddressStatusEnum("unregistered");
            public static readonly EmergencyAddressStatusEnum PendingRegistration = new EmergencyAddressStatusEnum("pending-registration");
            public static readonly EmergencyAddressStatusEnum RegistrationFailure = new EmergencyAddressStatusEnum("registration-failure");
            public static readonly EmergencyAddressStatusEnum PendingUnregistration = new EmergencyAddressStatusEnum("pending-unregistration");
            public static readonly EmergencyAddressStatusEnum UnregistrationFailure = new EmergencyAddressStatusEnum("unregistration-failure");

        }
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class VoiceReceiveModeEnum : StringEnum
        {
            private VoiceReceiveModeEnum(string value) : base(value) {}
            public VoiceReceiveModeEnum() {}
            public static implicit operator VoiceReceiveModeEnum(string value)
            {
                return new VoiceReceiveModeEnum(value);
            }
            public static readonly VoiceReceiveModeEnum Voice = new VoiceReceiveModeEnum("voice");
            public static readonly VoiceReceiveModeEnum Fax = new VoiceReceiveModeEnum("fax");

        }
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class AddressRequirementEnum : StringEnum
        {
            private AddressRequirementEnum(string value) : base(value) {}
            public AddressRequirementEnum() {}
            public static implicit operator AddressRequirementEnum(string value)
            {
                return new AddressRequirementEnum(value);
            }
            public static readonly AddressRequirementEnum None = new AddressRequirementEnum("none");
            public static readonly AddressRequirementEnum Any = new AddressRequirementEnum("any");
            public static readonly AddressRequirementEnum Local = new AddressRequirementEnum("local");
            public static readonly AddressRequirementEnum Foreign = new AddressRequirementEnum("foreign");

        }

        
        private static Request BuildCreateRequest(CreateLocalOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/IncomingPhoneNumbers/Local.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{"+"AccountSid"+"}", PathAccountSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> create </summary>
        /// <param name="options"> Create Local parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Local </returns>
        public static LocalResource Create(CreateLocalOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="options"> Create Local parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Local </returns>
        public static async System.Threading.Tasks.Task<LocalResource> CreateAsync(CreateLocalOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> create </summary>
        /// <param name="phoneNumber"> The phone number to purchase specified in [E.164](https://www.twilio.com/docs/glossary/what-e164) format.  E.164 phone numbers consist of a + followed by the country code and subscriber number without punctuation characters. For example, +14155551234. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that will create the resource. </param>
        /// <param name="apiVersion"> The API version to use for incoming calls made to the new phone number. The default is `2010-04-01`. </param>
        /// <param name="friendlyName"> A descriptive string that you created to describe the new phone number. It can be up to 64 characters long. By default, this is a formatted version of the phone number. </param>
        /// <param name="smsApplicationSid"> The SID of the application that should handle SMS messages sent to the new phone number. If an `sms_application_sid` is present, we ignore all of the `sms_*_url` urls and use those set on the application. </param>
        /// <param name="smsFallbackMethod"> The HTTP method that we should use to call `sms_fallback_url`. Can be: `GET` or `POST` and defaults to `POST`. </param>
        /// <param name="smsFallbackUrl"> The URL that we should call when an error occurs while requesting or executing the TwiML defined by `sms_url`. </param>
        /// <param name="smsMethod"> The HTTP method that we should use to call `sms_url`. Can be: `GET` or `POST` and defaults to `POST`. </param>
        /// <param name="smsUrl"> The URL we should call when the new phone number receives an incoming SMS message. </param>
        /// <param name="statusCallback"> The URL we should call using the `status_callback_method` to send status information to your application. </param>
        /// <param name="statusCallbackMethod"> The HTTP method we should use to call `status_callback`. Can be: `GET` or `POST` and defaults to `POST`. </param>
        /// <param name="voiceApplicationSid"> The SID of the application we should use to handle calls to the new phone number. If a `voice_application_sid` is present, we ignore all of the voice urls and use only those set on the application. Setting a `voice_application_sid` will automatically delete your `trunk_sid` and vice versa. </param>
        /// <param name="voiceCallerIdLookup"> Whether to lookup the caller's name from the CNAM database and post it to your app. Can be: `true` or `false` and defaults to `false`. </param>
        /// <param name="voiceFallbackMethod"> The HTTP method that we should use to call `voice_fallback_url`. Can be: `GET` or `POST` and defaults to `POST`. </param>
        /// <param name="voiceFallbackUrl"> The URL that we should call when an error occurs retrieving or executing the TwiML requested by `url`. </param>
        /// <param name="voiceMethod"> The HTTP method that we should use to call `voice_url`. Can be: `GET` or `POST` and defaults to `POST`. </param>
        /// <param name="voiceUrl"> The URL that we should call to answer a call to the new phone number. The `voice_url` will not be called if a `voice_application_sid` or a `trunk_sid` is set. </param>
        /// <param name="identitySid"> The SID of the Identity resource that we should associate with the new phone number. Some regions require an identity to meet local regulations. </param>
        /// <param name="addressSid"> The SID of the Address resource we should associate with the new phone number. Some regions require addresses to meet local regulations. </param>
        /// <param name="emergencyStatus">  </param>
        /// <param name="emergencyAddressSid"> The SID of the emergency address configuration to use for emergency calling from the new phone number. </param>
        /// <param name="trunkSid"> The SID of the Trunk we should use to handle calls to the new phone number. If a `trunk_sid` is present, we ignore all of the voice urls and voice applications and use only those set on the Trunk. Setting a `trunk_sid` will automatically delete your `voice_application_sid` and vice versa. </param>
        /// <param name="voiceReceiveMode">  </param>
        /// <param name="bundleSid"> The SID of the Bundle resource that you associate with the phone number. Some regions require a Bundle to meet local Regulations. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Local </returns>
        public static LocalResource Create(
                                          Types.PhoneNumber phoneNumber,
                                          string pathAccountSid = null,
                                          string apiVersion = null,
                                          string friendlyName = null,
                                          string smsApplicationSid = null,
                                          Twilio.Http.HttpMethod smsFallbackMethod = null,
                                          Uri smsFallbackUrl = null,
                                          Twilio.Http.HttpMethod smsMethod = null,
                                          Uri smsUrl = null,
                                          Uri statusCallback = null,
                                          Twilio.Http.HttpMethod statusCallbackMethod = null,
                                          string voiceApplicationSid = null,
                                          bool? voiceCallerIdLookup = null,
                                          Twilio.Http.HttpMethod voiceFallbackMethod = null,
                                          Uri voiceFallbackUrl = null,
                                          Twilio.Http.HttpMethod voiceMethod = null,
                                          Uri voiceUrl = null,
                                          string identitySid = null,
                                          string addressSid = null,
                                          LocalResource.EmergencyStatusEnum emergencyStatus = null,
                                          string emergencyAddressSid = null,
                                          string trunkSid = null,
                                          LocalResource.VoiceReceiveModeEnum voiceReceiveMode = null,
                                          string bundleSid = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateLocalOptions(phoneNumber){  PathAccountSid = pathAccountSid, ApiVersion = apiVersion, FriendlyName = friendlyName, SmsApplicationSid = smsApplicationSid, SmsFallbackMethod = smsFallbackMethod, SmsFallbackUrl = smsFallbackUrl, SmsMethod = smsMethod, SmsUrl = smsUrl, StatusCallback = statusCallback, StatusCallbackMethod = statusCallbackMethod, VoiceApplicationSid = voiceApplicationSid, VoiceCallerIdLookup = voiceCallerIdLookup, VoiceFallbackMethod = voiceFallbackMethod, VoiceFallbackUrl = voiceFallbackUrl, VoiceMethod = voiceMethod, VoiceUrl = voiceUrl, IdentitySid = identitySid, AddressSid = addressSid, EmergencyStatus = emergencyStatus, EmergencyAddressSid = emergencyAddressSid, TrunkSid = trunkSid, VoiceReceiveMode = voiceReceiveMode, BundleSid = bundleSid };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="phoneNumber"> The phone number to purchase specified in [E.164](https://www.twilio.com/docs/glossary/what-e164) format.  E.164 phone numbers consist of a + followed by the country code and subscriber number without punctuation characters. For example, +14155551234. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that will create the resource. </param>
        /// <param name="apiVersion"> The API version to use for incoming calls made to the new phone number. The default is `2010-04-01`. </param>
        /// <param name="friendlyName"> A descriptive string that you created to describe the new phone number. It can be up to 64 characters long. By default, this is a formatted version of the phone number. </param>
        /// <param name="smsApplicationSid"> The SID of the application that should handle SMS messages sent to the new phone number. If an `sms_application_sid` is present, we ignore all of the `sms_*_url` urls and use those set on the application. </param>
        /// <param name="smsFallbackMethod"> The HTTP method that we should use to call `sms_fallback_url`. Can be: `GET` or `POST` and defaults to `POST`. </param>
        /// <param name="smsFallbackUrl"> The URL that we should call when an error occurs while requesting or executing the TwiML defined by `sms_url`. </param>
        /// <param name="smsMethod"> The HTTP method that we should use to call `sms_url`. Can be: `GET` or `POST` and defaults to `POST`. </param>
        /// <param name="smsUrl"> The URL we should call when the new phone number receives an incoming SMS message. </param>
        /// <param name="statusCallback"> The URL we should call using the `status_callback_method` to send status information to your application. </param>
        /// <param name="statusCallbackMethod"> The HTTP method we should use to call `status_callback`. Can be: `GET` or `POST` and defaults to `POST`. </param>
        /// <param name="voiceApplicationSid"> The SID of the application we should use to handle calls to the new phone number. If a `voice_application_sid` is present, we ignore all of the voice urls and use only those set on the application. Setting a `voice_application_sid` will automatically delete your `trunk_sid` and vice versa. </param>
        /// <param name="voiceCallerIdLookup"> Whether to lookup the caller's name from the CNAM database and post it to your app. Can be: `true` or `false` and defaults to `false`. </param>
        /// <param name="voiceFallbackMethod"> The HTTP method that we should use to call `voice_fallback_url`. Can be: `GET` or `POST` and defaults to `POST`. </param>
        /// <param name="voiceFallbackUrl"> The URL that we should call when an error occurs retrieving or executing the TwiML requested by `url`. </param>
        /// <param name="voiceMethod"> The HTTP method that we should use to call `voice_url`. Can be: `GET` or `POST` and defaults to `POST`. </param>
        /// <param name="voiceUrl"> The URL that we should call to answer a call to the new phone number. The `voice_url` will not be called if a `voice_application_sid` or a `trunk_sid` is set. </param>
        /// <param name="identitySid"> The SID of the Identity resource that we should associate with the new phone number. Some regions require an identity to meet local regulations. </param>
        /// <param name="addressSid"> The SID of the Address resource we should associate with the new phone number. Some regions require addresses to meet local regulations. </param>
        /// <param name="emergencyStatus">  </param>
        /// <param name="emergencyAddressSid"> The SID of the emergency address configuration to use for emergency calling from the new phone number. </param>
        /// <param name="trunkSid"> The SID of the Trunk we should use to handle calls to the new phone number. If a `trunk_sid` is present, we ignore all of the voice urls and voice applications and use only those set on the Trunk. Setting a `trunk_sid` will automatically delete your `voice_application_sid` and vice versa. </param>
        /// <param name="voiceReceiveMode">  </param>
        /// <param name="bundleSid"> The SID of the Bundle resource that you associate with the phone number. Some regions require a Bundle to meet local Regulations. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Local </returns>
        public static async System.Threading.Tasks.Task<LocalResource> CreateAsync(
                                                                                  Types.PhoneNumber phoneNumber,
                                                                                  string pathAccountSid = null,
                                                                                  string apiVersion = null,
                                                                                  string friendlyName = null,
                                                                                  string smsApplicationSid = null,
                                                                                  Twilio.Http.HttpMethod smsFallbackMethod = null,
                                                                                  Uri smsFallbackUrl = null,
                                                                                  Twilio.Http.HttpMethod smsMethod = null,
                                                                                  Uri smsUrl = null,
                                                                                  Uri statusCallback = null,
                                                                                  Twilio.Http.HttpMethod statusCallbackMethod = null,
                                                                                  string voiceApplicationSid = null,
                                                                                  bool? voiceCallerIdLookup = null,
                                                                                  Twilio.Http.HttpMethod voiceFallbackMethod = null,
                                                                                  Uri voiceFallbackUrl = null,
                                                                                  Twilio.Http.HttpMethod voiceMethod = null,
                                                                                  Uri voiceUrl = null,
                                                                                  string identitySid = null,
                                                                                  string addressSid = null,
                                                                                  LocalResource.EmergencyStatusEnum emergencyStatus = null,
                                                                                  string emergencyAddressSid = null,
                                                                                  string trunkSid = null,
                                                                                  LocalResource.VoiceReceiveModeEnum voiceReceiveMode = null,
                                                                                  string bundleSid = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateLocalOptions(phoneNumber){  PathAccountSid = pathAccountSid, ApiVersion = apiVersion, FriendlyName = friendlyName, SmsApplicationSid = smsApplicationSid, SmsFallbackMethod = smsFallbackMethod, SmsFallbackUrl = smsFallbackUrl, SmsMethod = smsMethod, SmsUrl = smsUrl, StatusCallback = statusCallback, StatusCallbackMethod = statusCallbackMethod, VoiceApplicationSid = voiceApplicationSid, VoiceCallerIdLookup = voiceCallerIdLookup, VoiceFallbackMethod = voiceFallbackMethod, VoiceFallbackUrl = voiceFallbackUrl, VoiceMethod = voiceMethod, VoiceUrl = voiceUrl, IdentitySid = identitySid, AddressSid = addressSid, EmergencyStatus = emergencyStatus, EmergencyAddressSid = emergencyAddressSid, TrunkSid = trunkSid, VoiceReceiveMode = voiceReceiveMode, BundleSid = bundleSid };
            return await CreateAsync(options, client);
        }
        #endif
        
        private static Request BuildReadRequest(ReadLocalOptions options, ITwilioRestClient client)
        {
            
            string path = "/2010-04-01/Accounts/{AccountSid}/IncomingPhoneNumbers/Local.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{"+"AccountSid"+"}", PathAccountSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> read </summary>
        /// <param name="options"> Read Local parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Local </returns>
        public static ResourceSet<LocalResource> Read(ReadLocalOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<LocalResource>.FromJson("incoming_phone_numbers", response.Content);
            return new ResourceSet<LocalResource>(page, options, client);
        }

        #if !NET35
        /// <summary> read </summary>
        /// <param name="options"> Read Local parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Local </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<LocalResource>> ReadAsync(ReadLocalOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<LocalResource>.FromJson("incoming_phone_numbers", response.Content);
            return new ResourceSet<LocalResource>(page, options, client);
        }
        #endif
        /// <summary> read </summary>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the resources to read. </param>
        /// <param name="beta"> Whether to include phone numbers new to the Twilio platform. Can be: `true` or `false` and the default is `true`. </param>
        /// <param name="friendlyName"> A string that identifies the resources to read. </param>
        /// <param name="phoneNumber"> The phone numbers of the IncomingPhoneNumber resources to read. You can specify partial numbers and use '*' as a wildcard for any digit. </param>
        /// <param name="origin"> Whether to include phone numbers based on their origin. Can be: `twilio` or `hosted`. By default, phone numbers of all origin are included. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Local </returns>
        public static ResourceSet<LocalResource> Read(
                                                     string pathAccountSid = null,
                                                     bool? beta = null,
                                                     string friendlyName = null,
                                                     Types.PhoneNumber phoneNumber = null,
                                                     string origin = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadLocalOptions(){ PathAccountSid = pathAccountSid, Beta = beta, FriendlyName = friendlyName, PhoneNumber = phoneNumber, Origin = origin, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary> read </summary>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the resources to read. </param>
        /// <param name="beta"> Whether to include phone numbers new to the Twilio platform. Can be: `true` or `false` and the default is `true`. </param>
        /// <param name="friendlyName"> A string that identifies the resources to read. </param>
        /// <param name="phoneNumber"> The phone numbers of the IncomingPhoneNumber resources to read. You can specify partial numbers and use '*' as a wildcard for any digit. </param>
        /// <param name="origin"> Whether to include phone numbers based on their origin. Can be: `twilio` or `hosted`. By default, phone numbers of all origin are included. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Local </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<LocalResource>> ReadAsync(
                                                                                             string pathAccountSid = null,
                                                                                             bool? beta = null,
                                                                                             string friendlyName = null,
                                                                                             Types.PhoneNumber phoneNumber = null,
                                                                                             string origin = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadLocalOptions(){ PathAccountSid = pathAccountSid, Beta = beta, FriendlyName = friendlyName, PhoneNumber = phoneNumber, Origin = origin, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        
        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<LocalResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<LocalResource>.FromJson("incoming_phone_numbers", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<LocalResource> NextPage(Page<LocalResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<LocalResource>.FromJson("incoming_phone_numbers", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<LocalResource> PreviousPage(Page<LocalResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<LocalResource>.FromJson("incoming_phone_numbers", response.Content);
        }

    
        /// <summary>
        /// Converts a JSON string into a LocalResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> LocalResource object represented by the provided JSON </returns>
        public static LocalResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<LocalResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The SID of the Address resource associated with the phone number. </summary> 
        [JsonProperty("address_sid")]
        public string AddressSid { get; private set; }

        
        [JsonProperty("address_requirements")]
        public LocalResource.AddressRequirementEnum AddressRequirements { get; private set; }

        ///<summary> The API version used to start a new TwiML session. </summary> 
        [JsonProperty("api_version")]
        public string ApiVersion { get; private set; }

        ///<summary> Whether the phone number is new to the Twilio platform. Can be: `true` or `false`. </summary> 
        [JsonProperty("beta")]
        public bool? Beta { get; private set; }

        ///<summary> The capabilities </summary> 
        [JsonProperty("capabilities")]
        public PhoneNumberCapabilities Capabilities { get; private set; }

        ///<summary> The date and time in GMT that the resource was created specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT that the resource was last updated specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The string that you assigned to describe the resource. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> The SID of the Identity resource that we associate with the phone number. Some regions require an Identity to meet local regulations. </summary> 
        [JsonProperty("identity_sid")]
        public string IdentitySid { get; private set; }

        ///<summary> The phone number in [E.164](https://www.twilio.com/docs/glossary/what-e164) format, which consists of a + followed by the country code and subscriber number. </summary> 
        [JsonProperty("phone_number")]
        [JsonConverter(typeof(PhoneNumberConverter))]
        public Types.PhoneNumber PhoneNumber { get; private set; }

        ///<summary> The phone number's origin. `twilio` identifies Twilio-owned phone numbers and `hosted` identifies hosted phone numbers. </summary> 
        [JsonProperty("origin")]
        public string Origin { get; private set; }

        ///<summary> The unique string that that we created to identify the resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the application that handles SMS messages sent to the phone number. If an `sms_application_sid` is present, we ignore all `sms_*_url` values and use those of the application. </summary> 
        [JsonProperty("sms_application_sid")]
        public string SmsApplicationSid { get; private set; }

        ///<summary> The HTTP method we use to call `sms_fallback_url`. Can be: `GET` or `POST`. </summary> 
        [JsonProperty("sms_fallback_method")]
        public Twilio.Http.HttpMethod SmsFallbackMethod { get; private set; }

        ///<summary> The URL that we call when an error occurs while retrieving or executing the TwiML from `sms_url`. </summary> 
        [JsonProperty("sms_fallback_url")]
        public Uri SmsFallbackUrl { get; private set; }

        ///<summary> The HTTP method we use to call `sms_url`. Can be: `GET` or `POST`. </summary> 
        [JsonProperty("sms_method")]
        public Twilio.Http.HttpMethod SmsMethod { get; private set; }

        ///<summary> The URL we call when the phone number receives an incoming SMS message. </summary> 
        [JsonProperty("sms_url")]
        public Uri SmsUrl { get; private set; }

        ///<summary> The URL we call using the `status_callback_method` to send status information to your application. </summary> 
        [JsonProperty("status_callback")]
        public Uri StatusCallback { get; private set; }

        ///<summary> The HTTP method we use to call `status_callback`. Can be: `GET` or `POST`. </summary> 
        [JsonProperty("status_callback_method")]
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; private set; }

        ///<summary> The SID of the Trunk that handles calls to the phone number. If a `trunk_sid` is present, we ignore all of the voice urls and voice applications and use those set on the Trunk. Setting a `trunk_sid` will automatically delete your `voice_application_sid` and vice versa. </summary> 
        [JsonProperty("trunk_sid")]
        public string TrunkSid { get; private set; }

        ///<summary> The URI of the resource, relative to `https://api.twilio.com`. </summary> 
        [JsonProperty("uri")]
        public string Uri { get; private set; }

        
        [JsonProperty("voice_receive_mode")]
        public LocalResource.VoiceReceiveModeEnum VoiceReceiveMode { get; private set; }

        ///<summary> The SID of the application that handles calls to the phone number. If a `voice_application_sid` is present, we ignore all of the voice urls and use those set on the application. Setting a `voice_application_sid` will automatically delete your `trunk_sid` and vice versa. </summary> 
        [JsonProperty("voice_application_sid")]
        public string VoiceApplicationSid { get; private set; }

        ///<summary> Whether we look up the caller's caller-ID name from the CNAM database ($0.01 per look up). Can be: `true` or `false`. </summary> 
        [JsonProperty("voice_caller_id_lookup")]
        public bool? VoiceCallerIdLookup { get; private set; }

        ///<summary> The HTTP method we use to call `voice_fallback_url`. Can be: `GET` or `POST`. </summary> 
        [JsonProperty("voice_fallback_method")]
        public Twilio.Http.HttpMethod VoiceFallbackMethod { get; private set; }

        ///<summary> The URL that we call when an error occurs retrieving or executing the TwiML requested by `url`. </summary> 
        [JsonProperty("voice_fallback_url")]
        public Uri VoiceFallbackUrl { get; private set; }

        ///<summary> The HTTP method we use to call `voice_url`. Can be: `GET` or `POST`. </summary> 
        [JsonProperty("voice_method")]
        public Twilio.Http.HttpMethod VoiceMethod { get; private set; }

        ///<summary> The URL we call when this phone number receives a call. The `voice_url` will not be used if a `voice_application_sid` or a `trunk_sid` is set. </summary> 
        [JsonProperty("voice_url")]
        public Uri VoiceUrl { get; private set; }

        
        [JsonProperty("emergency_status")]
        public LocalResource.EmergencyStatusEnum EmergencyStatus { get; private set; }

        ///<summary> The SID of the emergency address configuration that we use for emergency calling from this phone number. </summary> 
        [JsonProperty("emergency_address_sid")]
        public string EmergencyAddressSid { get; private set; }

        
        [JsonProperty("emergency_address_status")]
        public LocalResource.EmergencyAddressStatusEnum EmergencyAddressStatus { get; private set; }

        ///<summary> The SID of the Bundle resource that you associate with the phone number. Some regions require a Bundle to meet local Regulations. </summary> 
        [JsonProperty("bundle_sid")]
        public string BundleSid { get; private set; }

        ///<summary> The status </summary> 
        [JsonProperty("status")]
        public string Status { get; private set; }



        private LocalResource() {

        }
    }
}
