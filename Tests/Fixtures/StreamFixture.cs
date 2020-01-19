using System;
using System.IO;
using Moq;

namespace com.WillisWare.EventViewer.Tests.Fixtures
{
    public sealed class StreamFixture
    {
        private readonly Mock<Stream> _stream;

        public StreamFixture()
        {
            _stream = new Mock<Stream>();
        }

        public Stream CreateInstance()
        {
            return _stream.Object;
        }

        public StreamFixture WithCanRead(bool canRead)
        {
            _stream.Setup(_ => _.CanRead).Returns(canRead);
            return this;
        }

        public StreamFixture WithLength(int length)
        {
            _stream.Setup(_ => _.Length).Returns(length);
            return this;
        }
    }
}
