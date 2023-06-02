/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Proxy
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




namespace Kandy.Rest.Proxy.V1.Service.Session
{
    /// <summary> Delete a specific Interaction. </summary>
    public class DeleteInteractionOptions : IOptions<InteractionResource>
    {
        
        ///<summary> The SID of the parent [Service](https://www.twilio.com/docs/proxy/api/service) of the resource to delete. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the parent [Session](https://www.twilio.com/docs/proxy/api/session) of the resource to delete. </summary> 
        public string PathSessionSid { get; }

        ///<summary> The Twilio-provided string that uniquely identifies the Interaction resource to delete. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteInteractionOptions </summary>
        /// <param name="pathServiceSid"> The SID of the parent [Service](https://www.twilio.com/docs/proxy/api/service) of the resource to delete. </param>
        /// <param name="pathSessionSid"> The SID of the parent [Session](https://www.twilio.com/docs/proxy/api/session) of the resource to delete. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Interaction resource to delete. </param>
        public DeleteInteractionOptions(string pathServiceSid, string pathSessionSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSessionSid = pathSessionSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Retrieve a list of Interactions for a given [Session](https://www.twilio.com/docs/proxy/api/session). </summary>
    public class FetchInteractionOptions : IOptions<InteractionResource>
    {
    
        ///<summary> The SID of the parent [Service](https://www.twilio.com/docs/proxy/api/service) of the resource to fetch. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the parent [Session](https://www.twilio.com/docs/proxy/api/session) of the resource to fetch. </summary> 
        public string PathSessionSid { get; }

        ///<summary> The Twilio-provided string that uniquely identifies the Interaction resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchInteractionOptions </summary>
        /// <param name="pathServiceSid"> The SID of the parent [Service](https://www.twilio.com/docs/proxy/api/service) of the resource to fetch. </param>
        /// <param name="pathSessionSid"> The SID of the parent [Session](https://www.twilio.com/docs/proxy/api/session) of the resource to fetch. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Interaction resource to fetch. </param>
        public FetchInteractionOptions(string pathServiceSid, string pathSessionSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSessionSid = pathSessionSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Retrieve a list of all Interactions for a Session. A maximum of 100 records will be returned per page. </summary>
    public class ReadInteractionOptions : ReadOptions<InteractionResource>
    {
    
        ///<summary> The SID of the parent [Service](https://www.twilio.com/docs/proxy/api/service) to read the resources from. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the parent [Session](https://www.twilio.com/docs/proxy/api/session) to read the resources from. </summary> 
        public string PathSessionSid { get; }



        /// <summary> Construct a new ListInteractionOptions </summary>
        /// <param name="pathServiceSid"> The SID of the parent [Service](https://www.twilio.com/docs/proxy/api/service) to read the resources from. </param>
        /// <param name="pathSessionSid"> The SID of the parent [Session](https://www.twilio.com/docs/proxy/api/session) to read the resources from. </param>
        public ReadInteractionOptions(string pathServiceSid, string pathSessionSid)
        {
            PathServiceSid = pathServiceSid;
            PathSessionSid = pathSessionSid;
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

}
