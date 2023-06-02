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
    /// Config TwiML Noun
    /// </summary>
    public class Config : TwiML
    {
        /// <summary>
        /// The name of the custom config
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The value of the custom config
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Create a new Config
        /// </summary>
        /// <param name="name"> The name of the custom config </param>
        /// <param name="value"> The value of the custom config </param>
        public Config(string name = null, string value = null) : base("Config")
        {
            this.Name = name;
            this.Value = value;
        }

        /// <summary>
        /// Return the attributes of the TwiML tag
        /// </summary>
        protected override List<XAttribute> GetElementAttributes()
        {
            var attributes = new List<XAttribute>();
            if (this.Name != null)
            {
                attributes.Add(new XAttribute("name", this.Name));
            }
            if (this.Value != null)
            {
                attributes.Add(new XAttribute("value", this.Value));
            }
            return attributes;
        }

        /// <summary>
        /// Append a child TwiML element to this element returning this element to allow chaining.
        /// </summary>
        /// <param name="childElem"> Child TwiML element to add </param>
        public new Config Append(TwiML childElem)
        {
            return (Config) base.Append(childElem);
        }

        /// <summary>
        /// Add freeform key-value attributes to the generated xml
        /// </summary>
        /// <param name="key"> Option key </param>
        /// <param name="value"> Option value </param>
        public new Config SetOption(string key, object value)
        {
            return (Config) base.SetOption(key, value);
        }
    }

}
