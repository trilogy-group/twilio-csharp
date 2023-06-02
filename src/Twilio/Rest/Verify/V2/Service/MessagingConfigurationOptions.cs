/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Verify
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




namespace Kandy.Rest.Verify.V2.Service
{

    /// <summary> Create a new MessagingConfiguration for a service. </summary>
    public class CreateMessagingConfigurationOptions : IOptions<MessagingConfigurationResource>
    {
        
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/verify/api/service) that the resource is associated with. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The [ISO-3166-1](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code of the country this configuration will be applied to. If this is a global configuration, Country will take the value `all`. </summary> 
        public string Country { get; }

        ///<summary> The SID of the [Messaging Service](https://www.twilio.com/docs/sms/services/api) to be used to send SMS to the country of this configuration. </summary> 
        public string MessagingServiceSid { get; }


        /// <summary> Construct a new CreateMessagingConfigurationOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/verify/api/service) that the resource is associated with. </param>
        /// <param name="country"> The [ISO-3166-1](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code of the country this configuration will be applied to. If this is a global configuration, Country will take the value `all`. </param>
        /// <param name="messagingServiceSid"> The SID of the [Messaging Service](https://www.twilio.com/docs/sms/services/api) to be used to send SMS to the country of this configuration. </param>
        public CreateMessagingConfigurationOptions(string pathServiceSid, string country, string messagingServiceSid)
        {
            PathServiceSid = pathServiceSid;
            Country = country;
            MessagingServiceSid = messagingServiceSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Country != null)
            {
                p.Add(new KeyValuePair<string, string>("Country", Country));
            }
            if (MessagingServiceSid != null)
            {
                p.Add(new KeyValuePair<string, string>("MessagingServiceSid", MessagingServiceSid));
            }
            return p;
        }
        

    }
    /// <summary> Delete a specific MessagingConfiguration. </summary>
    public class DeleteMessagingConfigurationOptions : IOptions<MessagingConfigurationResource>
    {
        
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/verify/api/service) that the resource is associated with. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The [ISO-3166-1](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code of the country this configuration will be applied to. If this is a global configuration, Country will take the value `all`. </summary> 
        public string PathCountry { get; }



        /// <summary> Construct a new DeleteMessagingConfigurationOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/verify/api/service) that the resource is associated with. </param>
        /// <param name="pathCountry"> The [ISO-3166-1](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code of the country this configuration will be applied to. If this is a global configuration, Country will take the value `all`. </param>
        public DeleteMessagingConfigurationOptions(string pathServiceSid, string pathCountry)
        {
            PathServiceSid = pathServiceSid;
            PathCountry = pathCountry;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Fetch a specific MessagingConfiguration. </summary>
    public class FetchMessagingConfigurationOptions : IOptions<MessagingConfigurationResource>
    {
    
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/verify/api/service) that the resource is associated with. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The [ISO-3166-1](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code of the country this configuration will be applied to. If this is a global configuration, Country will take the value `all`. </summary> 
        public string PathCountry { get; }



        /// <summary> Construct a new FetchMessagingConfigurationOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/verify/api/service) that the resource is associated with. </param>
        /// <param name="pathCountry"> The [ISO-3166-1](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code of the country this configuration will be applied to. If this is a global configuration, Country will take the value `all`. </param>
        public FetchMessagingConfigurationOptions(string pathServiceSid, string pathCountry)
        {
            PathServiceSid = pathServiceSid;
            PathCountry = pathCountry;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Retrieve a list of all Messaging Configurations for a Service. </summary>
    public class ReadMessagingConfigurationOptions : ReadOptions<MessagingConfigurationResource>
    {
    
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/verify/api/service) that the resource is associated with. </summary> 
        public string PathServiceSid { get; }



        /// <summary> Construct a new ListMessagingConfigurationOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/verify/api/service) that the resource is associated with. </param>
        public ReadMessagingConfigurationOptions(string pathServiceSid)
        {
            PathServiceSid = pathServiceSid;
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

    /// <summary> Update a specific MessagingConfiguration </summary>
    public class UpdateMessagingConfigurationOptions : IOptions<MessagingConfigurationResource>
    {
    
        ///<summary> The SID of the [Service](https://www.twilio.com/docs/verify/api/service) that the resource is associated with. </summary> 
        public string PathServiceSid { get; }

        ///<summary> The [ISO-3166-1](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code of the country this configuration will be applied to. If this is a global configuration, Country will take the value `all`. </summary> 
        public string PathCountry { get; }

        ///<summary> The SID of the [Messaging Service](https://www.twilio.com/docs/sms/services/api) to be used to send SMS to the country of this configuration. </summary> 
        public string MessagingServiceSid { get; }



        /// <summary> Construct a new UpdateMessagingConfigurationOptions </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/verify/api/service) that the resource is associated with. </param>
        /// <param name="pathCountry"> The [ISO-3166-1](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code of the country this configuration will be applied to. If this is a global configuration, Country will take the value `all`. </param>
        /// <param name="messagingServiceSid"> The SID of the [Messaging Service](https://www.twilio.com/docs/sms/services/api) to be used to send SMS to the country of this configuration. </param>
        public UpdateMessagingConfigurationOptions(string pathServiceSid, string pathCountry, string messagingServiceSid)
        {
            PathServiceSid = pathServiceSid;
            PathCountry = pathCountry;
            MessagingServiceSid = messagingServiceSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (MessagingServiceSid != null)
            {
                p.Add(new KeyValuePair<string, string>("MessagingServiceSid", MessagingServiceSid));
            }
            return p;
        }
        

    }


}
