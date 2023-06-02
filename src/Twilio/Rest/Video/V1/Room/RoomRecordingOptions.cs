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




namespace Kandy.Rest.Video.V1.Room
{
    /// <summary> delete </summary>
    public class DeleteRoomRecordingOptions : IOptions<RoomRecordingResource>
    {
        
        ///<summary> The SID of the room with the RoomRecording resource to delete. </summary> 
        public string PathRoomSid { get; }

        ///<summary> The SID of the RoomRecording resource to delete. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteRoomRecordingOptions </summary>
        /// <param name="pathRoomSid"> The SID of the room with the RoomRecording resource to delete. </param>
        /// <param name="pathSid"> The SID of the RoomRecording resource to delete. </param>
        public DeleteRoomRecordingOptions(string pathRoomSid, string pathSid)
        {
            PathRoomSid = pathRoomSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> fetch </summary>
    public class FetchRoomRecordingOptions : IOptions<RoomRecordingResource>
    {
    
        ///<summary> The SID of the Room resource with the recording to fetch. </summary> 
        public string PathRoomSid { get; }

        ///<summary> The SID of the RoomRecording resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchRoomRecordingOptions </summary>
        /// <param name="pathRoomSid"> The SID of the Room resource with the recording to fetch. </param>
        /// <param name="pathSid"> The SID of the RoomRecording resource to fetch. </param>
        public FetchRoomRecordingOptions(string pathRoomSid, string pathSid)
        {
            PathRoomSid = pathRoomSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> read </summary>
    public class ReadRoomRecordingOptions : ReadOptions<RoomRecordingResource>
    {
    
        ///<summary> The SID of the room with the RoomRecording resources to read. </summary> 
        public string PathRoomSid { get; }

        ///<summary> Read only the recordings with this status. Can be: `processing`, `completed`, or `deleted`. </summary> 
        public RoomRecordingResource.StatusEnum Status { get; set; }

        ///<summary> Read only the recordings that have this `source_sid`. </summary> 
        public string SourceSid { get; set; }

        ///<summary> Read only recordings that started on or after this [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) datetime with time zone. </summary> 
        public DateTime? DateCreatedAfter { get; set; }

        ///<summary> Read only Recordings that started before this [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) datetime with time zone. </summary> 
        public DateTime? DateCreatedBefore { get; set; }



        /// <summary> Construct a new ListRoomRecordingOptions </summary>
        /// <param name="pathRoomSid"> The SID of the room with the RoomRecording resources to read. </param>
        public ReadRoomRecordingOptions(string pathRoomSid)
        {
            PathRoomSid = pathRoomSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }
            if (SourceSid != null)
            {
                p.Add(new KeyValuePair<string, string>("SourceSid", SourceSid));
            }
            if (DateCreatedAfter != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreatedAfter", Serializers.DateTimeIso8601(DateCreatedAfter)));
            }
            if (DateCreatedBefore != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreatedBefore", Serializers.DateTimeIso8601(DateCreatedBefore)));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

}
