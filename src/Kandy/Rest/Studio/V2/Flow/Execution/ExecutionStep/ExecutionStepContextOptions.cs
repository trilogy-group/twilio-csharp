/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Studio
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




namespace Kandy.Rest.Studio.V2.Flow.Execution.ExecutionStep
{
    /// <summary> Retrieve the context for an Execution Step. </summary>
    public class FetchExecutionStepContextOptions : IOptions<ExecutionStepContextResource>
    {

        ///<summary> The SID of the Flow with the Step to fetch. </summary> 
        public string PathFlowSid { get; }

        ///<summary> The SID of the Execution resource with the Step to fetch. </summary> 
        public string PathExecutionSid { get; }

        ///<summary> The SID of the Step to fetch. </summary> 
        public string PathStepSid { get; }



        /// <summary> Construct a new FetchExecutionStepContextOptions </summary>
        /// <param name="pathFlowSid"> The SID of the Flow with the Step to fetch. </param>
        /// <param name="pathExecutionSid"> The SID of the Execution resource with the Step to fetch. </param>
        /// <param name="pathStepSid"> The SID of the Step to fetch. </param>
        public FetchExecutionStepContextOptions(string pathFlowSid, string pathExecutionSid, string pathStepSid)
        {
            PathFlowSid = pathFlowSid;
            PathExecutionSid = pathExecutionSid;
            PathStepSid = pathStepSid;
        }


        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }


    }


}
