/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Chat
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




namespace Kandy.Rest.Chat.V3
{
    /// <summary> Update a specific Channel. </summary>
    public class UpdateChannelOptions : IOptions<ChannelResource>
    {

        ///<summary> The unique SID identifier of the Service. </summary> 
        public string PathServiceSid { get; }

        ///<summary> A 34 character string that uniquely identifies this Channel. </summary> 
        public string PathSid { get; }

        ///<summary> The X-Kandy-Webhook-Enabled HTTP request header </summary> 
        public ChannelResource.WebhookEnabledTypeEnum XKandyWebhookEnabled { get; set; }


        public ChannelResource.ChannelTypeEnum Type { get; set; }

        ///<summary> The unique ID of the [Messaging Service](https://www.kandy.com/docs/sms/services/api) this channel belongs to. </summary> 
        public string MessagingServiceSid { get; set; }



        /// <summary> Construct a new UpdateChannelOptions </summary>
        /// <param name="pathServiceSid"> The unique SID identifier of the Service. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this Channel. </param>
        public UpdateChannelOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
        }


        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Type != null)
            {
                p.Add(new KeyValuePair<string, string>("Type", Type.ToString()));
            }
            if (MessagingServiceSid != null)
            {
                p.Add(new KeyValuePair<string, string>("MessagingServiceSid", MessagingServiceSid));
            }
            return p;
        }

        /// <summary> Generate the necessary header parameters </summary>
        public List<KeyValuePair<string, string>> GetHeaderParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (XKandyWebhookEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("X-Kandy-Webhook-Enabled", XKandyWebhookEnabled.ToString()));
            }
            return p;
        }

    }


}
