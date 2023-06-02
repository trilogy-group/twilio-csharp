/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Studio
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




namespace Kandy.Rest.Studio.V2.Flow
{
    /// <summary> Retrieve a specific Flow revision. </summary>
    public class FetchFlowRevisionOptions : IOptions<FlowRevisionResource>
    {

        ///<summary> The SID of the Flow resource to fetch. </summary> 
        public string PathSid { get; }

        ///<summary> Specific Revision number or can be `LatestPublished` and `LatestRevision`. </summary> 
        public string PathRevision { get; }



        /// <summary> Construct a new FetchFlowRevisionOptions </summary>
        /// <param name="pathSid"> The SID of the Flow resource to fetch. </param>
        /// <param name="pathRevision"> Specific Revision number or can be `LatestPublished` and `LatestRevision`. </param>
        public FetchFlowRevisionOptions(string pathSid, string pathRevision)
        {
            PathSid = pathSid;
            PathRevision = pathRevision;
        }


        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }


    }


    /// <summary> Retrieve a list of all Flows revisions. </summary>
    public class ReadFlowRevisionOptions : ReadOptions<FlowRevisionResource>
    {

        ///<summary> The SID of the Flow resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new ListFlowRevisionOptions </summary>
        /// <param name="pathSid"> The SID of the Flow resource to fetch. </param>
        public ReadFlowRevisionOptions(string pathSid)
        {
            PathSid = pathSid;
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
