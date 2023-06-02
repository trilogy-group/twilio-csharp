/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Supersim
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




namespace Kandy.Rest.Supersim.V1
{

    /// <summary> Register a Super SIM to your Account </summary>
    public class CreateSimOptions : IOptions<SimResource>
    {
        
        ///<summary> The [ICCID](https://en.wikipedia.org/wiki/Subscriber_identity_module#ICCID) of the Super SIM to be added to your Account. </summary> 
        public string Iccid { get; }

        ///<summary> The 10-digit code required to claim the Super SIM for your Account. </summary> 
        public string RegistrationCode { get; }


        /// <summary> Construct a new CreateSimOptions </summary>
        /// <param name="iccid"> The [ICCID](https://en.wikipedia.org/wiki/Subscriber_identity_module#ICCID) of the Super SIM to be added to your Account. </param>
        /// <param name="registrationCode"> The 10-digit code required to claim the Super SIM for your Account. </param>
        public CreateSimOptions(string iccid, string registrationCode)
        {
            Iccid = iccid;
            RegistrationCode = registrationCode;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Iccid != null)
            {
                p.Add(new KeyValuePair<string, string>("Iccid", Iccid));
            }
            if (RegistrationCode != null)
            {
                p.Add(new KeyValuePair<string, string>("RegistrationCode", RegistrationCode));
            }
            return p;
        }
        

    }
    /// <summary> Fetch a Super SIM instance from your account. </summary>
    public class FetchSimOptions : IOptions<SimResource>
    {
    
        ///<summary> The SID of the Sim resource to fetch. </summary> 
        public string PathSid { get; }



        /// <summary> Construct a new FetchSimOptions </summary>
        /// <param name="pathSid"> The SID of the Sim resource to fetch. </param>
        public FetchSimOptions(string pathSid)
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


    /// <summary> Retrieve a list of Super SIMs from your account. </summary>
    public class ReadSimOptions : ReadOptions<SimResource>
    {
    
        ///<summary> The status of the Sim resources to read. Can be `new`, `ready`, `active`, `inactive`, or `scheduled`. </summary> 
        public SimResource.StatusEnum Status { get; set; }

        ///<summary> The SID or unique name of the Fleet to which a list of Sims are assigned. </summary> 
        public string Fleet { get; set; }

        ///<summary> The [ICCID](https://en.wikipedia.org/wiki/Subscriber_identity_module#ICCID) associated with a Super SIM to filter the list by. Passing this parameter will always return a list containing zero or one SIMs. </summary> 
        public string Iccid { get; set; }




        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }
            if (Fleet != null)
            {
                p.Add(new KeyValuePair<string, string>("Fleet", Fleet));
            }
            if (Iccid != null)
            {
                p.Add(new KeyValuePair<string, string>("Iccid", Iccid));
            }
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

    /// <summary> Updates the given properties of a Super SIM instance from your account. </summary>
    public class UpdateSimOptions : IOptions<SimResource>
    {
    
        ///<summary> The SID of the Sim resource to update. </summary> 
        public string PathSid { get; }

        ///<summary> An application-defined string that uniquely identifies the resource. It can be used in place of the resource's `sid` in the URL to address the resource. </summary> 
        public string UniqueName { get; set; }

        
        public SimResource.StatusUpdateEnum Status { get; set; }

        ///<summary> The SID or unique name of the Fleet to which the SIM resource should be assigned. </summary> 
        public string Fleet { get; set; }

        ///<summary> The URL we should call using the `callback_method` after an asynchronous update has finished. </summary> 
        public Uri CallbackUrl { get; set; }

        ///<summary> The HTTP method we should use to call `callback_url`. Can be: `GET` or `POST` and the default is POST. </summary> 
        public Twilio.Http.HttpMethod CallbackMethod { get; set; }

        ///<summary> The SID of the Account to which the Sim resource should belong. The Account SID can only be that of the requesting Account or that of a Subaccount of the requesting Account. Only valid when the Sim resource's status is new. </summary> 
        public string AccountSid { get; set; }



        /// <summary> Construct a new UpdateSimOptions </summary>
        /// <param name="pathSid"> The SID of the Sim resource to update. </param>
        public UpdateSimOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }
            if (Fleet != null)
            {
                p.Add(new KeyValuePair<string, string>("Fleet", Fleet));
            }
            if (CallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("CallbackUrl", Serializers.Url(CallbackUrl)));
            }
            if (CallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("CallbackMethod", CallbackMethod.ToString()));
            }
            if (AccountSid != null)
            {
                p.Add(new KeyValuePair<string, string>("AccountSid", AccountSid));
            }
            return p;
        }
        

    }


}
