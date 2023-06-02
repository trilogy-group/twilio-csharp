﻿using Newtonsoft.Json;

namespace Kandy.Types
{
    /// <summary>
    /// Capabilities of a phone number
    /// </summary>
    public class PhoneNumberCapabilities
    {
        /// <summary>
        /// MMS capable
        /// </summary>
        [JsonProperty("mms")]
        public bool Mms { get; }

        /// <summary>
        /// SMS capable
        /// </summary>
        [JsonProperty("sms")]
        public bool Sms { get; }

        /// <summary>
        /// Voice capable
        /// </summary>
        [JsonProperty("voice")]
        public bool Voice { get; }

        /// <summary>
        /// Fax capable
        /// </summary>
        [JsonProperty("fax")]
        public bool Fax { get; }

        /// <summary>
        /// Create a new PhoneNumberCapability
        /// </summary>
        /// <param name="mms">MMS capable</param>
        /// <param name="sms">SMS capable</param>
        /// <param name="voice">Voice capable</param>
        /// <param name="fax">Fax capable</param>
        public PhoneNumberCapabilities (bool mms, bool sms, bool voice, bool fax)
        {
            Mms = mms;
            Sms = sms;
            Voice = voice;
            Fax = fax;
        }
    }
}
