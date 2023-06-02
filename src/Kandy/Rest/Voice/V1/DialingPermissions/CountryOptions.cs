/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Voice
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




namespace Kandy.Rest.Voice.V1.DialingPermissions
{
    /// <summary> Retrieve voice dialing country permissions identified by the given ISO country code </summary>
    public class FetchCountryOptions : IOptions<CountryResource>
    {

        ///<summary> The [ISO country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) of the DialingPermissions Country resource to fetch </summary> 
        public string PathIsoCode { get; }



        /// <summary> Construct a new FetchDialingPermissionsCountryOptions </summary>
        /// <param name="pathIsoCode"> The [ISO country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) of the DialingPermissions Country resource to fetch </param>
        public FetchCountryOptions(string pathIsoCode)
        {
            PathIsoCode = pathIsoCode;
        }


        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }


    }


    /// <summary> Retrieve all voice dialing country permissions for this account </summary>
    public class ReadCountryOptions : ReadOptions<CountryResource>
    {

        ///<summary> Filter to retrieve the country permissions by specifying the [ISO country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) </summary> 
        public string IsoCode { get; set; }

        ///<summary> Filter to retrieve the country permissions by specifying the continent </summary> 
        public string Continent { get; set; }

        ///<summary> Filter the results by specified [country codes](https://www.itu.int/itudoc/itu-t/ob-lists/icc/e164_763.html) </summary> 
        public string CountryCode { get; set; }

        ///<summary> Filter to retrieve the country permissions with dialing to low-risk numbers enabled. Can be: `true` or `false`. </summary> 
        public bool? LowRiskNumbersEnabled { get; set; }

        ///<summary> Filter to retrieve the country permissions with dialing to high-risk special service numbers enabled. Can be: `true` or `false` </summary> 
        public bool? HighRiskSpecialNumbersEnabled { get; set; }

        ///<summary> Filter to retrieve the country permissions with dialing to high-risk [toll fraud](https://www.kandy.com/learn/voice-and-video/toll-fraud) numbers enabled. Can be: `true` or `false`. </summary> 
        public bool? HighRiskTollfraudNumbersEnabled { get; set; }





        /// <summary> Generate the necessary parameters </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (IsoCode != null)
            {
                p.Add(new KeyValuePair<string, string>("IsoCode", IsoCode.ToString()));
            }
            if (Continent != null)
            {
                p.Add(new KeyValuePair<string, string>("Continent", Continent));
            }
            if (CountryCode != null)
            {
                p.Add(new KeyValuePair<string, string>("CountryCode", CountryCode));
            }
            if (LowRiskNumbersEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("LowRiskNumbersEnabled", LowRiskNumbersEnabled.Value.ToString().ToLower()));
            }
            if (HighRiskSpecialNumbersEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("HighRiskSpecialNumbersEnabled", HighRiskSpecialNumbersEnabled.Value.ToString().ToLower()));
            }
            if (HighRiskTollfraudNumbersEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("HighRiskTollfraudNumbersEnabled", HighRiskTollfraudNumbersEnabled.Value.ToString().ToLower()));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }


    }

}
