using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> b = (a) => a * 2;
            Console.WriteLine(b(5));

            Func<int, int, int> sum = (a, b) => a + b;
            Console.WriteLine(sum(4, 5));

            Func<int, int, int> maxNumber = (a, b) =>
            {
                if (a > b) return a;
                return b;
            };
            Console.WriteLine(maxNumber(9, 10));

            var numbers = new List<int> { 3, 5, 8, 7, 5, 6, 4 };
            Func<int, bool> GetPairs = (number) => number % 2 == 0;
            var pairs = numbers.Where(GetPairs);
            var odds = numbers.Where((number) => number % 2 == 1);
        }
    }
}
