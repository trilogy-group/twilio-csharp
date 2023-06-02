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




namespace Kandy.Rest.Messaging.V1.BrandRegistration
{

    /// <summary> create </summary>
    public class CreateBrandVettingOptions : IOptions<BrandVettingResource>
    {
        
        ///<summary> The SID of the Brand Registration resource of the vettings to create . </summary> 
        public string PathBrandSid { get; }

        
        public BrandVettingResource.VettingProviderEnum VettingProvider { get; }

        ///<summary> The unique ID of the vetting </summary> 
        public string VettingId { get; set; }


        /// <summary> Construct a new CreateBrandVettingOptions </summary>
        /// <param name="pathBrandSid"> The SID of the Brand Registration resource of the vettings to create . </param>
        /// <param name="vettingProvider">  </param>
        public CreateBrandVettingOptions(string pathBrandSid, BrandVettingResource.VettingProviderEnum vettingProvider)
        {
            PathBrandSid = pathBrandSid;
            VettingProvider = vettingProvider;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (VettingProvider != null)
            {
                p.Add(new KeyValuePair<string, string>("VettingProvider", VettingProvider.ToString()));
            }
            if (VettingId != null)
            {
                p.Add(new KeyValuePair<string, string>("VettingId", VettingId));
            }
            return p;
        }
        

    }
    /// <summary> fetch </summary>
    public class FetchBrandVettingOptions : IOptions<BrandVettingResource>
    {
    
        ///<summary> The SID of the Brand Registration resource of the vettings to read . </summary> 
        public string PathBrandSid { get; }

        ///<summary> The Twilio SID of the third-party vetting record. </summary> 
        public string PathBrandVettingSid { get; }



        /// <summary> Construct a new FetchBrandVettingOptions </summary>
        /// <param name="pathBrandSid"> The SID of the Brand Registration resource of the vettings to read . </param>
        /// <param name="pathBrandVettingSid"> The Twilio SID of the third-party vetting record. </param>
        public FetchBrandVettingOptions(string pathBrandSid, string pathBrandVettingSid)
        {
            PathBrandSid = pathBrandSid;
            PathBrandVettingSid = pathBrandVettingSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> read </summary>
    public class ReadBrandVettingOptions : ReadOptions<BrandVettingResource>
    {
    
        ///<summary> The SID of the Brand Registration resource of the vettings to read . </summary> 
        public string PathBrandSid { get; }

        ///<summary> The third-party provider of the vettings to read </summary> 
        public BrandVettingResource.VettingProviderEnum VettingProvider { get; set; }



        /// <summary> Construct a new ListBrandVettingOptions </summary>
        /// <param name="pathBrandSid"> The SID of the Brand Registration resource of the vettings to read . </param>
        public ReadBrandVettingOptions(string pathBrandSid)
        {
            PathBrandSid = pathBrandSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (VettingProvider != null)
            {
                p.Add(new KeyValuePair<string, string>("VettingProvider", VettingProvider.ToString()));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

}
