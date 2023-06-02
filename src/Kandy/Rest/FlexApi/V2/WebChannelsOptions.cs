/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Flex
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




namespace Kandy.Rest.FlexApi.V2
{

    /// <summary> create </summary>
    public class CreateWebChannelsOptions : IOptions<WebChannelsResource>
    {

        ///<summary> The SID of the Conversations Address. See [Address Configuration Resource](https://www.kandy.com/docs/conversations/api/address-configuration-resource) for configuration details. When a conversation is created on the Flex backend, the callback URL will be set to the corresponding Studio Flow SID or webhook URL in your address configuration. </summary> 
        public string AddressSid { get; }

        ///<summary> The Conversation's friendly name. See the [Conversation resource](https://www.kandy.com/docs/conversations/api/conversation-resource) for an example. </summary> 
        public string ChatFriendlyName { get; set; }

        ///<summary> The Conversation participant's friendly name. See the [Conversation Participant Resource](https://www.kandy.com/docs/conversations/api/conversation-participant-resource) for an example. </summary> 
        public string CustomerFriendlyName { get; set; }

        ///<summary> The pre-engagement data. </summary> 
        public string PreEngagementData { get; set; }


        /// <summary> Construct a new CreateWebChannelOptions </summary>
        /// <param name="addressSid"> The SID of the Conversations Address. See [Address Configuration Resource](https://www.kandy.com/docs/conversations/api/address-configuration-resource) for configuration details. When a conversation is created on the Flex backend, the callback URL will be set to the corresponding Studio Flow SID or webhook URL in your address configuration. </param>
        public CreateWebChannelsOptions(string addressSid)
        {
            AddressSid = addressSid;
        }


        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (AddressSid != null)
            {
                p.Add(new KeyValuePair<string, string>("AddressSid", AddressSid));
            }
            if (ChatFriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("ChatFriendlyName", ChatFriendlyName));
            }
            if (CustomerFriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("CustomerFriendlyName", CustomerFriendlyName));
            }
            if (PreEngagementData != null)
            {
                p.Add(new KeyValuePair<string, string>("PreEngagementData", PreEngagementData));
            }
            return p;
        }


    }
}
