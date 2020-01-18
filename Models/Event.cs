using System;
using System.Xml.Serialization;

namespace com.WillisWare.EventViewer.Models
{
    public sealed class Event
    {
        [XmlAttribute(AttributeName = "id")]
        public int Id { get; set; }

        [XmlElement]
        public EventSeverity Severity { get; set; }

        [XmlElement]
        public string Source { get; set; }

        [XmlElement]
        public DateTime Timestamp { get; set; }
    }
}
