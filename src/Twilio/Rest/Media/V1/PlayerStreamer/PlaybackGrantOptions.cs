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


using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;




namespace Kandy.Rest.Media.V1.PlayerStreamer
{

    /// <summary> create </summary>
    public class CreatePlaybackGrantOptions : IOptions<PlaybackGrantResource>
    {
        
        ///<summary> The unique string generated to identify the PlayerStreamer resource associated with this PlaybackGrant </summary> 
        public string PathSid { get; }

        ///<summary> The time to live of the PlaybackGrant. Default value is 15 seconds. Maximum value is 60 seconds. </summary> 
        public int? Ttl { get; set; }

        ///<summary> The full origin URL where the livestream can be streamed. If this is not provided, it can be streamed from any domain. </summary> 
        public string AccessControlAllowOrigin { get; set; }


        /// <summary> Construct a new CreatePlayerStreamerPlaybackGrantOptions </summary>
        /// <param name="pathSid"> The unique string generated to identify the PlayerStreamer resource associated with this PlaybackGrant </param>
        public CreatePlaybackGrantOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Ttl != null)
            {
                p.Add(new KeyValuePair<string, string>("Ttl", Ttl.ToString()));
            }
            if (AccessControlAllowOrigin != null)
            {
                p.Add(new KeyValuePair<string, string>("AccessControlAllowOrigin", AccessControlAllowOrigin));
            }
            return p;
        }
        

    }
    /// <summary> **This method is not enabled.** Returns a single PlaybackGrant resource identified by a SID. </summary>
    public class FetchPlaybackGrantOptions : IOptions<PlaybackGrantResource>
    {
    
        ///<summary> The SID of the PlayerStreamer resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchPlayerStreamerPlaybackGrantOptions </summary>
        /// <param name="pathSid"> The SID of the PlayerStreamer resource to fetch. </param>
        public FetchPlaybackGrantOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


}
