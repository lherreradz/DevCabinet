using System;
using System.Collections.Generic;
using System.IO;
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



        /*
         * Complete the 'sockMerchant' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. INTEGER_ARRAY ar
         */


        public static int JumpingOnClouds(List<int> c)
        {
            int jumpsCount = 0;
            int cloudsPositions = c.Count - 1;
            int pósition = 0;
            for (int i = 0; i <= cloudsPositions - 1; i++)
            {
                if (i == cloudsPositions - 1)
                {
                    jumpsCount++;
                    return jumpsCount;
                }
                else
                {
                    if (c[i + 2] == 1)
                    {
                        pósition = pósition + 2;
                        jumpsCount++;
                    }
                    else
                    {
                        pósition = pósition + 1;
                        jumpsCount++;
                    }
                }
            }
            return jumpsCount;
        }
    }
}
