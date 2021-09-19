

using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class ErrorLoggerTest
    {
        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            //Arrange
            var logger = new ErrorLogger();

            //Act
            logger.Log("error");

            //Assert
            Assert.That(logger.LastError, Is.EqualTo("error"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            //Arrange
            var logger = new ErrorLogger();

            //Assert
            Assert.That(() => logger.Log(error), Throws.ArgumentNullException);

        }

        [Test]
        public void Log_ValidErro_RaiseErrorLoggedEvent()
        {
            //Arrange
            var Logger = new ErrorLogger();

            //Act
            var id = Guid.Empty;
            Logger.ErrorLogged += (sender, args) => { id = args; };
            Logger.Log("a");

            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }
    }
}
