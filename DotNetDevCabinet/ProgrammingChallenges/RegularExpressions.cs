using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProgrammingChallenges
{
    public class RegularExpressions
    {
        public static string LongestWord(string sen)
        {
            // code goes here  

            Regex rx = new Regex("([a-zA-Z0-9]+)+");
            var words = rx.Matches(sen);

            var longestWord = string.Empty;
            int maxLen = 0;

            foreach(var word in words)
            {
                if(word.ToString().Length > maxLen)
                {
                    longestWord = word.ToString();
                    maxLen = word.ToString().Length;
                }
            }
            
            return longestWord;
        }

    }
}
