/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Preview
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




namespace Kandy.Rest.Preview.Understand.Assistant
{

    /// <summary> create </summary>
    public class CreateModelBuildOptions : IOptions<ModelBuildResource>
    {


        public string PathAssistantSid { get; }


        public Uri StatusCallback { get; set; }

        ///<summary> A user-provided string that uniquely identifies this resource as an alternative to the sid. Unique up to 64 characters long. For example: v0.1 </summary> 
        public string UniqueName { get; set; }


        /// <summary> Construct a new CreateUnderstandModelBuildOptions </summary>
        /// <param name="pathAssistantSid">  </param>
        public CreateModelBuildOptions(string pathAssistantSid)
        {
            PathAssistantSid = pathAssistantSid;
        }


        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
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


        public string PathAssistantSid { get; }


        public string PathSid { get; }



        /// <summary> Construct a new DeleteUnderstandModelBuildOptions </summary>
        /// <param name="pathAssistantSid">  </param>
        /// <param name="pathSid">  </param>
        public DeleteModelBuildOptions(string pathAssistantSid, string pathSid)
        {
            PathAssistantSid = pathAssistantSid;
            PathSid = pathSid;
        }


        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }


    }


    /// <summary> fetch </summary>
    public class FetchModelBuildOptions : IOptions<ModelBuildResource>
    {


        public string PathAssistantSid { get; }


        public string PathSid { get; }



        /// <summary> Construct a new FetchUnderstandModelBuildOptions </summary>
        /// <param name="pathAssistantSid">  </param>
        /// <param name="pathSid">  </param>
        public FetchModelBuildOptions(string pathAssistantSid, string pathSid)
        {
            PathAssistantSid = pathAssistantSid;
            PathSid = pathSid;
        }


        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }


    }


    /// <summary> read </summary>
    public class ReadModelBuildOptions : ReadOptions<ModelBuildResource>
    {


        public string PathAssistantSid { get; }



        /// <summary> Construct a new ListUnderstandModelBuildOptions </summary>
        /// <param name="pathAssistantSid">  </param>
        public ReadModelBuildOptions(string pathAssistantSid)
        {
            PathAssistantSid = pathAssistantSid;
        }


        /// <summary> Generate the necessary parameters </summary>
        public override List<KeyValuePair<string, string>> GetParams()
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


        public string PathAssistantSid { get; }


        public string PathSid { get; }

        ///<summary> A user-provided string that uniquely identifies this resource as an alternative to the sid. Unique up to 64 characters long. For example: v0.1 </summary> 
        public string UniqueName { get; set; }



        /// <summary> Construct a new UpdateUnderstandModelBuildOptions </summary>
        /// <param name="pathAssistantSid">  </param>
        /// <param name="pathSid">  </param>
        public UpdateModelBuildOptions(string pathAssistantSid, string pathSid)
        {
            PathAssistantSid = pathAssistantSid;
            PathSid = pathSid;
        }


        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
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
