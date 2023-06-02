/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Routes
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




namespace Kandy.Rest.Routes.V2
{
    /// <summary> Fetch the Inbound Processing Region assigned to a SIP Trunk. </summary>
    public class FetchTrunkOptions : IOptions<TrunkResource>
    {

        ///<summary> The absolute URL of the SIP Trunk </summary> 
        public string PathSipTrunkDomain { get; }



        /// <summary> Construct a new FetchTrunksOptions </summary>
        /// <param name="pathSipTrunkDomain"> The absolute URL of the SIP Trunk </param>
        public FetchTrunkOptions(string pathSipTrunkDomain)
        {
            PathSipTrunkDomain = pathSipTrunkDomain;
        }


        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }


    }


    /// <summary> Assign an Inbound Processing Region to a SIP Trunk </summary>
    public class UpdateTrunkOptions : IOptions<TrunkResource>
    {

        ///<summary> The absolute URL of the SIP Trunk </summary> 
        public string PathSipTrunkDomain { get; }

        ///<summary> The Inbound Processing Region used for this SIP Trunk for voice </summary> 
        public string VoiceRegion { get; set; }

        ///<summary> A human readable description of this resource, up to 64 characters. </summary> 
        public string FriendlyName { get; set; }



        /// <summary> Construct a new UpdateTrunksOptions </summary>
        /// <param name="pathSipTrunkDomain"> The absolute URL of the SIP Trunk </param>
        public UpdateTrunkOptions(string pathSipTrunkDomain)
        {
            PathSipTrunkDomain = pathSipTrunkDomain;
        }


        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (VoiceRegion != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceRegion", VoiceRegion));
            }
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            return p;
        }


    }


}
