/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Kandy - Bulkexports
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




namespace Kandy.Rest.Bulkexports.V1.Export
{

    /// <summary> create </summary>
    public class CreateExportCustomJobOptions : IOptions<ExportCustomJobResource>
    {

        ///<summary> The type of communication – Messages or Calls, Conferences, and Participants </summary> 
        public string PathResourceType { get; }

        ///<summary> The start day for the custom export specified as a string in the format of yyyy-mm-dd </summary> 
        public string StartDay { get; }

        ///<summary> The end day for the custom export specified as a string in the format of yyyy-mm-dd. End day is inclusive and must be 2 days earlier than the current UTC day. </summary> 
        public string EndDay { get; }

        ///<summary> The friendly name specified when creating the job </summary> 
        public string FriendlyName { get; }

        ///<summary> The optional webhook url called on completion of the job. If this is supplied, `WebhookMethod` must also be supplied. If you set neither webhook nor email, you will have to check your job's status manually. </summary> 
        public string WebhookUrl { get; set; }

        ///<summary> This is the method used to call the webhook on completion of the job. If this is supplied, `WebhookUrl` must also be supplied. </summary> 
        public string WebhookMethod { get; set; }

        ///<summary> The optional email to send the completion notification to. You can set both webhook, and email, or one or the other. If you set neither, the job will run but you will have to query to determine your job's status. </summary> 
        public string Email { get; set; }


        /// <summary> Construct a new CreateExportCustomJobOptions </summary>
        /// <param name="pathResourceType"> The type of communication – Messages or Calls, Conferences, and Participants </param>
        /// <param name="startDay"> The start day for the custom export specified as a string in the format of yyyy-mm-dd </param>
        /// <param name="endDay"> The end day for the custom export specified as a string in the format of yyyy-mm-dd. End day is inclusive and must be 2 days earlier than the current UTC day. </param>
        /// <param name="friendlyName"> The friendly name specified when creating the job </param>
        public CreateExportCustomJobOptions(string pathResourceType, string startDay, string endDay, string friendlyName)
        {
            PathResourceType = pathResourceType;
            StartDay = startDay;
            EndDay = endDay;
            FriendlyName = friendlyName;
        }


        /// <summary> Generate the necessary parameters </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (StartDay != null)
            {
                p.Add(new KeyValuePair<string, string>("StartDay", StartDay));
            }
            if (EndDay != null)
            {
                p.Add(new KeyValuePair<string, string>("EndDay", EndDay));
            }
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (WebhookUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("WebhookUrl", WebhookUrl));
            }
            if (WebhookMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("WebhookMethod", WebhookMethod));
            }
            if (Email != null)
            {
                p.Add(new KeyValuePair<string, string>("Email", Email));
            }
            return p;
        }


    }
    /// <summary> read </summary>
    public class ReadExportCustomJobOptions : ReadOptions<ExportCustomJobResource>
    {

        ///<summary> The type of communication – Messages, Calls, Conferences, and Participants </summary> 
        public string PathResourceType { get; }



        /// <summary> Construct a new ListExportCustomJobOptions </summary>
        /// <param name="pathResourceType"> The type of communication – Messages, Calls, Conferences, and Participants </param>
        public ReadExportCustomJobOptions(string pathResourceType)
        {
            PathResourceType = pathResourceType;
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
