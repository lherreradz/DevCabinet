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
            return (number / 2) * 2 == number;
        }
    }
}
