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
    }
}
