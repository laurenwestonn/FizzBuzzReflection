using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzReflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine("FizzBuzz!");
        }
    }

    public static class FizzBuzz
    {
        public static List<string> OutputFizzBuzz()
        {
            int numberToFizzBuzzUntil = 100;
            List<string> range = Enumerable.Range(1, numberToFizzBuzzUntil).Select(x => "Fizz").ToList();
            return range;
        }
    }
}
