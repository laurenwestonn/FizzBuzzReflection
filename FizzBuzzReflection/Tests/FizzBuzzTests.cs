using NUnit.Framework;
using System.Linq;

namespace FizzBuzzReflection.Tests
{
    [TestFixture]
    internal class FizzBuzzTests
    {
        [Test]
        public void Given_DivisibleByThree_Then_ReplaceWithFizz()
        {
            var result = FizzBuzz.OutputFizzBuzz();

            var divisibleByThreeOutputs = result.Where((value, i) => (i + 1) % 3 == 0);

            var areAllFizz = divisibleByThreeOutputs.All(x => x == "Fizz");
            Assert.That(areAllFizz, Is.True);
        }
    }
}
