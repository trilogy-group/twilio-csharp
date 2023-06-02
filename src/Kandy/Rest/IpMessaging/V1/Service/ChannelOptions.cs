/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Ip_messaging
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
using System.Linq;



namespace Kandy.Rest.IpMessaging.V1.Service
{

    /// <summary> create </summary>
    public class CreateChannelOptions : IOptions<ChannelResource>
    {


        public string PathServiceSid { get; }


        public string FriendlyName { get; set; }


        public string UniqueName { get; set; }


        public string Attributes { get; set; }


        public ChannelResource.ChannelTypeEnum Type { get; set; }


        /// <summary> Construct a new CreateChannelOptions </summary>
        /// <param name="pathServiceSid">  </param>
        public CreateChannelOptions(string pathServiceSid)
        {
            PathServiceSid = pathServiceSid;
        }


        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }
            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Attributes));
            }
            if (Type != null)
            {
                p.Add(new KeyValuePair<string, string>("Type", Type.ToString()));
            }
            return p;
        }


    }
    /// <summary> delete </summary>
    public class DeleteChannelOptions : IOptions<ChannelResource>
    {


        public string PathServiceSid { get; }


        public string PathSid { get; }



        /// <summary> Construct a new DeleteChannelOptions </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathSid">  </param>
        public DeleteChannelOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
        }


        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }


    }


    /// <summary> fetch </summary>
    public class FetchChannelOptions : IOptions<ChannelResource>
    {


        public string PathServiceSid { get; }


        public string PathSid { get; }



        /// <summary> Construct a new FetchChannelOptions </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathSid">  </param>
        public FetchChannelOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
        }


        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }


    }


    /// <summary> read </summary>
    public class ReadChannelOptions : ReadOptions<ChannelResource>
    {


        public string PathServiceSid { get; }


        public List<ChannelResource.ChannelTypeEnum> Type { get; set; }



        /// <summary> Construct a new ListChannelOptions </summary>
        /// <param name="pathServiceSid">  </param>
        public ReadChannelOptions(string pathServiceSid)
        {
            PathServiceSid = pathServiceSid;
            Type = new List<ChannelResource.ChannelTypeEnum>();
        }


        /// <summary> Generate the necessary parameters </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Type != null)
            {
                p.AddRange(Type.Select(Type => new KeyValuePair<string, string>("Type", Type.ToString())));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }


    }

    /// <summary> update </summary>
    public class UpdateChannelOptions : IOptions<ChannelResource>
    {


        public string PathServiceSid { get; }


        public string PathSid { get; }


        public string FriendlyName { get; set; }


        public string UniqueName { get; set; }


        public string Attributes { get; set; }



        /// <summary> Construct a new UpdateChannelOptions </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathSid">  </param>
        public UpdateChannelOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
        }


        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }
            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Attributes));
            }
            return p;
        }


    }


}
