/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Preview
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




namespace Kandy.Rest.Preview.Understand.Assistant
{
    /// <summary> fetch </summary>
    public class FetchAssistantInitiationActionsOptions : IOptions<AssistantInitiationActionsResource>
    {
    
        
        public string PathAssistantSid { get; }



        /// <summary> Construct a new FetchUnderstandAssistantInitiationActionsOptions </summary>
        /// <param name="pathAssistantSid">  </param>
        public FetchAssistantInitiationActionsOptions(string pathAssistantSid)
        {
            PathAssistantSid = pathAssistantSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> update </summary>
    public class UpdateAssistantInitiationActionsOptions : IOptions<AssistantInitiationActionsResource>
    {
    
        
        public string PathAssistantSid { get; }

        
        public object InitiationActions { get; set; }



        /// <summary> Construct a new UpdateUnderstandAssistantInitiationActionsOptions </summary>
        /// <param name="pathAssistantSid">  </param>
        public UpdateAssistantInitiationActionsOptions(string pathAssistantSid)
        {
            PathAssistantSid = pathAssistantSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (InitiationActions != null)
            {
                p.Add(new KeyValuePair<string, string>("InitiationActions", Serializers.JsonObject(InitiationActions)));
            }
            return p;
        }
        

    }


}
