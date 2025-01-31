/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;

namespace Kandy.TwiML.Voice
{

    /// <summary>
    /// Task TwiML Noun
    /// </summary>
    public class Task : TwiML
    {
        /// <summary>
        /// TaskRouter task attributes
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// Task priority
        /// </summary>
        public int? Priority { get; set; }
        /// <summary>
        /// Timeout associated with task
        /// </summary>
        public int? Timeout { get; set; }

        /// <summary>
        /// Create a new Task
        /// </summary>
        /// <param name="body"> TaskRouter task attributes, the body of the TwiML Element. Also accepts stringified object
        ///            </param>
        /// <param name="priority"> Task priority </param>
        /// <param name="timeout"> Timeout associated with task </param>
        public Task(string body = null, int? priority = null, int? timeout = null) : base("Task")
        {
            this.Body = body;
            this.Priority = priority;
            this.Timeout = timeout;
        }

        /// <summary>
        /// Return the body of the TwiML tag
        /// </summary>
        protected override string GetElementBody()
        {
            return this.Body != null ? this.Body : string.Empty;
        }

        /// <summary>
        /// Return the attributes of the TwiML tag
        /// </summary>
        protected override List<XAttribute> GetElementAttributes()
        {
            var attributes = new List<XAttribute>();
            if (this.Priority != null)
            {
                attributes.Add(new XAttribute("priority", this.Priority.ToString()));
            }
            if (this.Timeout != null)
            {
                attributes.Add(new XAttribute("timeout", this.Timeout.ToString()));
            }
            return attributes;
        }

        /// <summary>
        /// Append a child TwiML element to this element returning this element to allow chaining.
        /// </summary>
        /// <param name="childElem"> Child TwiML element to add </param>
        public new Task Append(TwiML childElem)
        {
            return (Task) base.Append(childElem);
        }

        /// <summary>
        /// Add freeform key-value attributes to the generated xml
        /// </summary>
        /// <param name="key"> Option key </param>
        /// <param name="value"> Option value </param>
        public new Task SetOption(string key, object value)
        {
            return (Task) base.SetOption(key, value);
        }
    }

}
