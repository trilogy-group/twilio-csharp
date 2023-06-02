/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Studio
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




namespace Kandy.Rest.Studio.V1.Flow.Execution
{
    /// <summary> Retrieve the most recent context for an Execution. </summary>
    public class FetchExecutionContextOptions : IOptions<ExecutionContextResource>
    {
    
        ///<summary> The SID of the Flow with the Execution context to fetch. </summary> 
        public string PathFlowSid { get; }

        ///<summary> The SID of the Execution context to fetch. </summary> 
        public string PathExecutionSid { get; }



        /// <summary> Construct a new FetchExecutionContextOptions </summary>
        /// <param name="pathFlowSid"> The SID of the Flow with the Execution context to fetch. </param>
        /// <param name="pathExecutionSid"> The SID of the Execution context to fetch. </param>
        public FetchExecutionContextOptions(string pathFlowSid, string pathExecutionSid)
        {
            PathFlowSid = pathFlowSid;
            PathExecutionSid = pathExecutionSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


}
