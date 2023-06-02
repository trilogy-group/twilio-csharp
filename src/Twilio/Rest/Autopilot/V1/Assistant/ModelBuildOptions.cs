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




namespace Kandy.Rest.Autopilot.V1.Assistant
{

    /// <summary> create </summary>
    public class CreateModelBuildOptions : IOptions<ModelBuildResource>
    {
        
        ///<summary> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the new resource. </summary> 
        public string PathAssistantSid { get; }

        ///<summary> The URL we should call using a POST method to send status information to your application. </summary> 
        public Uri StatusCallback { get; set; }

        ///<summary> An application-defined string that uniquely identifies the new resource. This value must be a unique string of no more than 64 characters. It can be used as an alternative to the `sid` in the URL path to address the resource. </summary> 
        public string UniqueName { get; set; }


        /// <summary> Construct a new CreateModelBuildOptions </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the new resource. </param>
        public CreateModelBuildOptions(string pathAssistantSid)
        {
            PathAssistantSid = pathAssistantSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (StatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallback", Serializers.Url(StatusCallback)));
            }
            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }
            return p;
        }
        

    }
    /// <summary> delete </summary>
    public class DeleteModelBuildOptions : IOptions<ModelBuildResource>
    {
        
        ///<summary> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the resources to delete. </summary> 
        public string PathAssistantSid { get; }

        ///<summary> The Twilio-provided string that uniquely identifies the ModelBuild resource to delete. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteModelBuildOptions </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the resources to delete. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the ModelBuild resource to delete. </param>
        public DeleteModelBuildOptions(string pathAssistantSid, string pathSid)
        {
            PathAssistantSid = pathAssistantSid;
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
    public class FetchModelBuildOptions : IOptions<ModelBuildResource>
    {
    
        ///<summary> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the resource to fetch. </summary> 
        public string PathAssistantSid { get; }

        ///<summary> The Twilio-provided string that uniquely identifies the ModelBuild resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchModelBuildOptions </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the resource to fetch. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the ModelBuild resource to fetch. </param>
        public FetchModelBuildOptions(string pathAssistantSid, string pathSid)
        {
            PathAssistantSid = pathAssistantSid;
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
    public class ReadModelBuildOptions : ReadOptions<ModelBuildResource>
    {
    
        ///<summary> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the resources to read. </summary> 
        public string PathAssistantSid { get; }



        /// <summary> Construct a new ListModelBuildOptions </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the resources to read. </param>
        public ReadModelBuildOptions(string pathAssistantSid)
        {
            PathAssistantSid = pathAssistantSid;
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

    /// <summary> update </summary>
    public class UpdateModelBuildOptions : IOptions<ModelBuildResource>
    {
    
        ///<summary> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the resource to update. </summary> 
        public string PathAssistantSid { get; }

        ///<summary> The Twilio-provided string that uniquely identifies the ModelBuild resource to update. </summary> 
        public string PathSid { get; }

        ///<summary> An application-defined string that uniquely identifies the resource. This value must be a unique string of no more than 64 characters. It can be used as an alternative to the `sid` in the URL path to address the resource. </summary> 
        public string UniqueName { get; set; }



        /// <summary> Construct a new UpdateModelBuildOptions </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the resource to update. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the ModelBuild resource to update. </param>
        public UpdateModelBuildOptions(string pathAssistantSid, string pathSid)
        {
            PathAssistantSid = pathAssistantSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }
            return p;
        }
        

    }


}
