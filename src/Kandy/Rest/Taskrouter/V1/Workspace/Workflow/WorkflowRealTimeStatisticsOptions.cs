/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Taskrouter
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




namespace Kandy.Rest.Taskrouter.V1.Workspace.Workflow
{
    /// <summary> fetch </summary>
    public class FetchWorkflowRealTimeStatisticsOptions : IOptions<WorkflowRealTimeStatisticsResource>
    {

        ///<summary> The SID of the Workspace with the Workflow to fetch. </summary> 
        public string PathWorkspaceSid { get; }

        ///<summary> Returns the list of Tasks that are being controlled by the Workflow with the specified SID value. </summary> 
        public string PathWorkflowSid { get; }

        ///<summary> Only calculate real-time statistics on this TaskChannel. Can be the TaskChannel's SID or its `unique_name`, such as `voice`, `sms`, or `default`. </summary> 
        public string TaskChannel { get; set; }



        /// <summary> Construct a new FetchWorkflowRealTimeStatisticsOptions </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Workflow to fetch. </param>
        /// <param name="pathWorkflowSid"> Returns the list of Tasks that are being controlled by the Workflow with the specified SID value. </param>
        public FetchWorkflowRealTimeStatisticsOptions(string pathWorkspaceSid, string pathWorkflowSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            PathWorkflowSid = pathWorkflowSid;
        }


        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (TaskChannel != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskChannel", TaskChannel));
            }
            return p;
        }


    }


}
