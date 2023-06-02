/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Voice
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



namespace Kandy.Rest.Voice.V1.DialingPermissions.Country
{
    public class HighriskSpecialPrefixResource : Resource
    {



        private static Request BuildReadRequest(ReadHighriskSpecialPrefixOptions options, IKandyRestClient client)
        {

            string path = "/v1/DialingPermissions/Countries/{IsoCode}/HighRiskSpecialPrefixes";

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
        /// <summary> Fetch the high-risk special services prefixes from the country resource corresponding to the [ISO country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) </summary>
        /// <param name="options"> Read HighriskSpecialPrefix parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of HighriskSpecialPrefix </returns>
        public static ResourceSet<HighriskSpecialPrefixResource> Read(ReadHighriskSpecialPrefixOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<HighriskSpecialPrefixResource>.FromJson("content", response.Content);
            return new ResourceSet<HighriskSpecialPrefixResource>(page, options, client);
        }

#if !NET35
        /// <summary> Fetch the high-risk special services prefixes from the country resource corresponding to the [ISO country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) </summary>
        /// <param name="options"> Read HighriskSpecialPrefix parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of HighriskSpecialPrefix </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<HighriskSpecialPrefixResource>> ReadAsync(ReadHighriskSpecialPrefixOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<HighriskSpecialPrefixResource>.FromJson("content", response.Content);
            return new ResourceSet<HighriskSpecialPrefixResource>(page, options, client);
        }
#endif
        /// <summary> Fetch the high-risk special services prefixes from the country resource corresponding to the [ISO country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) </summary>
        /// <param name="pathIsoCode"> The [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) to identify the country permissions from which high-risk special service number prefixes are fetched </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of HighriskSpecialPrefix </returns>
        public static ResourceSet<HighriskSpecialPrefixResource> Read(
                                                     string pathIsoCode,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     IKandyRestClient client = null)
        {
            var options = new ReadHighriskSpecialPrefixOptions(pathIsoCode) { PageSize = pageSize, Limit = limit };
            return Read(options, client);
        }

#if !NET35
        /// <summary> Fetch the high-risk special services prefixes from the country resource corresponding to the [ISO country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) </summary>
        /// <param name="pathIsoCode"> The [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) to identify the country permissions from which high-risk special service number prefixes are fetched </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of HighriskSpecialPrefix </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<HighriskSpecialPrefixResource>> ReadAsync(
                                                                                             string pathIsoCode,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             IKandyRestClient client = null)
        {
            var options = new ReadHighriskSpecialPrefixOptions(pathIsoCode) { PageSize = pageSize, Limit = limit };
            return await ReadAsync(options, client);
        }
#endif


        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<HighriskSpecialPrefixResource> GetPage(string targetUrl, IKandyRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<HighriskSpecialPrefixResource>.FromJson("content", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<HighriskSpecialPrefixResource> NextPage(Page<HighriskSpecialPrefixResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<HighriskSpecialPrefixResource>.FromJson("content", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<HighriskSpecialPrefixResource> PreviousPage(Page<HighriskSpecialPrefixResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<HighriskSpecialPrefixResource>.FromJson("content", response.Content);
        }


        /// <summary>
        /// Converts a JSON string into a HighriskSpecialPrefixResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> HighriskSpecialPrefixResource object represented by the provided JSON </returns>
        public static HighriskSpecialPrefixResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<HighriskSpecialPrefixResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> A prefix is a contiguous number range for a block of E.164 numbers that includes the E.164 assigned country code. For example, a North American Numbering Plan prefix like `+1510720` written like `+1(510) 720` matches all numbers inclusive from `+1(510) 720-0000` to `+1(510) 720-9999`. </summary> 
        [JsonProperty("prefix")]
        public string Prefix { get; private set; }



        private HighriskSpecialPrefixResource()
        {

        }
    }
}
