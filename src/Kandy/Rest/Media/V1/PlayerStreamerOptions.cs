/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Media
 * This is the public Kandy REST API.
 *
 * NOTE: This class is auto generated by OpenAPI Generator.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


using System;
using System.Collections.Generic;
using Kandy.Base;
using Kandy.Converters;




namespace Kandy.Rest.Media.V1
{

    /// <summary> create </summary>
    public class CreatePlayerStreamerOptions : IOptions<PlayerStreamerResource>
    {

        ///<summary> Specifies whether the PlayerStreamer is configured to stream video. Defaults to `true`. </summary> 
        public bool? Video { get; set; }

        ///<summary> The URL to which Kandy will send asynchronous webhook requests for every PlayerStreamer event. See [Status Callbacks](/docs/live/status-callbacks) for more details. </summary> 
        public Uri StatusCallback { get; set; }

        ///<summary> The HTTP method Kandy should use to call the `status_callback` URL. Can be `POST` or `GET` and the default is `POST`. </summary> 
        public Kandy.Http.HttpMethod StatusCallbackMethod { get; set; }

        ///<summary> The maximum time, in seconds, that the PlayerStreamer is active (`created` or `started`) before automatically ends. The default value is 300 seconds, and the maximum value is 90000 seconds. Once this maximum duration is reached, Kandy will end the PlayerStreamer, regardless of whether media is still streaming. </summary> 
        public int? MaxDuration { get; set; }




        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Video != null)
            {
                p.Add(new KeyValuePair<string, string>("Video", Video.Value.ToString().ToLower()));
            }
            if (StatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallback", Serializers.Url(StatusCallback)));
            }
            if (StatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallbackMethod", StatusCallbackMethod.ToString()));
            }
            if (MaxDuration != null)
            {
                p.Add(new KeyValuePair<string, string>("MaxDuration", MaxDuration.ToString()));
            }
            return p;
        }


    }
    /// <summary> Returns a single PlayerStreamer resource identified by a SID. </summary>
    public class FetchPlayerStreamerOptions : IOptions<PlayerStreamerResource>
    {

        ///<summary> The SID of the PlayerStreamer resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchPlayerStreamerOptions </summary>
        /// <param name="pathSid"> The SID of the PlayerStreamer resource to fetch. </param>
        public FetchPlayerStreamerOptions(string pathSid)
        {
            PathSid = pathSid;
        }


        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }


    }


    /// <summary> Returns a list of PlayerStreamers. </summary>
    public class ReadPlayerStreamerOptions : ReadOptions<PlayerStreamerResource>
    {

        ///<summary> The sort order of the list by `date_created`. Can be: `asc` (ascending) or `desc` (descending) with `desc` as the default. </summary> 
        public PlayerStreamerResource.OrderEnum Order { get; set; }

        ///<summary> Status to filter by, with possible values `created`, `started`, `ended`, or `failed`. </summary> 
        public PlayerStreamerResource.StatusEnum Status { get; set; }





        /// <summary> Generate the necessary parameters </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Order != null)
            {
                p.Add(new KeyValuePair<string, string>("Order", Order.ToString()));
            }
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }


    }

    /// <summary> Updates a PlayerStreamer resource identified by a SID. </summary>
    public class UpdatePlayerStreamerOptions : IOptions<PlayerStreamerResource>
    {

        ///<summary> The SID of the PlayerStreamer resource to update. </summary> 
        public string PathSid { get; }


        public PlayerStreamerResource.UpdateStatusEnum Status { get; }



        /// <summary> Construct a new UpdatePlayerStreamerOptions </summary>
        /// <param name="pathSid"> The SID of the PlayerStreamer resource to update. </param>
        /// <param name="status">  </param>
        public UpdatePlayerStreamerOptions(string pathSid, PlayerStreamerResource.UpdateStatusEnum status)
        {
            PathSid = pathSid;
            Status = status;
        }


        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }
            return p;
        }


    }


}
