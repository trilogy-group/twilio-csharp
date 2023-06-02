/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Messaging
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




namespace Kandy.Rest.Messaging.V1
{
    /// <summary> delete </summary>
    public class DeleteDomainCertsOptions : IOptions<DomainCertsResource>
    {
        
        ///<summary> Unique string used to identify the domain that this certificate should be associated with. </summary> 
        public string PathDomainSid { get; }



        /// <summary> Construct a new DeleteDomainCertV4Options </summary>
        /// <param name="pathDomainSid"> Unique string used to identify the domain that this certificate should be associated with. </param>
        public DeleteDomainCertsOptions(string pathDomainSid)
        {
            PathDomainSid = pathDomainSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> fetch </summary>
    public class FetchDomainCertsOptions : IOptions<DomainCertsResource>
    {
    
        ///<summary> Unique string used to identify the domain that this certificate should be associated with. </summary> 
        public string PathDomainSid { get; }



        /// <summary> Construct a new FetchDomainCertV4Options </summary>
        /// <param name="pathDomainSid"> Unique string used to identify the domain that this certificate should be associated with. </param>
        public FetchDomainCertsOptions(string pathDomainSid)
        {
            PathDomainSid = pathDomainSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> update </summary>
    public class UpdateDomainCertsOptions : IOptions<DomainCertsResource>
    {
    
        ///<summary> Unique string used to identify the domain that this certificate should be associated with. </summary> 
        public string PathDomainSid { get; }

        ///<summary> Contains the full TLS certificate and private for this domain in PEM format: https://en.wikipedia.org/wiki/Privacy-Enhanced_Mail. Twilio uses this information to process HTTPS traffic sent to your domain. </summary> 
        public string TlsCert { get; }



        /// <summary> Construct a new UpdateDomainCertV4Options </summary>
        /// <param name="pathDomainSid"> Unique string used to identify the domain that this certificate should be associated with. </param>
        /// <param name="tlsCert"> Contains the full TLS certificate and private for this domain in PEM format: https://en.wikipedia.org/wiki/Privacy-Enhanced_Mail. Twilio uses this information to process HTTPS traffic sent to your domain. </param>
        public UpdateDomainCertsOptions(string pathDomainSid, string tlsCert)
        {
            PathDomainSid = pathDomainSid;
            TlsCert = tlsCert;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (TlsCert != null)
            {
                p.Add(new KeyValuePair<string, string>("TlsCert", TlsCert));
            }
            return p;
        }
        

    }


}
