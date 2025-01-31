/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System.IO;
using System.Text;
using System.Xml.Linq;

namespace Kandy.TwiML.Voice
{

    /// <summary>
    /// ApplicationSid TwiML Noun
    /// </summary>
    public class ApplicationSid : TwiML
    {
        /// <summary>
        /// Application sid to dial
        /// </summary>
        public string Sid { get; set; }

        /// <summary>
        /// Create a new ApplicationSid
        /// </summary>
        /// <param name="sid"> Application sid to dial, the body of the TwiML Element. </param>
        public ApplicationSid(string sid = null) : base("ApplicationSid")
        {
            this.Sid = sid;
        }

        /// <summary>
        /// Return the body of the TwiML tag
        /// </summary>
        protected override string GetElementBody()
        {
            return this.Sid != null ? this.Sid : string.Empty;
        }

        /// <summary>
        /// Append a child TwiML element to this element returning this element to allow chaining.
        /// </summary>
        /// <param name="childElem"> Child TwiML element to add </param>
        public new ApplicationSid Append(TwiML childElem)
        {
            return (ApplicationSid) base.Append(childElem);
        }

        /// <summary>
        /// Add freeform key-value attributes to the generated xml
        /// </summary>
        /// <param name="key"> Option key </param>
        /// <param name="value"> Option value </param>
        public new ApplicationSid SetOption(string key, object value)
        {
            return (ApplicationSid) base.SetOption(key, value);
        }
    }

}
