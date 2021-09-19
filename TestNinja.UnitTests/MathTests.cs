using NUnit.Framework;
using System.Linq;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{   
    [TestFixture]
    class MathTests
    {
        private Math _math ;
        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test]
        //[Ignore("Because I want to do !! ")]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
         
            //Act
            var result = _math.Add(1, 2);

            //Assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(1,2,2)]
        [TestCase(2,1,2)]
        [TestCase(2,2,2)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            
            //Act
            var result = _math.Max(a, b);
            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterthanZero_ReturnOddUpToLimit()
        {
            //Act
            var result = _math.GetOddNumbers(5);

            //Assert
            Assert.That(result, Is.Not.Empty);
            Assert.That(result, Is.Not.Empty);
            Assert.That(result.Count(), Is.EqualTo(3));
            Assert.That(result, Does.Contain(1));
            Assert.That(result, Does.Contain(3));
            Assert.That(result, Does.Contain(5));
            Assert.That(result, Is.EquivalentTo(new[] { 1,3, 5}));
        }
    }
}
