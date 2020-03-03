

using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnedNotFound()
        {
            var controller = new CustomerController();
            var result = controller.GetCustomer(0);

            Assert.That(result, Is.TypeOf<NotFound>());//has to be notfound
            //Assert.That(result, Is.InstanceOf<NotFound>());//can be a derivitive of notfound
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnedOk()
        {
            var controller = new CustomerController();
            var result = controller.GetCustomer(1);

            Assert.That(result, Is.TypeOf<Ok>());//has to be notfound
        }
    }
}
