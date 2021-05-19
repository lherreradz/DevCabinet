using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDotNet5
{
    public class CustomMath
    {
        public static bool IsPairNumber(int number)
        {
            return number % 2 == 0;
        }

        public static int StringCalculator(string stringNumbers)
        {
            var numbers = stringNumbers.Split(",");
            int sum = 0;
            foreach(var number in numbers)
            {
                sum += Convert.ToInt32(number);
            }

            return sum;
        }
    }
}
