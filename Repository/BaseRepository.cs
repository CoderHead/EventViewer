using System;
using System.IO;

namespace com.WillisWare.EventViewer.Repository
{
    /// <summary>
    /// Base class for repositories containing utility methods and common members.
    /// </summary>
    public abstract class BaseRepository
    {
        /// <summary>
        /// Validates the presence and validity of the specified physical file path against the current environment.
        /// </summary>
        /// <param name="filePath">A <see cref="string"/> value containing the physical file path to be validated.</param>
        /// <exception cref="ArgumentNullException">Thrown when the file path is null or empty.</exception>
        /// <exception cref="FileNotFoundException">Thrown when the file path doesn't represent a valid file.</exception>
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

        /// <summary>
        /// Validates the presence and validity of the specified <see cref="Stream"/>. If valid, also resets the current position to the beginning of the stream.
        /// </summary>
        /// <param name="stream">A <see cref="Stream"/> instance to be validated.</param>
        /// <exception cref="ArgumentNullException">Thrown when the stream is null or empty.</exception>
        /// <exception cref="EndOfStreamException">Thrown when the stream cannot be read.</exception>
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
