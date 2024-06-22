using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzReflection.Tests
{
    [TestFixture]
    internal class FizzBuzzTests
    {

        public Dictionary<int, string> _exampleTranslations = new Dictionary<int, string>()
        {
            { 3, "Fizz" },
            { 5, "Buzz" },
            { 15, "FizzBuzz" }
        };

        [Test]
        public void Given_FizzBuzz_Then_ResultHasAHunderedOutputs()
        {
            var result = FizzBuzz.OutputFizzBuzz(_exampleTranslations);

            Assert.That(result.Count(), Is.EqualTo(100));
        }

        [Test]
        public void Given_DivisibleByThree_And_NotByFive_Then_ReplaceWithFizz()
        {
            var result = FizzBuzz.OutputFizzBuzz(_exampleTranslations);

            var divisibleByThreeOutputs = result.Where((value, i) => ((i+1) % 3 == 0) && ((i+1) % 5 != 0));

            var areAllFizz = divisibleByThreeOutputs.All(x => x == "Fizz");
            Assert.That(areAllFizz, Is.True);
        }

        [Test]
        public void Given_DivisibleByFive_And_NotByThree_Then_ReplaceWithBuzz()
        {
            var result = FizzBuzz.OutputFizzBuzz(_exampleTranslations);

            var divisibleByFiveOutputs = result.Where((value, i) => ((i+1) % 5 == 0) && ((i+1) % 3 != 0));

            var areAllFizz = divisibleByFiveOutputs.All(x => x == "Buzz");
            Assert.That(areAllFizz, Is.True);
        }

        [Test]
        public void Given_DivisibleByThreeOrFive_Then_ReplaceWithFizzBuzz()
        {
            var result = FizzBuzz.OutputFizzBuzz(_exampleTranslations);

            var divisibleByThreeOrFiveOutputs = result.Where((value, i) => (i + 1) % 15 == 0);

            var areAllFizz = divisibleByThreeOrFiveOutputs.All(x => x == "FizzBuzz");
            Assert.That(areAllFizz, Is.True);
        }

        [Test]
        public void Given_NotDivisibleByThreeOrFive_Then_RemainsANumber()
        {
            var result = FizzBuzz.OutputFizzBuzz(_exampleTranslations);

            for (int i = 1; i <= result.Count; i++)
            {
                if (i % 3 != 0 && i % 5 != 0)
                {
                    Assert.That(result[i - 1], Is.EqualTo(i.ToString()));
                }
            }
        }
    }
}
