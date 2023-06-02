/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Numbers
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




namespace Kandy.Rest.Numbers.V2.RegulatoryCompliance
{
    /// <summary> Fetch specific Regulation Instance. </summary>
    public class FetchRegulationOptions : IOptions<RegulationResource>
    {

        ///<summary> The unique string that identifies the Regulation resource. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchRegulationOptions </summary>
        /// <param name="pathSid"> The unique string that identifies the Regulation resource. </param>
        public FetchRegulationOptions(string pathSid)
        {
            PathSid = pathSid;
        }


        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }


    }


    /// <summary> Retrieve a list of all Regulations. </summary>
    public class ReadRegulationOptions : ReadOptions<RegulationResource>
    {

        ///<summary> The type of End User the regulation requires - can be `individual` or `business`. </summary> 
        public RegulationResource.EndUserTypeEnum EndUserType { get; set; }

        ///<summary> The ISO country code of the phone number's country. </summary> 
        public string IsoCountry { get; set; }

        ///<summary> The type of phone number that the regulatory requiremnt is restricting. </summary> 
        public string NumberType { get; set; }





        /// <summary> Generate the necessary parameters </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (EndUserType != null)
            {
                p.Add(new KeyValuePair<string, string>("EndUserType", EndUserType.ToString()));
            }
            if (IsoCountry != null)
            {
                p.Add(new KeyValuePair<string, string>("IsoCountry", IsoCountry));
            }
            if (NumberType != null)
            {
                p.Add(new KeyValuePair<string, string>("NumberType", NumberType));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }


    }

}
