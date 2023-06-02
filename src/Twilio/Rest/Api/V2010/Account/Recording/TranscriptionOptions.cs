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




namespace Kandy.Rest.Api.V2010.Account.Recording
{
    /// <summary> delete </summary>
    public class DeleteTranscriptionOptions : IOptions<TranscriptionResource>
    {
        
        ///<summary> The SID of the [Recording](https://www.twilio.com/docs/voice/api/recording) that created the transcription to delete. </summary> 
        public string PathRecordingSid { get; }

        ///<summary> The Twilio-provided string that uniquely identifies the Transcription resource to delete. </summary> 
        public string PathSid { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Transcription resources to delete. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new DeleteRecordingTranscriptionOptions </summary>
        /// <param name="pathRecordingSid"> The SID of the [Recording](https://www.twilio.com/docs/voice/api/recording) that created the transcription to delete. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Transcription resource to delete. </param>
        public DeleteTranscriptionOptions(string pathRecordingSid, string pathSid)
        {
            PathRecordingSid = pathRecordingSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> fetch </summary>
    public class FetchTranscriptionOptions : IOptions<TranscriptionResource>
    {
    
        ///<summary> The SID of the [Recording](https://www.twilio.com/docs/voice/api/recording) that created the transcription to fetch. </summary> 
        public string PathRecordingSid { get; }

        ///<summary> The Twilio-provided string that uniquely identifies the Transcription resource to fetch. </summary> 
        public string PathSid { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Transcription resource to fetch. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new FetchRecordingTranscriptionOptions </summary>
        /// <param name="pathRecordingSid"> The SID of the [Recording](https://www.twilio.com/docs/voice/api/recording) that created the transcription to fetch. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Transcription resource to fetch. </param>
        public FetchTranscriptionOptions(string pathRecordingSid, string pathSid)
        {
            PathRecordingSid = pathRecordingSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> read </summary>
    public class ReadTranscriptionOptions : ReadOptions<TranscriptionResource>
    {
    
        ///<summary> The SID of the [Recording](https://www.twilio.com/docs/voice/api/recording) that created the transcriptions to read. </summary> 
        public string PathRecordingSid { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Transcription resources to read. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new ListRecordingTranscriptionOptions </summary>
        /// <param name="pathRecordingSid"> The SID of the [Recording](https://www.twilio.com/docs/voice/api/recording) that created the transcriptions to read. </param>
        public ReadTranscriptionOptions(string pathRecordingSid)
        {
            PathRecordingSid = pathRecordingSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
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
