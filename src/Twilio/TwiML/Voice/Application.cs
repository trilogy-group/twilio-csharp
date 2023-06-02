/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Twilio.Converters;
using Twilio.Types;

namespace Kandy.TwiML.Voice
{

    /// <summary>
    /// Application TwiML Noun
    /// </summary>
    public class Application : TwiML
    {
        public sealed class EventEnum : StringEnum
        {
            private EventEnum(string value) : base(value) {}
            public EventEnum() {}
            public static implicit operator EventEnum(string value)
            {
                return new EventEnum(value);
            }

            public static readonly EventEnum Initiated = new EventEnum("initiated");
            public static readonly EventEnum Ringing = new EventEnum("ringing");
            public static readonly EventEnum Answered = new EventEnum("answered");
            public static readonly EventEnum Completed = new EventEnum("completed");
        }

        /// <summary>
        /// Application sid
        /// </summary>
        public string ApplicationSidAttribute { get; set; }
        /// <summary>
        /// TwiML URL
        /// </summary>
        public Uri Url { get; set; }
        /// <summary>
        /// TwiML URL Method
        /// </summary>
        public Twilio.Http.HttpMethod Method { get; set; }
        /// <summary>
        /// Events to trigger status callback
        /// </summary>
        public IEnumerable<Application.EventEnum> StatusCallbackEvent { get; set; }
        /// <summary>
        /// Status Callback URL
        /// </summary>
        public Uri StatusCallback { get; set; }
        /// <summary>
        /// Status Callback URL Method
        /// </summary>
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; set; }
        /// <summary>
        /// Identity of the customer calling application
        /// </summary>
        public string CustomerId { get; set; }
        /// <summary>
        /// Copy parent call To field to called application side, otherwise use the application sid as To field
        /// </summary>
        public bool? CopyParentTo { get; set; }

        /// <summary>
        /// Create a new Application
        /// </summary>
        /// <param name="applicationSid"> Application sid, the body of the TwiML Element. </param>
        /// <param name="url"> TwiML URL </param>
        /// <param name="method"> TwiML URL Method </param>
        /// <param name="statusCallbackEvent"> Events to trigger status callback </param>
        /// <param name="statusCallback"> Status Callback URL </param>
        /// <param name="statusCallbackMethod"> Status Callback URL Method </param>
        /// <param name="customerId"> Identity of the customer calling application </param>
        /// <param name="copyParentTo"> Copy parent call To field to called application side, otherwise use the application sid
        ///                    as To field </param>
        public Application(string applicationSid = null,
                           Uri url = null,
                           Twilio.Http.HttpMethod method = null,
                           IEnumerable<Application.EventEnum> statusCallbackEvent = null,
                           Uri statusCallback = null,
                           Twilio.Http.HttpMethod statusCallbackMethod = null,
                           string customerId = null,
                           bool? copyParentTo = null) : base("Application")
        {
            this.ApplicationSidAttribute = applicationSid;
            this.Url = url;
            this.Method = method;
            this.StatusCallbackEvent = statusCallbackEvent;
            this.StatusCallback = statusCallback;
            this.StatusCallbackMethod = statusCallbackMethod;
            this.CustomerId = customerId;
            this.CopyParentTo = copyParentTo;
        }

        /// <summary>
        /// Return the body of the TwiML tag
        /// </summary>
        protected override string GetElementBody()
        {
            return this.ApplicationSidAttribute != null ? this.ApplicationSidAttribute : string.Empty;
        }

        /// <summary>
        /// Return the attributes of the TwiML tag
        /// </summary>
        protected override List<XAttribute> GetElementAttributes()
        {
            var attributes = new List<XAttribute>();
            if (this.Url != null)
            {
                attributes.Add(new XAttribute("url", Serializers.Url(this.Url)));
            }
            if (this.Method != null)
            {
                attributes.Add(new XAttribute("method", this.Method.ToString()));
            }
            if (this.StatusCallbackEvent != null)
            {
                attributes.Add(new XAttribute("statusCallbackEvent", String.Join(" ", this.StatusCallbackEvent.Select(e => e.ToString()).ToArray())));
            }
            if (this.StatusCallback != null)
            {
                attributes.Add(new XAttribute("statusCallback", Serializers.Url(this.StatusCallback)));
            }
            if (this.StatusCallbackMethod != null)
            {
                attributes.Add(new XAttribute("statusCallbackMethod", this.StatusCallbackMethod.ToString()));
            }
            if (this.CustomerId != null)
            {
                attributes.Add(new XAttribute("customerId", this.CustomerId));
            }
            if (this.CopyParentTo != null)
            {
                attributes.Add(new XAttribute("copyParentTo", this.CopyParentTo.Value.ToString().ToLower()));
            }
            return attributes;
        }

        /// <summary>
        /// Create a new <ApplicationSid/> element and append it as a child of this element.
        /// </summary>
        /// <param name="sid"> Application sid to dial, the body of the TwiML Element. </param>
        public Application ApplicationSid(string sid = null)
        {
            var newChild = new ApplicationSid(sid);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <ApplicationSid/> element as a child of this element
        /// </summary>
        /// <param name="applicationSid"> A ApplicationSid instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public Application ApplicationSid(ApplicationSid applicationSid)
        {
            this.Append(applicationSid);
            return this;
        }

        /// <summary>
        /// Create a new <Parameter/> element and append it as a child of this element.
        /// </summary>
        /// <param name="name"> The name of the custom parameter </param>
        /// <param name="value"> The value of the custom parameter </param>
        public Application Parameter(string name = null, string value = null)
        {
            var newChild = new Parameter(name, value);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Parameter/> element as a child of this element
        /// </summary>
        /// <param name="parameter"> A Parameter instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public Application Parameter(Parameter parameter)
        {
            this.Append(parameter);
            return this;
        }

        /// <summary>
        /// Append a child TwiML element to this element returning this element to allow chaining.
        /// </summary>
        /// <param name="childElem"> Child TwiML element to add </param>
        public new Application Append(TwiML childElem)
        {
            return (Application) base.Append(childElem);
        }

        /// <summary>
        /// Add freeform key-value attributes to the generated xml
        /// </summary>
        /// <param name="key"> Option key </param>
        /// <param name="value"> Option value </param>
        public new Application SetOption(string key, object value)
        {
            return (Application) base.SetOption(key, value);
        }
    }

}
