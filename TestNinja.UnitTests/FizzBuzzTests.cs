

using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class FizzBuzzTests
    {
        [Test]
        public void GetOutput_InputDivisibleBy3And5_ReturnFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(15);

            Assert.That(result, Is.EqualTo("FizzBuzz").IgnoreCase);
        }

        [Test]
        public void GetOutput_InputDivisibleBy3Only_ReturnFizz()
        {
            var result = FizzBuzz.GetOutput(9);

            Assert.That(result, Is.EqualTo("Fizz").IgnoreCase);
        }

        [Test]
        public void GetOutput_InputDivisibleBy5Only_ReturnBuzz()
        {
            var result = FizzBuzz.GetOutput(10);

            Assert.That(result, Is.EqualTo("Buzz").IgnoreCase);
        }

        [Test]
        public void GetOutput_InputIsNotDivisibleBy3Or5_ReturnItself()
        {
            var result = FizzBuzz.GetOutput(8);

            Assert.That(result, Is.EqualTo("8").IgnoreCase);
        }

    }
}
