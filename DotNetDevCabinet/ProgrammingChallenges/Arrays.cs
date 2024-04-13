using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingChallenges
{
    public static class Arrays
    {
        public static int jumpingOnClouds(List<int> c)
        {
            int jumpsCount = 0;
            int cloudsPositions = c.Count - 1;
            int position = 0;
            int[] arClouds = c.ToArray();

            while (position <= cloudsPositions - 1)
            {
                if (arClouds[position + 2] == 0)
                {
                    position = position + 2;
                    jumpsCount++;
                }
                else
                {
                    position = position + 1;
                    jumpsCount++;
                }
                if (position == cloudsPositions) return jumpsCount;
                else if (position == cloudsPositions - 1) return jumpsCount + 1;
            }
            return jumpsCount;
        }


        public static long repeatedString(string s, long n)
        {
            int sLen = s.Length;
            var sAr = s.ToCharArray();
            long countAs = sAr.Where(r => r == 'a').Count();

            countAs = (n / sLen) * countAs;

            int resLen = (int)(n%sLen);

            var res = s.Substring(0, resLen);
            var resAr = res.ToCharArray();
            long countAsInResAr = resAr.Where(r => r == 'a').Count();

            return countAs + countAsInResAr;
        }


        /*
         * Complete the 'rotLeft' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY a
         *  2. INTEGER d
         */

        public static List<int> rotLeft(List<int> a, int d)
        {
            List<int> result = new List<int>();
            List<int> firstBPositions = new List<int>();

            int aCount = a.Count;
            int[] ar = a.ToArray();

            for (int i = 0; i <= aCount - 1; i++)
            {
                if (i < d) firstBPositions.Add(ar[i]);
                else result.Add(ar[i]);
            }

            result.AddRange(firstBPositions);

            return result;
        }

        //Coderbyte
        public static string FirstReverse(string str)
        {

            // code goes here
            var ar = str.ToArray();
            string newStr = String.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                newStr += ar[i];
            }
            return newStr;
        }

        //Coderbyte
        public static string FindIntersection(string[] strArr)
        {
            string outStr = String.Empty;
            var strA = strArr[0].Split(", ").ToList();
            var strB = strArr[1].Split(", ").ToList();
            List<string> resList = new List<string>();

            // code goes here  
            foreach (var elementA in strA)
            {
                if (strB.Contains(elementA) && !resList.Contains(elementA)) resList.Add(elementA);
            }
            if (resList.Any())
            {
                foreach (var num in resList) outStr += (num + ",");
                return outStr.Substring(0, outStr.Length - 1);
            }
            return "false";
        }

        public static int lonelyinteger(List<int> a)
        {
            int[] arr = new int[100];

            foreach (var n in a)
            {
                if (arr[n] == 0) arr[n] = 1;
                else if (arr[n] == 1) arr[n] = 2;
            }

            for (int i = 0; i < 100; i++)
            {
                if (arr[i] == 1) return i;
            }
            return 0;
        }
        public static int DiagonalDifference(List<List<int>> arr)
        {
            int size = arr.Count;
            int[,] matrix = new int[size, size];
            int i = 0;
            foreach (var line in arr)
            {
                int j = 0;
                foreach (var n in line)
                {
                    matrix[i, j] = n;
                    j++;
                }
                i++;
            }

            int sumA = 0;
            int sumB = 0;

            for (int k = 0; k < size; k++)
            {
                sumA += matrix[k, k];
                sumB += matrix[k, size - k - 1];
            }

            int res = sumA - sumB;
            return (res > 0) ? res : res * -1;
        }

         public static string ModuleHandle(int N)
         {
            StringBuilder res = new StringBuilder();

            int enable_print = (N % 10 != 0) ? 1 : 0 ;
            while (N > 0)
            {
                if (enable_print == 0 && N % 10 != 0)
                {
                    enable_print = 1;
                }
                if (enable_print == 1 || N < 10)
                {
                    Console.Write(N % 10);
                    res.Append(N % 10);
                }
                N = N / 10;
            }

            return res.ToString();

        }



        public static int[] solutionChar(string[] S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int[] res = new int[3];

            for (int i = 0; i < S[0].Length; i++)
            {
                for (int wordIndexA = 0; wordIndexA < S.Length; wordIndexA++)
                {
                    for (int wordIndexB = wordIndexA+1; wordIndexB < S.Length; wordIndexB++)
                    {
                        if (S[wordIndexA].ToCharArray()[i] == S[wordIndexB].ToCharArray()[i])
                        {
                            res = new int[3] { wordIndexA, wordIndexB, i };
                        }
                    }
                }
            }
            if (res == new int[3]) return new int[0];
            return res;

        }

        public static int IncreaseDecrease(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            //Find the average value
            int size = A.Length;
            int sum = 0;
            foreach (int n in A) sum += n;
            int integerAv = sum / size;
            float floatAv = (float)sum / size;
            int average = (integerAv + 1 - floatAv < ((integerAv - floatAv >= 0)? integerAv - floatAv: integerAv - floatAv*-1)) ? integerAv + 1: integerAv;

            //Calculate increase or decrease
            int steps = 0;
            foreach (int n in A) steps += ((n > average ) ? n - average : average - n);

            return steps;
        }

        // Create a function, in C#, that:
        // 1. Takes two integer arrays as parameters
        // 2. Returns an array of integers from the first array argument that do not exist in the second array argument
        // 3. Does not modify the input arrays

        public static int[] SetDifferenceArray(int[] arrayA, int[] arrayB)
        {
            // Get the max and min values of the array B
            int minValInB = arrayB.Min();
            int maxValInB = arrayB.Max();

            int difMinMaxInB = maxValInB - minValInB;

            // valuesInB contains only the values in B set to true indexed by the value itself
            bool[] valuesInB = new bool[difMinMaxInB+1];

            List<int> resultList = new List<int>();

            // Set to true values in B 
            foreach (var n in arrayB) valuesInB[n - minValInB] = true;

            foreach (var n in arrayA)
            {
                // check if the n value of the array A is in the range of values in B and is in B, if not then insert in result list
                if (!(n >= minValInB && n <= maxValInB && valuesInB[n - minValInB])) resultList.Add(n);
            }

            return resultList.ToArray();
        }
        public static int[] SetDifferenceArray2(int[] arrayA, int[] arrayB)
        {
            // valuesInB contains only the values in B set to true indexed by the value itself
            bool[] valuesInB = new bool[arrayB.Max()+1];

            List<int> resultList = new List<int>();

            // Set to true values in B 
            foreach (var n in arrayB) valuesInB[n] = true;

            foreach (var n in arrayA)
            {
                // check if the n value of the array A is in the range of values in B and is in B, if not then insert in result list
                if (!valuesInB[n]) resultList.Add(n);
            }

            return resultList.ToArray();
        }

    }
}
