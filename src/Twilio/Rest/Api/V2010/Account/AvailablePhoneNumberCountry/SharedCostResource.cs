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


namespace Kandy.Rest.Api.V2010.Account.AvailablePhoneNumberCountry
{
    public class SharedCostResource : Resource
    {



        private static Request BuildReadRequest(ReadSharedCostOptions options, IKandyRestClient client)
        {

            string path = "/2010-04-01/Accounts/{AccountSid}/AvailablePhoneNumbers/{CountryCode}/SharedCost.json";

            string PathAccountSid = options.PathAccountSid ?? client.AccountSid;
            path = path.Replace("{" + "AccountSid" + "}", PathAccountSid);
            string PathCountryCode = options.PathCountryCode.ToString();
            path = path.Replace("{" + "CountryCode" + "}", PathCountryCode);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> read </summary>
        /// <param name="options"> Read SharedCost parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SharedCost </returns>
        public static ResourceSet<SharedCostResource> Read(ReadSharedCostOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<SharedCostResource>.FromJson("available_phone_numbers", response.Content);
            return new ResourceSet<SharedCostResource>(page, options, client);
        }

#if !NET35
        /// <summary> read </summary>
        /// <param name="options"> Read SharedCost parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SharedCost </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<SharedCostResource>> ReadAsync(ReadSharedCostOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<SharedCostResource>.FromJson("available_phone_numbers", response.Content);
            return new ResourceSet<SharedCostResource>(page, options, client);
        }
#endif
        /// <summary> read </summary>
        /// <param name="pathCountryCode"> The [ISO-3166-1](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code of the country from which to read phone numbers. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) requesting the AvailablePhoneNumber resources. </param>
        /// <param name="areaCode"> The area code of the phone numbers to read. Applies to only phone numbers in the US and Canada. </param>
        /// <param name="contains"> The pattern on which to match phone numbers. Valid characters are `*`, `0-9`, `a-z`, and `A-Z`. The `*` character matches any single digit. For examples, see [Example 2](https://www.twilio.com/docs/phone-numbers/api/availablephonenumber-resource#local-get-basic-example-2) and [Example 3](https://www.twilio.com/docs/phone-numbers/api/availablephonenumber-resource#local-get-basic-example-3). If specified, this value must have at least two characters. </param>
        /// <param name="smsEnabled"> Whether the phone numbers can receive text messages. Can be: `true` or `false`. </param>
        /// <param name="mmsEnabled"> Whether the phone numbers can receive MMS messages. Can be: `true` or `false`. </param>
        /// <param name="voiceEnabled"> Whether the phone numbers can receive calls. Can be: `true` or `false`. </param>
        /// <param name="excludeAllAddressRequired"> Whether to exclude phone numbers that require an [Address](https://www.twilio.com/docs/usage/api/address). Can be: `true` or `false` and the default is `false`. </param>
        /// <param name="excludeLocalAddressRequired"> Whether to exclude phone numbers that require a local [Address](https://www.twilio.com/docs/usage/api/address). Can be: `true` or `false` and the default is `false`. </param>
        /// <param name="excludeForeignAddressRequired"> Whether to exclude phone numbers that require a foreign [Address](https://www.twilio.com/docs/usage/api/address). Can be: `true` or `false` and the default is `false`. </param>
        /// <param name="beta"> Whether to read phone numbers that are new to the Twilio platform. Can be: `true` or `false` and the default is `true`. </param>
        /// <param name="nearNumber"> Given a phone number, find a geographically close number within `distance` miles. Distance defaults to 25 miles. Applies to only phone numbers in the US and Canada. </param>
        /// <param name="nearLatLong"> Given a latitude/longitude pair `lat,long` find geographically close numbers within `distance` miles. Applies to only phone numbers in the US and Canada. </param>
        /// <param name="distance"> The search radius, in miles, for a `near_` query.  Can be up to `500` and the default is `25`. Applies to only phone numbers in the US and Canada. </param>
        /// <param name="inPostalCode"> Limit results to a particular postal code. Given a phone number, search within the same postal code as that number. Applies to only phone numbers in the US and Canada. </param>
        /// <param name="inRegion"> Limit results to a particular region, state, or province. Given a phone number, search within the same region as that number. Applies to only phone numbers in the US and Canada. </param>
        /// <param name="inRateCenter"> Limit results to a specific rate center, or given a phone number search within the same rate center as that number. Requires `in_lata` to be set as well. Applies to only phone numbers in the US and Canada. </param>
        /// <param name="inLata"> Limit results to a specific local access and transport area ([LATA](https://en.wikipedia.org/wiki/Local_access_and_transport_area)). Given a phone number, search within the same [LATA](https://en.wikipedia.org/wiki/Local_access_and_transport_area) as that number. Applies to only phone numbers in the US and Canada. </param>
        /// <param name="inLocality"> Limit results to a particular locality or city. Given a phone number, search within the same Locality as that number. </param>
        /// <param name="faxEnabled"> Whether the phone numbers can receive faxes. Can be: `true` or `false`. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SharedCost </returns>
        public static ResourceSet<SharedCostResource> Read(
                                                     string pathCountryCode,
                                                     string pathAccountSid = null,
                                                     int? areaCode = null,
                                                     string contains = null,
                                                     bool? smsEnabled = null,
                                                     bool? mmsEnabled = null,
                                                     bool? voiceEnabled = null,
                                                     bool? excludeAllAddressRequired = null,
                                                     bool? excludeLocalAddressRequired = null,
                                                     bool? excludeForeignAddressRequired = null,
                                                     bool? beta = null,
                                                     Types.PhoneNumber nearNumber = null,
                                                     string nearLatLong = null,
                                                     int? distance = null,
                                                     string inPostalCode = null,
                                                     string inRegion = null,
                                                     string inRateCenter = null,
                                                     string inLata = null,
                                                     string inLocality = null,
                                                     bool? faxEnabled = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     IKandyRestClient client = null)
        {
            var options = new ReadSharedCostOptions(pathCountryCode) { PathAccountSid = pathAccountSid, AreaCode = areaCode, Contains = contains, SmsEnabled = smsEnabled, MmsEnabled = mmsEnabled, VoiceEnabled = voiceEnabled, ExcludeAllAddressRequired = excludeAllAddressRequired, ExcludeLocalAddressRequired = excludeLocalAddressRequired, ExcludeForeignAddressRequired = excludeForeignAddressRequired, Beta = beta, NearNumber = nearNumber, NearLatLong = nearLatLong, Distance = distance, InPostalCode = inPostalCode, InRegion = inRegion, InRateCenter = inRateCenter, InLata = inLata, InLocality = inLocality, FaxEnabled = faxEnabled, PageSize = pageSize, Limit = limit };
            return Read(options, client);
        }

#if !NET35
        /// <summary> read </summary>
        /// <param name="pathCountryCode"> The [ISO-3166-1](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code of the country from which to read phone numbers. </param>
        /// <param name="pathAccountSid"> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) requesting the AvailablePhoneNumber resources. </param>
        /// <param name="areaCode"> The area code of the phone numbers to read. Applies to only phone numbers in the US and Canada. </param>
        /// <param name="contains"> The pattern on which to match phone numbers. Valid characters are `*`, `0-9`, `a-z`, and `A-Z`. The `*` character matches any single digit. For examples, see [Example 2](https://www.twilio.com/docs/phone-numbers/api/availablephonenumber-resource#local-get-basic-example-2) and [Example 3](https://www.twilio.com/docs/phone-numbers/api/availablephonenumber-resource#local-get-basic-example-3). If specified, this value must have at least two characters. </param>
        /// <param name="smsEnabled"> Whether the phone numbers can receive text messages. Can be: `true` or `false`. </param>
        /// <param name="mmsEnabled"> Whether the phone numbers can receive MMS messages. Can be: `true` or `false`. </param>
        /// <param name="voiceEnabled"> Whether the phone numbers can receive calls. Can be: `true` or `false`. </param>
        /// <param name="excludeAllAddressRequired"> Whether to exclude phone numbers that require an [Address](https://www.twilio.com/docs/usage/api/address). Can be: `true` or `false` and the default is `false`. </param>
        /// <param name="excludeLocalAddressRequired"> Whether to exclude phone numbers that require a local [Address](https://www.twilio.com/docs/usage/api/address). Can be: `true` or `false` and the default is `false`. </param>
        /// <param name="excludeForeignAddressRequired"> Whether to exclude phone numbers that require a foreign [Address](https://www.twilio.com/docs/usage/api/address). Can be: `true` or `false` and the default is `false`. </param>
        /// <param name="beta"> Whether to read phone numbers that are new to the Twilio platform. Can be: `true` or `false` and the default is `true`. </param>
        /// <param name="nearNumber"> Given a phone number, find a geographically close number within `distance` miles. Distance defaults to 25 miles. Applies to only phone numbers in the US and Canada. </param>
        /// <param name="nearLatLong"> Given a latitude/longitude pair `lat,long` find geographically close numbers within `distance` miles. Applies to only phone numbers in the US and Canada. </param>
        /// <param name="distance"> The search radius, in miles, for a `near_` query.  Can be up to `500` and the default is `25`. Applies to only phone numbers in the US and Canada. </param>
        /// <param name="inPostalCode"> Limit results to a particular postal code. Given a phone number, search within the same postal code as that number. Applies to only phone numbers in the US and Canada. </param>
        /// <param name="inRegion"> Limit results to a particular region, state, or province. Given a phone number, search within the same region as that number. Applies to only phone numbers in the US and Canada. </param>
        /// <param name="inRateCenter"> Limit results to a specific rate center, or given a phone number search within the same rate center as that number. Requires `in_lata` to be set as well. Applies to only phone numbers in the US and Canada. </param>
        /// <param name="inLata"> Limit results to a specific local access and transport area ([LATA](https://en.wikipedia.org/wiki/Local_access_and_transport_area)). Given a phone number, search within the same [LATA](https://en.wikipedia.org/wiki/Local_access_and_transport_area) as that number. Applies to only phone numbers in the US and Canada. </param>
        /// <param name="inLocality"> Limit results to a particular locality or city. Given a phone number, search within the same Locality as that number. </param>
        /// <param name="faxEnabled"> Whether the phone numbers can receive faxes. Can be: `true` or `false`. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SharedCost </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<SharedCostResource>> ReadAsync(
                                                                                             string pathCountryCode,
                                                                                             string pathAccountSid = null,
                                                                                             int? areaCode = null,
                                                                                             string contains = null,
                                                                                             bool? smsEnabled = null,
                                                                                             bool? mmsEnabled = null,
                                                                                             bool? voiceEnabled = null,
                                                                                             bool? excludeAllAddressRequired = null,
                                                                                             bool? excludeLocalAddressRequired = null,
                                                                                             bool? excludeForeignAddressRequired = null,
                                                                                             bool? beta = null,
                                                                                             Types.PhoneNumber nearNumber = null,
                                                                                             string nearLatLong = null,
                                                                                             int? distance = null,
                                                                                             string inPostalCode = null,
                                                                                             string inRegion = null,
                                                                                             string inRateCenter = null,
                                                                                             string inLata = null,
                                                                                             string inLocality = null,
                                                                                             bool? faxEnabled = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             IKandyRestClient client = null)
        {
            var options = new ReadSharedCostOptions(pathCountryCode) { PathAccountSid = pathAccountSid, AreaCode = areaCode, Contains = contains, SmsEnabled = smsEnabled, MmsEnabled = mmsEnabled, VoiceEnabled = voiceEnabled, ExcludeAllAddressRequired = excludeAllAddressRequired, ExcludeLocalAddressRequired = excludeLocalAddressRequired, ExcludeForeignAddressRequired = excludeForeignAddressRequired, Beta = beta, NearNumber = nearNumber, NearLatLong = nearLatLong, Distance = distance, InPostalCode = inPostalCode, InRegion = inRegion, InRateCenter = inRateCenter, InLata = inLata, InLocality = inLocality, FaxEnabled = faxEnabled, PageSize = pageSize, Limit = limit };
            return await ReadAsync(options, client);
        }
#endif


        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<SharedCostResource> GetPage(string targetUrl, IKandyRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<SharedCostResource>.FromJson("available_phone_numbers", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<SharedCostResource> NextPage(Page<SharedCostResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<SharedCostResource>.FromJson("available_phone_numbers", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<SharedCostResource> PreviousPage(Page<SharedCostResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<SharedCostResource>.FromJson("available_phone_numbers", response.Content);
        }


        /// <summary>
        /// Converts a JSON string into a SharedCostResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> SharedCostResource object represented by the provided JSON </returns>
        public static SharedCostResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<SharedCostResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> A formatted version of the phone number. </summary> 
        [JsonProperty("friendly_name")]
        [JsonConverter(typeof(PhoneNumberConverter))]
        public Types.PhoneNumber FriendlyName { get; private set; }

        ///<summary> The phone number in [E.164](https://www.twilio.com/docs/glossary/what-e164) format, which consists of a + followed by the country code and subscriber number. </summary> 
        [JsonProperty("phone_number")]
        [JsonConverter(typeof(PhoneNumberConverter))]
        public Types.PhoneNumber PhoneNumber { get; private set; }

        ///<summary> The [LATA](https://en.wikipedia.org/wiki/Local_access_and_transport_area) of this phone number. Available for only phone numbers from the US and Canada. </summary> 
        [JsonProperty("lata")]
        public string Lata { get; private set; }

        ///<summary> The locality or city of this phone number's location. </summary> 
        [JsonProperty("locality")]
        public string Locality { get; private set; }

        ///<summary> The [rate center](https://en.wikipedia.org/wiki/Telephone_exchange) of this phone number. Available for only phone numbers from the US and Canada. </summary> 
        [JsonProperty("rate_center")]
        public string RateCenter { get; private set; }

        ///<summary> The latitude of this phone number's location. Available for only phone numbers from the US and Canada. </summary> 
        [JsonProperty("latitude")]
        public decimal? Latitude { get; private set; }

        ///<summary> The longitude of this phone number's location. Available for only phone numbers from the US and Canada. </summary> 
        [JsonProperty("longitude")]
        public decimal? Longitude { get; private set; }

        ///<summary> The two-letter state or province abbreviation of this phone number's location. Available for only phone numbers from the US and Canada. </summary> 
        [JsonProperty("region")]
        public string Region { get; private set; }

        ///<summary> The postal or ZIP code of this phone number's location. Available for only phone numbers from the US and Canada. </summary> 
        [JsonProperty("postal_code")]
        public string PostalCode { get; private set; }

        ///<summary> The [ISO country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) of this phone number. </summary> 
        [JsonProperty("iso_country")]
        public string IsoCountry { get; private set; }

        ///<summary> The type of [Address](https://www.twilio.com/docs/usage/api/address) resource the phone number requires. Can be: `none`, `any`, `local`, or `foreign`. `none` means no address is required. `any` means an address is required, but it can be anywhere in the world. `local` means an address in the phone number's country is required. `foreign` means an address outside of the phone number's country is required. </summary> 
        [JsonProperty("address_requirements")]
        public string AddressRequirements { get; private set; }

        ///<summary> Whether the phone number is new to the Twilio platform. Can be: `true` or `false`. </summary> 
        [JsonProperty("beta")]
        public bool? Beta { get; private set; }

        ///<summary> The capabilities </summary> 
        [JsonProperty("capabilities")]
        public PhoneNumberCapabilities Capabilities { get; private set; }



        private SharedCostResource()
        {

        }
    }
}
