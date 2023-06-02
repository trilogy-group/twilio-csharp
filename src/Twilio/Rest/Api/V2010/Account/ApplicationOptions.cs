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




namespace Kandy.Rest.Api.V2010.Account
{

    /// <summary> Create a new application within your account </summary>
    public class CreateApplicationOptions : IOptions<ApplicationResource>
    {
        
        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that will create the resource. </summary> 
        public string PathAccountSid { get; set; }

        ///<summary> The API version to use to start a new TwiML session. Can be: `2010-04-01` or `2008-08-01`. The default value is the account's default API version. </summary> 
        public string ApiVersion { get; set; }

        ///<summary> The URL we should call when the phone number assigned to this application receives a call. </summary> 
        public Uri VoiceUrl { get; set; }

        ///<summary> The HTTP method we should use to call `voice_url`. Can be: `GET` or `POST`. </summary> 
        public Twilio.Http.HttpMethod VoiceMethod { get; set; }

        ///<summary> The URL that we should call when an error occurs retrieving or executing the TwiML requested by `url`. </summary> 
        public Uri VoiceFallbackUrl { get; set; }

        ///<summary> The HTTP method we should use to call `voice_fallback_url`. Can be: `GET` or `POST`. </summary> 
        public Twilio.Http.HttpMethod VoiceFallbackMethod { get; set; }

        ///<summary> The URL we should call using the `status_callback_method` to send status information to your application. </summary> 
        public Uri StatusCallback { get; set; }

        ///<summary> The HTTP method we should use to call `status_callback`. Can be: `GET` or `POST`. </summary> 
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; set; }

        ///<summary> Whether we should look up the caller's caller-ID name from the CNAM database (additional charges apply). Can be: `true` or `false`. </summary> 
        public bool? VoiceCallerIdLookup { get; set; }

        ///<summary> The URL we should call when the phone number receives an incoming SMS message. </summary> 
        public Uri SmsUrl { get; set; }

        ///<summary> The HTTP method we should use to call `sms_url`. Can be: `GET` or `POST`. </summary> 
        public Twilio.Http.HttpMethod SmsMethod { get; set; }

        ///<summary> The URL that we should call when an error occurs while retrieving or executing the TwiML from `sms_url`. </summary> 
        public Uri SmsFallbackUrl { get; set; }

        ///<summary> The HTTP method we should use to call `sms_fallback_url`. Can be: `GET` or `POST`. </summary> 
        public Twilio.Http.HttpMethod SmsFallbackMethod { get; set; }

        ///<summary> The URL we should call using a POST method to send status information about SMS messages sent by the application. </summary> 
        public Uri SmsStatusCallback { get; set; }

        ///<summary> The URL we should call using a POST method to send message status information to your application. </summary> 
        public Uri MessageStatusCallback { get; set; }

        ///<summary> A descriptive string that you create to describe the new application. It can be up to 64 characters long. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> Whether to allow other Twilio accounts to dial this applicaton using Dial verb. Can be: `true` or `false`. </summary> 
        public bool? PublicApplicationConnectEnabled { get; set; }



        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (ApiVersion != null)
            {
                p.Add(new KeyValuePair<string, string>("ApiVersion", ApiVersion));
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
            if (StatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallback", Serializers.Url(StatusCallback)));
            }
            if (StatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallbackMethod", StatusCallbackMethod.ToString()));
            }
            if (VoiceCallerIdLookup != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceCallerIdLookup", VoiceCallerIdLookup.Value.ToString().ToLower()));
            }
            if (SmsUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsUrl", Serializers.Url(SmsUrl)));
            }
            if (SmsMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsMethod", SmsMethod.ToString()));
            }
            if (SmsFallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsFallbackUrl", Serializers.Url(SmsFallbackUrl)));
            }
            if (SmsFallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsFallbackMethod", SmsFallbackMethod.ToString()));
            }
            if (SmsStatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsStatusCallback", Serializers.Url(SmsStatusCallback)));
            }
            if (MessageStatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("MessageStatusCallback", Serializers.Url(MessageStatusCallback)));
            }
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (PublicApplicationConnectEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("PublicApplicationConnectEnabled", PublicApplicationConnectEnabled.Value.ToString().ToLower()));
            }
            return p;
        }
        

    }
    /// <summary> Delete the application by the specified application sid </summary>
    public class DeleteApplicationOptions : IOptions<ApplicationResource>
    {
        
        ///<summary> The Twilio-provided string that uniquely identifies the Application resource to delete. </summary> 
        public string PathSid { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Application resources to delete. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new DeleteApplicationOptions </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Application resource to delete. </param>
        public DeleteApplicationOptions(string pathSid)
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


    /// <summary> Fetch the application specified by the provided sid </summary>
    public class FetchApplicationOptions : IOptions<ApplicationResource>
    {
    
        ///<summary> The Twilio-provided string that uniquely identifies the Application resource to fetch. </summary> 
        public string PathSid { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Application resource to fetch. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new FetchApplicationOptions </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Application resource to fetch. </param>
        public FetchApplicationOptions(string pathSid)
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


    /// <summary> Retrieve a list of applications representing an application within the requesting account </summary>
    public class ReadApplicationOptions : ReadOptions<ApplicationResource>
    {
    
        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Application resources to read. </summary> 
        public string PathAccountSid { get; set; }

        ///<summary> The string that identifies the Application resources to read. </summary> 
        public string FriendlyName { get; set; }




        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

    /// <summary> Updates the application's properties </summary>
    public class UpdateApplicationOptions : IOptions<ApplicationResource>
    {
    
        ///<summary> The Twilio-provided string that uniquely identifies the Application resource to update. </summary> 
        public string PathSid { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Application resources to update. </summary> 
        public string PathAccountSid { get; set; }

        ///<summary> A descriptive string that you create to describe the resource. It can be up to 64 characters long. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> The API version to use to start a new TwiML session. Can be: `2010-04-01` or `2008-08-01`. The default value is your account's default API version. </summary> 
        public string ApiVersion { get; set; }

        ///<summary> The URL we should call when the phone number assigned to this application receives a call. </summary> 
        public Uri VoiceUrl { get; set; }

        ///<summary> The HTTP method we should use to call `voice_url`. Can be: `GET` or `POST`. </summary> 
        public Twilio.Http.HttpMethod VoiceMethod { get; set; }

        ///<summary> The URL that we should call when an error occurs retrieving or executing the TwiML requested by `url`. </summary> 
        public Uri VoiceFallbackUrl { get; set; }

        ///<summary> The HTTP method we should use to call `voice_fallback_url`. Can be: `GET` or `POST`. </summary> 
        public Twilio.Http.HttpMethod VoiceFallbackMethod { get; set; }

        ///<summary> The URL we should call using the `status_callback_method` to send status information to your application. </summary> 
        public Uri StatusCallback { get; set; }

        ///<summary> The HTTP method we should use to call `status_callback`. Can be: `GET` or `POST`. </summary> 
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; set; }

        ///<summary> Whether we should look up the caller's caller-ID name from the CNAM database (additional charges apply). Can be: `true` or `false`. </summary> 
        public bool? VoiceCallerIdLookup { get; set; }

        ///<summary> The URL we should call when the phone number receives an incoming SMS message. </summary> 
        public Uri SmsUrl { get; set; }

        ///<summary> The HTTP method we should use to call `sms_url`. Can be: `GET` or `POST`. </summary> 
        public Twilio.Http.HttpMethod SmsMethod { get; set; }

        ///<summary> The URL that we should call when an error occurs while retrieving or executing the TwiML from `sms_url`. </summary> 
        public Uri SmsFallbackUrl { get; set; }

        ///<summary> The HTTP method we should use to call `sms_fallback_url`. Can be: `GET` or `POST`. </summary> 
        public Twilio.Http.HttpMethod SmsFallbackMethod { get; set; }

        ///<summary> Same as message_status_callback: The URL we should call using a POST method to send status information about SMS messages sent by the application. Deprecated, included for backwards compatibility. </summary> 
        public Uri SmsStatusCallback { get; set; }

        ///<summary> The URL we should call using a POST method to send message status information to your application. </summary> 
        public Uri MessageStatusCallback { get; set; }

        ///<summary> Whether to allow other Twilio accounts to dial this applicaton using Dial verb. Can be: `true` or `false`. </summary> 
        public bool? PublicApplicationConnectEnabled { get; set; }



        /// <summary> Construct a new UpdateApplicationOptions </summary>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Application resource to update. </param>
        public UpdateApplicationOptions(string pathSid)
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
            if (ApiVersion != null)
            {
                p.Add(new KeyValuePair<string, string>("ApiVersion", ApiVersion));
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
            if (StatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallback", Serializers.Url(StatusCallback)));
            }
            if (StatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallbackMethod", StatusCallbackMethod.ToString()));
            }
            if (VoiceCallerIdLookup != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceCallerIdLookup", VoiceCallerIdLookup.Value.ToString().ToLower()));
            }
            if (SmsUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsUrl", Serializers.Url(SmsUrl)));
            }
            if (SmsMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsMethod", SmsMethod.ToString()));
            }
            if (SmsFallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsFallbackUrl", Serializers.Url(SmsFallbackUrl)));
            }
            if (SmsFallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsFallbackMethod", SmsFallbackMethod.ToString()));
            }
            if (SmsStatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsStatusCallback", Serializers.Url(SmsStatusCallback)));
            }
            if (MessageStatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("MessageStatusCallback", Serializers.Url(MessageStatusCallback)));
            }
            if (PublicApplicationConnectEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("PublicApplicationConnectEnabled", PublicApplicationConnectEnabled.Value.ToString().ToLower()));
            }
            return p;
        }
        

    }


}
