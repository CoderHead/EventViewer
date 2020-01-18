using System;
using System.IO;
using com.WillisWare.EventViewer.Repository.Interfaces;

namespace com.WillisWare.EventViewer.Repository.Concretes
{
    public sealed class LogRepository : BaseRepository, IRepository<object>
    {
        /// <inheritdoc/>
        public object LoadFromFile(string filePath)
        {
            ValidateFilePath(filePath);

            throw new Models.Exceptions.EventFileLoadException();
        }

        /// <inheritdoc/>
        public object LoadFromStream(Stream stream)
        {
            ValidateStream(stream);

            throw new Models.Exceptions.EventStreamLoadException();
        }
    }
}
