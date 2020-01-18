using System;
using System.Xml.Serialization;

namespace com.WillisWare.EventViewer.Models
{
    /// <summary>
    /// Represents a single event.
    /// </summary>
    public sealed class Event
    {
        /// <summary>
        /// Gets or sets the unique event identifier.
        /// </summary>
        [XmlAttribute(AttributeName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the severity of the event.
        /// </summary>
        [XmlElement]
        public EventSeverity Severity { get; set; }

        /// <summary>
        /// Gets or sets the name of the event source.
        /// </summary>
        [XmlElement]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets the date and time of the event.
        /// </summary>
        [XmlElement]
        public DateTime Timestamp { get; set; }
    }
}
