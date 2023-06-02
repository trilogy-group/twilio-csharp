/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Sync
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




namespace Kandy.Rest.Sync.V1
{

    /// <summary> create </summary>
    public class CreateServiceOptions : IOptions<ServiceResource>
    {

        ///<summary> A string that you assign to describe the resource. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> The URL we should call when Sync objects are manipulated. </summary> 
        public Uri WebhookUrl { get; set; }

        ///<summary> Whether the service instance should call `webhook_url` when client endpoints connect to Sync. The default is `false`. </summary> 
        public bool? ReachabilityWebhooksEnabled { get; set; }

        ///<summary> Whether token identities in the Service must be granted access to Sync objects by using the [Permissions](https://www.kandy.com/docs/sync/api/sync-permissions) resource. </summary> 
        public bool? AclEnabled { get; set; }

        ///<summary> Whether every `endpoint_disconnected` event should occur after a configurable delay. The default is `false`, where the `endpoint_disconnected` event occurs immediately after disconnection. When `true`, intervening reconnections can prevent the `endpoint_disconnected` event. </summary> 
        public bool? ReachabilityDebouncingEnabled { get; set; }

        ///<summary> The reachability event delay in milliseconds if `reachability_debouncing_enabled` = `true`.  Must be between 1,000 and 30,000 and defaults to 5,000. This is the number of milliseconds after the last running client disconnects, and a Sync identity is declared offline, before the `webhook_url` is called if all endpoints remain offline. A reconnection from the same identity by any endpoint during this interval prevents the call to `webhook_url`. </summary> 
        public int? ReachabilityDebouncingWindow { get; set; }

        ///<summary> Whether the Service instance should call `webhook_url` when the REST API is used to update Sync objects. The default is `false`. </summary> 
        public bool? WebhooksFromRestEnabled { get; set; }




        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (WebhookUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("WebhookUrl", Serializers.Url(WebhookUrl)));
            }
            if (ReachabilityWebhooksEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("ReachabilityWebhooksEnabled", ReachabilityWebhooksEnabled.Value.ToString().ToLower()));
            }
            if (AclEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("AclEnabled", AclEnabled.Value.ToString().ToLower()));
            }
            if (ReachabilityDebouncingEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("ReachabilityDebouncingEnabled", ReachabilityDebouncingEnabled.Value.ToString().ToLower()));
            }
            if (ReachabilityDebouncingWindow != null)
            {
                p.Add(new KeyValuePair<string, string>("ReachabilityDebouncingWindow", ReachabilityDebouncingWindow.ToString()));
            }
            if (WebhooksFromRestEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("WebhooksFromRestEnabled", WebhooksFromRestEnabled.Value.ToString().ToLower()));
            }
            return p;
        }


    }
    /// <summary> delete </summary>
    public class DeleteServiceOptions : IOptions<ServiceResource>
    {

        ///<summary> The SID of the Service resource to delete. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteServiceOptions </summary>
        /// <param name="pathSid"> The SID of the Service resource to delete. </param>
        public DeleteServiceOptions(string pathSid)
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


    /// <summary> fetch </summary>
    public class FetchServiceOptions : IOptions<ServiceResource>
    {

        ///<summary> The SID of the Service resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchServiceOptions </summary>
        /// <param name="pathSid"> The SID of the Service resource to fetch. </param>
        public FetchServiceOptions(string pathSid)
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


    /// <summary> read </summary>
    public class ReadServiceOptions : ReadOptions<ServiceResource>
    {





        /// <summary> Generate the necessary parameters </summary>
        public override List<KeyValuePair<string, string>> GetParams()
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
    public class UpdateServiceOptions : IOptions<ServiceResource>
    {

        ///<summary> The SID of the Service resource to update. </summary> 
        public string PathSid { get; }

        ///<summary> The URL we should call when Sync objects are manipulated. </summary> 
        public Uri WebhookUrl { get; set; }

        ///<summary> A string that you assign to describe the resource. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> Whether the service instance should call `webhook_url` when client endpoints connect to Sync. The default is `false`. </summary> 
        public bool? ReachabilityWebhooksEnabled { get; set; }

        ///<summary> Whether token identities in the Service must be granted access to Sync objects by using the [Permissions](https://www.kandy.com/docs/sync/api/sync-permissions) resource. </summary> 
        public bool? AclEnabled { get; set; }

        ///<summary> Whether every `endpoint_disconnected` event should occur after a configurable delay. The default is `false`, where the `endpoint_disconnected` event occurs immediately after disconnection. When `true`, intervening reconnections can prevent the `endpoint_disconnected` event. </summary> 
        public bool? ReachabilityDebouncingEnabled { get; set; }

        ///<summary> The reachability event delay in milliseconds if `reachability_debouncing_enabled` = `true`.  Must be between 1,000 and 30,000 and defaults to 5,000. This is the number of milliseconds after the last running client disconnects, and a Sync identity is declared offline, before the webhook is called if all endpoints remain offline. A reconnection from the same identity by any endpoint during this interval prevents the webhook from being called. </summary> 
        public int? ReachabilityDebouncingWindow { get; set; }

        ///<summary> Whether the Service instance should call `webhook_url` when the REST API is used to update Sync objects. The default is `false`. </summary> 
        public bool? WebhooksFromRestEnabled { get; set; }



        /// <summary> Construct a new UpdateServiceOptions </summary>
        /// <param name="pathSid"> The SID of the Service resource to update. </param>
        public UpdateServiceOptions(string pathSid)
        {
            PathSid = pathSid;
        }


        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (WebhookUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("WebhookUrl", Serializers.Url(WebhookUrl)));
            }
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (ReachabilityWebhooksEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("ReachabilityWebhooksEnabled", ReachabilityWebhooksEnabled.Value.ToString().ToLower()));
            }
            if (AclEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("AclEnabled", AclEnabled.Value.ToString().ToLower()));
            }
            if (ReachabilityDebouncingEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("ReachabilityDebouncingEnabled", ReachabilityDebouncingEnabled.Value.ToString().ToLower()));
            }
            if (ReachabilityDebouncingWindow != null)
            {
                p.Add(new KeyValuePair<string, string>("ReachabilityDebouncingWindow", ReachabilityDebouncingWindow.ToString()));
            }
            if (WebhooksFromRestEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("WebhooksFromRestEnabled", WebhooksFromRestEnabled.Value.ToString().ToLower()));
            }
            return p;
        }


    }


}
