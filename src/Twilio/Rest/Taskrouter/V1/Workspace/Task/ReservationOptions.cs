/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Taskrouter
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
using System.Linq;



namespace Kandy.Rest.Taskrouter.V1.Workspace.Task
{
    /// <summary> fetch </summary>
    public class FetchReservationOptions : IOptions<ReservationResource>
    {
    
        ///<summary> The SID of the Workspace with the TaskReservation resource to fetch. </summary> 
        public string PathWorkspaceSid { get; }

        ///<summary> The SID of the reserved Task resource with the TaskReservation resource to fetch. </summary> 
        public string PathTaskSid { get; }

        ///<summary> The SID of the TaskReservation resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchTaskReservationOptions </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the TaskReservation resource to fetch. </param>
        /// <param name="pathTaskSid"> The SID of the reserved Task resource with the TaskReservation resource to fetch. </param>
        /// <param name="pathSid"> The SID of the TaskReservation resource to fetch. </param>
        public FetchReservationOptions(string pathWorkspaceSid, string pathTaskSid, string pathSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            PathTaskSid = pathTaskSid;
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
    public class ReadReservationOptions : ReadOptions<ReservationResource>
    {
    
        ///<summary> The SID of the Workspace with the TaskReservation resources to read. </summary> 
        public string PathWorkspaceSid { get; }

        ///<summary> The SID of the reserved Task resource with the TaskReservation resources to read. </summary> 
        public string PathTaskSid { get; }

        ///<summary> Returns the list of reservations for a task with a specified ReservationStatus.  Can be: `pending`, `accepted`, `rejected`, or `timeout`. </summary> 
        public ReservationResource.StatusEnum ReservationStatus { get; set; }

        ///<summary> The SID of the reserved Worker resource to read. </summary> 
        public string WorkerSid { get; set; }



        /// <summary> Construct a new ListTaskReservationOptions </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the TaskReservation resources to read. </param>
        /// <param name="pathTaskSid"> The SID of the reserved Task resource with the TaskReservation resources to read. </param>
        public ReadReservationOptions(string pathWorkspaceSid, string pathTaskSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            PathTaskSid = pathTaskSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (ReservationStatus != null)
            {
                p.Add(new KeyValuePair<string, string>("ReservationStatus", ReservationStatus.ToString()));
            }
            if (WorkerSid != null)
            {
                p.Add(new KeyValuePair<string, string>("WorkerSid", WorkerSid));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

    /// <summary> update </summary>
    public class UpdateReservationOptions : IOptions<ReservationResource>
    {
    
        ///<summary> The SID of the Workspace with the TaskReservation resources to update. </summary> 
        public string PathWorkspaceSid { get; }

        ///<summary> The SID of the reserved Task resource with the TaskReservation resources to update. </summary> 
        public string PathTaskSid { get; }

        ///<summary> The SID of the TaskReservation resource to update. </summary> 
        public string PathSid { get; }

        ///<summary> The If-Match HTTP request header </summary> 
        public string IfMatch { get; set; }

        
        public ReservationResource.StatusEnum ReservationStatus { get; set; }

        ///<summary> The new worker activity SID if rejecting a reservation. </summary> 
        public string WorkerActivitySid { get; set; }

        ///<summary> The assignment instruction for reservation. </summary> 
        public string Instruction { get; set; }

        ///<summary> The SID of the Activity resource to start after executing a Dequeue instruction. </summary> 
        public string DequeuePostWorkActivitySid { get; set; }

        ///<summary> The Caller ID of the call to the worker when executing a Dequeue instruction. </summary> 
        public string DequeueFrom { get; set; }

        ///<summary> Whether to record both legs of a call when executing a Dequeue instruction or which leg to record. </summary> 
        public string DequeueRecord { get; set; }

        ///<summary> Timeout for call when executing a Dequeue instruction. </summary> 
        public int? DequeueTimeout { get; set; }

        ///<summary> The Contact URI of the worker when executing a Dequeue instruction. Can be the URI of the Twilio Client, the SIP URI for Programmable SIP, or the [E.164](https://www.twilio.com/docs/glossary/what-e164) formatted phone number, depending on the destination. </summary> 
        public string DequeueTo { get; set; }

        ///<summary> The Callback URL for completed call event when executing a Dequeue instruction. </summary> 
        public Uri DequeueStatusCallbackUrl { get; set; }

        ///<summary> The Caller ID of the outbound call when executing a Call instruction. </summary> 
        public string CallFrom { get; set; }

        ///<summary> Whether to record both legs of a call when executing a Call instruction or which leg to record. </summary> 
        public string CallRecord { get; set; }

        ///<summary> Timeout for call when executing a Call instruction. </summary> 
        public int? CallTimeout { get; set; }

        ///<summary> The Contact URI of the worker when executing a Call instruction.  Can be the URI of the Twilio Client, the SIP URI for Programmable SIP, or the [E.164](https://www.twilio.com/docs/glossary/what-e164) formatted phone number, depending on the destination. </summary> 
        public string CallTo { get; set; }

        ///<summary> TwiML URI executed on answering the worker's leg as a result of the Call instruction. </summary> 
        public Uri CallUrl { get; set; }

        ///<summary> The URL to call  for the completed call event when executing a Call instruction. </summary> 
        public Uri CallStatusCallbackUrl { get; set; }

        ///<summary> Whether to accept a reservation when executing a Call instruction. </summary> 
        public bool? CallAccept { get; set; }

        ///<summary> The Call SID of the call parked in the queue when executing a Redirect instruction. </summary> 
        public string RedirectCallSid { get; set; }

        ///<summary> Whether the reservation should be accepted when executing a Redirect instruction. </summary> 
        public bool? RedirectAccept { get; set; }

        ///<summary> TwiML URI to redirect the call to when executing the Redirect instruction. </summary> 
        public Uri RedirectUrl { get; set; }

        ///<summary> The Contact URI of the worker when executing a Conference instruction. Can be the URI of the Twilio Client, the SIP URI for Programmable SIP, or the [E.164](https://www.twilio.com/docs/glossary/what-e164) formatted phone number, depending on the destination. </summary> 
        public string To { get; set; }

        ///<summary> The Caller ID of the call to the worker when executing a Conference instruction. </summary> 
        public string From { get; set; }

        ///<summary> The URL we should call using the `status_callback_method` to send status information to your application. </summary> 
        public Uri StatusCallback { get; set; }

        ///<summary> The HTTP method we should use to call `status_callback`. Can be: `POST` or `GET` and the default is `POST`. </summary> 
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; set; }

        ///<summary> The call progress events that we will send to `status_callback`. Can be: `initiated`, `ringing`, `answered`, or `completed`. </summary> 
        public List<ReservationResource.CallStatusEnum> StatusCallbackEvent { get; set; }

        ///<summary> Timeout for call when executing a Conference instruction. </summary> 
        public int? Timeout { get; set; }

        ///<summary> Whether to record the participant and their conferences, including the time between conferences. The default is `false`. </summary> 
        public bool? Record { get; set; }

        ///<summary> Whether the agent is muted in the conference. The default is `false`. </summary> 
        public bool? Muted { get; set; }

        ///<summary> Whether to play a notification beep when the participant joins or when to play a beep. Can be: `true`, `false`, `onEnter`, or `onExit`. The default value is `true`. </summary> 
        public string Beep { get; set; }

        ///<summary> Whether to start the conference when the participant joins, if it has not already started. The default is `true`. If `false` and the conference has not started, the participant is muted and hears background music until another participant starts the conference. </summary> 
        public bool? StartConferenceOnEnter { get; set; }

        ///<summary> Whether to end the conference when the agent leaves. </summary> 
        public bool? EndConferenceOnExit { get; set; }

        ///<summary> The URL we should call using the `wait_method` for the music to play while participants are waiting for the conference to start. The default value is the URL of our standard hold music. [Learn more about hold music](https://www.twilio.com/labs/twimlets/holdmusic). </summary> 
        public Uri WaitUrl { get; set; }

        ///<summary> The HTTP method we should use to call `wait_url`. Can be `GET` or `POST` and the default is `POST`. When using a static audio file, this should be `GET` so that we can cache the file. </summary> 
        public Twilio.Http.HttpMethod WaitMethod { get; set; }

        ///<summary> Whether to allow an agent to hear the state of the outbound call, including ringing or disconnect messages. The default is `true`. </summary> 
        public bool? EarlyMedia { get; set; }

        ///<summary> The maximum number of participants in the conference. Can be a positive integer from `2` to `250`. The default value is `250`. </summary> 
        public int? MaxParticipants { get; set; }

        ///<summary> The URL we should call using the `conference_status_callback_method` when the conference events in `conference_status_callback_event` occur. Only the value set by the first participant to join the conference is used. Subsequent `conference_status_callback` values are ignored. </summary> 
        public Uri ConferenceStatusCallback { get; set; }

        ///<summary> The HTTP method we should use to call `conference_status_callback`. Can be: `GET` or `POST` and defaults to `POST`. </summary> 
        public Twilio.Http.HttpMethod ConferenceStatusCallbackMethod { get; set; }

        ///<summary> The conference status events that we will send to `conference_status_callback`. Can be: `start`, `end`, `join`, `leave`, `mute`, `hold`, `speaker`. </summary> 
        public List<ReservationResource.ConferenceEventEnum> ConferenceStatusCallbackEvent { get; set; }

        ///<summary> Whether to record the conference the participant is joining or when to record the conference. Can be: `true`, `false`, `record-from-start`, and `do-not-record`. The default value is `false`. </summary> 
        public string ConferenceRecord { get; set; }

        ///<summary> How to trim the leading and trailing silence from your recorded conference audio files. Can be: `trim-silence` or `do-not-trim` and defaults to `trim-silence`. </summary> 
        public string ConferenceTrim { get; set; }

        ///<summary> The recording channels for the final recording. Can be: `mono` or `dual` and the default is `mono`. </summary> 
        public string RecordingChannels { get; set; }

        ///<summary> The URL that we should call using the `recording_status_callback_method` when the recording status changes. </summary> 
        public Uri RecordingStatusCallback { get; set; }

        ///<summary> The HTTP method we should use when we call `recording_status_callback`. Can be: `GET` or `POST` and defaults to `POST`. </summary> 
        public Twilio.Http.HttpMethod RecordingStatusCallbackMethod { get; set; }

        ///<summary> The URL we should call using the `conference_recording_status_callback_method` when the conference recording is available. </summary> 
        public Uri ConferenceRecordingStatusCallback { get; set; }

        ///<summary> The HTTP method we should use to call `conference_recording_status_callback`. Can be: `GET` or `POST` and defaults to `POST`. </summary> 
        public Twilio.Http.HttpMethod ConferenceRecordingStatusCallbackMethod { get; set; }

        ///<summary> The [region](https://support.twilio.com/hc/en-us/articles/223132167-How-global-low-latency-routing-and-region-selection-work-for-conferences-and-Client-calls) where we should mix the recorded audio. Can be:`us1`, `ie1`, `de1`, `sg1`, `br1`, `au1`, or `jp1`. </summary> 
        public string Region { get; set; }

        ///<summary> The SIP username used for authentication. </summary> 
        public string SipAuthUsername { get; set; }

        ///<summary> The SIP password for authentication. </summary> 
        public string SipAuthPassword { get; set; }

        ///<summary> The Call progress events sent via webhooks as a result of a Dequeue instruction. </summary> 
        public List<string> DequeueStatusCallbackEvent { get; set; }

        ///<summary> The new worker activity SID after executing a Conference instruction. </summary> 
        public string PostWorkActivitySid { get; set; }

        
        public ReservationResource.SupervisorModeEnum SupervisorMode { get; set; }

        ///<summary> The Supervisor SID/URI when executing the Supervise instruction. </summary> 
        public string Supervisor { get; set; }

        ///<summary> Whether to end the conference when the customer leaves. </summary> 
        public bool? EndConferenceOnCustomerExit { get; set; }

        ///<summary> Whether to play a notification beep when the customer joins. </summary> 
        public bool? BeepOnCustomerEntrance { get; set; }



        /// <summary> Construct a new UpdateTaskReservationOptions </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the TaskReservation resources to update. </param>
        /// <param name="pathTaskSid"> The SID of the reserved Task resource with the TaskReservation resources to update. </param>
        /// <param name="pathSid"> The SID of the TaskReservation resource to update. </param>
        public UpdateReservationOptions(string pathWorkspaceSid, string pathTaskSid, string pathSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            PathTaskSid = pathTaskSid;
            PathSid = pathSid;
            StatusCallbackEvent = new List<ReservationResource.CallStatusEnum>();
            ConferenceStatusCallbackEvent = new List<ReservationResource.ConferenceEventEnum>();
            DequeueStatusCallbackEvent = new List<string>();
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (ReservationStatus != null)
            {
                p.Add(new KeyValuePair<string, string>("ReservationStatus", ReservationStatus.ToString()));
            }
            if (WorkerActivitySid != null)
            {
                p.Add(new KeyValuePair<string, string>("WorkerActivitySid", WorkerActivitySid));
            }
            if (Instruction != null)
            {
                p.Add(new KeyValuePair<string, string>("Instruction", Instruction));
            }
            if (DequeuePostWorkActivitySid != null)
            {
                p.Add(new KeyValuePair<string, string>("DequeuePostWorkActivitySid", DequeuePostWorkActivitySid));
            }
            if (DequeueFrom != null)
            {
                p.Add(new KeyValuePair<string, string>("DequeueFrom", DequeueFrom));
            }
            if (DequeueRecord != null)
            {
                p.Add(new KeyValuePair<string, string>("DequeueRecord", DequeueRecord));
            }
            if (DequeueTimeout != null)
            {
                p.Add(new KeyValuePair<string, string>("DequeueTimeout", DequeueTimeout.ToString()));
            }
            if (DequeueTo != null)
            {
                p.Add(new KeyValuePair<string, string>("DequeueTo", DequeueTo));
            }
            if (DequeueStatusCallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("DequeueStatusCallbackUrl", Serializers.Url(DequeueStatusCallbackUrl)));
            }
            if (CallFrom != null)
            {
                p.Add(new KeyValuePair<string, string>("CallFrom", CallFrom));
            }
            if (CallRecord != null)
            {
                p.Add(new KeyValuePair<string, string>("CallRecord", CallRecord));
            }
            if (CallTimeout != null)
            {
                p.Add(new KeyValuePair<string, string>("CallTimeout", CallTimeout.ToString()));
            }
            if (CallTo != null)
            {
                p.Add(new KeyValuePair<string, string>("CallTo", CallTo));
            }
            if (CallUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("CallUrl", Serializers.Url(CallUrl)));
            }
            if (CallStatusCallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("CallStatusCallbackUrl", Serializers.Url(CallStatusCallbackUrl)));
            }
            if (CallAccept != null)
            {
                p.Add(new KeyValuePair<string, string>("CallAccept", CallAccept.Value.ToString().ToLower()));
            }
            if (RedirectCallSid != null)
            {
                p.Add(new KeyValuePair<string, string>("RedirectCallSid", RedirectCallSid));
            }
            if (RedirectAccept != null)
            {
                p.Add(new KeyValuePair<string, string>("RedirectAccept", RedirectAccept.Value.ToString().ToLower()));
            }
            if (RedirectUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("RedirectUrl", Serializers.Url(RedirectUrl)));
            }
            if (To != null)
            {
                p.Add(new KeyValuePair<string, string>("To", To));
            }
            if (From != null)
            {
                p.Add(new KeyValuePair<string, string>("From", From));
            }
            if (StatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallback", Serializers.Url(StatusCallback)));
            }
            if (StatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallbackMethod", StatusCallbackMethod.ToString()));
            }
            if (StatusCallbackEvent != null)
            {
                p.AddRange(StatusCallbackEvent.Select(StatusCallbackEvent => new KeyValuePair<string, string>("StatusCallbackEvent", StatusCallbackEvent.ToString())));
            }
            if (Timeout != null)
            {
                p.Add(new KeyValuePair<string, string>("Timeout", Timeout.ToString()));
            }
            if (Record != null)
            {
                p.Add(new KeyValuePair<string, string>("Record", Record.Value.ToString().ToLower()));
            }
            if (Muted != null)
            {
                p.Add(new KeyValuePair<string, string>("Muted", Muted.Value.ToString().ToLower()));
            }
            if (Beep != null)
            {
                p.Add(new KeyValuePair<string, string>("Beep", Beep));
            }
            if (StartConferenceOnEnter != null)
            {
                p.Add(new KeyValuePair<string, string>("StartConferenceOnEnter", StartConferenceOnEnter.Value.ToString().ToLower()));
            }
            if (EndConferenceOnExit != null)
            {
                p.Add(new KeyValuePair<string, string>("EndConferenceOnExit", EndConferenceOnExit.Value.ToString().ToLower()));
            }
            if (WaitUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("WaitUrl", Serializers.Url(WaitUrl)));
            }
            if (WaitMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("WaitMethod", WaitMethod.ToString()));
            }
            if (EarlyMedia != null)
            {
                p.Add(new KeyValuePair<string, string>("EarlyMedia", EarlyMedia.Value.ToString().ToLower()));
            }
            if (MaxParticipants != null)
            {
                p.Add(new KeyValuePair<string, string>("MaxParticipants", MaxParticipants.ToString()));
            }
            if (ConferenceStatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("ConferenceStatusCallback", Serializers.Url(ConferenceStatusCallback)));
            }
            if (ConferenceStatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("ConferenceStatusCallbackMethod", ConferenceStatusCallbackMethod.ToString()));
            }
            if (ConferenceStatusCallbackEvent != null)
            {
                p.AddRange(ConferenceStatusCallbackEvent.Select(ConferenceStatusCallbackEvent => new KeyValuePair<string, string>("ConferenceStatusCallbackEvent", ConferenceStatusCallbackEvent.ToString())));
            }
            if (ConferenceRecord != null)
            {
                p.Add(new KeyValuePair<string, string>("ConferenceRecord", ConferenceRecord));
            }
            if (ConferenceTrim != null)
            {
                p.Add(new KeyValuePair<string, string>("ConferenceTrim", ConferenceTrim));
            }
            if (RecordingChannels != null)
            {
                p.Add(new KeyValuePair<string, string>("RecordingChannels", RecordingChannels));
            }
            if (RecordingStatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("RecordingStatusCallback", Serializers.Url(RecordingStatusCallback)));
            }
            if (RecordingStatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("RecordingStatusCallbackMethod", RecordingStatusCallbackMethod.ToString()));
            }
            if (ConferenceRecordingStatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("ConferenceRecordingStatusCallback", Serializers.Url(ConferenceRecordingStatusCallback)));
            }
            if (ConferenceRecordingStatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("ConferenceRecordingStatusCallbackMethod", ConferenceRecordingStatusCallbackMethod.ToString()));
            }
            if (Region != null)
            {
                p.Add(new KeyValuePair<string, string>("Region", Region));
            }
            if (SipAuthUsername != null)
            {
                p.Add(new KeyValuePair<string, string>("SipAuthUsername", SipAuthUsername));
            }
            if (SipAuthPassword != null)
            {
                p.Add(new KeyValuePair<string, string>("SipAuthPassword", SipAuthPassword));
            }
            if (DequeueStatusCallbackEvent != null)
            {
                p.AddRange(DequeueStatusCallbackEvent.Select(DequeueStatusCallbackEvent => new KeyValuePair<string, string>("DequeueStatusCallbackEvent", DequeueStatusCallbackEvent)));
            }
            if (PostWorkActivitySid != null)
            {
                p.Add(new KeyValuePair<string, string>("PostWorkActivitySid", PostWorkActivitySid));
            }
            if (SupervisorMode != null)
            {
                p.Add(new KeyValuePair<string, string>("SupervisorMode", SupervisorMode.ToString()));
            }
            if (Supervisor != null)
            {
                p.Add(new KeyValuePair<string, string>("Supervisor", Supervisor));
            }
            if (EndConferenceOnCustomerExit != null)
            {
                p.Add(new KeyValuePair<string, string>("EndConferenceOnCustomerExit", EndConferenceOnCustomerExit.Value.ToString().ToLower()));
            }
            if (BeepOnCustomerEntrance != null)
            {
                p.Add(new KeyValuePair<string, string>("BeepOnCustomerEntrance", BeepOnCustomerEntrance.Value.ToString().ToLower()));
            }
            return p;
        }
        
    /// <summary> Generate the necessary header parameters </summary>
    public List<KeyValuePair<string, string>> GetHeaderParams()
    {
        var p = new List<KeyValuePair<string, string>>();
        if (IfMatch != null)
        {
            p.Add(new KeyValuePair<string, string>("If-Match", IfMatch));
        }
        return p;
    }

    }


}
