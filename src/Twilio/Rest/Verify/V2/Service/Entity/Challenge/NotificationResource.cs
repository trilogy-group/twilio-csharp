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


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;



namespace Kandy.Rest.Verify.V2.Service.Entity.Challenge
{
    public class NotificationResource : Resource
    {
    

        
        private static Request BuildCreateRequest(CreateNotificationOptions options, ITwilioRestClient client)
        {
            
            string path = "/v2/Services/{ServiceSid}/Entities/{Identity}/Challenges/{ChallengeSid}/Notifications";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);
            string PathIdentity = options.PathIdentity;
            path = path.Replace("{"+"Identity"+"}", PathIdentity);
            string PathChallengeSid = options.PathChallengeSid;
            path = path.Replace("{"+"ChallengeSid"+"}", PathChallengeSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Verify,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> Create a new Notification for the corresponding Challenge </summary>
        /// <param name="options"> Create Notification parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Notification </returns>
        public static NotificationResource Create(CreateNotificationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary> Create a new Notification for the corresponding Challenge </summary>
        /// <param name="options"> Create Notification parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Notification </returns>
        public static async System.Threading.Tasks.Task<NotificationResource> CreateAsync(CreateNotificationOptions options,
        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary> Create a new Notification for the corresponding Challenge </summary>
        /// <param name="pathServiceSid"> The unique SID identifier of the Service. </param>
        /// <param name="pathIdentity"> Customer unique identity for the Entity owner of the Challenge. This identifier should be immutable, not PII, length between 8 and 64 characters, and generated by your external system, such as your user's UUID, GUID, or SID. It can only contain dash (-) separated alphanumeric characters. </param>
        /// <param name="pathChallengeSid"> The unique SID identifier of the Challenge. </param>
        /// <param name="ttl"> How long, in seconds, the notification is valid. Can be an integer between 0 and 300. Default is 300. Delivery is attempted until the TTL elapses, even if the device is offline. 0 means that the notification delivery is attempted immediately, only once, and is not stored for future delivery. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Notification </returns>
        public static NotificationResource Create(
                                          string pathServiceSid,
                                          string pathIdentity,
                                          string pathChallengeSid,
                                          int? ttl = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateNotificationOptions(pathServiceSid, pathIdentity, pathChallengeSid){  Ttl = ttl };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> Create a new Notification for the corresponding Challenge </summary>
        /// <param name="pathServiceSid"> The unique SID identifier of the Service. </param>
        /// <param name="pathIdentity"> Customer unique identity for the Entity owner of the Challenge. This identifier should be immutable, not PII, length between 8 and 64 characters, and generated by your external system, such as your user's UUID, GUID, or SID. It can only contain dash (-) separated alphanumeric characters. </param>
        /// <param name="pathChallengeSid"> The unique SID identifier of the Challenge. </param>
        /// <param name="ttl"> How long, in seconds, the notification is valid. Can be an integer between 0 and 300. Default is 300. Delivery is attempted until the TTL elapses, even if the device is offline. 0 means that the notification delivery is attempted immediately, only once, and is not stored for future delivery. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Notification </returns>
        public static async System.Threading.Tasks.Task<NotificationResource> CreateAsync(
                                                                                  string pathServiceSid,
                                                                                  string pathIdentity,
                                                                                  string pathChallengeSid,
                                                                                  int? ttl = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateNotificationOptions(pathServiceSid, pathIdentity, pathChallengeSid){  Ttl = ttl };
            return await CreateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a NotificationResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> NotificationResource object represented by the provided JSON </returns>
        public static NotificationResource FromJson(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<NotificationResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

    
        ///<summary> A 34 character string that uniquely identifies this Notification. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The unique SID identifier of the Account. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The unique SID identifier of the Service. </summary> 
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }

        ///<summary> The unique SID identifier of the Entity. </summary> 
        [JsonProperty("entity_sid")]
        public string EntitySid { get; private set; }

        ///<summary> Customer unique identity for the Entity owner of the Challenge. This identifier should be immutable, not PII, length between 8 and 64 characters, and generated by your external system, such as your user's UUID, GUID, or SID. It can only contain dash (-) separated alphanumeric characters. </summary> 
        [JsonProperty("identity")]
        public string Identity { get; private set; }

        ///<summary> The unique SID identifier of the Challenge. </summary> 
        [JsonProperty("challenge_sid")]
        public string ChallengeSid { get; private set; }

        ///<summary> The priority of the notification. For `push` Challenges it's always `high` which sends the notification immediately, and can wake up a sleeping device. </summary> 
        [JsonProperty("priority")]
        public string Priority { get; private set; }

        ///<summary> How long, in seconds, the notification is valid. Max: 5 minutes </summary> 
        [JsonProperty("ttl")]
        public int? Ttl { get; private set; }

        ///<summary> The date that this Notification was created, given in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }



        private NotificationResource() {

        }
    }
}
