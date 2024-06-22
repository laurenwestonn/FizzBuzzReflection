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

            FizzBuzz.OutputFizzBuzz(mapper);
        }
    }

    public static class FizzBuzz
    {
        public static List<string> OutputFizzBuzz(Dictionary<int, string> mapper)
        {
            int numberToFizzBuzzUntil = 100;
            List<int> range = Enumerable.Range(1, numberToFizzBuzzUntil).ToList();

            List<string> result = new List<string>();

            foreach (var value in range)
            {
                var translatedValue = "";
                foreach (var divisibleFactor in mapper.Keys)
                {
                    if (value % divisibleFactor == 0)
                    {
                        var method = typeof(FizzBuzzOutputs).GetMethod(mapper[divisibleFactor]);
                        translatedValue = method.Invoke(null, null) as string;
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
