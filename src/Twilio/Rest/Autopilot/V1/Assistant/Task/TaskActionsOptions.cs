/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Autopilot
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




namespace Twilio.Rest.Autopilot.V1.Assistant.Task
{
    /// <summary> Returns JSON actions for the Task. </summary>
    public class FetchTaskActionsOptions : IOptions<TaskActionsResource>
    {
    
        ///<summary> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the Task for which the task actions to fetch were defined. </summary> 
        public string PathAssistantSid { get; }

        ///<summary> The SID of the [Task](https://www.twilio.com/docs/autopilot/api/task) for which the task actions to fetch were defined. </summary> 
        public string PathTaskSid { get; }



        /// <summary> Construct a new FetchTaskActionsOptions </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the Task for which the task actions to fetch were defined. </param>
        /// <param name="pathTaskSid"> The SID of the [Task](https://www.twilio.com/docs/autopilot/api/task) for which the task actions to fetch were defined. </param>
        public FetchTaskActionsOptions(string pathAssistantSid, string pathTaskSid)
        {
            PathAssistantSid = pathAssistantSid;
            PathTaskSid = pathTaskSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Updates the actions of an Task identified by {TaskSid} or {TaskUniqueName}. </summary>
    public class UpdateTaskActionsOptions : IOptions<TaskActionsResource>
    {
    
        ///<summary> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the Task for which the task actions to update were defined. </summary> 
        public string PathAssistantSid { get; }

        ///<summary> The SID of the [Task](https://www.twilio.com/docs/autopilot/api/task) for which the task actions to update were defined. </summary> 
        public string PathTaskSid { get; }

        ///<summary> The JSON string that specifies the [actions](https://www.twilio.com/docs/autopilot/actions) that instruct the Assistant on how to perform the task. </summary> 
        public object Actions { get; set; }



        /// <summary> Construct a new UpdateTaskActionsOptions </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the Task for which the task actions to update were defined. </param>
        /// <param name="pathTaskSid"> The SID of the [Task](https://www.twilio.com/docs/autopilot/api/task) for which the task actions to update were defined. </param>
        public UpdateTaskActionsOptions(string pathAssistantSid, string pathTaskSid)
        {
            PathAssistantSid = pathAssistantSid;
            PathTaskSid = pathTaskSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Actions != null)
            {
                p.Add(new KeyValuePair<string, string>("Actions", Serializers.JsonObject(Actions)));
            }
            return p;
        }
        

    }


}

