using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.EulerProjectMath
{
    public static class NumberToLetters
    {

        public static string Letters(int number)
        {
            // input a number, return that number written out in letters                          
            
            string[] OneToNineteen = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven",
                                     "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};

            string[] TwentyToNinety = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };           

            if (number >= 1 && number <= 19)
            {
                return OneToNineteen[number];

            }

            if (number >= 20 && number <= 99)
            {
                return TwentyToNinety[(number / 10) - 2] + Letters(number % 10);

            }
            
            if (number >= 100 && number <= 999)
            {
                return Letters(number / 100) + "Hundred" + And(number) + Letters(number % 100);

            }
            
            if (number == 1000)
            {
                return "OneThousand";

            }            
            return "";
        }

        public static string And(int num)
        {
            if (num != 100 && num != 200 && num != 300 && num != 400 && num != 500 && num != 600 && num != 700 && num != 800 && num != 900)
                return "and";
            else return "";
        }

    }
}
