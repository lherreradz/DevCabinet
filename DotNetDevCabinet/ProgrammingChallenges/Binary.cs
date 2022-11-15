using System;
using System.Text;

namespace ProgrammingChallenges
{
    public static class Binary
    {
        public static string ConvertToBinary(int n)
        {
            if (n == 0) return "0";
            int maxV = 1;
            StringBuilder binary = new StringBuilder();
            for (int i = 1; ; i *= 2)
            {
                if (i == n)
                {
                    maxV = i;
                    break;
                }
                else if (i > n)
                {
                    maxV = i / 2;
                    break;
                }
            }
            for (int i = maxV; i >= 1; i /= 2)
            {
                if (n - i >= 0)
                {
                    n -= i;
                    binary.Append('1');
                }
                else binary.Append('0');
            }
            return binary.ToString();
        }

    }
}
