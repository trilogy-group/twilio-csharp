/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Chat
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



namespace Kandy.Rest.Chat.V2.Service
{

    /// <summary> create </summary>
    public class CreateChannelOptions : IOptions<ChannelResource>
    {
        
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to create the Channel resource under. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The X-Twilio-Webhook-Enabled HTTP request header </summary> 
        public ChannelResource.WebhookEnabledTypeEnum XTwilioWebhookEnabled { get; set; }

        ///<summary> A descriptive string that you create to describe the new resource. It can be up to 64 characters long. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> An application-defined string that uniquely identifies the resource. It can be used to address the resource in place of the Channel resource's `sid` in the URL. This value must be 64 characters or less in length and be unique within the Service. </summary> 
        public string UniqueName { get; set; }

        ///<summary> A valid JSON string that contains application-specific data. </summary> 
        public string Attributes { get; set; }

        
        public ChannelResource.ChannelTypeEnum Type { get; set; }

        ///<summary> The date, specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format, to assign to the resource as the date it was created. The default value is the current time set by the Chat service.  Note that this should only be used in cases where a Channel is being recreated from a backup/separate source. </summary> 
        public DateTime? DateCreated { get; set; }

        ///<summary> The date, specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format, to assign to the resource as the date it was last updated. The default value is `null`. Note that this parameter should only be used in cases where a Channel is being recreated from a backup/separate source  and where a Message was previously updated. </summary> 
        public DateTime? DateUpdated { get; set; }

        ///<summary> The `identity` of the User that created the channel. Default is: `system`. </summary> 
        public string CreatedBy { get; set; }


        /// <summary> Construct a new CreateChannelOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to create the Channel resource under. </param>
        public CreateChannelOptions(string pathServiceSid)
        {
            PathServiceSid = pathServiceSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
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
            if (DateCreated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreated", Serializers.DateTimeIso8601(DateCreated)));
            }
            if (DateUpdated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateUpdated", Serializers.DateTimeIso8601(DateUpdated)));
            }
            if (CreatedBy != null)
            {
                p.Add(new KeyValuePair<string, string>("CreatedBy", CreatedBy));
            }
            return p;
        }
        
    /// <summary> Generate the necessary header parameters </summary>
    public List<KeyValuePair<string, string>> GetHeaderParams()
    {
        var p = new List<KeyValuePair<string, string>>();
        if (XTwilioWebhookEnabled != null)
        {
            p.Add(new KeyValuePair<string, string>("X-Twilio-Webhook-Enabled", XTwilioWebhookEnabled.ToString()));
        }
        return p;
    }

    }
    /// <summary> delete </summary>
    public class DeleteChannelOptions : IOptions<ChannelResource>
    {
        
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to delete the resource from. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the Channel resource to delete.  This value can be either the `sid` or the `unique_name` of the Channel resource to delete. </summary> 
        public string PathSid { get; }

        ///<summary> The X-Twilio-Webhook-Enabled HTTP request header </summary> 
        public ChannelResource.WebhookEnabledTypeEnum XTwilioWebhookEnabled { get; set; }



        /// <summary> Construct a new DeleteChannelOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to delete the resource from. </param>
        /// <param name="pathSid"> The SID of the Channel resource to delete.  This value can be either the `sid` or the `unique_name` of the Channel resource to delete. </param>
        public DeleteChannelOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        
    /// <summary> Generate the necessary header parameters </summary>
    public List<KeyValuePair<string, string>> GetHeaderParams()
    {
        var p = new List<KeyValuePair<string, string>>();
        if (XTwilioWebhookEnabled != null)
        {
            p.Add(new KeyValuePair<string, string>("X-Twilio-Webhook-Enabled", XTwilioWebhookEnabled.ToString()));
        }
        return p;
    }

    }


    /// <summary> fetch </summary>
    public class FetchChannelOptions : IOptions<ChannelResource>
    {
    
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to fetch the Channel resource from. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the Channel resource to fetch. This value can be either the `sid` or the `unique_name` of the Channel resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchChannelOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to fetch the Channel resource from. </param>
        /// <param name="pathSid"> The SID of the Channel resource to fetch. This value can be either the `sid` or the `unique_name` of the Channel resource to fetch. </param>
        public FetchChannelOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
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
    public class ReadChannelOptions : ReadOptions<ChannelResource>
    {
    
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to read the Channel resources from. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The visibility of the Channels to read. Can be: `public` or `private` and defaults to `public`. </summary> 
        public List<ChannelResource.ChannelTypeEnum> Type { get; set; }



        /// <summary> Construct a new ListChannelOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to read the Channel resources from. </param>
        public ReadChannelOptions(string pathServiceSid)
        {
            PathServiceSid = pathServiceSid;
            Type = new List<ChannelResource.ChannelTypeEnum>();
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
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
    
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to update the Channel resource in. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the Channel resource to update. This value can be either the `sid` or the `unique_name` of the Channel resource to update. </summary> 
        public string PathSid { get; }

        ///<summary> The X-Twilio-Webhook-Enabled HTTP request header </summary> 
        public ChannelResource.WebhookEnabledTypeEnum XTwilioWebhookEnabled { get; set; }

        ///<summary> A descriptive string that you create to describe the resource. It can be up to 256 characters long. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> An application-defined string that uniquely identifies the resource. It can be used to address the resource in place of the resource's `sid` in the URL. This value must be 256 characters or less in length and unique within the Service. </summary> 
        public string UniqueName { get; set; }

        ///<summary> A valid JSON string that contains application-specific data. </summary> 
        public string Attributes { get; set; }

        ///<summary> The date, specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format, to assign to the resource as the date it was created. The default value is the current time set by the Chat service.  Note that this should only be used in cases where a Channel is being recreated from a backup/separate source. </summary> 
        public DateTime? DateCreated { get; set; }

        ///<summary> The date, specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format, to assign to the resource as the date it was last updated. </summary> 
        public DateTime? DateUpdated { get; set; }

        ///<summary> The `identity` of the User that created the channel. Default is: `system`. </summary> 
        public string CreatedBy { get; set; }



        /// <summary> Construct a new UpdateChannelOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to update the Channel resource in. </param>
        /// <param name="pathSid"> The SID of the Channel resource to update. This value can be either the `sid` or the `unique_name` of the Channel resource to update. </param>
        public UpdateChannelOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
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
            if (DateCreated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreated", Serializers.DateTimeIso8601(DateCreated)));
            }
            if (DateUpdated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateUpdated", Serializers.DateTimeIso8601(DateUpdated)));
            }
            if (CreatedBy != null)
            {
                p.Add(new KeyValuePair<string, string>("CreatedBy", CreatedBy));
            }
            return p;
        }
        
    /// <summary> Generate the necessary header parameters </summary>
    public List<KeyValuePair<string, string>> GetHeaderParams()
    {
        var p = new List<KeyValuePair<string, string>>();
        if (XTwilioWebhookEnabled != null)
        {
            p.Add(new KeyValuePair<string, string>("X-Twilio-Webhook-Enabled", XTwilioWebhookEnabled.ToString()));
        }
        return p;
    }

    }


}
