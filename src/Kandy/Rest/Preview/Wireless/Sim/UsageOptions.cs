/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Preview
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




namespace Kandy.Rest.Preview.Wireless.Sim
{
    /// <summary> fetch </summary>
    public class FetchUsageOptions : IOptions<UsageResource>
    {


        public string PathSimSid { get; }


        public string End { get; set; }


        public string Start { get; set; }



        /// <summary> Construct a new FetchWirelessUsageOptions </summary>
        /// <param name="pathSimSid">  </param>
        public FetchUsageOptions(string pathSimSid)
        {
            PathSimSid = pathSimSid;
        }


        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (End != null)
            {
                p.Add(new KeyValuePair<string, string>("End", End));
            }
            if (Start != null)
            {
                p.Add(new KeyValuePair<string, string>("Start", Start));
            }
            return p;
        }


    }


}
