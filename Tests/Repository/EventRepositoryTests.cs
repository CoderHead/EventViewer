using System;
using System.IO;
using com.WillisWare.EventViewer.Models;
using com.WillisWare.EventViewer.Models.Exceptions;
using com.WillisWare.EventViewer.Repository.Concretes;
using com.WillisWare.EventViewer.Repository.Interfaces;
using NUnit.Framework;

namespace com.WillisWare.EventViewer.Tests.Repository
{
    [TestFixture]
    public sealed class EventRepositoryTests
    {
        private const string DATA_DIR = "Test_Data";

        private IRepository<EventLog> _repository;

        [OneTimeSetUp]
        public void Setup()
        {
            _repository = new EventRepository();
        }

        [OneTimeTearDown]
        public void Teardown()
        {
            _repository = null;
        }

        [TestCase("Valid_Log_File.xml")]
        public void LoadFromFile_Succeeds_With_ValidLogFile(string filePath)
        {
            var physicalPath = $"{DATA_DIR}{Path.DirectorySeparatorChar}{filePath}";

            Assert.DoesNotThrow(() => _repository.LoadFromFile(physicalPath));
        }

        [Test]
        public void LoadFromFile_Throws_ArgumentNullException_With_MissingFilePath()
        {
            Assert.Throws<ArgumentNullException>(() => _repository.LoadFromFile(null));
        }

        [TestCase("Invalid_Log_File.xml")]
        public void LoadFromFile_Throws_FileLoadException_With_InvalidLogFile(string filePath)
        {
            var physicalPath = $"{DATA_DIR}{Path.DirectorySeparatorChar}{filePath}";

            Assert.Throws<EventFileLoadException>(() => _repository.LoadFromFile(physicalPath));
        }

        [Test]
        public void LoadFromFile_Throws_FileNotFoundException_With_InvalidFilePath()
        {
            Assert.Throws<FileNotFoundException>(() => _repository.LoadFromFile("test.xml"));
        }

        public void LoadFromStream_Throws_ArgumentNulException_With_MissingStream()
        {
            Assert.Throws<ArgumentNullException>(() => _repository.LoadFromStream(null));
        }
    }
}
