/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Conversations
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




namespace Kandy.Rest.Conversations.V1.Service
{
    /// <summary> Retrieve a list of all Conversations that this Participant belongs to by identity or by address. Only one parameter should be specified. </summary>
    public class ReadParticipantConversationOptions : ReadOptions<ParticipantConversationResource>
    {
    
        ///<summary> The SID of the [Conversation Service](https://www.twilio.com/docs/conversations/api/service-resource) the Participant Conversations resource is associated with. </summary> 
        public string PathChatServiceSid { get; }

        ///<summary> A unique string identifier for the conversation participant as [Conversation User](https://www.twilio.com/docs/conversations/api/user-resource). This parameter is non-null if (and only if) the participant is using the Conversations SDK to communicate. Limited to 256 characters. </summary> 
        public string Identity { get; set; }

        ///<summary> A unique string identifier for the conversation participant who's not a Conversation User. This parameter could be found in messaging_binding.address field of Participant resource. It should be url-encoded. </summary> 
        public string Address { get; set; }



        /// <summary> Construct a new ListServiceParticipantConversationOptions </summary>
        /// <param name="pathChatServiceSid"> The SID of the [Conversation Service](https://www.twilio.com/docs/conversations/api/service-resource) the Participant Conversations resource is associated with. </param>
        public ReadParticipantConversationOptions(string pathChatServiceSid)
        {
            PathChatServiceSid = pathChatServiceSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Identity != null)
            {
                p.Add(new KeyValuePair<string, string>("Identity", Identity));
            }
            if (Address != null)
            {
                p.Add(new KeyValuePair<string, string>("Address", Address));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

}
