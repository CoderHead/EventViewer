using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace com.WillisWare.EventViewer.Models
{
    /// <summary>
    /// Represents the severity of an <see cref="Event"/>.
    /// </summary>
    [XmlType(TypeName = "int")]
    public enum EventSeverity : int
    {
        /// <summary>
        /// Indicates an informational (non-vital) event.
        /// </summary>
        [EnumMember(Value = "0")]
        [XmlEnum("0")]
        Information,
        /// <summary>
        /// Indicates a warning (non-error) event.
        /// </summary>
        [EnumMember(Value = "1")]
        [XmlEnum("1")]
        Warning,
        /// <summary>
        /// Indicates an error (non-critical) event.
        /// </summary>
        [EnumMember(Value = "2")]
        [XmlEnum("2")]
        Error,
        /// <summary>
        /// Indicates a critical error event.
        /// </summary>
        [EnumMember(Value = "3")]
        [XmlEnum("3")]
        Critical
    }
}
