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
    }
}
