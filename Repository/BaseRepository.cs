using System;
using System.IO;

namespace com.WillisWare.EventViewer.Repository
{
    public class BaseRepository
    {
        protected void ValidateFilePath(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentNullException(nameof(filePath));
            }

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Invalid file path.", filePath);
            }
        }

        protected void ValidateStream(Stream stream)
        {
            if (stream == null || stream.Length == 0)
            {
                throw new ArgumentNullException(nameof(stream));
            }

            if (!stream.CanRead)
            {
                throw new EndOfStreamException("Stream cannot be read.");
            }

            if (stream.CanSeek)
            {
                stream.Seek(0, SeekOrigin.Begin);
            }
            else
            {
                stream.Position = 0;
            }
        }
    }
}
