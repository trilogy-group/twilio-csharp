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
using System.Linq;



namespace Kandy.Rest.Conversations.V1.Configuration
{
    /// <summary> fetch </summary>
    public class FetchWebhookOptions : IOptions<WebhookResource>
    {
    



        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> update </summary>
    public class UpdateWebhookOptions : IOptions<WebhookResource>
    {
    
        ///<summary> The HTTP method to be used when sending a webhook request. </summary> 
        public string Method { get; set; }

        ///<summary> The list of webhook event triggers that are enabled for this Service: `onMessageAdded`, `onMessageUpdated`, `onMessageRemoved`, `onConversationUpdated`, `onConversationRemoved`, `onParticipantAdded`, `onParticipantUpdated`, `onParticipantRemoved` </summary> 
        public List<string> Filters { get; set; }

        ///<summary> The absolute url the pre-event webhook request should be sent to. </summary> 
        public string PreWebhookUrl { get; set; }

        ///<summary> The absolute url the post-event webhook request should be sent to. </summary> 
        public string PostWebhookUrl { get; set; }

        
        public WebhookResource.TargetEnum Target { get; set; }




        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Method != null)
            {
                p.Add(new KeyValuePair<string, string>("Method", Method));
            }
            if (Filters != null)
            {
                p.AddRange(Filters.Select(Filters => new KeyValuePair<string, string>("Filters", Filters)));
            }
            if (PreWebhookUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("PreWebhookUrl", PreWebhookUrl));
            }
            if (PostWebhookUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("PostWebhookUrl", PostWebhookUrl));
            }
            if (Target != null)
            {
                p.Add(new KeyValuePair<string, string>("Target", Target.ToString()));
            }
            return p;
        }
        

    }


}
