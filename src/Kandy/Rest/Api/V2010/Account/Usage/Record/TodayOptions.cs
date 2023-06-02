/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Api
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




namespace Kandy.Rest.Api.V2010.Account.Usage.Record
{
    /// <summary> read </summary>
    public class ReadTodayOptions : ReadOptions<TodayResource>
    {

        ///<summary> The SID of the [Account](https://www.kandy.com/docs/iam/api/account) that created the UsageRecord resources to read. </summary> 
        public string PathAccountSid { get; set; }

        ///<summary> The [usage category](https://www.kandy.com/docs/usage/api/usage-record#usage-categories) of the UsageRecord resources to read. Only UsageRecord resources in the specified category are retrieved. </summary> 
        public TodayResource.CategoryEnum Category { get; set; }

        ///<summary> Only include usage that has occurred on or after this date. Specify the date in GMT and format as `YYYY-MM-DD`. You can also specify offsets from the current date, such as: `-30days`, which will set the start date to be 30 days before the current date. </summary> 
        public DateTime? StartDate { get; set; }

        ///<summary> Only include usage that occurred on or before this date. Specify the date in GMT and format as `YYYY-MM-DD`.  You can also specify offsets from the current date, such as: `+30days`, which will set the end date to 30 days from the current date. </summary> 
        public DateTime? EndDate { get; set; }

        ///<summary> Whether to include usage from the master account and all its subaccounts. Can be: `true` (the default) to include usage from the master account and all subaccounts or `false` to retrieve usage from only the specified account. </summary> 
        public bool? IncludeSubaccounts { get; set; }





        /// <summary> Generate the necessary parameters </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Category != null)
            {
                p.Add(new KeyValuePair<string, string>("Category", Category.ToString()));
            }
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
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }


    }

}
