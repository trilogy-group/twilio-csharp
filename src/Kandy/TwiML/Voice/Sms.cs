/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;
using Kandy.Converters;

namespace Kandy.TwiML.Voice
{

    /// <summary>
    /// Sms TwiML Noun
    /// </summary>
    public class Sms : TwiML
    {
        /// <summary>
        /// Message body
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// Number to send message to
        /// </summary>
        public Types.PhoneNumber To { get; set; }
        /// <summary>
        /// Number to send message from
        /// </summary>
        public Types.PhoneNumber From { get; set; }
        /// <summary>
        /// Action URL
        /// </summary>
        public Uri Action { get; set; }
        /// <summary>
        /// Action URL method
        /// </summary>
        public Kandy.Http.HttpMethod Method { get; set; }
        /// <summary>
        /// Status callback URL
        /// </summary>
        public Uri StatusCallback { get; set; }

        /// <summary>
        /// Create a new Sms
        /// </summary>
        /// <param name="message"> Message body, the body of the TwiML Element. </param>
        /// <param name="to"> Number to send message to </param>
        /// <param name="from"> Number to send message from </param>
        /// <param name="action"> Action URL </param>
        /// <param name="method"> Action URL method </param>
        /// <param name="statusCallback"> Status callback URL </param>
        public Sms(string message = null,
                   Types.PhoneNumber to = null,
                   Types.PhoneNumber from = null,
                   Uri action = null,
                   Kandy.Http.HttpMethod method = null,
                   Uri statusCallback = null) : base("Sms")
        {
            this.Message = message;
            this.To = to;
            this.From = from;
            this.Action = action;
            this.Method = method;
            this.StatusCallback = statusCallback;
        }

        /// <summary>
        /// Return the body of the TwiML tag
        /// </summary>
        protected override string GetElementBody()
        {
            return this.Message != null ? this.Message : string.Empty;
        }

        /// <summary>
        /// Return the attributes of the TwiML tag
        /// </summary>
        protected override List<XAttribute> GetElementAttributes()
        {
            var attributes = new List<XAttribute>();
            if (this.To != null)
            {
                attributes.Add(new XAttribute("to", this.To.ToString()));
            }
            if (this.From != null)
            {
                attributes.Add(new XAttribute("from", this.From.ToString()));
            }
            if (this.Action != null)
            {
                attributes.Add(new XAttribute("action", Serializers.Url(this.Action)));
            }
            if (this.Method != null)
            {
                attributes.Add(new XAttribute("method", this.Method.ToString()));
            }
            if (this.StatusCallback != null)
            {
                attributes.Add(new XAttribute("statusCallback", Serializers.Url(this.StatusCallback)));
            }
            return attributes;
        }

        /// <summary>
        /// Append a child TwiML element to this element returning this element to allow chaining.
        /// </summary>
        /// <param name="childElem"> Child TwiML element to add </param>
        public new Sms Append(TwiML childElem)
        {
            return (Sms)base.Append(childElem);
        }

        /// <summary>
        /// Add freeform key-value attributes to the generated xml
        /// </summary>
        /// <param name="key"> Option key </param>
        /// <param name="value"> Option value </param>
        public new Sms SetOption(string key, object value)
        {
            return (Sms)base.SetOption(key, value);
        }
    }

}
