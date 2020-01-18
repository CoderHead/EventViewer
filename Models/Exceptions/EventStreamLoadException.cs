using System;

namespace com.WillisWare.EventViewer.Models.Exceptions
{
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
