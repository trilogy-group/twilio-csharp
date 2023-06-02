/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Conversations
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




namespace Kandy.Rest.Conversations.V1
{

    /// <summary> Create a new conversation service on your account </summary>
    public class CreateServiceOptions : IOptions<ServiceResource>
    {

        ///<summary> The human-readable name of this service, limited to 256 characters. Optional. </summary> 
        public string FriendlyName { get; }


        /// <summary> Construct a new CreateServiceOptions </summary>
        /// <param name="friendlyName"> The human-readable name of this service, limited to 256 characters. Optional. </param>
        public CreateServiceOptions(string friendlyName)
        {
            FriendlyName = friendlyName;
        }


        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            return p;
        }


    }
    /// <summary> Remove a conversation service with all its nested resources from your account </summary>
    public class DeleteServiceOptions : IOptions<ServiceResource>
    {

        ///<summary> A 34 character string that uniquely identifies this resource. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteServiceOptions </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
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


    /// <summary> Fetch a conversation service from your account </summary>
    public class FetchServiceOptions : IOptions<ServiceResource>
    {

        ///<summary> A 34 character string that uniquely identifies this resource. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchServiceOptions </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
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


    /// <summary> Retrieve a list of all conversation services on your account </summary>
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

}
