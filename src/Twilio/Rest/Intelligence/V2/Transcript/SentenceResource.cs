/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Intelligence
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



namespace Kandy.Rest.Intelligence.V2.Transcript
{
    public class SentenceResource : Resource
    {



        private static Request BuildReadRequest(ReadSentenceOptions options, IKandyRestClient client)
        {

            string path = "/v2/Transcripts/{TranscriptSid}/Sentences";

            string PathTranscriptSid = options.PathTranscriptSid;
            path = path.Replace("{" + "TranscriptSid" + "}", PathTranscriptSid);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Intelligence,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }
        /// <summary> Get all Transcript Sentences by TranscriptSid </summary>
        /// <param name="options"> Read Sentence parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Sentence </returns>
        public static ResourceSet<SentenceResource> Read(ReadSentenceOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            var page = Page<SentenceResource>.FromJson("sentences", response.Content);
            return new ResourceSet<SentenceResource>(page, options, client);
        }

#if !NET35
        /// <summary> Get all Transcript Sentences by TranscriptSid </summary>
        /// <param name="options"> Read Sentence parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Sentence </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<SentenceResource>> ReadAsync(ReadSentenceOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<SentenceResource>.FromJson("sentences", response.Content);
            return new ResourceSet<SentenceResource>(page, options, client);
        }
#endif
        /// <summary> Get all Transcript Sentences by TranscriptSid </summary>
        /// <param name="pathTranscriptSid"> The unique SID identifier of the Transcript. </param>
        /// <param name="redacted"> Grant access to PII Redacted/Unredacted Sentences. The default is `true` to access redacted sentences. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Sentence </returns>
        public static ResourceSet<SentenceResource> Read(
                                                     string pathTranscriptSid,
                                                     bool? redacted = null,
                                                     int? pageSize = null,
                                                     long? limit = null,
                                                     IKandyRestClient client = null)
        {
            var options = new ReadSentenceOptions(pathTranscriptSid) { Redacted = redacted, PageSize = pageSize, Limit = limit };
            return Read(options, client);
        }

#if !NET35
        /// <summary> Get all Transcript Sentences by TranscriptSid </summary>
        /// <param name="pathTranscriptSid"> The unique SID identifier of the Transcript. </param>
        /// <param name="redacted"> Grant access to PII Redacted/Unredacted Sentences. The default is `true` to access redacted sentences. </param>
        /// <param name="pageSize"> How many resources to return in each list page. The default is 50, and the maximum is 1000. </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Sentence </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<SentenceResource>> ReadAsync(
                                                                                             string pathTranscriptSid,
                                                                                             bool? redacted = null,
                                                                                             int? pageSize = null,
                                                                                             long? limit = null,
                                                                                             IKandyRestClient client = null)
        {
            var options = new ReadSentenceOptions(pathTranscriptSid) { Redacted = redacted, PageSize = pageSize, Limit = limit };
            return await ReadAsync(options, client);
        }
#endif


        /// <summary> Fetch the target page of records </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<SentenceResource> GetPage(string targetUrl, IKandyRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<SentenceResource>.FromJson("sentences", response.Content);
        }

        /// <summary> Fetch the next page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<SentenceResource> NextPage(Page<SentenceResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<SentenceResource>.FromJson("sentences", response.Content);
        }

        /// <summary> Fetch the previous page of records </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<SentenceResource> PreviousPage(Page<SentenceResource> page, IKandyRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Api)
            );

            var response = client.Request(request);
            return Page<SentenceResource>.FromJson("sentences", response.Content);
        }


        /// <summary>
        /// Converts a JSON string into a SentenceResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> SentenceResource object represented by the provided JSON </returns>
        public static SentenceResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<SentenceResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> The channel number. </summary> 
        [JsonProperty("media_channel")]
        public int? MediaChannel { get; private set; }

        ///<summary> The index of the sentence in the transcript. </summary> 
        [JsonProperty("sentence_index")]
        public int? SentenceIndex { get; private set; }

        ///<summary> Offset from the beginning of the transcript when this sentence starts. </summary> 
        [JsonProperty("start_time")]
        public decimal? StartTime { get; private set; }

        ///<summary> Offset from the beginning of the transcript when this sentence ends. </summary> 
        [JsonProperty("end_time")]
        public decimal? EndTime { get; private set; }

        ///<summary> Transcript text. </summary> 
        [JsonProperty("transcript")]
        public string Transcript { get; private set; }

        ///<summary> A 34 character string that uniquely identifies this Sentence. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The confidence </summary> 
        [JsonProperty("confidence")]
        public decimal? Confidence { get; private set; }



        private SentenceResource()
        {

        }
    }
}
