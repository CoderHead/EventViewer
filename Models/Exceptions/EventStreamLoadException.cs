using System;
using System.IO;

namespace com.WillisWare.EventViewer.Models.Exceptions
{
    /// <summary>
    /// Represents an <see cref="Exception"/> specific to the loading of an event log file from a <see cref="Stream"/>.
    /// </summary>
    public sealed class EventStreamLoadException : Exception
    {
        public const string BASE_MESSAGE = "Event stream failed to load.";

        public EventStreamLoadException()
            : base(BASE_MESSAGE)
        {
        }

        public EventStreamLoadException(Exception innerException)
            : base(BASE_MESSAGE, innerException)
        {
        }
    }
}
