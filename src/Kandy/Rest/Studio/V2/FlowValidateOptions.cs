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




namespace Kandy.Rest.Studio.V2
{
    /// <summary> Validate flow JSON definition </summary>
    public class UpdateFlowValidateOptions : IOptions<FlowValidateResource>
    {

        ///<summary> The string that you assigned to describe the Flow. </summary> 
        public string FriendlyName { get; }


        public FlowValidateResource.StatusEnum Status { get; }

        ///<summary> JSON representation of flow definition. </summary> 
        public object Definition { get; }

        ///<summary> Description of change made in the revision. </summary> 
        public string CommitMessage { get; set; }



        /// <summary> Construct a new UpdateFlowValidateOptions </summary>
        /// <param name="friendlyName"> The string that you assigned to describe the Flow. </param>
        /// <param name="status">  </param>
        /// <param name="definition"> JSON representation of flow definition. </param>
        public UpdateFlowValidateOptions(string friendlyName, FlowValidateResource.StatusEnum status, object definition)
        {
            FriendlyName = friendlyName;
            Status = status;
            Definition = definition;
        }


        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }
            if (Definition != null)
            {
                p.Add(new KeyValuePair<string, string>("Definition", Serializers.JsonObject(Definition)));
            }
            if (CommitMessage != null)
            {
                p.Add(new KeyValuePair<string, string>("CommitMessage", CommitMessage));
            }
            return p;
        }


    }


}
