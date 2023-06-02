/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Media
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



namespace Kandy.Rest.Media.V1.PlayerStreamer
{
    public class PlaybackGrantResource : Resource
    {



        private static Request BuildCreateRequest(CreatePlaybackGrantOptions options, IKandyRestClient client)
        {

            string path = "/v1/PlayerStreamers/{Sid}/PlaybackGrant";

            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Media,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> create </summary>
        /// <param name="options"> Create PlaybackGrant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PlaybackGrant </returns>
        public static PlaybackGrantResource Create(CreatePlaybackGrantOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> create </summary>
        /// <param name="options"> Create PlaybackGrant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PlaybackGrant </returns>
        public static async System.Threading.Tasks.Task<PlaybackGrantResource> CreateAsync(CreatePlaybackGrantOptions options,
        IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> create </summary>
        /// <param name="pathSid"> The unique string generated to identify the PlayerStreamer resource associated with this PlaybackGrant </param>
        /// <param name="ttl"> The time to live of the PlaybackGrant. Default value is 15 seconds. Maximum value is 60 seconds. </param>
        /// <param name="accessControlAllowOrigin"> The full origin URL where the livestream can be streamed. If this is not provided, it can be streamed from any domain. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PlaybackGrant </returns>
        public static PlaybackGrantResource Create(
                                          string pathSid,
                                          int? ttl = null,
                                          string accessControlAllowOrigin = null,
                                          IKandyRestClient client = null)
        {
            var options = new CreatePlaybackGrantOptions(pathSid) { Ttl = ttl, AccessControlAllowOrigin = accessControlAllowOrigin };
            return Create(options, client);
        }

#if !NET35
        /// <summary> create </summary>
        /// <param name="pathSid"> The unique string generated to identify the PlayerStreamer resource associated with this PlaybackGrant </param>
        /// <param name="ttl"> The time to live of the PlaybackGrant. Default value is 15 seconds. Maximum value is 60 seconds. </param>
        /// <param name="accessControlAllowOrigin"> The full origin URL where the livestream can be streamed. If this is not provided, it can be streamed from any domain. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PlaybackGrant </returns>
        public static async System.Threading.Tasks.Task<PlaybackGrantResource> CreateAsync(
                                                                                  string pathSid,
                                                                                  int? ttl = null,
                                                                                  string accessControlAllowOrigin = null,
                                                                                  IKandyRestClient client = null)
        {
            var options = new CreatePlaybackGrantOptions(pathSid) { Ttl = ttl, AccessControlAllowOrigin = accessControlAllowOrigin };
            return await CreateAsync(options, client);
        }
#endif

        private static Request BuildFetchRequest(FetchPlaybackGrantOptions options, IKandyRestClient client)
        {

            string path = "/v1/PlayerStreamers/{Sid}/PlaybackGrant";

            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Media,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> **This method is not enabled.** Returns a single PlaybackGrant resource identified by a SID. </summary>
        /// <param name="options"> Fetch PlaybackGrant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PlaybackGrant </returns>
        public static PlaybackGrantResource Fetch(FetchPlaybackGrantOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> **This method is not enabled.** Returns a single PlaybackGrant resource identified by a SID. </summary>
        /// <param name="options"> Fetch PlaybackGrant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PlaybackGrant </returns>
        public static async System.Threading.Tasks.Task<PlaybackGrantResource> FetchAsync(FetchPlaybackGrantOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
#endif
        /// <summary> **This method is not enabled.** Returns a single PlaybackGrant resource identified by a SID. </summary>
        /// <param name="pathSid"> The SID of the PlayerStreamer resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PlaybackGrant </returns>
        public static PlaybackGrantResource Fetch(
                                         string pathSid,
                                         IKandyRestClient client = null)
        {
            var options = new FetchPlaybackGrantOptions(pathSid) { };
            return Fetch(options, client);
        }

#if !NET35
        /// <summary> **This method is not enabled.** Returns a single PlaybackGrant resource identified by a SID. </summary>
        /// <param name="pathSid"> The SID of the PlayerStreamer resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PlaybackGrant </returns>
        public static async System.Threading.Tasks.Task<PlaybackGrantResource> FetchAsync(string pathSid, IKandyRestClient client = null)
        {
            var options = new FetchPlaybackGrantOptions(pathSid) { };
            return await FetchAsync(options, client);
        }
#endif

        /// <summary>
        /// Converts a JSON string into a PlaybackGrantResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> PlaybackGrantResource object represented by the provided JSON </returns>
        public static PlaybackGrantResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<PlaybackGrantResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> The unique string generated to identify the PlayerStreamer resource that this PlaybackGrant authorizes views for. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The absolute URL of the resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created this resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The date and time in GMT when the resource was created specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The grant that authorizes the player sdk to connect to the livestream </summary> 
        [JsonProperty("grant")]
        public object Grant { get; private set; }



        private PlaybackGrantResource()
        {

        }
    }
}
