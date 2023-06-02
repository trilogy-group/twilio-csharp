/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Video
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


namespace Kandy.Rest.Video.V1.Room.Participant
{
    public class SubscribedTrackResource : Resource
    {

        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class KindEnum : StringEnum
        {
            private KindEnum(string value) : base(value) { }
            public KindEnum() { }
            public static implicit operator KindEnum(string value)
            {
                return new KindEnum(value);
            }
            public static readonly KindEnum Audio = new KindEnum("audio");
            public static readonly KindEnum Video = new KindEnum("video");
            public static readonly KindEnum Data = new KindEnum("data");

        }


        private static Request BuildFetchRequest(FetchSubscribedTrackOptions options, IKandyRestClient client)
        {

            string path = "/v1/Rooms/{RoomSid}/Participants/{ParticipantSid}/SubscribedTracks/{Sid}";

            string PathRoomSid = options.PathRoomSid;
            path = path.Replace("{" + "RoomSid" + "}", PathRoomSid);
            string PathParticipantSid = options.PathParticipantSid;
            path = path.Replace("{" + "ParticipantSid" + "}", PathParticipantSid);
            string PathSid = options.PathSid;
            path = path.Replace("{" + "Sid" + "}", PathSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Video,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Returns a single Track resource represented by `track_sid`.  Note: This is one resource with the Video API that requires a SID, be Track Name on the subscriber side is not guaranteed to be unique. </summary>
        /// <param name="options"> Fetch SubscribedTrack parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SubscribedTrack </returns>
        public static SubscribedTrackResource Fetch(FetchSubscribedTrackOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> Returns a single Track resource represented by `track_sid`.  Note: This is one resource with the Video API that requires a SID, be Track Name on the subscriber side is not guaranteed to be unique. </summary>
        /// <param name="options"> Fetch SubscribedTrack parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SubscribedTrack </returns>
        public static async System.Threading.Tasks.Task<SubscribedTrackResource> FetchAsync(FetchSubscribedTrackOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
#endif
        /// <summary> Returns a single Track resource represented by `track_sid`.  Note: This is one resource with the Video API that requires a SID, be Track Name on the subscriber side is not guaranteed to be unique. </summary>
        /// <param name="pathRoomSid"> The SID of the Room where the Track resource to fetch is subscribed. </param>
        /// <param name="pathParticipantSid"> The SID of the participant that subscribes to the Track resource to fetch. </param>
        /// <param name="pathSid"> The SID of the RoomParticipantSubscribedTrack resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SubscribedTrack </returns>
        public static SubscribedTrackResource Fetch(
                                         string pathRoomSid,
                                         string pathParticipantSid,
                                         string pathSid,
                                         IKandyRestClient client = null)
        {
            var options = new FetchSubscribedTrackOptions(pathRoomSid, pathParticipantSid, pathSid) { };
            return Fetch(options, client);
        }

#if !NET35
        /// <summary> Returns a single Track resource represented by `track_sid`.  Note: This is one resource with the Video API that requires a SID, be Track Name on the subscriber side is not guaranteed to be unique. </summary>
        /// <param name="pathRoomSid"> The SID of the Room where the Track resource to fetch is subscribed. </param>
        /// <param name="pathParticipantSid"> The SID of the participant that subscribes to the Track resource to fetch. </param>
        /// <param name="pathSid"> The SID of the RoomParticipantSubscribedTrack resource to fetch. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SubscribedTrack </returns>
        public static async System.Threading.Tasks.Task<SubscribedTrackResource> FetchAsync(string pathRoomSid, string pathParticipantSid, string pathSid, IKandyRestClient client = null)
        {
            var options = new FetchSubscribedTrackOptions(pathRoomSid, pathParticipantSid, pathSid) { };
            return await FetchAsync(options, client);
        }
#endif

        private static Request BuildReadRequest(ReadSubscribedTrackOptions options, IKandyRestClient client)
        {

            string path = "/v1/Rooms/{RoomSid}/Participants/{ParticipantSid}/SubscribedTracks";

            string PathRoomSid = options.PathRoomSid;
            path = path.Replace("{" + "RoomSid" + "}", PathRoomSid);
            string PathParticipantSid = options.PathParticipantSid;
            path = path.Replace("{" + "ParticipantSid" + "}", PathParticipantSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Video,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Returns a list of tracks that are subscribed for the participant. </summary>
        /// <param name="options"> Read SubscribedTrack parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SubscribedTrack </returns>
        public static ResourceSet<SubscribedTrackResource> Read(ReadSubscribedTrackOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<SubscribedTrackResource>.FromJson("subscribed_tracks", response.Content);
            return new ResourceSet<SubscribedTrackResource>(page, options, client);
        }

#if !NET35
        /// <summary> Returns a list of tracks that are subscribed for the participant. </summary>
        /// <param name="options"> Read SubscribedTrack parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SubscribedTrack </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<SubscribedTrackResource>> ReadAsync(ReadSubscribedTrackOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<SubscribedTrackResource>.FromJson("subscribed_tracks", response.Content);
            return new ResourceSet<SubscribedTrackResource>(page, options, client);
        }
#endif
        /// <summary> Returns a list of tracks that are subscribed for the participant. </summary>
        /// <param name="pathRoomSid"> The SID of the Room resource with the Track resources to read. </param>
        /// <param name="pathParticipantSid"> The SID of the participant that subscribes to the Track resources to read. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SubscribedTrack </returns>
        public static ResourceSet<SubscribedTrackResource> Read(
                                                     string pathRoomSid,
                                                     string pathParticipantSid,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     IKandyRestClient client = null)
        {
            var options = new ReadSubscribedTrackOptions(pathRoomSid, pathParticipantSid) { PageSize = pageSize, Limit = limit };
            return Read(options, client);
        }

#if !NET35
        /// <summary> Returns a list of tracks that are subscribed for the participant. </summary>
        /// <param name="pathRoomSid"> The SID of the Room resource with the Track resources to read. </param>
        /// <param name="pathParticipantSid"> The SID of the participant that subscribes to the Track resources to read. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SubscribedTrack </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<SubscribedTrackResource>> ReadAsync(
                                                                                             string pathRoomSid,
                                                                                             string pathParticipantSid,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             IKandyRestClient client = null)
        {
            var options = new ReadSubscribedTrackOptions(pathRoomSid, pathParticipantSid) { PageSize = pageSize, Limit = limit };
            return await ReadAsync(options, client);
        }
#endif


        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<SubscribedTrackResource> GetPage(string targetUrl, IKandyRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<SubscribedTrackResource>.FromJson("subscribed_tracks", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<SubscribedTrackResource> NextPage(Page<SubscribedTrackResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<SubscribedTrackResource>.FromJson("subscribed_tracks", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<SubscribedTrackResource> PreviousPage(Page<SubscribedTrackResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<SubscribedTrackResource>.FromJson("subscribed_tracks", response.Content);
        }


        /// <summary>
        /// Converts a JSON string into a SubscribedTrackResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> SubscribedTrackResource object represented by the provided JSON </returns>
        public static SubscribedTrackResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<SubscribedTrackResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> The unique string that we created to identify the RoomParticipantSubscribedTrack resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the participant that subscribes to the track. </summary> 
        [JsonProperty("participant_sid")]
        public string ParticipantSid { get; private set; }

        ///<summary> The SID of the participant that publishes the track. </summary> 
        [JsonProperty("publisher_sid")]
        public string PublisherSid { get; private set; }

        ///<summary> The SID of the room where the track is published. </summary> 
        [JsonProperty("room_sid")]
        public string RoomSid { get; private set; }

        ///<summary> The track name. Must have no more than 128 characters and be unique among the participant's published tracks. </summary> 
        [JsonProperty("name")]
        public string Name { get; private set; }

        ///<summary> The date and time in GMT when the resource was created specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date and time in GMT when the resource was last updated specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        ///<summary> Whether the track is enabled. </summary> 
        [JsonProperty("enabled")]
        public bool? Enabled { get; private set; }


        [JsonProperty("kind")]
        public SubscribedTrackResource.KindEnum Kind { get; private set; }

        ///<summary> The absolute URL of the resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }



        private SubscribedTrackResource()
        {

        }
    }
}
