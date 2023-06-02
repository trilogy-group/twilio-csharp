/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Trunking
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




namespace Kandy.Rest.Trunking.V1.Trunk
{

    /// <summary> create </summary>
    public class CreateCredentialListOptions : IOptions<CredentialListResource>
    {
        
        ///<summary> The SID of the Trunk to associate the credential list with. </summary> 
        public string PathTrunkSid { get; }

        ///<summary> The SID of the [Credential List](https://www.twilio.com/docs/voice/sip/api/sip-credentiallist-resource) that you want to associate with the trunk. Once associated, we will authenticate access to the trunk against this list. </summary> 
        public string CredentialListSid { get; }


        /// <summary> Construct a new CreateCredentialListOptions </summary>
        /// <param name="pathTrunkSid"> The SID of the Trunk to associate the credential list with. </param>
        /// <param name="credentialListSid"> The SID of the [Credential List](https://www.twilio.com/docs/voice/sip/api/sip-credentiallist-resource) that you want to associate with the trunk. Once associated, we will authenticate access to the trunk against this list. </param>
        public CreateCredentialListOptions(string pathTrunkSid, string credentialListSid)
        {
            PathTrunkSid = pathTrunkSid;
            CredentialListSid = credentialListSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (CredentialListSid != null)
            {
                p.Add(new KeyValuePair<string, string>("CredentialListSid", CredentialListSid));
            }
            return p;
        }
        

    }
    /// <summary> delete </summary>
    public class DeleteCredentialListOptions : IOptions<CredentialListResource>
    {
        
        ///<summary> The SID of the Trunk from which to delete the credential list. </summary> 
        public string PathTrunkSid { get; }

        ///<summary> The unique string that we created to identify the CredentialList resource to delete. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteCredentialListOptions </summary>
        /// <param name="pathTrunkSid"> The SID of the Trunk from which to delete the credential list. </param>
        /// <param name="pathSid"> The unique string that we created to identify the CredentialList resource to delete. </param>
        public DeleteCredentialListOptions(string pathTrunkSid, string pathSid)
        {
            PathTrunkSid = pathTrunkSid;
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
    public class FetchCredentialListOptions : IOptions<CredentialListResource>
    {
    
        ///<summary> The SID of the Trunk from which to fetch the credential list. </summary> 
        public string PathTrunkSid { get; }

        ///<summary> The unique string that we created to identify the CredentialList resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchCredentialListOptions </summary>
        /// <param name="pathTrunkSid"> The SID of the Trunk from which to fetch the credential list. </param>
        /// <param name="pathSid"> The unique string that we created to identify the CredentialList resource to fetch. </param>
        public FetchCredentialListOptions(string pathTrunkSid, string pathSid)
        {
            PathTrunkSid = pathTrunkSid;
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
    public class ReadCredentialListOptions : ReadOptions<CredentialListResource>
    {
    
        ///<summary> The SID of the Trunk from which to read the credential lists. </summary> 
        public string PathTrunkSid { get; }



        /// <summary> Construct a new ListCredentialListOptions </summary>
        /// <param name="pathTrunkSid"> The SID of the Trunk from which to read the credential lists. </param>
        public ReadCredentialListOptions(string pathTrunkSid)
        {
            PathTrunkSid = pathTrunkSid;
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

}
