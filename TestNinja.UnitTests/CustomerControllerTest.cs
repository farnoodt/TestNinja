using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class CustomerControllerTest
    {
        [Test]
        public void GetCustomer_IdZero_ReturnNotFound() 
        {
            //Arrange
            var controller = new CustomerController();

            //Act
            var result = controller.GetCustomer(0);

            //Assert
            //Notfound
            Assert.That(result, Is.TypeOf<NotFound>());

            //Not found or one of it's derivative
            Assert.That(result, Is.InstanceOf<NotFound>());

        }

        [Test]
        public void GetCustomer_IdNotZero_ReturnOK() { }
    }
}
