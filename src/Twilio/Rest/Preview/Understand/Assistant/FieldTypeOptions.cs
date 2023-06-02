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

    /// <summary> create </summary>
    public class CreateFieldTypeOptions : IOptions<FieldTypeResource>
    {
        
        
        public string PathAssistantSid { get; }

        ///<summary> A user-provided string that uniquely identifies this resource as an alternative to the sid. Unique up to 64 characters long. </summary> 
        public string UniqueName { get; }

        ///<summary> A user-provided string that identifies this resource. It is non-unique and can up to 255 characters long. </summary> 
        public string FriendlyName { get; set; }


        /// <summary> Construct a new CreateUnderstandFieldTypeOptions </summary>
        /// <param name="pathAssistantSid">  </param>
        /// <param name="uniqueName"> A user-provided string that uniquely identifies this resource as an alternative to the sid. Unique up to 64 characters long. </param>
        public CreateFieldTypeOptions(string pathAssistantSid, string uniqueName)
        {
            PathAssistantSid = pathAssistantSid;
            UniqueName = uniqueName;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            return p;
        }
        

    }
    /// <summary> delete </summary>
    public class DeleteFieldTypeOptions : IOptions<FieldTypeResource>
    {
        
        
        public string PathAssistantSid { get; }

        
        public string PathSid { get; }



        /// <summary> Construct a new DeleteUnderstandFieldTypeOptions </summary>
        /// <param name="pathAssistantSid">  </param>
        /// <param name="pathSid">  </param>
        public DeleteFieldTypeOptions(string pathAssistantSid, string pathSid)
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
    public class FetchFieldTypeOptions : IOptions<FieldTypeResource>
    {
    
        
        public string PathAssistantSid { get; }

        
        public string PathSid { get; }



        /// <summary> Construct a new FetchUnderstandFieldTypeOptions </summary>
        /// <param name="pathAssistantSid">  </param>
        /// <param name="pathSid">  </param>
        public FetchFieldTypeOptions(string pathAssistantSid, string pathSid)
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
    public class ReadFieldTypeOptions : ReadOptions<FieldTypeResource>
    {
    
        
        public string PathAssistantSid { get; }



        /// <summary> Construct a new ListUnderstandFieldTypeOptions </summary>
        /// <param name="pathAssistantSid">  </param>
        public ReadFieldTypeOptions(string pathAssistantSid)
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
    public class UpdateFieldTypeOptions : IOptions<FieldTypeResource>
    {
    
        
        public string PathAssistantSid { get; }

        
        public string PathSid { get; }

        ///<summary> A user-provided string that identifies this resource. It is non-unique and can up to 255 characters long. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> A user-provided string that uniquely identifies this resource as an alternative to the sid. Unique up to 64 characters long. </summary> 
        public string UniqueName { get; set; }



        /// <summary> Construct a new UpdateUnderstandFieldTypeOptions </summary>
        /// <param name="pathAssistantSid">  </param>
        /// <param name="pathSid">  </param>
        public UpdateFieldTypeOptions(string pathAssistantSid, string pathSid)
        {
            PathAssistantSid = pathAssistantSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }
            return p;
        }
        

    }


}
