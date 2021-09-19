
using TestNinja.Fundamentals;
using NUnit.Framework;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class FizzbuzzTest
    {
        [Test]
        public void GetOutput_InputIsDivisibleBy3and5_ReturnFizzBuzz()
        {
            //We don't have Arrange static methods

            //Act
            var result = FizzBuzz.GetOutput(15);

            Assert.That(result, Is.EqualTo("FizzBuzz"));

        }

        [Test]
        public void GetOutput_InputIsDivisibleBy3Only_ReturnFizzBuzz()
        {
            //Act
            var result = FizzBuzz.GetOutput(3);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutput_InputIsDivisibleBy5Only_ReturnFizzBuzz()
        {
            //Act
            var result = FizzBuzz.GetOutput(5);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetOutput_InputIsNotDivisibleBy5Only_ReturnTheSameNumber()
        {
            //Act
            var result = FizzBuzz.GetOutput(1);

            Assert.That(result, Is.EqualTo("1"));
        }
    }
}
