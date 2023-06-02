/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Api
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




namespace Kandy.Rest.Api.V2010.Account.Call
{

    /// <summary> Create a FeedbackSummary resource for a call </summary>
    public class CreateFeedbackSummaryOptions : IOptions<FeedbackSummaryResource>
    {
        
        ///<summary> Only include feedback given on or after this date. Format is `YYYY-MM-DD` and specified in UTC. </summary> 
        public DateTime? StartDate { get; }

        ///<summary> Only include feedback given on or before this date. Format is `YYYY-MM-DD` and specified in UTC. </summary> 
        public DateTime? EndDate { get; }

        ///<summary> The unique id of the [Account](https://www.twilio.com/docs/iam/api/account) responsible for this resource. </summary> 
        public string PathAccountSid { get; set; }

        ///<summary> Whether to also include Feedback resources from all subaccounts. `true` includes feedback from all subaccounts and `false`, the default, includes feedback from only the specified account. </summary> 
        public bool? IncludeSubaccounts { get; set; }

        ///<summary> The URL that we will request when the feedback summary is complete. </summary> 
        public Uri StatusCallback { get; set; }

        ///<summary> The HTTP method (`GET` or `POST`) we use to make the request to the `StatusCallback` URL. </summary> 
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; set; }


        /// <summary> Construct a new CreateCallFeedbackSummaryOptions </summary>
        /// <param name="startDate"> Only include feedback given on or after this date. Format is `YYYY-MM-DD` and specified in UTC. </param>
        /// <param name="endDate"> Only include feedback given on or before this date. Format is `YYYY-MM-DD` and specified in UTC. </param>
        public CreateFeedbackSummaryOptions(DateTime? startDate, DateTime? endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (StartDate != null)
            {
                p.Add(new KeyValuePair<string, string>("StartDate", StartDate.Value.ToString("yyyy-MM-dd")));
            }
            if (EndDate != null)
            {
                p.Add(new KeyValuePair<string, string>("EndDate", EndDate.Value.ToString("yyyy-MM-dd")));
            }
            if (IncludeSubaccounts != null)
            {
                p.Add(new KeyValuePair<string, string>("IncludeSubaccounts", IncludeSubaccounts.Value.ToString().ToLower()));
            }
            if (StatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallback", Serializers.Url(StatusCallback)));
            }
            if (StatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallbackMethod", StatusCallbackMethod.ToString()));
            }
            return p;
        }
        

    }
    /// <summary> Delete a FeedbackSummary resource from a call </summary>
    public class DeleteFeedbackSummaryOptions : IOptions<FeedbackSummaryResource>
    {
        
        ///<summary> A 34 character string that uniquely identifies this resource. </summary> 
        public string PathSid { get; }

        ///<summary> The unique id of the [Account](https://www.twilio.com/docs/iam/api/account) responsible for this resource. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new DeleteCallFeedbackSummaryOptions </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        public DeleteFeedbackSummaryOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Fetch a FeedbackSummary resource from a call </summary>
    public class FetchFeedbackSummaryOptions : IOptions<FeedbackSummaryResource>
    {
    
        ///<summary> A 34 character string that uniquely identifies this resource. </summary> 
        public string PathSid { get; }

        ///<summary> The unique id of the [Account](https://www.twilio.com/docs/iam/api/account) responsible for this resource. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new FetchCallFeedbackSummaryOptions </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        public FetchFeedbackSummaryOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


}
