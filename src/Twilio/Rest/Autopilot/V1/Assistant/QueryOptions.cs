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
    public class CreateQueryOptions : IOptions<QueryResource>
    {
        
        ///<summary> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the new resource. </summary> 
        public string PathAssistantSid { get; }

        ///<summary> The [ISO language-country](https://docs.oracle.com/cd/E13214_01/wli/docs92/xref/xqisocodes.html) string that specifies the language used for the new query. For example: `en-US`. </summary> 
        public string Language { get; }

        ///<summary> The end-user's natural language input. It can be up to 2048 characters long. </summary> 
        public string Query { get; }

        ///<summary> The list of tasks to limit the new query to. Tasks are expressed as a comma-separated list of task `unique_name` values. For example, `task-unique_name-1, task-unique_name-2`. Listing specific tasks is useful to constrain the paths that a user can take. </summary> 
        public string Tasks { get; set; }

        ///<summary> The SID or unique name of the [Model Build](https://www.twilio.com/docs/autopilot/api/model-build) to be queried. </summary> 
        public string ModelBuild { get; set; }


        /// <summary> Construct a new CreateQueryOptions </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the new resource. </param>
        /// <param name="language"> The [ISO language-country](https://docs.oracle.com/cd/E13214_01/wli/docs92/xref/xqisocodes.html) string that specifies the language used for the new query. For example: `en-US`. </param>
        /// <param name="query"> The end-user's natural language input. It can be up to 2048 characters long. </param>
        public CreateQueryOptions(string pathAssistantSid, string language, string query)
        {
            PathAssistantSid = pathAssistantSid;
            Language = language;
            Query = query;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Language != null)
            {
                p.Add(new KeyValuePair<string, string>("Language", Language));
            }
            if (Query != null)
            {
                p.Add(new KeyValuePair<string, string>("Query", Query));
            }
            if (Tasks != null)
            {
                p.Add(new KeyValuePair<string, string>("Tasks", Tasks));
            }
            if (ModelBuild != null)
            {
                p.Add(new KeyValuePair<string, string>("ModelBuild", ModelBuild));
            }
            return p;
        }
        

    }
    /// <summary> delete </summary>
    public class DeleteQueryOptions : IOptions<QueryResource>
    {
        
        ///<summary> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the resources to delete. </summary> 
        public string PathAssistantSid { get; }

        ///<summary> The Twilio-provided string that uniquely identifies the Query resource to delete. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteQueryOptions </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the resources to delete. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Query resource to delete. </param>
        public DeleteQueryOptions(string pathAssistantSid, string pathSid)
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
    public class FetchQueryOptions : IOptions<QueryResource>
    {
    
        ///<summary> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the resource to fetch. </summary> 
        public string PathAssistantSid { get; }

        ///<summary> The Twilio-provided string that uniquely identifies the Query resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchQueryOptions </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the resource to fetch. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Query resource to fetch. </param>
        public FetchQueryOptions(string pathAssistantSid, string pathSid)
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
    public class ReadQueryOptions : ReadOptions<QueryResource>
    {
    
        ///<summary> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the resources to read. </summary> 
        public string PathAssistantSid { get; }

        ///<summary> The [ISO language-country](https://docs.oracle.com/cd/E13214_01/wli/docs92/xref/xqisocodes.html) string that specifies the language used by the Query resources to read. For example: `en-US`. </summary> 
        public string Language { get; set; }

        ///<summary> The SID or unique name of the [Model Build](https://www.twilio.com/docs/autopilot/api/model-build) to be queried. </summary> 
        public string ModelBuild { get; set; }

        ///<summary> The status of the resources to read. Can be: `pending-review`, `reviewed`, or `discarded` </summary> 
        public string Status { get; set; }

        ///<summary> The SID of the [Dialogue](https://www.twilio.com/docs/autopilot/api/dialogue). </summary> 
        public string DialogueSid { get; set; }



        /// <summary> Construct a new ListQueryOptions </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the resources to read. </param>
        public ReadQueryOptions(string pathAssistantSid)
        {
            PathAssistantSid = pathAssistantSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Language != null)
            {
                p.Add(new KeyValuePair<string, string>("Language", Language));
            }
            if (ModelBuild != null)
            {
                p.Add(new KeyValuePair<string, string>("ModelBuild", ModelBuild));
            }
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status));
            }
            if (DialogueSid != null)
            {
                p.Add(new KeyValuePair<string, string>("DialogueSid", DialogueSid));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

    /// <summary> update </summary>
    public class UpdateQueryOptions : IOptions<QueryResource>
    {
    
        ///<summary> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the resource to update. </summary> 
        public string PathAssistantSid { get; }

        ///<summary> The Twilio-provided string that uniquely identifies the Query resource to update. </summary> 
        public string PathSid { get; }

        ///<summary> The SID of an optional reference to the [Sample](https://www.twilio.com/docs/autopilot/api/task-sample) created from the query. </summary> 
        public string SampleSid { get; set; }

        ///<summary> The new status of the resource. Can be: `pending-review`, `reviewed`, or `discarded` </summary> 
        public string Status { get; set; }



        /// <summary> Construct a new UpdateQueryOptions </summary>
        /// <param name="pathAssistantSid"> The SID of the [Assistant](https://www.twilio.com/docs/autopilot/api/assistant) that is the parent of the resource to update. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Query resource to update. </param>
        public UpdateQueryOptions(string pathAssistantSid, string pathSid)
        {
            PathAssistantSid = pathAssistantSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (SampleSid != null)
            {
                p.Add(new KeyValuePair<string, string>("SampleSid", SampleSid));
            }
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status));
            }
            return p;
        }
        

    }


}
