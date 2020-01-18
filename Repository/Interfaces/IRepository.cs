using System;
using System.IO;

namespace com.WillisWare.EventViewer.Repository.Interfaces
{
    public interface IRepository<T>
    {
        T LoadFromFile(string filePath);

        T LoadFromStream(Stream stream);
    }
}
