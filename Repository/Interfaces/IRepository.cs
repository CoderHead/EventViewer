using System;
using System.IO;

namespace com.WillisWare.EventViewer.Repository.Interfaces
{
    public interface IRepository<T>
    {
        /// <summary>
        /// Loads an instance of <typeparamref name="T"/> from a physical file path.
        /// </summary>
        /// <param name="filePath">A <see cref="string"/> value containing the physical file path.</param>
        /// <returns>An instance of <typeparamref name="T"/> loaded from the specified file.</returns>
        T LoadFromFile(string filePath);

        /// <summary>
        /// Loads an instance of <typeparamref name="T"/> from a <see cref="Stream"/>.
        /// </summary>
        /// <param name="stream">The <see cref="Stream"/> containing the serialized instance.</param>
        /// <returns>An instance of <typeparamref name="T"/> loaded from the specified <see cref="Stream"/>.</returns>
        T LoadFromStream(Stream stream);
    }
}
