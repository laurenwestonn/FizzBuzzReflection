﻿using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace FizzBuzzReflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz.OutputFizzBuzz();
        }
    }

    public static class FizzBuzz
    {
        public static List<string> OutputFizzBuzz()
        {
            int numberToFizzBuzzUntil = 100;
            List<int> range = Enumerable.Range(1, numberToFizzBuzzUntil).ToList();

            List<string> result = new List<string>();

            foreach (var value in range)
            {
                if (value % 15 == 0)
                {
                    result.Add(FizzBuzzOutputs.FizzBuzz());
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
