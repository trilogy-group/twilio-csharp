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




namespace Kandy.Rest.Api.V2010.Account.Sip
{

    /// <summary> Create a new Domain </summary>
    public class CreateDomainOptions : IOptions<DomainResource>
    {
        
        ///<summary> The unique address you reserve on Twilio to which you route your SIP traffic. Domain names can contain letters, digits, and \\\"-\\\" and must end with `sip.twilio.com`. </summary> 
        public string DomainName { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that will create the resource. </summary> 
        public string PathAccountSid { get; set; }

        ///<summary> A descriptive string that you created to describe the resource. It can be up to 64 characters long. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> The URL we should when the domain receives a call. </summary> 
        public Uri VoiceUrl { get; set; }

        ///<summary> The HTTP method we should use to call `voice_url`. Can be: `GET` or `POST`. </summary> 
        public Twilio.Http.HttpMethod VoiceMethod { get; set; }

        ///<summary> The URL that we should call when an error occurs while retrieving or executing the TwiML from `voice_url`. </summary> 
        public Uri VoiceFallbackUrl { get; set; }

        ///<summary> The HTTP method we should use to call `voice_fallback_url`. Can be: `GET` or `POST`. </summary> 
        public Twilio.Http.HttpMethod VoiceFallbackMethod { get; set; }

        ///<summary> The URL that we should call to pass status parameters (such as call ended) to your application. </summary> 
        public Uri VoiceStatusCallbackUrl { get; set; }

        ///<summary> The HTTP method we should use to call `voice_status_callback_url`. Can be: `GET` or `POST`. </summary> 
        public Twilio.Http.HttpMethod VoiceStatusCallbackMethod { get; set; }

        ///<summary> Whether to allow SIP Endpoints to register with the domain to receive calls. Can be `true` or `false`. `true` allows SIP Endpoints to register with the domain to receive calls, `false` does not. </summary> 
        public bool? SipRegistration { get; set; }

        ///<summary> Whether emergency calling is enabled for the domain. If enabled, allows emergency calls on the domain from phone numbers with validated addresses. </summary> 
        public bool? EmergencyCallingEnabled { get; set; }

        ///<summary> Whether secure SIP is enabled for the domain. If enabled, TLS will be enforced and SRTP will be negotiated on all incoming calls to this sip domain. </summary> 
        public bool? Secure { get; set; }

        ///<summary> The SID of the BYOC Trunk(Bring Your Own Carrier) resource that the Sip Domain will be associated with. </summary> 
        public string ByocTrunkSid { get; set; }

        ///<summary> Whether an emergency caller sid is configured for the domain. If present, this phone number will be used as the callback for the emergency call. </summary> 
        public string EmergencyCallerSid { get; set; }


        /// <summary> Construct a new CreateSipDomainOptions </summary>
        /// <param name="domainName"> The unique address you reserve on Twilio to which you route your SIP traffic. Domain names can contain letters, digits, and \\\"-\\\" and must end with `sip.twilio.com`. </param>
        public CreateDomainOptions(string domainName)
        {
            DomainName = domainName;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (DomainName != null)
            {
                p.Add(new KeyValuePair<string, string>("DomainName", DomainName));
            }
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (VoiceUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceUrl", Serializers.Url(VoiceUrl)));
            }
            if (VoiceMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceMethod", VoiceMethod.ToString()));
            }
            if (VoiceFallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceFallbackUrl", Serializers.Url(VoiceFallbackUrl)));
            }
            if (VoiceFallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceFallbackMethod", VoiceFallbackMethod.ToString()));
            }
            if (VoiceStatusCallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceStatusCallbackUrl", Serializers.Url(VoiceStatusCallbackUrl)));
            }
            if (VoiceStatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceStatusCallbackMethod", VoiceStatusCallbackMethod.ToString()));
            }
            if (SipRegistration != null)
            {
                p.Add(new KeyValuePair<string, string>("SipRegistration", SipRegistration.Value.ToString().ToLower()));
            }
            if (EmergencyCallingEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("EmergencyCallingEnabled", EmergencyCallingEnabled.Value.ToString().ToLower()));
            }
            if (Secure != null)
            {
                p.Add(new KeyValuePair<string, string>("Secure", Secure.Value.ToString().ToLower()));
            }
            if (ByocTrunkSid != null)
            {
                p.Add(new KeyValuePair<string, string>("ByocTrunkSid", ByocTrunkSid));
            }
            if (EmergencyCallerSid != null)
            {
                p.Add(new KeyValuePair<string, string>("EmergencyCallerSid", EmergencyCallerSid));
            }
            return p;
        }
        

    }
    /// <summary> Delete an instance of a Domain </summary>
    public class DeleteDomainOptions : IOptions<DomainResource>
    {
        
        ///<summary> The Twilio-provided string that uniquely identifies the SipDomain resource to delete. </summary> 
        public string PathSid { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the SipDomain resources to delete. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new DeleteSipDomainOptions </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the SipDomain resource to delete. </param>
        public DeleteDomainOptions(string pathSid)
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


    /// <summary> Fetch an instance of a Domain </summary>
    public class FetchDomainOptions : IOptions<DomainResource>
    {
    
        ///<summary> The Twilio-provided string that uniquely identifies the SipDomain resource to fetch. </summary> 
        public string PathSid { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the SipDomain resource to fetch. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new FetchSipDomainOptions </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the SipDomain resource to fetch. </param>
        public FetchDomainOptions(string pathSid)
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


    /// <summary> Retrieve a list of domains belonging to the account used to make the request </summary>
    public class ReadDomainOptions : ReadOptions<DomainResource>
    {
    
        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the SipDomain resources to read. </summary> 
        public string PathAccountSid { get; set; }




        
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

    /// <summary> Update the attributes of a domain </summary>
    public class UpdateDomainOptions : IOptions<DomainResource>
    {
    
        ///<summary> The Twilio-provided string that uniquely identifies the SipDomain resource to update. </summary> 
        public string PathSid { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the SipDomain resource to update. </summary> 
        public string PathAccountSid { get; set; }

        ///<summary> A descriptive string that you created to describe the resource. It can be up to 64 characters long. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> The HTTP method we should use to call `voice_fallback_url`. Can be: `GET` or `POST`. </summary> 
        public Twilio.Http.HttpMethod VoiceFallbackMethod { get; set; }

        ///<summary> The URL that we should call when an error occurs while retrieving or executing the TwiML requested by `voice_url`. </summary> 
        public Uri VoiceFallbackUrl { get; set; }

        ///<summary> The HTTP method we should use to call `voice_url` </summary> 
        public Twilio.Http.HttpMethod VoiceMethod { get; set; }

        ///<summary> The HTTP method we should use to call `voice_status_callback_url`. Can be: `GET` or `POST`. </summary> 
        public Twilio.Http.HttpMethod VoiceStatusCallbackMethod { get; set; }

        ///<summary> The URL that we should call to pass status parameters (such as call ended) to your application. </summary> 
        public Uri VoiceStatusCallbackUrl { get; set; }

        ///<summary> The URL we should call when the domain receives a call. </summary> 
        public Uri VoiceUrl { get; set; }

        ///<summary> Whether to allow SIP Endpoints to register with the domain to receive calls. Can be `true` or `false`. `true` allows SIP Endpoints to register with the domain to receive calls, `false` does not. </summary> 
        public bool? SipRegistration { get; set; }

        ///<summary> The unique address you reserve on Twilio to which you route your SIP traffic. Domain names can contain letters, digits, and \\\"-\\\" and must end with `sip.twilio.com`. </summary> 
        public string DomainName { get; set; }

        ///<summary> Whether emergency calling is enabled for the domain. If enabled, allows emergency calls on the domain from phone numbers with validated addresses. </summary> 
        public bool? EmergencyCallingEnabled { get; set; }

        ///<summary> Whether secure SIP is enabled for the domain. If enabled, TLS will be enforced and SRTP will be negotiated on all incoming calls to this sip domain. </summary> 
        public bool? Secure { get; set; }

        ///<summary> The SID of the BYOC Trunk(Bring Your Own Carrier) resource that the Sip Domain will be associated with. </summary> 
        public string ByocTrunkSid { get; set; }

        ///<summary> Whether an emergency caller sid is configured for the domain. If present, this phone number will be used as the callback for the emergency call. </summary> 
        public string EmergencyCallerSid { get; set; }



        /// <summary> Construct a new UpdateSipDomainOptions </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the SipDomain resource to update. </param>
        public UpdateDomainOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (VoiceFallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceFallbackMethod", VoiceFallbackMethod.ToString()));
            }
            if (VoiceFallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceFallbackUrl", Serializers.Url(VoiceFallbackUrl)));
            }
            if (VoiceMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceMethod", VoiceMethod.ToString()));
            }
            if (VoiceStatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceStatusCallbackMethod", VoiceStatusCallbackMethod.ToString()));
            }
            if (VoiceStatusCallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceStatusCallbackUrl", Serializers.Url(VoiceStatusCallbackUrl)));
            }
            if (VoiceUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceUrl", Serializers.Url(VoiceUrl)));
            }
            if (SipRegistration != null)
            {
                p.Add(new KeyValuePair<string, string>("SipRegistration", SipRegistration.Value.ToString().ToLower()));
            }
            if (DomainName != null)
            {
                p.Add(new KeyValuePair<string, string>("DomainName", DomainName));
            }
            if (EmergencyCallingEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("EmergencyCallingEnabled", EmergencyCallingEnabled.Value.ToString().ToLower()));
            }
            if (Secure != null)
            {
                p.Add(new KeyValuePair<string, string>("Secure", Secure.Value.ToString().ToLower()));
            }
            if (ByocTrunkSid != null)
            {
                p.Add(new KeyValuePair<string, string>("ByocTrunkSid", ByocTrunkSid));
            }
            if (EmergencyCallerSid != null)
            {
                p.Add(new KeyValuePair<string, string>("EmergencyCallerSid", EmergencyCallerSid));
            }
            return p;
        }
        

    }


}
