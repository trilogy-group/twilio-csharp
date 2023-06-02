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


using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;




namespace Kandy.Rest.Video.V1.Room.Participant
{
    /// <summary> Returns a single Track resource represented by TrackName or SID. </summary>
    public class FetchPublishedTrackOptions : IOptions<PublishedTrackResource>
    {
    
        ///<summary> The SID of the Room resource where the Track resource to fetch is published. </summary> 
        public string PathRoomSid { get; }

        ///<summary> The SID of the Participant resource with the published track to fetch. </summary> 
        public string PathParticipantSid { get; }

        ///<summary> The SID of the RoomParticipantPublishedTrack resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchRoomParticipantPublishedTrackOptions </summary>
        /// <param name="pathRoomSid"> The SID of the Room resource where the Track resource to fetch is published. </param>
        /// <param name="pathParticipantSid"> The SID of the Participant resource with the published track to fetch. </param>
        /// <param name="pathSid"> The SID of the RoomParticipantPublishedTrack resource to fetch. </param>
        public FetchPublishedTrackOptions(string pathRoomSid, string pathParticipantSid, string pathSid)
        {
            PathRoomSid = pathRoomSid;
            PathParticipantSid = pathParticipantSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Returns a list of tracks associated with a given Participant. Only `currently` Published Tracks are in the list resource. </summary>
    public class ReadPublishedTrackOptions : ReadOptions<PublishedTrackResource>
    {
    
        ///<summary> The SID of the Room resource where the Track resources to read are published. </summary> 
        public string PathRoomSid { get; }

        ///<summary> The SID of the Participant resource with the published tracks to read. </summary> 
        public string PathParticipantSid { get; }



        /// <summary> Construct a new ListRoomParticipantPublishedTrackOptions </summary>
        /// <param name="pathRoomSid"> The SID of the Room resource where the Track resources to read are published. </param>
        /// <param name="pathParticipantSid"> The SID of the Participant resource with the published tracks to read. </param>
        public ReadPublishedTrackOptions(string pathRoomSid, string pathParticipantSid)
        {
            PathRoomSid = pathRoomSid;
            PathParticipantSid = pathParticipantSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

}
