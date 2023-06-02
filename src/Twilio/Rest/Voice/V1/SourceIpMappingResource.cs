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



namespace Kandy.Rest.Voice.V1
{
    public class SourceIpMappingResource : Resource
    {



        private static Request BuildCreateRequest(CreateSourceIpMappingOptions options, IKandyRestClient client)
        {

            string path = "/v1/SourceIpMappings";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Voice,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> create </summary>
        /// <param name="options"> Create SourceIpMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SourceIpMapping </returns>
        public static SourceIpMappingResource Create(CreateSourceIpMappingOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> create </summary>
        /// <param name="options"> Create SourceIpMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SourceIpMapping </returns>
        public static async System.Threading.Tasks.Task<SourceIpMappingResource> CreateAsync(CreateSourceIpMappingOptions options,
        IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> create </summary>
        /// <param name="ipRecordSid"> The Twilio-provided string that uniquely identifies the IP Record resource to map from. </param>
        /// <param name="sipDomainSid"> The SID of the SIP Domain that the IP Record should be mapped to. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SourceIpMapping </returns>
        public static SourceIpMappingResource Create(
                                          string ipRecordSid,
                                          string sipDomainSid,
                                          IKandyRestClient client = null)
        {
            var options = new CreateSourceIpMappingOptions(ipRecordSid, sipDomainSid) { };
            return Create(options, client);
        }

#if !NET35
        /// <summary> create </summary>
        /// <param name="ipRecordSid"> The Twilio-provided string that uniquely identifies the IP Record resource to map from. </param>
        /// <param name="sipDomainSid"> The SID of the SIP Domain that the IP Record should be mapped to. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SourceIpMapping </returns>
        public static async System.Threading.Tasks.Task<SourceIpMappingResource> CreateAsync(
                                                                                  string ipRecordSid,
                                                                                  string sipDomainSid,
                                                                                  IKandyRestClient client = null)
        {
            var options = new CreateSourceIpMappingOptions(ipRecordSid, sipDomainSid) { };
            return await CreateAsync(options, client);
        }
#endif

        /// <summary> delete </summary>
        /// <param name="options"> Delete SourceIpMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SourceIpMapping </returns>
        private static Request BuildDeleteRequest(DeleteSourceIpMappingOptions options, IKandyRestClient client)
        {

            string path = "/v1/SourceIpMappings/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Voice,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> delete </summary>
        /// <param name="options"> Delete SourceIpMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SourceIpMapping </returns>
        public static bool Delete(DeleteSourceIpMappingOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

#if !NET35
        /// <summary> delete </summary>
        /// <param name="options"> Delete SourceIpMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SourceIpMapping </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteSourceIpMappingOptions options,
                                                                          IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
#endif

        /// <summary> delete </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the IP Record resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SourceIpMapping </returns>
        public static bool Delete(string pathSid, IKandyRestClient client = null)
        {
            var options = new DeleteSourceIpMappingOptions(pathSid);
            return Delete(options, client);
        }

#if !NET35
        /// <summary> delete </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the IP Record resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SourceIpMapping </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, IKandyRestClient client = null)
        {
            var options = new DeleteSourceIpMappingOptions(pathSid);
            return await DeleteAsync(options, client);
        }
#endif

        private static Request BuildFetchRequest(FetchSourceIpMappingOptions options, IKandyRestClient client)
        {

            string path = "/v1/SourceIpMappings/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Voice,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch SourceIpMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SourceIpMapping </returns>
        public static SourceIpMappingResource Fetch(FetchSourceIpMappingOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch SourceIpMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SourceIpMapping </returns>
        public static async System.Threading.Tasks.Task<SourceIpMappingResource> FetchAsync(FetchSourceIpMappingOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
#endif
        /// <summary> fetch </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the IP Record resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SourceIpMapping </returns>
        public static SourceIpMappingResource Fetch(
                                         string pathSid,
                                         IKandyRestClient client = null)
        {
            var options = new FetchSourceIpMappingOptions(pathSid) { };
            return Fetch(options, client);
        }

#if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the IP Record resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SourceIpMapping </returns>
        public static async System.Threading.Tasks.Task<SourceIpMappingResource> FetchAsync(string pathSid, IKandyRestClient client = null)
        {
            var options = new FetchSourceIpMappingOptions(pathSid) { };
            return await FetchAsync(options, client);
        }
#endif

        private static Request BuildReadRequest(ReadSourceIpMappingOptions options, IKandyRestClient client)
        {

            string path = "/v1/SourceIpMappings";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Voice,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> read </summary>
        /// <param name="options"> Read SourceIpMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SourceIpMapping </returns>
        public static ResourceSet<SourceIpMappingResource> Read(ReadSourceIpMappingOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<SourceIpMappingResource>.FromJson("source_ip_mappings", response.Content);
            return new ResourceSet<SourceIpMappingResource>(page, options, client);
        }

#if !NET35
        /// <summary> read </summary>
        /// <param name="options"> Read SourceIpMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SourceIpMapping </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<SourceIpMappingResource>> ReadAsync(ReadSourceIpMappingOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<SourceIpMappingResource>.FromJson("source_ip_mappings", response.Content);
            return new ResourceSet<SourceIpMappingResource>(page, options, client);
        }
#endif
        /// <summary> read </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SourceIpMapping </returns>
        public static ResourceSet<SourceIpMappingResource> Read(
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     IKandyRestClient client = null)
        {
            var options = new ReadSourceIpMappingOptions() { PageSize = pageSize, Limit = limit };
            return Read(options, client);
        }

#if !NET35
        /// <summary> read </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SourceIpMapping </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<SourceIpMappingResource>> ReadAsync(
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             IKandyRestClient client = null)
        {
            var options = new ReadSourceIpMappingOptions() { PageSize = pageSize, Limit = limit };
            return await ReadAsync(options, client);
        }
#endif


        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<SourceIpMappingResource> GetPage(string targetUrl, IKandyRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<SourceIpMappingResource>.FromJson("source_ip_mappings", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<SourceIpMappingResource> NextPage(Page<SourceIpMappingResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<SourceIpMappingResource>.FromJson("source_ip_mappings", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<SourceIpMappingResource> PreviousPage(Page<SourceIpMappingResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<SourceIpMappingResource>.FromJson("source_ip_mappings", response.Content);
        }


        private static Request BuildUpdateRequest(UpdateSourceIpMappingOptions options, IKandyRestClient client)
        {

            string path = "/v1/SourceIpMappings/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Voice,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> update </summary>
        /// <param name="options"> Update SourceIpMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SourceIpMapping </returns>
        public static SourceIpMappingResource Update(UpdateSourceIpMappingOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> update </summary>
        /// <param name="options"> Update SourceIpMapping parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SourceIpMapping </returns>
#if !NET35
        public static async System.Threading.Tasks.Task<SourceIpMappingResource> UpdateAsync(UpdateSourceIpMappingOptions options,
                                                                                                          IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> update </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the IP Record resource to update. </param>
        /// <param name="sipDomainSid"> The SID of the SIP Domain that the IP Record should be mapped to. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SourceIpMapping </returns>
        public static SourceIpMappingResource Update(
                                          string pathSid,
                                          string sipDomainSid,
                                          IKandyRestClient client = null)
        {
            var options = new UpdateSourceIpMappingOptions(pathSid, sipDomainSid) { };
            return Update(options, client);
        }

#if !NET35
        /// <summary> update </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the IP Record resource to update. </param>
        /// <param name="sipDomainSid"> The SID of the SIP Domain that the IP Record should be mapped to. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SourceIpMapping </returns>
        public static async System.Threading.Tasks.Task<SourceIpMappingResource> UpdateAsync(
                                                                              string pathSid,
                                                                              string sipDomainSid,
                                                                              IKandyRestClient client = null)
        {
            var options = new UpdateSourceIpMappingOptions(pathSid, sipDomainSid) { };
            return await UpdateAsync(options, client);
        }
#endif

        /// <summary>
        /// Converts a JSON string into a SourceIpMappingResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> SourceIpMappingResource object represented by the provided JSON </returns>
        public static SourceIpMappingResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<SourceIpMappingResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> The unique string that we created to identify the IP Record resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The Twilio-provided string that uniquely identifies the IP Record resource to map from. </summary> 
        [JsonProperty("ip_record_sid")]
        public string IpRecordSid { get; private set; }

        ///<summary> The SID of the SIP Domain that the IP Record is mapped to. </summary> 
        [JsonProperty("sip_domain_sid")]
        public string SipDomainSid { get; private set; }

        ///<summary> The date and time in GMT that the resource was created specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT that the resource was last updated specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The absolute URL of the resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private SourceIpMappingResource()
        {

        }
    }
}
