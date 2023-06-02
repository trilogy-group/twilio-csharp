/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Routes
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



namespace Kandy.Rest.Routes.V2
{
    public class PhoneNumberResource : Resource
    {



        private static Request BuildFetchRequest(FetchPhoneNumberOptions options, IKandyRestClient client)
        {

            string path = "/v2/PhoneNumbers/{PhoneNumber}";

            string PathPhoneNumber = options.PathPhoneNumber;
            path = path.Replace("{" + "PhoneNumber" + "}", PathPhoneNumber);

            return new Request(
                HttpMethod.Get,
                Rest.Domain.Routes,
                path,
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Fetch the Inbound Processing Region assigned to a phone number. </summary>
        /// <param name="options"> Fetch PhoneNumber parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PhoneNumber </returns>
        public static PhoneNumberResource Fetch(FetchPhoneNumberOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

#if !NET35
        /// <summary> Fetch the Inbound Processing Region assigned to a phone number. </summary>
        /// <param name="options"> Fetch PhoneNumber parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PhoneNumber </returns>
        public static async System.Threading.Tasks.Task<PhoneNumberResource> FetchAsync(FetchPhoneNumberOptions options,
                                                                                             IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
#endif
        /// <summary> Fetch the Inbound Processing Region assigned to a phone number. </summary>
        /// <param name="pathPhoneNumber"> The phone number in E.164 format </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PhoneNumber </returns>
        public static PhoneNumberResource Fetch(
                                         string pathPhoneNumber,
                                         IKandyRestClient client = null)
        {
            var options = new FetchPhoneNumberOptions(pathPhoneNumber) { };
            return Fetch(options, client);
        }

#if !NET35
        /// <summary> Fetch the Inbound Processing Region assigned to a phone number. </summary>
        /// <param name="pathPhoneNumber"> The phone number in E.164 format </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PhoneNumber </returns>
        public static async System.Threading.Tasks.Task<PhoneNumberResource> FetchAsync(string pathPhoneNumber, IKandyRestClient client = null)
        {
            var options = new FetchPhoneNumberOptions(pathPhoneNumber) { };
            return await FetchAsync(options, client);
        }
#endif

        private static Request BuildUpdateRequest(UpdatePhoneNumberOptions options, IKandyRestClient client)
        {

            string path = "/v2/PhoneNumbers/{PhoneNumber}";

            string PathPhoneNumber = options.PathPhoneNumber;
            path = path.Replace("{" + "PhoneNumber" + "}", PathPhoneNumber);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Routes,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Assign an Inbound Processing Region to a phone number. </summary>
        /// <param name="options"> Update PhoneNumber parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PhoneNumber </returns>
        public static PhoneNumberResource Update(UpdatePhoneNumberOptions options, IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        /// <summary> Assign an Inbound Processing Region to a phone number. </summary>
        /// <param name="options"> Update PhoneNumber parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PhoneNumber </returns>
#if !NET35
        public static async System.Threading.Tasks.Task<PhoneNumberResource> UpdateAsync(UpdatePhoneNumberOptions options,
                                                                                                          IKandyRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
#endif

        /// <summary> Assign an Inbound Processing Region to a phone number. </summary>
        /// <param name="pathPhoneNumber"> The phone number in E.164 format </param>
        /// <param name="voiceRegion"> The Inbound Processing Region used for this phone number for voice </param>
        /// <param name="friendlyName"> A human readable description of this resource, up to 64 characters. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PhoneNumber </returns>
        public static PhoneNumberResource Update(
                                          string pathPhoneNumber,
                                          string voiceRegion = null,
                                          string friendlyName = null,
                                          IKandyRestClient client = null)
        {
            var options = new UpdatePhoneNumberOptions(pathPhoneNumber) { VoiceRegion = voiceRegion, FriendlyName = friendlyName };
            return Update(options, client);
        }

#if !NET35
        /// <summary> Assign an Inbound Processing Region to a phone number. </summary>
        /// <param name="pathPhoneNumber"> The phone number in E.164 format </param>
        /// <param name="voiceRegion"> The Inbound Processing Region used for this phone number for voice </param>
        /// <param name="friendlyName"> A human readable description of this resource, up to 64 characters. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PhoneNumber </returns>
        public static async System.Threading.Tasks.Task<PhoneNumberResource> UpdateAsync(
                                                                              string pathPhoneNumber,
                                                                              string voiceRegion = null,
                                                                              string friendlyName = null,
                                                                              IKandyRestClient client = null)
        {
            var options = new UpdatePhoneNumberOptions(pathPhoneNumber) { VoiceRegion = voiceRegion, FriendlyName = friendlyName };
            return await UpdateAsync(options, client);
        }
#endif

        /// <summary>
        /// Converts a JSON string into a PhoneNumberResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> PhoneNumberResource object represented by the provided JSON </returns>
        public static PhoneNumberResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<PhoneNumberResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }


        ///<summary> The phone number in E.164 format </summary> 
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; private set; }

        ///<summary> The absolute URL of the resource. </summary> 
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        ///<summary> A 34 character string that uniquely identifies the Inbound Processing Region assignments for this phone number. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The unique SID identifier of the Account. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> A human readable description of the Inbound Processing Region assignments for this phone number, up to 64 characters. </summary> 
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }

        ///<summary> The Inbound Processing Region used for this phone number for voice. </summary> 
        [JsonProperty("voice_region")]
        public string VoiceRegion { get; private set; }

        ///<summary> The date that this phone number was assigned an Inbound Processing Region, given in ISO 8601 format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The date that the Inbound Processing Region was updated for this phone number, given in ISO 8601 format. </summary> 
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }



        private PhoneNumberResource()
        {

        }
    }
}
