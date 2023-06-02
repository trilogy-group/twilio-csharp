/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;
using Twilio.Converters;

namespace Kandy.TwiML.Voice
{

    /// <summary>
    /// Start TwiML Verb
    /// </summary>
    public class Start : TwiML
    {
        /// <summary>
        /// Action URL
        /// </summary>
        public Uri Action { get; set; }
        /// <summary>
        /// Action URL method
        /// </summary>
        public Twilio.Http.HttpMethod Method { get; set; }

        /// <summary>
        /// Create a new Start
        /// </summary>
        /// <param name="action"> Action URL </param>
        /// <param name="method"> Action URL method </param>
        public Start(Uri action = null, Twilio.Http.HttpMethod method = null) : base("Start")
        {
            this.Action = action;
            this.Method = method;
        }

        /// <summary>
        /// Return the attributes of the TwiML tag
        /// </summary>
        protected override List<XAttribute> GetElementAttributes()
        {
            var attributes = new List<XAttribute>();
            if (this.Action != null)
            {
                attributes.Add(new XAttribute("action", Serializers.Url(this.Action)));
            }
            if (this.Method != null)
            {
                attributes.Add(new XAttribute("method", this.Method.ToString()));
            }
            return attributes;
        }

        /// <summary>
        /// Create a new <Stream/> element and append it as a child of this element.
        /// </summary>
        /// <param name="name"> Friendly name given to the Stream </param>
        /// <param name="connectorName"> Unique name for Stream Connector </param>
        /// <param name="url"> URL of the remote service where the Stream is routed </param>
        /// <param name="track"> Track to be streamed to remote service </param>
        /// <param name="statusCallback"> Status Callback URL </param>
        /// <param name="statusCallbackMethod"> Status Callback URL method </param>
        public Start Stream(string name = null,
                            string connectorName = null,
                            string url = null,
                            Stream.TrackEnum track = null,
                            string statusCallback = null,
                            Stream.StatusCallbackMethodEnum statusCallbackMethod = null)
        {
            var newChild = new Stream(name, connectorName, url, track, statusCallback, statusCallbackMethod);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Stream/> element as a child of this element
        /// </summary>
        /// <param name="stream"> A Stream instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public Start Stream(Stream stream)
        {
            this.Append(stream);
            return this;
        }

        /// <summary>
        /// Create a new <Siprec/> element and append it as a child of this element.
        /// </summary>
        /// <param name="name"> Friendly name given to SIPREC </param>
        /// <param name="connectorName"> Unique name for Connector </param>
        /// <param name="track"> Track to be streamed to remote service </param>
        public Start Siprec(string name = null, string connectorName = null, Siprec.TrackEnum track = null)
        {
            var newChild = new Siprec(name, connectorName, track);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Siprec/> element as a child of this element
        /// </summary>
        /// <param name="siprec"> A Siprec instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public Start Siprec(Siprec siprec)
        {
            this.Append(siprec);
            return this;
        }

        /// <summary>
        /// Append a child TwiML element to this element returning this element to allow chaining.
        /// </summary>
        /// <param name="childElem"> Child TwiML element to add </param>
        public new Start Append(TwiML childElem)
        {
            return (Start) base.Append(childElem);
        }

        /// <summary>
        /// Add freeform key-value attributes to the generated xml
        /// </summary>
        /// <param name="key"> Option key </param>
        /// <param name="value"> Option value </param>
        public new Start SetOption(string key, object value)
        {
            return (Start) base.SetOption(key, value);
        }
    }

}
