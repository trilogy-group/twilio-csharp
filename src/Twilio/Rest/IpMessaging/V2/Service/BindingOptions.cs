/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Ip_messaging
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



namespace Kandy.Rest.IpMessaging.V2.Service
{
    /// <summary> delete </summary>
    public class DeleteBindingOptions : IOptions<BindingResource>
    {
        
        
        public string PathServiceSid { get; }

        
        public string PathSid { get; }



        /// <summary> Construct a new DeleteBindingOptions </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathSid">  </param>
        public DeleteBindingOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
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
    public class FetchBindingOptions : IOptions<BindingResource>
    {
    
        
        public string PathServiceSid { get; }

        
        public string PathSid { get; }



        /// <summary> Construct a new FetchBindingOptions </summary>
        /// <param name="pathServiceSid">  </param>
        /// <param name="pathSid">  </param>
        public FetchBindingOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
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
    public class ReadBindingOptions : ReadOptions<BindingResource>
    {
    
        
        public string PathServiceSid { get; }

        
        public List<BindingResource.BindingTypeEnum> BindingType { get; set; }

        
        public List<string> Identity { get; set; }



        /// <summary> Construct a new ListBindingOptions </summary>
        /// <param name="pathServiceSid">  </param>
        public ReadBindingOptions(string pathServiceSid)
        {
            PathServiceSid = pathServiceSid;
            BindingType = new List<BindingResource.BindingTypeEnum>();
            Identity = new List<string>();
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (BindingType != null)
            {
                p.AddRange(BindingType.Select(BindingType => new KeyValuePair<string, string>("BindingType", BindingType.ToString())));
            }
            if (Identity != null)
            {
                p.AddRange(Identity.Select(Identity => new KeyValuePair<string, string>("Identity", Identity)));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

}
