using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace FizzBuzzReflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mapper = new Dictionary<int, string>()
            {
                { 15, "FizzBuzz" },
                { 3, "Fizz" },
                { 5, "Buzz" }
            };

            var fizzBuzzOutputs = new FizzBuzzOutputs();

            Translator.OutputTranslator(mapper, fizzBuzzOutputs, 100);
        }
    }

    public static class Translator
    {
        public static List<string> OutputTranslator(Dictionary<int, string> mapper, IOutputs outputter, int until)
        {
            List<int> range = Enumerable.Range(1, until).ToList();

            List<string> result = new List<string>();

            foreach (var value in range)
            {
                var translatedValue = "";
                foreach (var divisibleFactor in mapper.Keys)
                {
                    if (value % divisibleFactor == 0)
                    {
                        var method = typeof(IOutputs).GetMethod(mapper[divisibleFactor]);
                        translatedValue = method.Invoke(outputter, null) as string;
                        break;
                    }
                }
                
                if (translatedValue == "")
                {
                    translatedValue = value.ToString();
                }

                result.Add(translatedValue);
            }

            Debug.WriteLine(string.Join(" ", result));
            return result;
        }
    }
}
