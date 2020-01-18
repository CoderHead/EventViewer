using System;

namespace com.WillisWare.EventViewer.Models.Exceptions
{
    public sealed class EventFileLoadException : Exception
    {
        public const string BASE_MESSAGE = "Event file failed to load.";

        public EventFileLoadException()
            : base(BASE_MESSAGE)
        {
        }

        public EventFileLoadException(Exception innerException)
            : base(BASE_MESSAGE, innerException)
        {
        }
    }
}
