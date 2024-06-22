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
                { 3, "Fizz" },
                { 5, "Buzz" },
                { 15, "FizzBuzz" }
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
                if (value % 15 == 0 && mapper.ContainsKey(15))
                {
                    var method = typeof(FizzBuzzOutputs).GetMethod(mapper[15]);
                    string translation = method.Invoke(null, null) as string;
                    result.Add(translation);
                } 
                else if (value % 3 == 0)
                {
                    result.Add(FizzBuzzOutputs.Fizz());
                }
                else if (value % 5 == 0)
                {
                    result.Add(FizzBuzzOutputs.Buzz());
                }
                else
                {
                    result.Add(value.ToString());
                }
            }

            Debug.WriteLine(string.Join(" ", result));
            return result;
        }
    }
}
