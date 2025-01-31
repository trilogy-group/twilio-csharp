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
    /// Room TwiML Noun
    /// </summary>
    public class Room : TwiML
    {
        /// <summary>
        /// Room name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Participant identity when connecting to the Room
        /// </summary>
        public string ParticipantIdentity { get; set; }

        /// <summary>
        /// Create a new Room
        /// </summary>
        /// <param name="name"> Room name, the body of the TwiML Element. </param>
        /// <param name="participantIdentity"> Participant identity when connecting to the Room </param>
        public Room(string name = null, string participantIdentity = null) : base("Room")
        {
            this.Name = name;
            this.ParticipantIdentity = participantIdentity;
        }

        /// <summary>
        /// Return the body of the TwiML tag
        /// </summary>
        protected override string GetElementBody()
        {
            return this.Name != null ? this.Name : string.Empty;
        }

        /// <summary>
        /// Return the attributes of the TwiML tag
        /// </summary>
        protected override List<XAttribute> GetElementAttributes()
        {
            var attributes = new List<XAttribute>();
            if (this.ParticipantIdentity != null)
            {
                attributes.Add(new XAttribute("participantIdentity", this.ParticipantIdentity));
            }
            return attributes;
        }

        /// <summary>
        /// Append a child TwiML element to this element returning this element to allow chaining.
        /// </summary>
        /// <param name="childElem"> Child TwiML element to add </param>
        public new Room Append(TwiML childElem)
        {
            return (Room) base.Append(childElem);
        }

        /// <summary>
        /// Add freeform key-value attributes to the generated xml
        /// </summary>
        /// <param name="key"> Option key </param>
        /// <param name="value"> Option value </param>
        public new Room SetOption(string key, object value)
        {
            return (Room) base.SetOption(key, value);
        }
    }

}
