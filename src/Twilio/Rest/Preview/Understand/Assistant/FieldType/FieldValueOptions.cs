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




namespace Kandy.Rest.Preview.Understand.Assistant.FieldType
{

    /// <summary> create </summary>
    public class CreateFieldValueOptions : IOptions<FieldValueResource>
    {
        
        
        public string PathAssistantSid { get; }

        
        public string PathFieldTypeSid { get; }

        ///<summary> An ISO language-country string of the value. </summary> 
        public string Language { get; }

        ///<summary> A user-provided string that uniquely identifies this resource as an alternative to the sid. Unique up to 64 characters long. </summary> 
        public string Value { get; }

        ///<summary> A value that indicates this field value is a synonym of. Empty if the value is not a synonym. </summary> 
        public string SynonymOf { get; set; }


        /// <summary> Construct a new CreateUnderstandFieldValueOptions </summary>
        /// <param name="pathAssistantSid">  </param>
        /// <param name="pathFieldTypeSid">  </param>
        /// <param name="language"> An ISO language-country string of the value. </param>
        /// <param name="value"> A user-provided string that uniquely identifies this resource as an alternative to the sid. Unique up to 64 characters long. </param>
        public CreateFieldValueOptions(string pathAssistantSid, string pathFieldTypeSid, string language, string value)
        {
            PathAssistantSid = pathAssistantSid;
            PathFieldTypeSid = pathFieldTypeSid;
            Language = language;
            Value = value;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Language != null)
            {
                p.Add(new KeyValuePair<string, string>("Language", Language));
            }
            if (Value != null)
            {
                p.Add(new KeyValuePair<string, string>("Value", Value));
            }
            if (SynonymOf != null)
            {
                p.Add(new KeyValuePair<string, string>("SynonymOf", SynonymOf));
            }
            return p;
        }
        

    }
    /// <summary> delete </summary>
    public class DeleteFieldValueOptions : IOptions<FieldValueResource>
    {
        
        
        public string PathAssistantSid { get; }

        
        public string PathFieldTypeSid { get; }

        
        public string PathSid { get; }



        /// <summary> Construct a new DeleteUnderstandFieldValueOptions </summary>
        /// <param name="pathAssistantSid">  </param>
        /// <param name="pathFieldTypeSid">  </param>
        /// <param name="pathSid">  </param>
        public DeleteFieldValueOptions(string pathAssistantSid, string pathFieldTypeSid, string pathSid)
        {
            PathAssistantSid = pathAssistantSid;
            PathFieldTypeSid = pathFieldTypeSid;
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
    public class FetchFieldValueOptions : IOptions<FieldValueResource>
    {
    
        
        public string PathAssistantSid { get; }

        
        public string PathFieldTypeSid { get; }

        
        public string PathSid { get; }



        /// <summary> Construct a new FetchUnderstandFieldValueOptions </summary>
        /// <param name="pathAssistantSid">  </param>
        /// <param name="pathFieldTypeSid">  </param>
        /// <param name="pathSid">  </param>
        public FetchFieldValueOptions(string pathAssistantSid, string pathFieldTypeSid, string pathSid)
        {
            PathAssistantSid = pathAssistantSid;
            PathFieldTypeSid = pathFieldTypeSid;
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
    public class ReadFieldValueOptions : ReadOptions<FieldValueResource>
    {
    
        
        public string PathAssistantSid { get; }

        
        public string PathFieldTypeSid { get; }

        ///<summary> An ISO language-country string of the value. For example: *en-US* </summary> 
        public string Language { get; set; }



        /// <summary> Construct a new ListUnderstandFieldValueOptions </summary>
        /// <param name="pathAssistantSid">  </param>
        /// <param name="pathFieldTypeSid">  </param>
        public ReadFieldValueOptions(string pathAssistantSid, string pathFieldTypeSid)
        {
            PathAssistantSid = pathAssistantSid;
            PathFieldTypeSid = pathFieldTypeSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Language != null)
            {
                p.Add(new KeyValuePair<string, string>("Language", Language));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

}
