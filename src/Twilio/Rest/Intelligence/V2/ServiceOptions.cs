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


using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;




namespace Kandy.Rest.Intelligence.V2
{

    /// <summary> Create a new Service for the given Account </summary>
    public class CreateServiceOptions : IOptions<ServiceResource>
    {
        
        ///<summary> Provides a unique and addressable name to be assigned to this Service, assigned by the developer, to be optionally used in addition to SID. </summary> 
        public string UniqueName { get; }

        ///<summary> Instructs the Speech Recognition service to automatically transcribe all recordings made on the account. </summary> 
        public bool? AutoTranscribe { get; set; }

        ///<summary> Data logging allows Twilio to improve the quality of the speech recognition through using customer data to refine its speech recognition models. </summary> 
        public bool? DataLogging { get; set; }

        ///<summary> A human readable description of this resource, up to 64 characters. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> The default language code of the audio. </summary> 
        public string LanguageCode { get; set; }

        ///<summary> Instructs the Speech Recognition service to automatically redact PII from all transcripts made on this service. </summary> 
        public bool? AutoRedaction { get; set; }

        ///<summary> Instructs the Speech Recognition service to automatically redact PII from all transcripts media made on this service. The auto_redaction flag must be enabled, results in error otherwise. </summary> 
        public bool? MediaRedaction { get; set; }

        ///<summary> The URL Twilio will request when executing the Webhook. </summary> 
        public string WebhookUrl { get; set; }

        
        public ServiceResource.HttpMethodEnum WebhookHttpMethod { get; set; }


        /// <summary> Construct a new CreateServiceOptions </summary>
        /// <param name="uniqueName"> Provides a unique and addressable name to be assigned to this Service, assigned by the developer, to be optionally used in addition to SID. </param>
        public CreateServiceOptions(string uniqueName)
        {
            UniqueName = uniqueName;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }
            if (AutoTranscribe != null)
            {
                p.Add(new KeyValuePair<string, string>("AutoTranscribe", AutoTranscribe.Value.ToString().ToLower()));
            }
            if (DataLogging != null)
            {
                p.Add(new KeyValuePair<string, string>("DataLogging", DataLogging.Value.ToString().ToLower()));
            }
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (LanguageCode != null)
            {
                p.Add(new KeyValuePair<string, string>("LanguageCode", LanguageCode));
            }
            if (AutoRedaction != null)
            {
                p.Add(new KeyValuePair<string, string>("AutoRedaction", AutoRedaction.Value.ToString().ToLower()));
            }
            if (MediaRedaction != null)
            {
                p.Add(new KeyValuePair<string, string>("MediaRedaction", MediaRedaction.Value.ToString().ToLower()));
            }
            if (WebhookUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("WebhookUrl", WebhookUrl));
            }
            if (WebhookHttpMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("WebhookHttpMethod", WebhookHttpMethod.ToString()));
            }
            return p;
        }
        

    }
    /// <summary> Delete a specific Service. </summary>
    public class DeleteServiceOptions : IOptions<ServiceResource>
    {
        
        ///<summary> A 34 character string that uniquely identifies this Service. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new DeleteServiceOptions </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this Service. </param>
        public DeleteServiceOptions(string pathSid)
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


    /// <summary> Fetch a specific Service. </summary>
    public class FetchServiceOptions : IOptions<ServiceResource>
    {
    
        ///<summary> A 34 character string that uniquely identifies this Service. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchServiceOptions </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this Service. </param>
        public FetchServiceOptions(string pathSid)
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


    /// <summary> Retrieves a list of all Services for an account. </summary>
    public class ReadServiceOptions : ReadOptions<ServiceResource>
    {
    



        
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

    /// <summary> Update a specific Service. </summary>
    public class UpdateServiceOptions : IOptions<ServiceResource>
    {
    
        ///<summary> A 34 character string that uniquely identifies this Service. </summary> 
        public string PathSid { get; }

        ///<summary> The If-Match HTTP request header </summary> 
        public string IfMatch { get; set; }

        ///<summary> Instructs the Speech Recognition service to automatically transcribe all recordings made on the account. </summary> 
        public bool? AutoTranscribe { get; set; }

        ///<summary> Data logging allows Twilio to improve the quality of the speech recognition through using customer data to refine its speech recognition models. </summary> 
        public bool? DataLogging { get; set; }

        ///<summary> A human readable description of this resource, up to 64 characters. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> The default language code of the audio. </summary> 
        public string LanguageCode { get; set; }

        ///<summary> Provides a unique and addressable name to be assigned to this Service, assigned by the developer, to be optionally used in addition to SID. </summary> 
        public string UniqueName { get; set; }

        ///<summary> Instructs the Speech Recognition service to automatically redact PII from all transcripts made on this service. </summary> 
        public bool? AutoRedaction { get; set; }

        ///<summary> Instructs the Speech Recognition service to automatically redact PII from all transcripts media made on this service. The auto_redaction flag must be enabled, results in error otherwise. </summary> 
        public bool? MediaRedaction { get; set; }

        ///<summary> The URL Twilio will request when executing the Webhook. </summary> 
        public string WebhookUrl { get; set; }

        
        public ServiceResource.HttpMethodEnum WebhookHttpMethod { get; set; }



        /// <summary> Construct a new UpdateServiceOptions </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this Service. </param>
        public UpdateServiceOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (AutoTranscribe != null)
            {
                p.Add(new KeyValuePair<string, string>("AutoTranscribe", AutoTranscribe.Value.ToString().ToLower()));
            }
            if (DataLogging != null)
            {
                p.Add(new KeyValuePair<string, string>("DataLogging", DataLogging.Value.ToString().ToLower()));
            }
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (LanguageCode != null)
            {
                p.Add(new KeyValuePair<string, string>("LanguageCode", LanguageCode));
            }
            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }
            if (AutoRedaction != null)
            {
                p.Add(new KeyValuePair<string, string>("AutoRedaction", AutoRedaction.Value.ToString().ToLower()));
            }
            if (MediaRedaction != null)
            {
                p.Add(new KeyValuePair<string, string>("MediaRedaction", MediaRedaction.Value.ToString().ToLower()));
            }
            if (WebhookUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("WebhookUrl", WebhookUrl));
            }
            if (WebhookHttpMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("WebhookHttpMethod", WebhookHttpMethod.ToString()));
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
