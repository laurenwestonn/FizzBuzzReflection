using NUnit.Framework;
using System.Linq;

namespace FizzBuzzReflection.Tests
{
    [TestFixture]
    internal class FizzBuzzTests
    {
        [Test]
        public void Given_FizzBuzz_Then_ResultHasAHunderedOutputs()
        {
            var result = FizzBuzz.OutputFizzBuzz();

            Assert.That(result.Count(), Is.EqualTo(100));
        }

        [Test]
        public void Given_DivisibleByThree_Then_ReplaceWithFizz()
        {
            var result = FizzBuzz.OutputFizzBuzz();

            var divisibleByThreeOutputs = result.Where((value, i) => (i + 1) % 3 == 0);

            var areAllFizz = divisibleByThreeOutputs.All(x => x == "Fizz");
            Assert.That(areAllFizz, Is.True);
        }

        [Test]
        public void Given_DivisibleByFive_Then_ReplaceWithBuzz()
        {
            var result = FizzBuzz.OutputFizzBuzz();

            var divisibleByFiveOutputs = result.Where((value, i) => (i + 1) % 5 == 0);

            var areAllFizz = divisibleByFiveOutputs.All(x => x == "Buzz");
            Assert.That(areAllFizz, Is.True);
        }

        [Test]
        public void Given_DivisibleByThreeOrFive_Then_ReplaceWithFizzBuzz()
        {
            var result = FizzBuzz.OutputFizzBuzz();

            var divisibleByThreeOrFiveOutputs = result.Where((value, i) => (i + 1) % 15 == 0);

            var areAllFizz = divisibleByThreeOrFiveOutputs.All(x => x == "FizzBuzz");
            Assert.That(areAllFizz, Is.True);
        }
    }
}
