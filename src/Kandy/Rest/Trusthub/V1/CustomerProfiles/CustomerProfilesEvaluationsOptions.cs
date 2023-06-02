/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Trusthub
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




namespace Kandy.Rest.Trusthub.V1.CustomerProfiles
{

    /// <summary> Create a new Evaluation </summary>
    public class CreateCustomerProfilesEvaluationsOptions : IOptions<CustomerProfilesEvaluationsResource>
    {

        ///<summary> The unique string that we created to identify the CustomerProfile resource. </summary> 
        public string PathCustomerProfileSid { get; }

        ///<summary> The unique string of a policy that is associated to the customer_profile resource. </summary> 
        public string PolicySid { get; }


        /// <summary> Construct a new CreateCustomerProfileEvaluationOptions </summary>
        /// <param name="pathCustomerProfileSid"> The unique string that we created to identify the CustomerProfile resource. </param>
        /// <param name="policySid"> The unique string of a policy that is associated to the customer_profile resource. </param>
        public CreateCustomerProfilesEvaluationsOptions(string pathCustomerProfileSid, string policySid)
        {
            PathCustomerProfileSid = pathCustomerProfileSid;
            PolicySid = policySid;
        }


        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (PolicySid != null)
            {
                p.Add(new KeyValuePair<string, string>("PolicySid", PolicySid));
            }
            return p;
        }


    }
    /// <summary> Fetch specific Evaluation Instance. </summary>
    public class FetchCustomerProfilesEvaluationsOptions : IOptions<CustomerProfilesEvaluationsResource>
    {

        ///<summary> The unique string that we created to identify the customer_profile resource. </summary> 
        public string PathCustomerProfileSid { get; }

        ///<summary> The unique string that identifies the Evaluation resource. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchCustomerProfileEvaluationOptions </summary>
        /// <param name="pathCustomerProfileSid"> The unique string that we created to identify the customer_profile resource. </param>
        /// <param name="pathSid"> The unique string that identifies the Evaluation resource. </param>
        public FetchCustomerProfilesEvaluationsOptions(string pathCustomerProfileSid, string pathSid)
        {
            PathCustomerProfileSid = pathCustomerProfileSid;
            PathSid = pathSid;
        }


        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }


    }


    /// <summary> Retrieve a list of Evaluations associated to the customer_profile resource. </summary>
    public class ReadCustomerProfilesEvaluationsOptions : ReadOptions<CustomerProfilesEvaluationsResource>
    {

        ///<summary> The unique string that we created to identify the CustomerProfile resource. </summary> 
        public string PathCustomerProfileSid { get; }



        /// <summary> Construct a new ListCustomerProfileEvaluationOptions </summary>
        /// <param name="pathCustomerProfileSid"> The unique string that we created to identify the CustomerProfile resource. </param>
        public ReadCustomerProfilesEvaluationsOptions(string pathCustomerProfileSid)
        {
            PathCustomerProfileSid = pathCustomerProfileSid;
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
