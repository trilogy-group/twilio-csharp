/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Voice
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




namespace Twilio.Rest.Voice.V1.ConnectionPolicy
{

    /// <summary> create </summary>
    public class CreateConnectionPolicyTargetOptions : IOptions<ConnectionPolicyTargetResource>
    {
        
        ///<summary> The SID of the Connection Policy that owns the Target. </summary> 
        public string PathConnectionPolicySid { get; }

        ///<summary> The SIP address you want Twilio to route your calls to. This must be a `sip:` schema. `sips` is NOT supported. </summary> 
        public Uri Target { get; }

        ///<summary> A descriptive string that you create to describe the resource. It is not unique and can be up to 255 characters long. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> The relative importance of the target. Can be an integer from 0 to 65535, inclusive, and the default is 10. The lowest number represents the most important target. </summary> 
        public int? Priority { get; set; }

        ///<summary> The value that determines the relative share of the load the Target should receive compared to other Targets with the same priority. Can be an integer from 1 to 65535, inclusive, and the default is 10. Targets with higher values receive more load than those with lower ones with the same priority. </summary> 
        public int? Weight { get; set; }

        ///<summary> Whether the Target is enabled. The default is `true`. </summary> 
        public bool? Enabled { get; set; }


        /// <summary> Construct a new CreateConnectionPolicyTargetOptions </summary>
        /// <param name="pathConnectionPolicySid"> The SID of the Connection Policy that owns the Target. </param>
        /// <param name="target"> The SIP address you want Twilio to route your calls to. This must be a `sip:` schema. `sips` is NOT supported. </param>
        public CreateConnectionPolicyTargetOptions(string pathConnectionPolicySid, Uri target)
        {
            PathConnectionPolicySid = pathConnectionPolicySid;
            Target = target;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Target != null)
            {
                p.Add(new KeyValuePair<string, string>("Target", Serializers.Url(Target)));
            }
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (Priority != null)
            {
                p.Add(new KeyValuePair<string, string>("Priority", Priority.ToString()));
            }
            if (Weight != null)
            {
                p.Add(new KeyValuePair<string, string>("Weight", Weight.ToString()));
            }
            if (Enabled != null)
            {
                p.Add(new KeyValuePair<string, string>("Enabled", Enabled.Value.ToString().ToLower()));
            }
            return p;
        }
        

    }
    /// <summary> delete </summary>
    public class DeleteConnectionPolicyTargetOptions : IOptions<ConnectionPolicyTargetResource>
    {
        
        ///<summary> The SID of the Connection Policy that owns the Target. </summary> 
        public string PathConnectionPolicySid { get; }

        ///<summary> The unique string that we created to identify the Target resource to delete. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteConnectionPolicyTargetOptions </summary>
        /// <param name="pathConnectionPolicySid"> The SID of the Connection Policy that owns the Target. </param>
        /// <param name="pathSid"> The unique string that we created to identify the Target resource to delete. </param>
        public DeleteConnectionPolicyTargetOptions(string pathConnectionPolicySid, string pathSid)
        {
            PathConnectionPolicySid = pathConnectionPolicySid;
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
    public class FetchConnectionPolicyTargetOptions : IOptions<ConnectionPolicyTargetResource>
    {
    
        ///<summary> The SID of the Connection Policy that owns the Target. </summary> 
        public string PathConnectionPolicySid { get; }

        ///<summary> The unique string that we created to identify the Target resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchConnectionPolicyTargetOptions </summary>
        /// <param name="pathConnectionPolicySid"> The SID of the Connection Policy that owns the Target. </param>
        /// <param name="pathSid"> The unique string that we created to identify the Target resource to fetch. </param>
        public FetchConnectionPolicyTargetOptions(string pathConnectionPolicySid, string pathSid)
        {
            PathConnectionPolicySid = pathConnectionPolicySid;
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
    public class ReadConnectionPolicyTargetOptions : ReadOptions<ConnectionPolicyTargetResource>
    {
    
        ///<summary> The SID of the Connection Policy from which to read the Targets. </summary> 
        public string PathConnectionPolicySid { get; }



        /// <summary> Construct a new ListConnectionPolicyTargetOptions </summary>
        /// <param name="pathConnectionPolicySid"> The SID of the Connection Policy from which to read the Targets. </param>
        public ReadConnectionPolicyTargetOptions(string pathConnectionPolicySid)
        {
            PathConnectionPolicySid = pathConnectionPolicySid;
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
    public class UpdateConnectionPolicyTargetOptions : IOptions<ConnectionPolicyTargetResource>
    {
    
        ///<summary> The SID of the Connection Policy that owns the Target. </summary> 
        public string PathConnectionPolicySid { get; }

        ///<summary> The unique string that we created to identify the Target resource to update. </summary> 
        public string PathSid { get; }

        ///<summary> A descriptive string that you create to describe the resource. It is not unique and can be up to 255 characters long. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> The SIP address you want Twilio to route your calls to. This must be a `sip:` schema. `sips` is NOT supported. </summary> 
        public Uri Target { get; set; }

        ///<summary> The relative importance of the target. Can be an integer from 0 to 65535, inclusive. The lowest number represents the most important target. </summary> 
        public int? Priority { get; set; }

        ///<summary> The value that determines the relative share of the load the Target should receive compared to other Targets with the same priority. Can be an integer from 1 to 65535, inclusive. Targets with higher values receive more load than those with lower ones with the same priority. </summary> 
        public int? Weight { get; set; }

        ///<summary> Whether the Target is enabled. </summary> 
        public bool? Enabled { get; set; }



        /// <summary> Construct a new UpdateConnectionPolicyTargetOptions </summary>
        /// <param name="pathConnectionPolicySid"> The SID of the Connection Policy that owns the Target. </param>
        /// <param name="pathSid"> The unique string that we created to identify the Target resource to update. </param>
        public UpdateConnectionPolicyTargetOptions(string pathConnectionPolicySid, string pathSid)
        {
            PathConnectionPolicySid = pathConnectionPolicySid;
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
            if (Target != null)
            {
                p.Add(new KeyValuePair<string, string>("Target", Serializers.Url(Target)));
            }
            if (Priority != null)
            {
                p.Add(new KeyValuePair<string, string>("Priority", Priority.ToString()));
            }
            if (Weight != null)
            {
                p.Add(new KeyValuePair<string, string>("Weight", Weight.ToString()));
            }
            if (Enabled != null)
            {
                p.Add(new KeyValuePair<string, string>("Enabled", Enabled.Value.ToString().ToLower()));
            }
            return p;
        }
        

    }


}

