/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Trunking
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




namespace Kandy.Rest.Trunking.V1.Trunk
{

    /// <summary> Associate an IP Access Control List with a Trunk </summary>
    public class CreateIpAccessControlListOptions : IOptions<IpAccessControlListResource>
    {

        ///<summary> The SID of the Trunk to associate the IP Access Control List with. </summary> 
        public string PathTrunkSid { get; }

        ///<summary> The SID of the [IP Access Control List](https://www.kandy.com/docs/voice/sip/api/sip-ipaccesscontrollist-resource) that you want to associate with the trunk. </summary> 
        public string IpAccessControlListSid { get; }


        /// <summary> Construct a new CreateIpAccessControlListOptions </summary>
        /// <param name="pathTrunkSid"> The SID of the Trunk to associate the IP Access Control List with. </param>
        /// <param name="ipAccessControlListSid"> The SID of the [IP Access Control List](https://www.kandy.com/docs/voice/sip/api/sip-ipaccesscontrollist-resource) that you want to associate with the trunk. </param>
        public CreateIpAccessControlListOptions(string pathTrunkSid, string ipAccessControlListSid)
        {
            PathTrunkSid = pathTrunkSid;
            IpAccessControlListSid = ipAccessControlListSid;
        }


        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (IpAccessControlListSid != null)
            {
                p.Add(new KeyValuePair<string, string>("IpAccessControlListSid", IpAccessControlListSid));
            }
            return p;
        }


    }
    /// <summary> Remove an associated IP Access Control List from a Trunk </summary>
    public class DeleteIpAccessControlListOptions : IOptions<IpAccessControlListResource>
    {

        ///<summary> The SID of the Trunk from which to delete the IP Access Control List. </summary> 
        public string PathTrunkSid { get; }

        ///<summary> The unique string that we created to identify the IpAccessControlList resource to delete. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteIpAccessControlListOptions </summary>
        /// <param name="pathTrunkSid"> The SID of the Trunk from which to delete the IP Access Control List. </param>
        /// <param name="pathSid"> The unique string that we created to identify the IpAccessControlList resource to delete. </param>
        public DeleteIpAccessControlListOptions(string pathTrunkSid, string pathSid)
        {
            PathTrunkSid = pathTrunkSid;
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
    public class FetchIpAccessControlListOptions : IOptions<IpAccessControlListResource>
    {

        ///<summary> The SID of the Trunk from which to fetch the IP Access Control List. </summary> 
        public string PathTrunkSid { get; }

        ///<summary> The unique string that we created to identify the IpAccessControlList resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchIpAccessControlListOptions </summary>
        /// <param name="pathTrunkSid"> The SID of the Trunk from which to fetch the IP Access Control List. </param>
        /// <param name="pathSid"> The unique string that we created to identify the IpAccessControlList resource to fetch. </param>
        public FetchIpAccessControlListOptions(string pathTrunkSid, string pathSid)
        {
            PathTrunkSid = pathTrunkSid;
            PathSid = pathSid;
        }


        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }


    }


    /// <summary> List all IP Access Control Lists for a Trunk </summary>
    public class ReadIpAccessControlListOptions : ReadOptions<IpAccessControlListResource>
    {

        ///<summary> The SID of the Trunk from which to read the IP Access Control Lists. </summary> 
        public string PathTrunkSid { get; }



        /// <summary> Construct a new ListIpAccessControlListOptions </summary>
        /// <param name="pathTrunkSid"> The SID of the Trunk from which to read the IP Access Control Lists. </param>
        public ReadIpAccessControlListOptions(string pathTrunkSid)
        {
            PathTrunkSid = pathTrunkSid;
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

}
