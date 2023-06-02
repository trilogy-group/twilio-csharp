/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Serverless
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




namespace Kandy.Rest.Serverless.V1.Service.Function
{
    /// <summary> Retrieve a specific Function Version resource. </summary>
    public class FetchFunctionVersionOptions : IOptions<FunctionVersionResource>
    {
    
        ///<summary> The SID of the Service to fetch the Function Version resource from. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the function that is the parent of the Function Version resource to fetch. </summary> 
        public string PathFunctionSid { get; }

        ///<summary> The SID of the Function Version resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchFunctionVersionOptions </summary>
        /// <param name="pathServiceSid"> The SID of the Service to fetch the Function Version resource from. </param>
        /// <param name="pathFunctionSid"> The SID of the function that is the parent of the Function Version resource to fetch. </param>
        /// <param name="pathSid"> The SID of the Function Version resource to fetch. </param>
        public FetchFunctionVersionOptions(string pathServiceSid, string pathFunctionSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathFunctionSid = pathFunctionSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Retrieve a list of all Function Version resources. </summary>
    public class ReadFunctionVersionOptions : ReadOptions<FunctionVersionResource>
    {
    
        ///<summary> The SID of the Service to read the Function Version resources from. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The SID of the function that is the parent of the Function Version resources to read. </summary> 
        public string PathFunctionSid { get; }



        /// <summary> Construct a new ListFunctionVersionOptions </summary>
        /// <param name="pathServiceSid"> The SID of the Service to read the Function Version resources from. </param>
        /// <param name="pathFunctionSid"> The SID of the function that is the parent of the Function Version resources to read. </param>
        public ReadFunctionVersionOptions(string pathServiceSid, string pathFunctionSid)
        {
            PathServiceSid = pathServiceSid;
            PathFunctionSid = pathFunctionSid;
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
