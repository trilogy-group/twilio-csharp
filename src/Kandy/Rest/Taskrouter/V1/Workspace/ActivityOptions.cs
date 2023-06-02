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




namespace Kandy.Rest.Taskrouter.V1.Workspace
{

    /// <summary> create </summary>
    public class CreateActivityOptions : IOptions<ActivityResource>
    {

        ///<summary> The SID of the Workspace that the new Activity belongs to. </summary> 
        public string PathWorkspaceSid { get; }

        ///<summary> A descriptive string that you create to describe the Activity resource. It can be up to 64 characters long. These names are used to calculate and expose statistics about Workers, and provide visibility into the state of each Worker. Examples of friendly names include: `on-call`, `break`, and `email`. </summary> 
        public string FriendlyName { get; }

        ///<summary> Whether the Worker should be eligible to receive a Task when it occupies the Activity. A value of `true`, `1`, or `yes` specifies the Activity is available. All other values specify that it is not. The value cannot be changed after the Activity is created. </summary> 
        public bool? Available { get; set; }


        /// <summary> Construct a new CreateActivityOptions </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace that the new Activity belongs to. </param>
        /// <param name="friendlyName"> A descriptive string that you create to describe the Activity resource. It can be up to 64 characters long. These names are used to calculate and expose statistics about Workers, and provide visibility into the state of each Worker. Examples of friendly names include: `on-call`, `break`, and `email`. </param>
        public CreateActivityOptions(string pathWorkspaceSid, string friendlyName)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            FriendlyName = friendlyName;
        }


        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (Available != null)
            {
                p.Add(new KeyValuePair<string, string>("Available", Available.Value.ToString().ToLower()));
            }
            return p;
        }


    }
    /// <summary> delete </summary>
    public class DeleteActivityOptions : IOptions<ActivityResource>
    {

        ///<summary> The SID of the Workspace with the Activity resources to delete. </summary> 
        public string PathWorkspaceSid { get; }

        ///<summary> The SID of the Activity resource to delete. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteActivityOptions </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Activity resources to delete. </param>
        /// <param name="pathSid"> The SID of the Activity resource to delete. </param>
        public DeleteActivityOptions(string pathWorkspaceSid, string pathSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
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
    public class FetchActivityOptions : IOptions<ActivityResource>
    {

        ///<summary> The SID of the Workspace with the Activity resources to fetch. </summary> 
        public string PathWorkspaceSid { get; }

        ///<summary> The SID of the Activity resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchActivityOptions </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Activity resources to fetch. </param>
        /// <param name="pathSid"> The SID of the Activity resource to fetch. </param>
        public FetchActivityOptions(string pathWorkspaceSid, string pathSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
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
    public class ReadActivityOptions : ReadOptions<ActivityResource>
    {

        ///<summary> The SID of the Workspace with the Activity resources to read. </summary> 
        public string PathWorkspaceSid { get; }

        ///<summary> The `friendly_name` of the Activity resources to read. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> Whether return only Activity resources that are available or unavailable. A value of `true` returns only available activities. Values of '1' or `yes` also indicate `true`. All other values represent `false` and return activities that are unavailable. </summary> 
        public string Available { get; set; }



        /// <summary> Construct a new ListActivityOptions </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Activity resources to read. </param>
        public ReadActivityOptions(string pathWorkspaceSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
        }


        /// <summary> Generate the necessary parameters </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (Available != null)
            {
                p.Add(new KeyValuePair<string, string>("Available", Available));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }


    }

    /// <summary> update </summary>
    public class UpdateActivityOptions : IOptions<ActivityResource>
    {

        ///<summary> The SID of the Workspace with the Activity resources to update. </summary> 
        public string PathWorkspaceSid { get; }

        ///<summary> The SID of the Activity resource to update. </summary> 
        public string PathSid { get; }

        ///<summary> A descriptive string that you create to describe the Activity resource. It can be up to 64 characters long. These names are used to calculate and expose statistics about Workers, and provide visibility into the state of each Worker. Examples of friendly names include: `on-call`, `break`, and `email`. </summary> 
        public string FriendlyName { get; set; }



        /// <summary> Construct a new UpdateActivityOptions </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Activity resources to update. </param>
        /// <param name="pathSid"> The SID of the Activity resource to update. </param>
        public UpdateActivityOptions(string pathWorkspaceSid, string pathSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            PathSid = pathSid;
        }


        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            return p;
        }


    }


}
