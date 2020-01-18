using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using com.WillisWare.EventViewer.Models;
using com.WillisWare.EventViewer.Repository.Interfaces;

namespace com.WillisWare.EventViewer.Repository.Concretes
{
    public sealed class EventRepository : BaseRepository, IRepository<EventLog>
    {
        /// <inheritdoc/>
        public EventLog LoadFromFile(string filePath)
        {
            ValidateFilePath(filePath);

            try
            {
                using var stream = File.OpenRead(filePath);
                return LoadFromStream(stream);
            }
            catch (Exception ex)
            {
                throw new Models.Exceptions.EventFileLoadException(ex);
            }
        }

        /// <inheritdoc/>
        public EventLog LoadFromStream(Stream stream)
        {
            ValidateStream(stream);

            try
            {
                var serializer = new XmlSerializer(typeof(EventLog));
                var returnValue = (EventLog)serializer.Deserialize(stream);

                return returnValue;
            }
            catch (Exception ex)
            {
                throw new Models.Exceptions.EventStreamLoadException(ex);
            }
        }
    }
}
