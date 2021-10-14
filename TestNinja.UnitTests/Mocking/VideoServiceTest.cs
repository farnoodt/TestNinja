using Moq;
using NUnit.Framework;
using TestNinja.Mocking;


namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    class VideoServiceTest
    {
        VideoService _videoService;
        Mock<IFileReader> _fileReader;

        [SetUp]
        public void SetUp()
        {
            _fileReader = new Mock<IFileReader>();
            _videoService = new VideoService(_fileReader.Object);
        }

        [Test]
        public void ReadVideoTitle_Emptyfile_ReturnErrorMessage()
        {
            _fileReader.Setup(fr => fr.Read("video.txt")).Returns("");
            // Method Dependency Injection
            //var result = service.ReadVideoTitle(new FakeFileReader());

            //Property Dependency Injection
            //service.fileReader = new FakeFileReader();
            var result = _videoService.ReadVideoTitle();
            Assert.That( result, Does.Contain("Error").IgnoreCase);
        }
    }
}
