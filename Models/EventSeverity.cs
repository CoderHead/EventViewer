using System;

namespace com.WillisWare.EventViewer.Models
{
    /// <summary>
    /// Represents the severity of an <see cref="Event"/>.
    /// </summary>
    public enum EventSeverity
    {
        /// <summary>
        /// Indicates an informational (non-vital) event.
        /// </summary>
        Information,
        /// <summary>
        /// Indicates a warning (non-error) event.
        /// </summary>
        Warning,
        /// <summary>
        /// Indicates an error (non-critical) event.
        /// </summary>
        Error,
        /// <summary>
        /// Indicates a critical error event.
        /// </summary>
        Critical
    }
}
