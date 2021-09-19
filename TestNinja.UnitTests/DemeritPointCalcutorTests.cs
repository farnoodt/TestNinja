using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class DemeritPointCalcutorTests
    {
        private DemeritPointsCalculator _calculate;
        [SetUp]
        public void SetUp()
        {
            _calculate = new DemeritPointsCalculator();
        }

        [Test]
        [TestCase(-1)]
        [TestCase(301)]
        public void CalculateDemeritPoints_SpeedIsOutOfRange_ThrowArgumentOutOfRangeException(int speed)
        {
            

            //Assert
            Assert.That(()=> _calculate.CalculateDemeritPoints(speed), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

       


        [Test]
        [TestCase(0,0)]
        [TestCase(64,0)]
        [TestCase(65,0)]
        [TestCase(66,0)]
        [TestCase(70,1)]
        [TestCase(75,2)]
        public void CalculateDemeritPoints_WhenCalled_ReturnDemeritPoints(int speed, int ExpectedResult)
        {
            var result = _calculate.CalculateDemeritPoints(speed);

            //Assert
            Assert.That(result, Is.EqualTo(ExpectedResult));
        }
    }
}
