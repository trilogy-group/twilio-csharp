/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Api
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




namespace Kandy.Rest.Api.V2010.Account.Call
{
    /// <summary> Retrieve a list of all events for a call. </summary>
    public class ReadEventOptions : ReadOptions<EventResource>
    {
    
        ///<summary> The unique SID identifier of the Call. </summary> 
        public string PathCallSid { get; }

        ///<summary> The unique SID identifier of the Account. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new ListCallEventOptions </summary>
        /// <param name="pathCallSid"> The unique SID identifier of the Call. </param>
        public ReadEventOptions(string pathCallSid)
        {
            PathCallSid = pathCallSid;
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
