/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Trunking
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


namespace Kandy.Rest.Trunking.V1
{
    public class TrunkResource : Resource
    {

        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class TransferSettingEnum : StringEnum
        {
            private TransferSettingEnum(string value) : base(value) { }
            public TransferSettingEnum() { }
            public static implicit operator TransferSettingEnum(string value)
            {
                return new TransferSettingEnum(value);
            }
            public static readonly TransferSettingEnum DisableAll = new TransferSettingEnum("disable-all");
            public static readonly TransferSettingEnum EnableAll = new TransferSettingEnum("enable-all");
            public static readonly TransferSettingEnum SipOnly = new TransferSettingEnum("sip-only");

        }
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class TransferCallerIdEnum : StringEnum
        {
            private TransferCallerIdEnum(string value) : base(value) { }
            public TransferCallerIdEnum() { }
            public static implicit operator TransferCallerIdEnum(string value)
            {
                return new TransferCallerIdEnum(value);
            }
            public static readonly TransferCallerIdEnum FromTransferee = new TransferCallerIdEnum("from-transferee");
            public static readonly TransferCallerIdEnum FromTransferor = new TransferCallerIdEnum("from-transferor");

        }


        private static Request BuildCreateRequest(CreateTrunkOptions options, IKandyRestClient client)
        {

            string path = "/v1/Trunks";


            return new Request(
                HttpMethod.Post,
                Rest.Domain.Trunking,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> create </summary>
        /// <param name="options"> Create Trunk parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trunk </returns>
        public static TrunkResource Create(CreateTrunkOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> create </summary>
        /// <param name="options"> Create Trunk parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trunk </returns>
        public static async System.Threading.Tasks.Task<TrunkResource> CreateAsync(CreateTrunkOptions options,
        IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> create </summary>
        /// <param name="friendlyName"> A descriptive string that you create to describe the resource. It can be up to 64 characters long. </param>
        /// <param name="domainName"> The unique address you reserve on Twilio to which you route your SIP traffic. Domain names can contain letters, digits, and `-` and must end with `pstn.twilio.com`. See [Termination Settings](https://www.twilio.com/docs/sip-trunking#termination) for more information. </param>
        /// <param name="disasterRecoveryUrl"> The URL we should call using the `disaster_recovery_method` if an error occurs while sending SIP traffic towards the configured Origination URL. We retrieve TwiML from the URL and execute the instructions like any other normal TwiML call. See [Disaster Recovery](https://www.twilio.com/docs/sip-trunking#disaster-recovery) for more information. </param>
        /// <param name="disasterRecoveryMethod"> The HTTP method we should use to call the `disaster_recovery_url`. Can be: `GET` or `POST`. </param>
        /// <param name="transferMode">  </param>
        /// <param name="secure"> Whether Secure Trunking is enabled for the trunk. If enabled, all calls going through the trunk will be secure using SRTP for media and TLS for signaling. If disabled, then RTP will be used for media. See [Secure Trunking](https://www.twilio.com/docs/sip-trunking#securetrunking) for more information. </param>
        /// <param name="cnamLookupEnabled"> Whether Caller ID Name (CNAM) lookup should be enabled for the trunk. If enabled, all inbound calls to the SIP Trunk from the United States and Canada automatically perform a CNAM Lookup and display Caller ID data on your phone. See [CNAM Lookups](https://www.twilio.com/docs/sip-trunking#CNAM) for more information. </param>
        /// <param name="transferCallerId">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trunk </returns>
        public static TrunkResource Create(
                                          string friendlyName = null,
                                          string domainName = null,
                                          Uri disasterRecoveryUrl = null,
                                          Twilio.Http.HttpMethod disasterRecoveryMethod = null,
                                          TrunkResource.TransferSettingEnum transferMode = null,
                                          bool? secure = null,
                                          bool? cnamLookupEnabled = null,
                                          TrunkResource.TransferCallerIdEnum transferCallerId = null,
                                          IKandyRestClient client = null)
        {
            var options = new CreateTrunkOptions() { FriendlyName = friendlyName, DomainName = domainName, DisasterRecoveryUrl = disasterRecoveryUrl, DisasterRecoveryMethod = disasterRecoveryMethod, TransferMode = transferMode, Secure = secure, CnamLookupEnabled = cnamLookupEnabled, TransferCallerId = transferCallerId };
            return Create(options, client);
        }

#if !NET35
        /// <summary> create </summary>
        /// <param name="friendlyName"> A descriptive string that you create to describe the resource. It can be up to 64 characters long. </param>
        /// <param name="domainName"> The unique address you reserve on Twilio to which you route your SIP traffic. Domain names can contain letters, digits, and `-` and must end with `pstn.twilio.com`. See [Termination Settings](https://www.twilio.com/docs/sip-trunking#termination) for more information. </param>
        /// <param name="disasterRecoveryUrl"> The URL we should call using the `disaster_recovery_method` if an error occurs while sending SIP traffic towards the configured Origination URL. We retrieve TwiML from the URL and execute the instructions like any other normal TwiML call. See [Disaster Recovery](https://www.twilio.com/docs/sip-trunking#disaster-recovery) for more information. </param>
        /// <param name="disasterRecoveryMethod"> The HTTP method we should use to call the `disaster_recovery_url`. Can be: `GET` or `POST`. </param>
        /// <param name="transferMode">  </param>
        /// <param name="secure"> Whether Secure Trunking is enabled for the trunk. If enabled, all calls going through the trunk will be secure using SRTP for media and TLS for signaling. If disabled, then RTP will be used for media. See [Secure Trunking](https://www.twilio.com/docs/sip-trunking#securetrunking) for more information. </param>
        /// <param name="cnamLookupEnabled"> Whether Caller ID Name (CNAM) lookup should be enabled for the trunk. If enabled, all inbound calls to the SIP Trunk from the United States and Canada automatically perform a CNAM Lookup and display Caller ID data on your phone. See [CNAM Lookups](https://www.twilio.com/docs/sip-trunking#CNAM) for more information. </param>
        /// <param name="transferCallerId">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trunk </returns>
        public static async System.Threading.Tasks.Task<TrunkResource> CreateAsync(
                                                                                  string friendlyName = null,
                                                                                  string domainName = null,
                                                                                  Uri disasterRecoveryUrl = null,
                                                                                  Twilio.Http.HttpMethod disasterRecoveryMethod = null,
                                                                                  TrunkResource.TransferSettingEnum transferMode = null,
                                                                                  bool? secure = null,
                                                                                  bool? cnamLookupEnabled = null,
                                                                                  TrunkResource.TransferCallerIdEnum transferCallerId = null,
                                                                                  IKandyRestClient client = null)
        {
            var options = new CreateTrunkOptions() { FriendlyName = friendlyName, DomainName = domainName, DisasterRecoveryUrl = disasterRecoveryUrl, DisasterRecoveryMethod = disasterRecoveryMethod, TransferMode = transferMode, Secure = secure, CnamLookupEnabled = cnamLookupEnabled, TransferCallerId = transferCallerId };
            return await CreateAsync(options, client);
        }
#endif

        /// <summary> delete </summary>
        /// <param name="options"> Delete Trunk parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trunk </returns>
        private static Request BuildDeleteRequest(DeleteTrunkOptions options, IKandyRestClient client)
        {

            string path = "/v1/Trunks/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Trunking,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> delete </summary>
        /// <param name="options"> Delete Trunk parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trunk </returns>
        public static bool Delete(DeleteTrunkOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

#if !NET35
        /// <summary> delete </summary>
        /// <param name="options"> Delete Trunk parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trunk </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteTrunkOptions options,
                                                                          IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
#endif

        /// <summary> delete </summary>
        /// <param name="pathSid"> The unique string that we created to identify the Trunk resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trunk </returns>
        public static bool Delete(string pathSid, IKandyRestClient client = null)
        {
            var options = new DeleteTrunkOptions(pathSid);
            return Delete(options, client);
        }

#if !NET35
        /// <summary> delete </summary>
        /// <param name="pathSid"> The unique string that we created to identify the Trunk resource to delete. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trunk </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, IKandyRestClient client = null)
        {
            var options = new DeleteTrunkOptions(pathSid);
            return await DeleteAsync(options, client);
        }
#endif

        private static Request BuildFetchRequest(FetchTrunkOptions options, IKandyRestClient client)
        {

            string path = "/v1/Trunks/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Trunking,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Trunk parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trunk </returns>
        public static TrunkResource Fetch(FetchTrunkOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Trunk parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trunk </returns>
        public static async System.Threading.Tasks.Task<TrunkResource> FetchAsync(FetchTrunkOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
#endif
        /// <summary> fetch </summary>
        /// <param name="pathSid"> The unique string that we created to identify the Trunk resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trunk </returns>
        public static TrunkResource Fetch(
                                         string pathSid,
                                         IKandyRestClient client = null)
        {
            var options = new FetchTrunkOptions(pathSid) { };
            return Fetch(options, client);
        }

#if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathSid"> The unique string that we created to identify the Trunk resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trunk </returns>
        public static async System.Threading.Tasks.Task<TrunkResource> FetchAsync(string pathSid, IKandyRestClient client = null)
        {
            var options = new FetchTrunkOptions(pathSid) { };
            return await FetchAsync(options, client);
        }
#endif

        private static Request BuildReadRequest(ReadTrunkOptions options, IKandyRestClient client)
        {

            string path = "/v1/Trunks";


            return new Request(
                HttpMethod.Get,
                Rest.Domain.Trunking,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> read </summary>
        /// <param name="options"> Read Trunk parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trunk </returns>
        public static ResourceSet<TrunkResource> Read(ReadTrunkOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<TrunkResource>.FromJson("trunks", response.Content);
            return new ResourceSet<TrunkResource>(page, options, client);
        }

#if !NET35
        /// <summary> read </summary>
        /// <param name="options"> Read Trunk parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trunk </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<TrunkResource>> ReadAsync(ReadTrunkOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<TrunkResource>.FromJson("trunks", response.Content);
            return new ResourceSet<TrunkResource>(page, options, client);
        }
#endif
        /// <summary> read </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trunk </returns>
        public static ResourceSet<TrunkResource> Read(
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     IKandyRestClient client = null)
        {
            var options = new ReadTrunkOptions() { PageSize = pageSize, Limit = limit };
            return Read(options, client);
        }

#if !NET35
        /// <summary> read </summary>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trunk </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<TrunkResource>> ReadAsync(
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             IKandyRestClient client = null)
        {
            var options = new ReadTrunkOptions() { PageSize = pageSize, Limit = limit };
            return await ReadAsync(options, client);
        }
#endif


        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<TrunkResource> GetPage(string targetUrl, IKandyRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<TrunkResource>.FromJson("trunks", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<TrunkResource> NextPage(Page<TrunkResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<TrunkResource>.FromJson("trunks", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<TrunkResource> PreviousPage(Page<TrunkResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<TrunkResource>.FromJson("trunks", response.Content);
        }


        private static Request BuildUpdateRequest(UpdateTrunkOptions options, IKandyRestClient client)
        {

            string path = "/v1/Trunks/{Sid}";

            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Trunking,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> update </summary>
        /// <param name="options"> Update Trunk parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trunk </returns>
        public static TrunkResource Update(UpdateTrunkOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> update </summary>
        /// <param name="options"> Update Trunk parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trunk </returns>
#if !NET35
        public static async System.Threading.Tasks.Task<TrunkResource> UpdateAsync(UpdateTrunkOptions options,
                                                                                                          IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> update </summary>
        /// <param name="pathSid"> The unique string that we created to identify the OriginationUrl resource to update. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the resource. It can be up to 64 characters long. </param>
        /// <param name="domainName"> The unique address you reserve on Twilio to which you route your SIP traffic. Domain names can contain letters, digits, and `-` and must end with `pstn.twilio.com`. See [Termination Settings](https://www.twilio.com/docs/sip-trunking#termination) for more information. </param>
        /// <param name="disasterRecoveryUrl"> The URL we should call using the `disaster_recovery_method` if an error occurs while sending SIP traffic towards the configured Origination URL. We retrieve TwiML from the URL and execute the instructions like any other normal TwiML call. See [Disaster Recovery](https://www.twilio.com/docs/sip-trunking#disaster-recovery) for more information. </param>
        /// <param name="disasterRecoveryMethod"> The HTTP method we should use to call the `disaster_recovery_url`. Can be: `GET` or `POST`. </param>
        /// <param name="transferMode">  </param>
        /// <param name="secure"> Whether Secure Trunking is enabled for the trunk. If enabled, all calls going through the trunk will be secure using SRTP for media and TLS for signaling. If disabled, then RTP will be used for media. See [Secure Trunking](https://www.twilio.com/docs/sip-trunking#securetrunking) for more information. </param>
        /// <param name="cnamLookupEnabled"> Whether Caller ID Name (CNAM) lookup should be enabled for the trunk. If enabled, all inbound calls to the SIP Trunk from the United States and Canada automatically perform a CNAM Lookup and display Caller ID data on your phone. See [CNAM Lookups](https://www.twilio.com/docs/sip-trunking#CNAM) for more information. </param>
        /// <param name="transferCallerId">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trunk </returns>
        public static TrunkResource Update(
                                          string pathSid,
                                          string friendlyName = null,
                                          string domainName = null,
                                          Uri disasterRecoveryUrl = null,
                                          Twilio.Http.HttpMethod disasterRecoveryMethod = null,
                                          TrunkResource.TransferSettingEnum transferMode = null,
                                          bool? secure = null,
                                          bool? cnamLookupEnabled = null,
                                          TrunkResource.TransferCallerIdEnum transferCallerId = null,
                                          IKandyRestClient client = null)
        {
            var options = new UpdateTrunkOptions(pathSid) { FriendlyName = friendlyName, DomainName = domainName, DisasterRecoveryUrl = disasterRecoveryUrl, DisasterRecoveryMethod = disasterRecoveryMethod, TransferMode = transferMode, Secure = secure, CnamLookupEnabled = cnamLookupEnabled, TransferCallerId = transferCallerId };
            return Update(options, client);
        }

#if !NET35
        /// <summary> update </summary>
        /// <param name="pathSid"> The unique string that we created to identify the OriginationUrl resource to update. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the resource. It can be up to 64 characters long. </param>
        /// <param name="domainName"> The unique address you reserve on Twilio to which you route your SIP traffic. Domain names can contain letters, digits, and `-` and must end with `pstn.twilio.com`. See [Termination Settings](https://www.twilio.com/docs/sip-trunking#termination) for more information. </param>
        /// <param name="disasterRecoveryUrl"> The URL we should call using the `disaster_recovery_method` if an error occurs while sending SIP traffic towards the configured Origination URL. We retrieve TwiML from the URL and execute the instructions like any other normal TwiML call. See [Disaster Recovery](https://www.twilio.com/docs/sip-trunking#disaster-recovery) for more information. </param>
        /// <param name="disasterRecoveryMethod"> The HTTP method we should use to call the `disaster_recovery_url`. Can be: `GET` or `POST`. </param>
        /// <param name="transferMode">  </param>
        /// <param name="secure"> Whether Secure Trunking is enabled for the trunk. If enabled, all calls going through the trunk will be secure using SRTP for media and TLS for signaling. If disabled, then RTP will be used for media. See [Secure Trunking](https://www.twilio.com/docs/sip-trunking#securetrunking) for more information. </param>
        /// <param name="cnamLookupEnabled"> Whether Caller ID Name (CNAM) lookup should be enabled for the trunk. If enabled, all inbound calls to the SIP Trunk from the United States and Canada automatically perform a CNAM Lookup and display Caller ID data on your phone. See [CNAM Lookups](https://www.twilio.com/docs/sip-trunking#CNAM) for more information. </param>
        /// <param name="transferCallerId">  </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trunk </returns>
        public static async System.Threading.Tasks.Task<TrunkResource> UpdateAsync(
                                                                              string pathSid,
                                                                              string friendlyName = null,
                                                                              string domainName = null,
                                                                              Uri disasterRecoveryUrl = null,
                                                                              Twilio.Http.HttpMethod disasterRecoveryMethod = null,
                                                                              TrunkResource.TransferSettingEnum transferMode = null,
                                                                              bool? secure = null,
                                                                              bool? cnamLookupEnabled = null,
                                                                              TrunkResource.TransferCallerIdEnum transferCallerId = null,
                                                                              IKandyRestClient client = null)
        {
            var options = new UpdateTrunkOptions(pathSid) { FriendlyName = friendlyName, DomainName = domainName, DisasterRecoveryUrl = disasterRecoveryUrl, DisasterRecoveryMethod = disasterRecoveryMethod, TransferMode = transferMode, Secure = secure, CnamLookupEnabled = cnamLookupEnabled, TransferCallerId = transferCallerId };
            return await UpdateAsync(options, client);
        }
#endif

        /// <summary>
        /// Converts a JSON string into a TrunkResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> TrunkResource object represented by the provided JSON </returns>
        public static TrunkResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<TrunkResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Trunk resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The unique address you reserve on Twilio to which you route your SIP traffic. Domain names can contain letters, digits, and `-` and must end with `pstn.twilio.com`. See [Termination Settings](https://www.twilio.com/docs/sip-trunking#termination) for more information. </summary> 
        [JsonProperty("domain_name")]
        public string DomainName { get; private set; }

        ///<summary> The HTTP method we use to call the `disaster_recovery_url`. Can be: `GET` or `POST`. </summary> 
        [JsonProperty("disaster_recovery_method")]
        public Twilio.Http.HttpMethod DisasterRecoveryMethod { get; private set; }

        ///<summary> The URL we call using the `disaster_recovery_method` if an error occurs while sending SIP traffic towards the configured Origination URL. We retrieve TwiML from this URL and execute the instructions like any other normal TwiML call. See [Disaster Recovery](https://www.twilio.com/docs/sip-trunking#disaster-recovery) for more information. </summary> 
        [JsonProperty("disaster_recovery_url")]
        public Uri DisasterRecoveryUrl { get; private set; }

        ///<summary> The string that you assigned to describe the resource. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> Whether Secure Trunking is enabled for the trunk. If enabled, all calls going through the trunk will be secure using SRTP for media and TLS for signaling. If disabled, then RTP will be used for media. See [Secure Trunking](https://www.twilio.com/docs/sip-trunking#securetrunking) for more information. </summary> 
        [JsonProperty("secure")]
        public bool? Secure { get; private set; }

        ///<summary> The recording settings for the trunk. Can be: `do-not-record`, `record-from-ringing`, `record-from-answer`. If set to `record-from-ringing` or `record-from-answer`, all calls going through the trunk will be recorded. The only way to change recording parameters is on a sub-resource of a Trunk after it has been created. e.g.`/Trunks/[Trunk_SID]/Recording -XPOST -d'Mode=record-from-answer'`. See [Recording](https://www.twilio.com/docs/sip-trunking#recording) for more information. </summary> 
        [JsonProperty("recording")]
        public object Recording { get; private set; }


        [JsonProperty("transfer_mode")]
        public TrunkResource.TransferSettingEnum TransferMode { get; private set; }


        [JsonProperty("transfer_caller_id")]
        public TrunkResource.TransferCallerIdEnum TransferCallerId { get; private set; }

        ///<summary> Whether Caller ID Name (CNAM) lookup is enabled for the trunk. If enabled, all inbound calls to the SIP Trunk from the United States and Canada automatically perform a CNAM Lookup and display Caller ID data on your phone. See [CNAM Lookups](https://www.twilio.com/docs/sip-trunking#CNAM) for more information. </summary> 
        [JsonProperty("cnam_lookup_enabled")]
        public bool? CnamLookupEnabled { get; private set; }

        ///<summary> The types of authentication mapped to the domain. Can be: `IP_ACL` and `CREDENTIAL_LIST`. If both are mapped, the values are returned in a comma delimited list. If empty, the domain will not receive any traffic. </summary> 
        [JsonProperty("auth_type")]
        public string AuthType { get; private set; }

        ///<summary> Reserved. </summary> 
        [JsonProperty("auth_type_set")]
        public List<string> AuthTypeSet { get; private set; }

        ///<summary> The date and time in GMT when the resource was created specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT when the resource was last updated specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> The unique string that we created to identify the Trunk resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The absolute URL of the resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The URLs of related resources. </summary> 
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }



        private TrunkResource()
        {

        }
    }
}
