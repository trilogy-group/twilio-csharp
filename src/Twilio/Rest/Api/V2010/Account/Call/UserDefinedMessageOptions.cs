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

    /// <summary> Create a new User Defined Message for the given Call SID. </summary>
    public class CreateUserDefinedMessageOptions : IOptions<UserDefinedMessageResource>
    {
        
        ///<summary> The SID of the [Call](https://www.twilio.com/docs/voice/api/call-resource) the User Defined Message is associated with. </summary> 
        public string PathCallSid { get; }

        ///<summary> The User Defined Message in the form of URL-encoded JSON string. </summary> 
        public string Content { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created User Defined Message. </summary> 
        public string PathAccountSid { get; set; }

        ///<summary> A unique string value to identify API call. This should be a unique string value per API call and can be a randomly generated. </summary> 
        public string IdempotencyKey { get; set; }


        /// <summary> Construct a new CreateUserDefinedMessageOptions </summary>
        /// <param name="pathCallSid"> The SID of the [Call](https://www.twilio.com/docs/voice/api/call-resource) the User Defined Message is associated with. </param>
        /// <param name="content"> The User Defined Message in the form of URL-encoded JSON string. </param>
        public CreateUserDefinedMessageOptions(string pathCallSid, string content)
        {
            PathCallSid = pathCallSid;
            Content = content;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Content != null)
            {
                p.Add(new KeyValuePair<string, string>("Content", Content));
            }
            if (IdempotencyKey != null)
            {
                p.Add(new KeyValuePair<string, string>("IdempotencyKey", IdempotencyKey));
            }
            return p;
        }
        

    }
}
