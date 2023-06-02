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




namespace Kandy.Rest.Verify.V2
{

    /// <summary> Add a new phone number to SafeList. </summary>
    public class CreateSafelistOptions : IOptions<SafelistResource>
    {
        
        ///<summary> The phone number to be added in SafeList. Phone numbers must be in [E.164 format](https://www.twilio.com/docs/glossary/what-e164). </summary> 
        public string PhoneNumber { get; }


        /// <summary> Construct a new CreateSafelistOptions </summary>
        /// <param name="phoneNumber"> The phone number to be added in SafeList. Phone numbers must be in [E.164 format](https://www.twilio.com/docs/glossary/what-e164). </param>
        public CreateSafelistOptions(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (PhoneNumber != null)
            {
                p.Add(new KeyValuePair<string, string>("PhoneNumber", PhoneNumber));
            }
            return p;
        }
        

    }
    /// <summary> Remove a phone number from SafeList. </summary>
    public class DeleteSafelistOptions : IOptions<SafelistResource>
    {
        
        ///<summary> The phone number to be removed from SafeList. Phone numbers must be in [E.164 format](https://www.twilio.com/docs/glossary/what-e164). </summary> 
        public string PathPhoneNumber { get; }



        /// <summary> Construct a new DeleteSafelistOptions </summary>
        /// <param name="pathPhoneNumber"> The phone number to be removed from SafeList. Phone numbers must be in [E.164 format](https://www.twilio.com/docs/glossary/what-e164). </param>
        public DeleteSafelistOptions(string pathPhoneNumber)
        {
            PathPhoneNumber = pathPhoneNumber;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Check if a phone number exists in SafeList. </summary>
    public class FetchSafelistOptions : IOptions<SafelistResource>
    {
    
        ///<summary> The phone number to be fetched from SafeList. Phone numbers must be in [E.164 format](https://www.twilio.com/docs/glossary/what-e164). </summary> 
        public string PathPhoneNumber { get; }



        /// <summary> Construct a new FetchSafelistOptions </summary>
        /// <param name="pathPhoneNumber"> The phone number to be fetched from SafeList. Phone numbers must be in [E.164 format](https://www.twilio.com/docs/glossary/what-e164). </param>
        public FetchSafelistOptions(string pathPhoneNumber)
        {
            PathPhoneNumber = pathPhoneNumber;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


}
