/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Autopilot
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




namespace Kandy.Rest.Autopilot.V1.Assistant
{

    /// <summary> create </summary>
    public class CreateWebhookOptions : IOptions<WebhookResource>
    {
        
        ///<summary> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the new resource. </summary> 
        public string PathAssistantSid { get; }

        ///<summary> An application-defined string that uniquely identifies the new resource. It can be used as an alternative to the `sid` in the URL path to address the resource. This value must be unique and 64 characters or less in length. </summary> 
        public string UniqueName { get; }

        ///<summary> The list of space-separated events that this Webhook will subscribe to. </summary> 
        public string Events { get; }

        ///<summary> The URL associated with this Webhook. </summary> 
        public Uri WebhookUrl { get; }

        ///<summary> The method to be used when calling the webhook's URL. </summary> 
        public string WebhookMethod { get; set; }


        /// <summary> Construct a new CreateWebhookOptions </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the new resource. </param>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the new resource. It can be used as an alternative to the `sid` in the URL path to address the resource. This value must be unique and 64 characters or less in length. </param>
        /// <param name="events"> The list of space-separated events that this Webhook will subscribe to. </param>
        /// <param name="webhookUrl"> The URL associated with this Webhook. </param>
        public CreateWebhookOptions(string pathAssistantSid, string uniqueName, string events, Uri webhookUrl)
        {
            PathAssistantSid = pathAssistantSid;
            UniqueName = uniqueName;
            Events = events;
            WebhookUrl = webhookUrl;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }
            if (Events != null)
            {
                p.Add(new KeyValuePair<string, string>("Events", Events));
            }
            if (WebhookUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("WebhookUrl", Serializers.Url(WebhookUrl)));
            }
            if (WebhookMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("WebhookMethod", WebhookMethod));
            }
            return p;
        }
        

    }
    /// <summary> delete </summary>
    public class DeleteWebhookOptions : IOptions<WebhookResource>
    {
        
        ///<summary> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the resources to delete. </summary> 
        public string PathAssistantSid { get; }

        ///<summary> The Twilio-provided string that uniquely identifies the Webhook resource to delete. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteWebhookOptions </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the resources to delete. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Webhook resource to delete. </param>
        public DeleteWebhookOptions(string pathAssistantSid, string pathSid)
        {
            PathAssistantSid = pathAssistantSid;
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
    public class FetchWebhookOptions : IOptions<WebhookResource>
    {
    
        ///<summary> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the resource to fetch. </summary> 
        public string PathAssistantSid { get; }

        ///<summary> The Twilio-provided string that uniquely identifies the Webhook resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchWebhookOptions </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the resource to fetch. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Webhook resource to fetch. </param>
        public FetchWebhookOptions(string pathAssistantSid, string pathSid)
        {
            PathAssistantSid = pathAssistantSid;
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
    public class ReadWebhookOptions : ReadOptions<WebhookResource>
    {
    
        ///<summary> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the resources to read. </summary> 
        public string PathAssistantSid { get; }



        /// <summary> Construct a new ListWebhookOptions </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the resources to read. </param>
        public ReadWebhookOptions(string pathAssistantSid)
        {
            PathAssistantSid = pathAssistantSid;
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

    /// <summary> update </summary>
    public class UpdateWebhookOptions : IOptions<WebhookResource>
    {
    
        ///<summary> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the resource to update. </summary> 
        public string PathAssistantSid { get; }

        ///<summary> The Twilio-provided string that uniquely identifies the Webhook resource to update. </summary> 
        public string PathSid { get; }

        ///<summary> An application-defined string that uniquely identifies the new resource. It can be used as an alternative to the `sid` in the URL path to address the resource. This value must be unique and 64 characters or less in length. </summary> 
        public string UniqueName { get; set; }

        ///<summary> The list of space-separated events that this Webhook will subscribe to. </summary> 
        public string Events { get; set; }

        ///<summary> The URL associated with this Webhook. </summary> 
        public Uri WebhookUrl { get; set; }

        ///<summary> The method to be used when calling the webhook's URL. </summary> 
        public string WebhookMethod { get; set; }



        /// <summary> Construct a new UpdateWebhookOptions </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the resource to update. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Webhook resource to update. </param>
        public UpdateWebhookOptions(string pathAssistantSid, string pathSid)
        {
            PathAssistantSid = pathAssistantSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }
            if (Events != null)
            {
                p.Add(new KeyValuePair<string, string>("Events", Events));
            }
            if (WebhookUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("WebhookUrl", Serializers.Url(WebhookUrl)));
            }
            if (WebhookMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("WebhookMethod", WebhookMethod));
            }
            return p;
        }
        

    }


}
