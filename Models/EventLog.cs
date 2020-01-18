using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace com.WillisWare.EventViewer.Models
{
    [XmlRoot]
    public sealed class EventLog
    {
        [XmlArrayItem(ElementName = nameof(Event))]
        public Event[] Events { get; set; } = new Event[] { };
    }
}
