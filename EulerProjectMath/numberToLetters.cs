using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject.EulerProjectMath
{
    static class numberToLetters
    {

        public static string letters(int number)
        {
            // input a number, return that number written out in letters                          
            
            string[] oneToNineteen = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven",
                                     "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};

            string[] twentyToNinety = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };           

            if (number >= 1 && number <= 19)
            {
                return oneToNineteen[number];

            }

            if (number >= 20 && number <= 99)
            {
                return twentyToNinety[(number / 10) - 2] + letters(number % 10);

            }
            
            if (number >= 100 && number <= 999)
            {
                return letters(number / 100) + "Hundred" + And(number) + letters(number % 100);

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
