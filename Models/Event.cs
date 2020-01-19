using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace com.WillisWare.EventViewer.Models
{
    /// <summary>
    /// Represents a single event.
    /// </summary>
    [XmlInclude(typeof(EventSeverity))]
    public sealed class Event
    {
        public Event()
        {
        }

        /// <summary>
        /// Gets or sets the unique event identifier.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        [JsonRequired]
        [XmlAttribute(AttributeName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the severity of the event.
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        [XmlElement]
        public EventSeverity Severity { get; set; }

        /// <summary>
        /// Gets or sets the name of the event source.
        /// </summary>
        [JsonProperty(PropertyName = "source", NullValueHandling = NullValueHandling.Include)]
        [XmlElement]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets the date and time of the event.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        [XmlElement]
        public DateTime Timestamp { get; set; }
    }
}
