﻿using System.Collections.Generic;

namespace Kandy.Jwt.AccessToken
{
    /// <summary>
    /// Grant to expose Kandy Voice
    /// </summary>
    public class VoiceGrant : IGrant
    {
        /// <summary>
        /// Whether incoming connections are allowed (JS Client)
        /// </summary>
        public bool IncomingAllow { get; set; }

        /// <summary>
        /// Outgoing application SID
        /// </summary>
        public string OutgoingApplicationSid { get; set; }

        /// <summary>
        /// Parameters to send to the outgoing application
        /// </summary>
        public Dictionary<string, string> OutgoingApplicationParams { get; set; }

        /// <summary>
        /// Push credential SID
        /// </summary>
        public string PushCredentialSid { get; set; }

        /// <summary>
        /// Endpoint ID
        /// </summary>
        public string EndpointId { get; set; }

        /// <summary>
        /// Get the grant key
        /// </summary>
        ///
        /// <returns>the grant key</returns>
        public string Key
        {
            get
            {
                return "voice";
            }
        }

        /// <summary>
        /// Get the grant payload
        /// </summary>
        ///
        /// <returns>the grant payload</returns>
        public object Payload
        {
            get
            {
                var payload = new Dictionary<string, object>();
                if (IncomingAllow == true)
                {
                    var incoming = new Dictionary<string, object> { { "allow", true } };
                    payload.Add("incoming", incoming);
                }

                if (OutgoingApplicationSid != null)
                {
                    var outgoing = new Dictionary<string, object> { { "application_sid", OutgoingApplicationSid } };
                    if (OutgoingApplicationParams != null)
                    {
                        outgoing.Add("params", OutgoingApplicationParams);
                    }

                    payload.Add("outgoing", outgoing);
                }

                if (PushCredentialSid != null)
                {
                    payload.Add("push_credential_sid", PushCredentialSid);
                }

                if (EndpointId != null)
                {
                    payload.Add("endpoint_id", EndpointId);
                }

                return payload;
            }
        }
    }
}
