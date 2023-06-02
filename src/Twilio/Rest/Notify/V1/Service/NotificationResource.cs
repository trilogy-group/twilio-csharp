/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Notify
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
using Twilio.Types;


namespace Kandy.Rest.Notify.V1.Service
{
    public class NotificationResource : Resource
    {
    
        [JsonConverter(typeof(StringEnumConverter))]
        public sealed class PriorityEnum : StringEnum
        {
            private PriorityEnum(string value) : base(value) {}
            public PriorityEnum() {}
            public static implicit operator PriorityEnum(string value)
            {
                return new PriorityEnum(value);
            }
            public static readonly PriorityEnum High = new PriorityEnum("high");
            public static readonly PriorityEnum Low = new PriorityEnum("low");

        }

        
        private static Request BuildCreateRequest(CreateNotificationOptions options, ITwilioRestClient client)
        {
            
            string path = "/v1/Services/{ServiceSid}/Notifications";

            string PathServiceSid = options.PathServiceSid;
            path = path.Replace("{"+"ServiceSid"+"}", PathServiceSid);

            return new Request(
                HttpMethod.Post,
                Rest.Domain.Notify,
                path,
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary> create </summary>
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
        /// <summary> create </summary>
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

        /// <summary> create </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/notify/api/service-resource) to create the resource under. </param>
        /// <param name="identity"> The `identity` value that uniquely identifies the new resource's [User](https://www.twilio.com/docs/chat/rest/user-resource) within the [Service](https://www.twilio.com/docs/notify/api/service-resource). Delivery will be attempted only to Bindings with an Identity in this list. No more than 20 items are allowed in this list. </param>
        /// <param name="tag"> A tag that selects the Bindings to notify. Repeat this parameter to specify more than one tag, up to a total of 5 tags. The implicit tag `all` is available to notify all Bindings in a Service instance. Similarly, the implicit tags `apn`, `fcm`, `gcm`, `sms` and `facebook-messenger` are available to notify all Bindings in a specific channel. </param>
        /// <param name="body"> The notification text. For FCM and GCM, translates to `data.twi_body`. For APNS, translates to `aps.alert.body`. For SMS, translates to `body`. SMS requires either this `body` value, or `media_urls` attribute defined in the `sms` parameter of the notification. </param>
        /// <param name="priority">  </param>
        /// <param name="ttl"> How long, in seconds, the notification is valid. Can be an integer between 0 and 2,419,200, which is 4 weeks, the default and the maximum supported time to live (TTL). Delivery should be attempted if the device is offline until the TTL elapses. Zero means that the notification delivery is attempted immediately, only once, and is not stored for future delivery. SMS does not support this property. </param>
        /// <param name="title"> The notification title. For FCM and GCM, this translates to the `data.twi_title` value. For APNS, this translates to the `aps.alert.title` value. SMS does not support this property. This field is not visible on iOS phones and tablets but appears on Apple Watch and Android devices. </param>
        /// <param name="sound"> The name of the sound to be played for the notification. For FCM and GCM, this Translates to `data.twi_sound`.  For APNS, this translates to `aps.sound`.  SMS does not support this property. </param>
        /// <param name="action"> The actions to display for the notification. For APNS, translates to the `aps.category` value. For GCM, translates to the `data.twi_action` value. For SMS, this parameter is not supported and is omitted from deliveries to those channels. </param>
        /// <param name="data"> The custom key-value pairs of the notification's payload. For FCM and GCM, this value translates to `data` in the FCM and GCM payloads. FCM and GCM [reserve certain keys](https://firebase.google.com/docs/cloud-messaging/http-server-ref) that cannot be used in those channels. For APNS, attributes of `data` are inserted into the APNS payload as custom properties outside of the `aps` dictionary. In all channels, we reserve keys that start with `twi_` for future use. Custom keys that start with `twi_` are not allowed and are rejected as 400 Bad request with no delivery attempted. For SMS, this parameter is not supported and is omitted from deliveries to those channels. </param>
        /// <param name="apn"> The APNS-specific payload that overrides corresponding attributes in the generic payload for APNS Bindings. This property maps to the APNS `Payload` item, therefore the `aps` key must be used to change standard attributes. Adds custom key-value pairs to the root of the dictionary. See the [APNS documentation](https://developer.apple.com/library/content/documentation/NetworkingInternet/Conceptual/RemoteNotificationsPG/CommunicatingwithAPNs.html) for more details. We reserve keys that start with `twi_` for future use. Custom keys that start with `twi_` are not allowed. </param>
        /// <param name="gcm"> The GCM-specific payload that overrides corresponding attributes in the generic payload for GCM Bindings.  This property maps to the root JSON dictionary. See the [GCM documentation](https://firebase.google.com/docs/cloud-messaging/http-server-ref) for more details. Target parameters `to`, `registration_ids`, and `notification_key` are not allowed. We reserve keys that start with `twi_` for future use. Custom keys that start with `twi_` are not allowed. GCM also [reserves certain keys](https://firebase.google.com/docs/cloud-messaging/http-server-ref). </param>
        /// <param name="sms"> The SMS-specific payload that overrides corresponding attributes in the generic payload for SMS Bindings.  Each attribute in this value maps to the corresponding `form` parameter of the Twilio [Message](https://www.twilio.com/docs/sms/send-messages) resource.  These parameters of the Message resource are supported in snake case format: `body`, `media_urls`, `status_callback`, and `max_price`.  The `status_callback` parameter overrides the corresponding parameter in the messaging service, if configured. The `media_urls` property expects a JSON array. </param>
        /// <param name="facebookMessenger"> Deprecated. </param>
        /// <param name="fcm"> The FCM-specific payload that overrides corresponding attributes in the generic payload for FCM Bindings. This property maps to the root JSON dictionary. See the [FCM documentation](https://firebase.google.com/docs/cloud-messaging/http-server-ref#downstream) for more details. Target parameters `to`, `registration_ids`, `condition`, and `notification_key` are not allowed in this parameter. We reserve keys that start with `twi_` for future use. Custom keys that start with `twi_` are not allowed. FCM also [reserves certain keys](https://firebase.google.com/docs/cloud-messaging/http-server-ref), which cannot be used in that channel. </param>
        /// <param name="segment"> The Segment resource is deprecated. Use the `tag` parameter, instead. </param>
        /// <param name="alexa"> Deprecated. </param>
        /// <param name="toBinding"> The destination address specified as a JSON string.  Multiple `to_binding` parameters can be included but the total size of the request entity should not exceed 1MB. This is typically sufficient for 10,000 phone numbers. </param>
        /// <param name="deliveryCallbackUrl"> URL to send webhooks. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Notification </returns>
        public static NotificationResource Create(
                                          string pathServiceSid,
                                          List<string> identity = null,
                                          List<string> tag = null,
                                          string body = null,
                                          NotificationResource.PriorityEnum priority = null,
                                          int? ttl = null,
                                          string title = null,
                                          string sound = null,
                                          string action = null,
                                          object data = null,
                                          object apn = null,
                                          object gcm = null,
                                          object sms = null,
                                          object facebookMessenger = null,
                                          object fcm = null,
                                          List<string> segment = null,
                                          object alexa = null,
                                          List<string> toBinding = null,
                                          string deliveryCallbackUrl = null,
                                          ITwilioRestClient client = null)
        {
            var options = new CreateNotificationOptions(pathServiceSid){  Identity = identity, Tag = tag, Body = body, Priority = priority, Ttl = ttl, Title = title, Sound = sound, Action = action, Data = data, Apn = apn, Gcm = gcm, Sms = sms, FacebookMessenger = facebookMessenger, Fcm = fcm, Segment = segment, Alexa = alexa, ToBinding = toBinding, DeliveryCallbackUrl = deliveryCallbackUrl };
            return Create(options, client);
        }

        #if !NET35
        /// <summary> create </summary>
        /// <param name="pathServiceSid"> The SID of the [Service](https://www.twilio.com/docs/notify/api/service-resource) to create the resource under. </param>
        /// <param name="identity"> The `identity` value that uniquely identifies the new resource's [User](https://www.twilio.com/docs/chat/rest/user-resource) within the [Service](https://www.twilio.com/docs/notify/api/service-resource). Delivery will be attempted only to Bindings with an Identity in this list. No more than 20 items are allowed in this list. </param>
        /// <param name="tag"> A tag that selects the Bindings to notify. Repeat this parameter to specify more than one tag, up to a total of 5 tags. The implicit tag `all` is available to notify all Bindings in a Service instance. Similarly, the implicit tags `apn`, `fcm`, `gcm`, `sms` and `facebook-messenger` are available to notify all Bindings in a specific channel. </param>
        /// <param name="body"> The notification text. For FCM and GCM, translates to `data.twi_body`. For APNS, translates to `aps.alert.body`. For SMS, translates to `body`. SMS requires either this `body` value, or `media_urls` attribute defined in the `sms` parameter of the notification. </param>
        /// <param name="priority">  </param>
        /// <param name="ttl"> How long, in seconds, the notification is valid. Can be an integer between 0 and 2,419,200, which is 4 weeks, the default and the maximum supported time to live (TTL). Delivery should be attempted if the device is offline until the TTL elapses. Zero means that the notification delivery is attempted immediately, only once, and is not stored for future delivery. SMS does not support this property. </param>
        /// <param name="title"> The notification title. For FCM and GCM, this translates to the `data.twi_title` value. For APNS, this translates to the `aps.alert.title` value. SMS does not support this property. This field is not visible on iOS phones and tablets but appears on Apple Watch and Android devices. </param>
        /// <param name="sound"> The name of the sound to be played for the notification. For FCM and GCM, this Translates to `data.twi_sound`.  For APNS, this translates to `aps.sound`.  SMS does not support this property. </param>
        /// <param name="action"> The actions to display for the notification. For APNS, translates to the `aps.category` value. For GCM, translates to the `data.twi_action` value. For SMS, this parameter is not supported and is omitted from deliveries to those channels. </param>
        /// <param name="data"> The custom key-value pairs of the notification's payload. For FCM and GCM, this value translates to `data` in the FCM and GCM payloads. FCM and GCM [reserve certain keys](https://firebase.google.com/docs/cloud-messaging/http-server-ref) that cannot be used in those channels. For APNS, attributes of `data` are inserted into the APNS payload as custom properties outside of the `aps` dictionary. In all channels, we reserve keys that start with `twi_` for future use. Custom keys that start with `twi_` are not allowed and are rejected as 400 Bad request with no delivery attempted. For SMS, this parameter is not supported and is omitted from deliveries to those channels. </param>
        /// <param name="apn"> The APNS-specific payload that overrides corresponding attributes in the generic payload for APNS Bindings. This property maps to the APNS `Payload` item, therefore the `aps` key must be used to change standard attributes. Adds custom key-value pairs to the root of the dictionary. See the [APNS documentation](https://developer.apple.com/library/content/documentation/NetworkingInternet/Conceptual/RemoteNotificationsPG/CommunicatingwithAPNs.html) for more details. We reserve keys that start with `twi_` for future use. Custom keys that start with `twi_` are not allowed. </param>
        /// <param name="gcm"> The GCM-specific payload that overrides corresponding attributes in the generic payload for GCM Bindings.  This property maps to the root JSON dictionary. See the [GCM documentation](https://firebase.google.com/docs/cloud-messaging/http-server-ref) for more details. Target parameters `to`, `registration_ids`, and `notification_key` are not allowed. We reserve keys that start with `twi_` for future use. Custom keys that start with `twi_` are not allowed. GCM also [reserves certain keys](https://firebase.google.com/docs/cloud-messaging/http-server-ref). </param>
        /// <param name="sms"> The SMS-specific payload that overrides corresponding attributes in the generic payload for SMS Bindings.  Each attribute in this value maps to the corresponding `form` parameter of the Twilio [Message](https://www.twilio.com/docs/sms/send-messages) resource.  These parameters of the Message resource are supported in snake case format: `body`, `media_urls`, `status_callback`, and `max_price`.  The `status_callback` parameter overrides the corresponding parameter in the messaging service, if configured. The `media_urls` property expects a JSON array. </param>
        /// <param name="facebookMessenger"> Deprecated. </param>
        /// <param name="fcm"> The FCM-specific payload that overrides corresponding attributes in the generic payload for FCM Bindings. This property maps to the root JSON dictionary. See the [FCM documentation](https://firebase.google.com/docs/cloud-messaging/http-server-ref#downstream) for more details. Target parameters `to`, `registration_ids`, `condition`, and `notification_key` are not allowed in this parameter. We reserve keys that start with `twi_` for future use. Custom keys that start with `twi_` are not allowed. FCM also [reserves certain keys](https://firebase.google.com/docs/cloud-messaging/http-server-ref), which cannot be used in that channel. </param>
        /// <param name="segment"> The Segment resource is deprecated. Use the `tag` parameter, instead. </param>
        /// <param name="alexa"> Deprecated. </param>
        /// <param name="toBinding"> The destination address specified as a JSON string.  Multiple `to_binding` parameters can be included but the total size of the request entity should not exceed 1MB. This is typically sufficient for 10,000 phone numbers. </param>
        /// <param name="deliveryCallbackUrl"> URL to send webhooks. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Notification </returns>
        public static async System.Threading.Tasks.Task<NotificationResource> CreateAsync(
                                                                                  string pathServiceSid,
                                                                                  List<string> identity = null,
                                                                                  List<string> tag = null,
                                                                                  string body = null,
                                                                                  NotificationResource.PriorityEnum priority = null,
                                                                                  int? ttl = null,
                                                                                  string title = null,
                                                                                  string sound = null,
                                                                                  string action = null,
                                                                                  object data = null,
                                                                                  object apn = null,
                                                                                  object gcm = null,
                                                                                  object sms = null,
                                                                                  object facebookMessenger = null,
                                                                                  object fcm = null,
                                                                                  List<string> segment = null,
                                                                                  object alexa = null,
                                                                                  List<string> toBinding = null,
                                                                                  string deliveryCallbackUrl = null,
                                                                                  ITwilioRestClient client = null)
        {
        var options = new CreateNotificationOptions(pathServiceSid){  Identity = identity, Tag = tag, Body = body, Priority = priority, Ttl = ttl, Title = title, Sound = sound, Action = action, Data = data, Apn = apn, Gcm = gcm, Sms = sms, FacebookMessenger = facebookMessenger, Fcm = fcm, Segment = segment, Alexa = alexa, ToBinding = toBinding, DeliveryCallbackUrl = deliveryCallbackUrl };
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

    
        ///<summary> The unique string that we created to identify the Notification resource. </summary> 
        [JsonProperty("sid")]
        public string Sid { get; private set; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Notification resource. </summary> 
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }

        ///<summary> The SID of the [Service](https://www.twilio.com/docs/notify/api/service-resource) the resource is associated with. </summary> 
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }

        ///<summary> The date and time in GMT when the resource was created specified in [RFC 2822](https://www.ietf.org/rfc/rfc2822.txt) format. </summary> 
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }

        ///<summary> The list of `identity` values of the Users to notify. We will attempt to deliver notifications only to Bindings with an identity in this list. </summary> 
        [JsonProperty("identities")]
        public List<string> Identities { get; private set; }

        ///<summary> The tags that select the Bindings to notify. Notifications will be attempted only to Bindings that have all of the tags listed in this property. </summary> 
        [JsonProperty("tags")]
        public List<string> Tags { get; private set; }

        ///<summary> The list of Segments to notify. The [Segment](https://www.twilio.com/docs/notify/api/segment-resource) resource is deprecated. Use the `tags` property, instead. </summary> 
        [JsonProperty("segments")]
        public List<string> Segments { get; private set; }

        
        [JsonProperty("priority")]
        public NotificationResource.PriorityEnum Priority { get; private set; }

        ///<summary> How long, in seconds, the notification is valid. Can be an integer between 0 and 2,419,200, which is 4 weeks, the default and the maximum supported time to live (TTL). Delivery should be attempted if the device is offline until the TTL elapses. Zero means that the notification delivery is attempted immediately, only once, and is not stored for future delivery. SMS does not support this property. </summary> 
        [JsonProperty("ttl")]
        public int? Ttl { get; private set; }

        ///<summary> The notification title. For FCM and GCM, this translates to the `data.twi_title` value. For APNS, this translates to the `aps.alert.title` value. SMS does not support this property. This field is not visible on iOS phones and tablets but appears on Apple Watch and Android devices. </summary> 
        [JsonProperty("title")]
        public string Title { get; private set; }

        ///<summary> The notification text. For FCM and GCM, translates to `data.twi_body`. For APNS, translates to `aps.alert.body`. For SMS, translates to `body`. SMS requires either this `body` value, or `media_urls` attribute defined in the `sms` parameter of the notification. </summary> 
        [JsonProperty("body")]
        public string Body { get; private set; }

        ///<summary> The name of the sound to be played for the notification. For FCM and GCM, this Translates to `data.twi_sound`.  For APNS, this translates to `aps.sound`.  SMS does not support this property. </summary> 
        [JsonProperty("sound")]
        public string Sound { get; private set; }

        ///<summary> The actions to display for the notification. For APNS, translates to the `aps.category` value. For GCM, translates to the `data.twi_action` value. For SMS, this parameter is not supported and is omitted from deliveries to those channels. </summary> 
        [JsonProperty("action")]
        public string Action { get; private set; }

        ///<summary> The custom key-value pairs of the notification's payload. For FCM and GCM, this value translates to `data` in the FCM and GCM payloads. FCM and GCM [reserve certain keys](https://firebase.google.com/docs/cloud-messaging/http-server-ref) that cannot be used in those channels. For APNS, attributes of `data` are inserted into the APNS payload as custom properties outside of the `aps` dictionary. In all channels, we reserve keys that start with `twi_` for future use. Custom keys that start with `twi_` are not allowed and are rejected as 400 Bad request with no delivery attempted. For SMS, this parameter is not supported and is omitted from deliveries to those channels. </summary> 
        [JsonProperty("data")]
        public object Data { get; private set; }

        ///<summary> The APNS-specific payload that overrides corresponding attributes in the generic payload for APNS Bindings. This property maps to the APNS `Payload` item, therefore the `aps` key must be used to change standard attributes. Adds custom key-value pairs to the root of the dictionary. See the [APNS documentation](https://developer.apple.com/library/content/documentation/NetworkingInternet/Conceptual/RemoteNotificationsPG/CommunicatingwithAPNs.html) for more details. We reserve keys that start with `twi_` for future use. Custom keys that start with `twi_` are not allowed. </summary> 
        [JsonProperty("apn")]
        public object Apn { get; private set; }

        ///<summary> The GCM-specific payload that overrides corresponding attributes in the generic payload for GCM Bindings.  This property maps to the root JSON dictionary. Target parameters `to`, `registration_ids`, and `notification_key` are not allowed. We reserve keys that start with `twi_` for future use. Custom keys that start with `twi_` are not allowed. </summary> 
        [JsonProperty("gcm")]
        public object Gcm { get; private set; }

        ///<summary> The FCM-specific payload that overrides corresponding attributes in the generic payload for FCM Bindings. This property maps to the root JSON dictionary. See the [FCM documentation](https://firebase.google.com/docs/cloud-messaging/http-server-ref#downstream) for more details. Target parameters `to`, `registration_ids`, `condition`, and `notification_key` are not allowed in this parameter. We reserve keys that start with `twi_` for future use. Custom keys that start with `twi_` are not allowed. FCM also [reserves certain keys](https://firebase.google.com/docs/cloud-messaging/http-server-ref), which cannot be used in that channel. </summary> 
        [JsonProperty("fcm")]
        public object Fcm { get; private set; }

        ///<summary> The SMS-specific payload that overrides corresponding attributes in the generic payload for SMS Bindings.  Each attribute in this value maps to the corresponding `form` parameter of the Twilio [Message](https://www.twilio.com/docs/sms/api/message-resource) resource.  These parameters of the Message resource are supported in snake case format: `body`, `media_urls`, `status_callback`, and `max_price`.  The `status_callback` parameter overrides the corresponding parameter in the messaging service, if configured. The `media_urls` property expects a JSON array. </summary> 
        [JsonProperty("sms")]
        public object Sms { get; private set; }

        ///<summary> Deprecated. </summary> 
        [JsonProperty("facebook_messenger")]
        public object FacebookMessenger { get; private set; }

        ///<summary> Deprecated. </summary> 
        [JsonProperty("alexa")]
        public object Alexa { get; private set; }



        private NotificationResource() {

        }
    }
}
