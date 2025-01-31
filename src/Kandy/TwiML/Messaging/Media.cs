/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.IO;
using System.Text;
using System.Xml.Linq;
using Kandy.Converters;

namespace Kandy.TwiML.Messaging
{

    /// <summary>
    /// Media TwiML Noun
    /// </summary>
    public class Media : TwiML
    {
        /// <summary>
        /// Media URL
        /// </summary>
        public Uri Url { get; set; }

        /// <summary>
        /// Create a new Media
        /// </summary>
        /// <param name="url"> Media URL, the body of the TwiML Element. </param>
        public Media(Uri url = null) : base("Media")
        {
            this.Url = url;
        }

        /// <summary>
        /// Return the body of the TwiML tag
        /// </summary>
        protected override string GetElementBody()
        {
            return this.Url != null ? Serializers.Url(this.Url) : string.Empty;
        }

        /// <summary>
        /// Append a child TwiML element to this element returning this element to allow chaining.
        /// </summary>
        /// <param name="childElem"> Child TwiML element to add </param>
        public new Media Append(TwiML childElem)
        {
            return (Media)base.Append(childElem);
        }

        /// <summary>
        /// Add freeform key-value attributes to the generated xml
        /// </summary>
        /// <param name="key"> Option key </param>
        /// <param name="value"> Option value </param>
        public new Media SetOption(string key, object value)
        {
            return (Media)base.SetOption(key, value);
        }
    }

}
