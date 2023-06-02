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




namespace Kandy.Rest.Preview.DeployedDevices.Fleet
{

    /// <summary> Create a new Device in the Fleet, optionally giving it a unique name, friendly name, and assigning to a Deployment and/or human identity. </summary>
    public class CreateDeviceOptions : IOptions<DeviceResource>
    {
        
        
        public string PathFleetSid { get; }

        ///<summary> Provides a unique and addressable name to be assigned to this Device, to be used in addition to SID, up to 128 characters long. </summary> 
        public string UniqueName { get; set; }

        ///<summary> Provides a human readable descriptive text to be assigned to this Device, up to 256 characters long. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> Provides an arbitrary string identifier representing a human user to be associated with this Device, up to 256 characters long. </summary> 
        public string Identity { get; set; }

        ///<summary> Specifies the unique string identifier of the Deployment group that this Device is going to be associated with. </summary> 
        public string DeploymentSid { get; set; }

        
        public bool? Enabled { get; set; }


        /// <summary> Construct a new CreateDeployedDevicesDeviceOptions </summary>
        /// <param name="pathFleetSid">  </param>
        public CreateDeviceOptions(string pathFleetSid)
        {
            PathFleetSid = pathFleetSid;
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
            if (Identity != null)
            {
                p.Add(new KeyValuePair<string, string>("Identity", Identity));
            }
            if (DeploymentSid != null)
            {
                p.Add(new KeyValuePair<string, string>("DeploymentSid", DeploymentSid));
            }
            if (Enabled != null)
            {
                p.Add(new KeyValuePair<string, string>("Enabled", Enabled.Value.ToString().ToLower()));
            }
            return p;
        }
        

    }
    /// <summary> Delete a specific Device from the Fleet, also removing it from associated Deployments. </summary>
    public class DeleteDeviceOptions : IOptions<DeviceResource>
    {
        
        
        public string PathFleetSid { get; }

        ///<summary> Provides a 34 character string that uniquely identifies the requested Device resource. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteDeployedDevicesDeviceOptions </summary>
        /// <param name="pathFleetSid">  </param>
        /// <param name="pathSid"> Provides a 34 character string that uniquely identifies the requested Device resource. </param>
        public DeleteDeviceOptions(string pathFleetSid, string pathSid)
        {
            PathFleetSid = pathFleetSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Fetch information about a specific Device in the Fleet. </summary>
    public class FetchDeviceOptions : IOptions<DeviceResource>
    {
    
        
        public string PathFleetSid { get; }

        ///<summary> Provides a 34 character string that uniquely identifies the requested Device resource. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchDeployedDevicesDeviceOptions </summary>
        /// <param name="pathFleetSid">  </param>
        /// <param name="pathSid"> Provides a 34 character string that uniquely identifies the requested Device resource. </param>
        public FetchDeviceOptions(string pathFleetSid, string pathSid)
        {
            PathFleetSid = pathFleetSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Retrieve a list of all Devices belonging to the Fleet. </summary>
    public class ReadDeviceOptions : ReadOptions<DeviceResource>
    {
    
        
        public string PathFleetSid { get; }

        ///<summary> Filters the resulting list of Devices by a unique string identifier of the Deployment they are associated with. </summary> 
        public string DeploymentSid { get; set; }



        /// <summary> Construct a new ListDeployedDevicesDeviceOptions </summary>
        /// <param name="pathFleetSid">  </param>
        public ReadDeviceOptions(string pathFleetSid)
        {
            PathFleetSid = pathFleetSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (DeploymentSid != null)
            {
                p.Add(new KeyValuePair<string, string>("DeploymentSid", DeploymentSid));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

    /// <summary> Update the given properties of a specific Device in the Fleet, giving it a friendly name, assigning to a Deployment, or a human identity. </summary>
    public class UpdateDeviceOptions : IOptions<DeviceResource>
    {
    
        
        public string PathFleetSid { get; }

        ///<summary> Provides a 34 character string that uniquely identifies the requested Device resource. </summary> 
        public string PathSid { get; }

        ///<summary> Provides a human readable descriptive text to be assigned to this Device, up to 256 characters long. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> Provides an arbitrary string identifier representing a human user to be associated with this Device, up to 256 characters long. </summary> 
        public string Identity { get; set; }

        ///<summary> Specifies the unique string identifier of the Deployment group that this Device is going to be associated with. </summary> 
        public string DeploymentSid { get; set; }

        
        public bool? Enabled { get; set; }



        /// <summary> Construct a new UpdateDeployedDevicesDeviceOptions </summary>
        /// <param name="pathFleetSid">  </param>
        /// <param name="pathSid"> Provides a 34 character string that uniquely identifies the requested Device resource. </param>
        public UpdateDeviceOptions(string pathFleetSid, string pathSid)
        {
            PathFleetSid = pathFleetSid;
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
            if (Identity != null)
            {
                p.Add(new KeyValuePair<string, string>("Identity", Identity));
            }
            if (DeploymentSid != null)
            {
                p.Add(new KeyValuePair<string, string>("DeploymentSid", DeploymentSid));
            }
            if (Enabled != null)
            {
                p.Add(new KeyValuePair<string, string>("Enabled", Enabled.Value.ToString().ToLower()));
            }
            return p;
        }
        

    }


}
