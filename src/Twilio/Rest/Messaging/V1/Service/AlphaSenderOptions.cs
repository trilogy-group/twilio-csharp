/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Messaging
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




namespace Kandy.Rest.Messaging.V1.Service
{

    /// <summary> create </summary>
    public class CreateAlphaSenderOptions : IOptions<AlphaSenderResource>
    {
        
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to create the resource under. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The Alphanumeric Sender ID string. Can be up to 11 characters long. Valid characters are A-Z, a-z, 0-9, space, hyphen `-`, plus `+`, underscore `_` and ampersand `&`. This value cannot contain only numbers. </summary> 
        public string AlphaSender { get; }


        /// <summary> Construct a new CreateAlphaSenderOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to create the resource under. </param>
        /// <param name="alphaSender"> The Alphanumeric Sender ID string. Can be up to 11 characters long. Valid characters are A-Z, a-z, 0-9, space, hyphen `-`, plus `+`, underscore `_` and ampersand `&`. This value cannot contain only numbers. </param>
        public CreateAlphaSenderOptions(string pathServiceSid, string alphaSender)
        {
            PathServiceSid = pathServiceSid;
            AlphaSender = alphaSender;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (AlphaSender != null)
            {
                p.Add(new KeyValuePair<string, string>("AlphaSender", AlphaSender));
            }
            return p;
        }
        

    }
    /// <summary> delete </summary>
    public class DeleteAlphaSenderOptions : IOptions<AlphaSenderResource>
    {
        
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to delete the resource from. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the AlphaSender resource to delete. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteAlphaSenderOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to delete the resource from. </param>
        /// <param name="pathSid"> The SID of the AlphaSender resource to delete. </param>
        public DeleteAlphaSenderOptions(string pathServiceSid, string pathSid)
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


    /// <summary> fetch </summary>
    public class FetchAlphaSenderOptions : IOptions<AlphaSenderResource>
    {
    
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to fetch the resource from. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the AlphaSender resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchAlphaSenderOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to fetch the resource from. </param>
        /// <param name="pathSid"> The SID of the AlphaSender resource to fetch. </param>
        public FetchAlphaSenderOptions(string pathServiceSid, string pathSid)
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
    public class ReadAlphaSenderOptions : ReadOptions<AlphaSenderResource>
    {
    
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to read the resources from. </summary> 
        public string PathServiceSid { get; }



        /// <summary> Construct a new ListAlphaSenderOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/chat/rest/service-resource) to read the resources from. </param>
        public ReadAlphaSenderOptions(string pathServiceSid)
        {
            PathServiceSid = pathServiceSid;
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
