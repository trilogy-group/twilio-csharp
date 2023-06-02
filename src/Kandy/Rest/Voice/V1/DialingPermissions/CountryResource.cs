/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Voice
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



namespace Kandy.Rest.Voice.V1.DialingPermissions
{
    public class CountryResource : Resource
    {



        private static Request BuildFetchRequest(FetchCountryOptions options, IKandyRestClient client)
        {

            string path = "/v1/DialingPermissions/Countries/{IsoCode}";

            string PathIsoCode = options.PathIsoCode.ToString();
            path = path.Replace("{" + "IsoCode" + "}", PathIsoCode);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Voice,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Retrieve voice dialing country permissions identified by the given ISO country code </summary>
        /// <param name="options"> Fetch Country parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Country </returns>
        public static CountryResource Fetch(FetchCountryOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> Retrieve voice dialing country permissions identified by the given ISO country code </summary>
        /// <param name="options"> Fetch Country parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Country </returns>
        public static async System.Threading.Tasks.Task<CountryResource> FetchAsync(FetchCountryOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
#endif
        /// <summary> Retrieve voice dialing country permissions identified by the given ISO country code </summary>
        /// <param name="pathIsoCode"> The [ISO country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) of the DialingPermissions Country resource to fetch </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Country </returns>
        public static CountryResource Fetch(
                                         string pathIsoCode,
                                         IKandyRestClient client = null)
        {
            var options = new FetchCountryOptions(pathIsoCode) { };
            return Fetch(options, client);
        }

#if !NET35
        /// <summary> Retrieve voice dialing country permissions identified by the given ISO country code </summary>
        /// <param name="pathIsoCode"> The [ISO country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) of the DialingPermissions Country resource to fetch </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Country </returns>
        public static async System.Threading.Tasks.Task<CountryResource> FetchAsync(string pathIsoCode, IKandyRestClient client = null)
        {
            var options = new FetchCountryOptions(pathIsoCode) { };
            return await FetchAsync(options, client);
        }
#endif

        private static Request BuildReadRequest(ReadCountryOptions options, IKandyRestClient client)
        {

            string path = "/v1/DialingPermissions/Countries";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Voice,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Retrieve all voice dialing country permissions for this account </summary>
        /// <param name="options"> Read Country parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Country </returns>
        public static ResourceSet<CountryResource> Read(ReadCountryOptions options, IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<CountryResource>.FromJson("content", response.Content);
            return new ResourceSet<CountryResource>(page, options, client);
        }

#if !NET35
        /// <summary> Retrieve all voice dialing country permissions for this account </summary>
        /// <param name="options"> Read Country parameters </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Country </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<CountryResource>> ReadAsync(ReadCountryOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? KandyClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<CountryResource>.FromJson("content", response.Content);
            return new ResourceSet<CountryResource>(page, options, client);
        }
#endif
        /// <summary> Retrieve all voice dialing country permissions for this account </summary>
        /// <param name="isoCode"> Filter to retrieve the country permissions by specifying the [ISO country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) </param>
        /// <param name="continent"> Filter to retrieve the country permissions by specifying the continent </param>
        /// <param name="countryCode"> Filter the results by specified [country codes](https://www.itu.int/itudoc/itu-t/ob-lists/icc/e164_763.html) </param>
        /// <param name="lowRiskNumbersEnabled"> Filter to retrieve the country permissions with dialing to low-risk numbers enabled. Can be: `true` or `false`. </param>
        /// <param name="highRiskSpecialNumbersEnabled"> Filter to retrieve the country permissions with dialing to high-risk special service numbers enabled. Can be: `true` or `false` </param>
        /// <param name="highRiskTollfraudNumbersEnabled"> Filter to retrieve the country permissions with dialing to high-risk [toll fraud](https://www.kandy.com/learn/voice-and-video/toll-fraud) numbers enabled. Can be: `true` or `false`. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> A single instance of Country </returns>
        public static ResourceSet<CountryResource> Read(
                                                     string isoCode = null,
                                                     string continent = null,
                                                     string countryCode = null,
                                                     bool? lowRiskNumbersEnabled = null,
                                                     bool? highRiskSpecialNumbersEnabled = null,
                                                     bool? highRiskTollfraudNumbersEnabled = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     IKandyRestClient client = null)
        {
            var options = new ReadCountryOptions() { IsoCode = isoCode, Continent = continent, CountryCode = countryCode, LowRiskNumbersEnabled = lowRiskNumbersEnabled, HighRiskSpecialNumbersEnabled = highRiskSpecialNumbersEnabled, HighRiskTollfraudNumbersEnabled = highRiskTollfraudNumbersEnabled, PageSize = pageSize, Limit = limit };
            return Read(options, client);
        }

#if !NET35
        /// <summary> Retrieve all voice dialing country permissions for this account </summary>
        /// <param name="isoCode"> Filter to retrieve the country permissions by specifying the [ISO country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) </param>
        /// <param name="continent"> Filter to retrieve the country permissions by specifying the continent </param>
        /// <param name="countryCode"> Filter the results by specified [country codes](https://www.itu.int/itudoc/itu-t/ob-lists/icc/e164_763.html) </param>
        /// <param name="lowRiskNumbersEnabled"> Filter to retrieve the country permissions with dialing to low-risk numbers enabled. Can be: `true` or `false`. </param>
        /// <param name="highRiskSpecialNumbersEnabled"> Filter to retrieve the country permissions with dialing to high-risk special service numbers enabled. Can be: `true` or `false` </param>
        /// <param name="highRiskTollfraudNumbersEnabled"> Filter to retrieve the country permissions with dialing to high-risk [toll fraud](https://www.kandy.com/learn/voice-and-video/toll-fraud) numbers enabled. Can be: `true` or `false`. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> Task that resolves to A single instance of Country </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<CountryResource>> ReadAsync(
                                                                                             string isoCode = null,
                                                                                             string continent = null,
                                                                                             string countryCode = null,
                                                                                             bool? lowRiskNumbersEnabled = null,
                                                                                             bool? highRiskSpecialNumbersEnabled = null,
                                                                                             bool? highRiskTollfraudNumbersEnabled = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             IKandyRestClient client = null)
        {
            var options = new ReadCountryOptions() { IsoCode = isoCode, Continent = continent, CountryCode = countryCode, LowRiskNumbersEnabled = lowRiskNumbersEnabled, HighRiskSpecialNumbersEnabled = highRiskSpecialNumbersEnabled, HighRiskTollfraudNumbersEnabled = highRiskTollfraudNumbersEnabled, PageSize = pageSize, Limit = limit };
            return await ReadAsync(options, client);
        }
#endif


        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The target page of records </returns>
        public static Page<CountryResource> GetPage(string targetUrl, IKandyRestClient client)
        {
            client = client ?? KandyClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<CountryResource>.FromJson("content", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The next page of records </returns>
        public static Page<CountryResource> NextPage(Page<CountryResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<CountryResource>.FromJson("content", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Kandy </param>
        /// <returns> The previous page of records </returns>
        public static Page<CountryResource> PreviousPage(Page<CountryResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<CountryResource>.FromJson("content", response.Content);
        }


        /// <summary>
        /// Converts a JSON string into a CountryResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> CountryResource object represented by the provided JSON </returns>
        public static CountryResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<CountryResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> The [ISO country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2). </summary> 
        [JsonProperty("iso_code")]
        public string IsoCode { get; private set; }

        ///<summary> The name of the country. </summary> 
        [JsonProperty("name")]
        public string Name { get; private set; }

        ///<summary> The name of the continent in which the country is located. </summary> 
        [JsonProperty("continent")]
        public string Continent { get; private set; }

        ///<summary> The E.164 assigned [country codes(s)](https://www.itu.int/itudoc/itu-t/ob-lists/icc/e164_763.html) </summary> 
        [JsonProperty("country_codes")]
        public List<string> CountryCodes { get; private set; }

        ///<summary> Whether dialing to low-risk numbers is enabled. </summary> 
        [JsonProperty("low_risk_numbers_enabled")]
        public bool? LowRiskNumbersEnabled { get; private set; }

        ///<summary> Whether dialing to high-risk special services numbers is enabled. These prefixes include number ranges allocated by the country and include premium numbers, special services, shared cost, and others </summary> 
        [JsonProperty("high_risk_special_numbers_enabled")]
        public bool? HighRiskSpecialNumbersEnabled { get; private set; }

        ///<summary> Whether dialing to high-risk [toll fraud](https://www.kandy.com/learn/voice-and-video/toll-fraud) numbers is enabled. These prefixes include narrow number ranges that have a high-risk of international revenue sharing fraud (IRSF) attacks, also known as [toll fraud](https://www.kandy.com/learn/voice-and-video/toll-fraud). These prefixes are collected from anti-fraud databases and verified by analyzing calls on our network. These prefixes are not available for download and are updated frequently </summary> 
        [JsonProperty("high_risk_tollfraud_numbers_enabled")]
        public bool? HighRiskTollfraudNumbersEnabled { get; private set; }

        ///<summary> The absolute URL of this resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> A list of URLs related to this resource. </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }



        private CountryResource()
        {

        }
    }
}
