/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.IO;
using System.Text;
using System.Xml.Linq;
using Kandy.Converters;
using Kandy.TwiML.Fax;

namespace Kandy.TwiML
{

    /// <summary>
    /// Response TwiML for Faxes
    /// </summary>
    public class FaxResponse : TwiML
    {
        /// <summary>
        /// Create a new FaxResponse
        /// </summary>
        public FaxResponse() : base("Response")
        {
        }

        /// <summary>
        /// Create a new <Receive/> element and append it as a child of this element.
        /// </summary>
        /// <param name="action"> Receive action URL </param>
        /// <param name="method"> Receive action URL method </param>
        /// <param name="mediaType"> The media type used to store media in the fax media store </param>
        /// <param name="pageSize"> What size to interpret received pages as </param>
        /// <param name="storeMedia"> Whether or not to store received media in the fax media store </param>
        public FaxResponse Receive(Uri action = null,
                                   Kandy.Http.HttpMethod method = null,
                                   Receive.MediaTypeEnum mediaType = null,
                                   Receive.PageSizeEnum pageSize = null,
                                   bool? storeMedia = null)
        {
            var newChild = new Receive(action, method, mediaType, pageSize, storeMedia);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Receive/> element as a child of this element
        /// </summary>
        /// <param name="receive"> A Receive instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public FaxResponse Receive(Receive receive)
        {
            this.Append(receive);
            return this;
        }

        /// <summary>
        /// Append a child TwiML element to this element returning this element to allow chaining.
        /// </summary>
        /// <param name="childElem"> Child TwiML element to add </param>
        public new FaxResponse Append(TwiML childElem)
        {
            return (FaxResponse)base.Append(childElem);
        }

        /// <summary>
        /// Add freeform key-value attributes to the generated xml
        /// </summary>
        /// <param name="key"> Option key </param>
        /// <param name="value"> Option value </param>
        public new FaxResponse SetOption(string key, object value)
        {
            return (FaxResponse)base.SetOption(key, value);
        }
    }

}
