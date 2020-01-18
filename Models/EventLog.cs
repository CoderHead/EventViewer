using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace com.WillisWare.EventViewer.Models
{
    /// <summary>
    /// Represents a history of events.
    /// </summary>
    [XmlRoot]
    public sealed class EventLog
    {
        /// <summary>
        /// Gets or sets the collection of events in the history.
        /// </summary>
        [XmlArrayItem(ElementName = nameof(Event))]
        public Event[] Events { get; set; } = new Event[] { };

        /// <summary>
        /// Overridden. Converts this instance to its string representation.
        /// </summary>
        /// <returns>A <see cref="string"/> value containing the representation of this instance.</returns>
        public override string ToString()
        {
            return $"{nameof(EventLog)} with {Events.Count()} children.";
        }

        /// <summary>
        /// Utility method for serializing this class to XML.
        /// </summary>
        /// <param name="writer">The <see cref="TextWriter"/> instance to which the XML will be written.</param>
        /// <exception cref="ArgumentNullException">Thrown when the <paramref name="writer"/> parameter is null.</exception>
        public void ToXml(TextWriter writer)
        {
            if (writer == null)
            {
                throw new ArgumentNullException(nameof(writer));
            }

            var serializer = new XmlSerializer(typeof(EventLog));
            serializer.Serialize(writer, this);
        }
    }
}
