/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Bulkexports
 * This is the public Twilio REST API.
 *
 * NOTE: This class is auto generated by OpenAPI Generator.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;



namespace Kandy.Rest.Bulkexports.V1.Export
{
    public class JobResource : Resource
    {
    

        
        /// <summary> delete </summary>
        /// <param name="options"> Delete Job parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Job </returns>
        private static Request BuildDeleteRequest(DeleteJobOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Exports/Jobs/{JobSid}";

            string PathJobSid = options.PathJobSid;
            path = path.Replace("{"+"JobSid"+"}", PathJobSid);

            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Bulkexports,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> delete </summary>
        /// <param name="options"> Delete Job parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Job </returns>
        public static bool Delete(DeleteJobOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary> delete </summary>
        /// <param name="options"> Delete Job parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Job </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteJobOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary> delete </summary>
        /// <param name="pathJobSid"> The unique string that that we created to identify the Bulk Export job </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Job </returns>
        public static bool Delete(string pathJobSid, ITwilioRestClient client = null)
        {
            var options = new DeleteJobOptions(pathJobSid)     ;
            return Delete(options, client);
        }

        #if !NET35
        /// <summary> delete </summary>
        /// <param name="pathJobSid"> The unique string that that we created to identify the Bulk Export job </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Job </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathJobSid, ITwilioRestClient client = null)
        {
            var options = new DeleteJobOptions(pathJobSid) ;
            return await DeleteAsync(options, client);
        }
        #endif
        
        private static Request BuildFetchRequest(FetchJobOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Exports/Jobs/{JobSid}";

            string PathJobSid = options.PathJobSid;
            path = path.Replace("{"+"JobSid"+"}", PathJobSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Bulkexports,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Job parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Job </returns>
        public static JobResource Fetch(FetchJobOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="options"> Fetch Job parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Job </returns>
        public static async System.Threading.Tasks.Task<JobResource> FetchAsync(FetchJobOptions options,
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
        /// <summary> fetch </summary>
        /// <param name="pathJobSid"> The unique string that that we created to identify the Bulk Export job </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Job </returns>
        public static JobResource Fetch(
                                         string pathJobSid, 
                                         ITwilioRestClient client = null)
        {
            var options = new FetchJobOptions(pathJobSid){  };
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary> fetch </summary>
        /// <param name="pathJobSid"> The unique string that that we created to identify the Bulk Export job </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Job </returns>
        public static async System.Threading.Tasks.Task<JobResource> FetchAsync(string pathJobSid, ITwilioRestClient client = null)
        {
            var options = new FetchJobOptions(pathJobSid){  };
            return await FetchAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a JobResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> JobResource object represented by the provided JSON </returns>
        public static JobResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<JobResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> The type of communication – Messages, Calls, Conferences, and Participants </summary> 
        [JsonProperty("resource_type")]
        public string ResourceType { get; private set; }

        ///<summary> The friendly name specified when creating the job </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> The details of a job which is an object that contains an array of status grouped by `status` state.  Each `status` object has a `status` string, a count which is the number of days in that `status`, and list of days in that `status`. The day strings are in the format yyyy-MM-dd. As an example, a currently running job may have a status object for COMPLETED and a `status` object for SUBMITTED each with its own count and list of days. </summary> 
        [JsonProperty("details")]
        public object Details { get; private set; }

        ///<summary> The start time for the export specified when creating the job </summary> 
        [JsonProperty("start_day")]
        public string StartDay { get; private set; }

        ///<summary> The end time for the export specified when creating the job </summary> 
        [JsonProperty("end_day")]
        public string EndDay { get; private set; }

        ///<summary> The job_sid returned when the export was created </summary> 
        [JsonProperty("job_sid")]
        public string JobSid { get; private set; }

        ///<summary> The optional webhook url called on completion </summary> 
        [JsonProperty("webhook_url")]
        public string WebhookUrl { get; private set; }

        ///<summary> This is the method used to call the webhook </summary> 
        [JsonProperty("webhook_method")]
        public string WebhookMethod { get; private set; }

        ///<summary> The optional email to send the completion notification to </summary> 
        [JsonProperty("email")]
        public string Email { get; private set; }

        ///<summary> The url </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> This is the job position from the 1st in line. Your queue position will never increase. As jobs ahead of yours in the queue are processed, the queue position number will decrease </summary> 
        [JsonProperty("job_queue_position")]
        public string JobQueuePosition { get; private set; }

        ///<summary> this is the time estimated until your job is complete. This is calculated each time you request the job list. The time is calculated based on the current rate of job completion (which may vary) and your job queue position </summary> 
        [JsonProperty("estimated_completion_time")]
        public string EstimatedCompletionTime { get; private set; }



        private JobResource() {

        }
    }
}
